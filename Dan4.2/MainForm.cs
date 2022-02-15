using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Program
{
    public partial class MainForm : Form
    {
        private bool _isHeaderMoving = false;
        private Point _cursorPosition;

        private static Random random = new Random();

        public MainForm()
        {
            InitializeComponent();

            headerPictureBox.BackColor = ColorTranslator.FromHtml("#a4e6fc");
            menuStrip.BackColor = ColorTranslator.FromHtml("#a4effc");
            closeFormButton.BackColor = ColorTranslator.FromHtml("#FF0000");

            gostRadioButton.Checked = true;

            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        //////////////////////////////////////////////ENCRYPT//////////////////////////////////////////////////////////////////
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            ICipher cipher = GetCipher();

            if(cipher == null)
            {
                return;
            }

            Byte[] encryptedDataByte;

            try
            {
                encryptedDataByte = cipher.Encode(openTextBox.Text, keyTextBox.Text);
            }
            catch (Exception ex)
            {
                encryptedTextBoxErrorProvider.SetError(keyTextBox, ex.Message);
                return;
            }

            encryptedTextBox.Text = BitConverter.ToString(encryptedDataByte, 0);

            encryptedTextBoxErrorProvider.Clear();
        }

        private void DecipherButton_Click(object sender, EventArgs e)
        {
            Byte[] encryptedDataByte;

            try
            {
                encryptedDataByte = SplitStringIntoBytes(encryptedTextBox.Text);
            }
            catch (Exception)
            {
                encryptedTextBoxErrorProvider.SetError(encryptedTextBox, "Введены некорректные данные");
                return;
            }

            ICipher cipher = GetCipher();

            String encryptedData;

            try
            {
                encryptedData = cipher.Decode(encryptedDataByte, keyTextBox.Text);
            }
            catch (KeyArgumentException ex)
            {
                encryptedTextBoxErrorProvider.SetError(keyTextBox, ex.Message);
                return;
            }
            catch (EncryptedTextException ex)
            {
                encryptedTextBoxErrorProvider.SetError(encryptedTextBox, ex.Message);
                return;
            }

            openTextBox.Text = encryptedData;

            encryptedTextBoxErrorProvider.Clear();
        }

        private ICipher GetCipher()
        {
            if (gostRadioButton.Checked == true)
            {
                return new Gost28147_89();
            }
            else if (gammaXoringRadioButton.Checked == true)
            {
                return new GammaXoring();
            }

            return null;
        }

        private Byte[] SplitStringIntoBytes(String data)
        {
            String[] splitData = new String[data.Length];

            int byteIndex = 0;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == '-')
                {
                    byteIndex++;
                    continue;
                }

                splitData[byteIndex] += data[i];
            }

            Byte[] dataByte = new Byte[++byteIndex];

            for (int i = 0; i < byteIndex; i++)
            {
                dataByte[i] = byte.Parse(splitData[i], System.Globalization.NumberStyles.HexNumber);
            }

            return dataByte;
        }

        private void RandomInputButton_Click(object sender, EventArgs e)
        {
            const int minASCII = 33;
            const int maxASCII = 127;

            int lenghtKey = 0;

            if (gostRadioButton.Checked == true)
            {
                lenghtKey = 32;
            }
            else if (gammaXoringRadioButton.Checked == true)
            {
                lenghtKey = openTextBox.Text.Length;
            }

            keyTextBox.Text = "";

            for (int i = 0; i < lenghtKey; i++)
            {
                keyTextBox.Text += Convert.ToChar(random.Next(minASCII, maxASCII));
            }
        }

        //////////////////////////////////////////////TOOL_STRIP_MENU//////////////////////////////////////////////////////////////////
        private void InputOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String text = InputData();

            if (text != null)
            {
                openTextBox.Text = text;
            }
        }

        private void InputEncryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String text = InputData();

            if (text != null)
            {
                encryptedTextBox.Text = text;
            }
        }

        private void InputKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String text = InputData();

            if (text != null)
            {
                keyTextBox.Text = text;
            }
        }

        private void SaveOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData(openTextBox.Text);
        }

        private void SaveEncryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData(encryptedTextBox.Text);
        }

        private void SaveKeyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveData(keyTextBox.Text);
        }

        private String InputData()
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                String text = "";

                try
                {
                    using System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog.OpenFile());

                    string inputText;

                    while ((inputText = sr.ReadLine()) != null)
                    {
                        text += inputText;
                    }
                }
                catch (System.IO.IOException)
                {
                    text = null;
                    MessageBox.Show("Файл не может быть прочитан.", "Ошибка!");
                }

                return text;
            }

            return null;
        }

        private void SaveData(String text)
        {
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    using System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog.OpenFile());

                    sw.WriteLine(text);
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Не удалось сохранить данные.", "Ошибка!");
                }
            }
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лабораторная работа №2\n\n" +
                            "Создать интерфейс ICipher, который определяет методы поддержки шифрования строк. " +
                            "В интерфейсе объявляются два метода Encode() и Decode(), которые используются для " +
                            "шифрования и дешифрования строк, соответственно. Реализовать 2 класса реализующих " +
                            "данный интерфейс. Алгоритмы: ГОСТ 28147_89, Гаммирование.\n\n" +
                            "Выполнил стедент группы 404, Азаров Даниил Константинович.\n\n" +
                            "2022 год.", "О программе");
        }

        //////////////////////////////////////////////HEADER//////////////////////////////////////////////////////////////////
        private void HeaderPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isHeaderMoving = true;
                _cursorPosition = new Point(e.X, e.Y);
            }
            else
            {
                _isHeaderMoving = false;
            }
        }

        private void HeaderPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isHeaderMoving)
            {
                Point cursorMoveTo;

                cursorMoveTo = this.PointToScreen(new Point(e.X, e.Y));
                cursorMoveTo.Offset(-_cursorPosition.X, -_cursorPosition.Y);

                this.Location = cursorMoveTo;
            }
        }

        private void HeaderPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _isHeaderMoving = false;
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
