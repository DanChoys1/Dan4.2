using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Program
{
    public partial class MainForm : Form
    {
        private static Random _random;

        Form _form;

        private bool _isHeaderMoving = false;
        private Point _cursorPosition;

        public MainForm()
        {
            InitializeComponent();

            headerPictureBox.BackColor = ColorTranslator.FromHtml("#a4e6fc");
            menuStrip.BackColor = ColorTranslator.FromHtml("#a4effc");
            closeFormButton.BackColor = ColorTranslator.FromHtml("#FF0000");

            gostRadioButton.Checked = true;

            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            _random = new Random();

            CreateAboutDialog();

            this.Show();

            if (Properties.Settings.Default.isShowAboutMenu)
            {
                _form.ShowDialog();
            }
        }

        private void CreateAboutDialog()
        {
            _form = new Form();
            _form.Text = "О программе";
            _form.Size = new Size(550, 250);
            _form.StartPosition = FormStartPosition.CenterParent;
            _form.MaximizeBox = false;
            _form.MinimizeBox = false;

            Label textAbout = new Label();
            textAbout.AutoSize = true;
            textAbout.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            textAbout.Left = 10;
            textAbout.Top = 10;
            textAbout.Text =    "Лабораторная работа №2" + Environment.NewLine + Environment.NewLine +
                                "Создать интерфейс ICipher, который определяет методы поддержки шифрования строк. " + Environment.NewLine +
                                "В интерфейсе объявляются два метода Encode() и Decode(), которые используются для " + Environment.NewLine +
                                "шифрования и дешифрования строк, соответственно. Реализовать 2 класса реализующих " + Environment.NewLine +
                                "данный интерфейс. Алгоритмы: ГОСТ 28147_89, Гаммирование." + Environment.NewLine + Environment.NewLine +
                                "Выполнил стедент группы 404, Азаров Даниил Константинович." + Environment.NewLine + Environment.NewLine +
                                "2022 год.";

            CheckBox checkBox = new CheckBox();
            checkBox.Location = new Point(295, 177);
            checkBox.AutoSize = true;
            checkBox.TextAlign = ContentAlignment.MiddleCenter;
            checkBox.Text = "Больше не показывать";
            checkBox.Checked = !Properties.Settings.Default.isShowAboutMenu;
            //checkBox.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;

            Button ok = new Button();
            ok.Text = "Ок";
            ok.AutoSize = true;
            ok.Location = new Point(450, 175);
            //ok.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            ok.Click += (sender, e) => 
            {
                Properties.Settings.Default.isShowAboutMenu = !checkBox.Checked;
                Properties.Settings.Default.Save();

                _form.Close();
            };

            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;

            panel.Controls.Add(textAbout);
            panel.Controls.Add(checkBox);
            panel.Controls.Add(ok);

            _form.Controls.Add(panel);
        }

        #region Encrypting text function

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            ICipher cipher = GetCipher();

            if(cipher == null)
            {
                return;
            }

            try
            {
                encryptedTextBox.Text = cipher.Encode(openTextBox.Text, keyTextBox.Text);
            }
            catch (Exception ex)
            {
                cipherTextBoxErrorProvider.SetError(keyTextBox, ex.Message);
                return;
            }

            cipherTextBoxErrorProvider.Clear();
        }

        private void DecipherButton_Click(object sender, EventArgs e)
        {
            ICipher cipher = GetCipher();

            String encryptedData;

            try
            {
                encryptedData = cipher.Decode(encryptedTextBox.Text, keyTextBox.Text);
            }
            catch (KeyArgumentException ex)
            {
                cipherTextBoxErrorProvider.SetError(keyTextBox, ex.Message);
                return;
            }
            catch (EncryptedTextException ex)
            {
                cipherTextBoxErrorProvider.SetError(encryptedTextBox, ex.Message);
                return;
            }

            openTextBox.Text = encryptedData;

            cipherTextBoxErrorProvider.Clear();
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
                keyTextBox.Text += Convert.ToChar(_random.Next(minASCII, maxASCII));
            }
        }

        #endregion

        #region Tool strip menu 

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
            _form.ShowDialog();
        }

        #endregion

        #region Form's header functional

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

        #endregion
    }
}
