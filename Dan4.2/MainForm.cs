using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography.Xml;
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

        private Gost28147_89 gost = new Gost28147_89();

        public MainForm()
        {
            InitializeComponent();

            headerPictureBox.BackColor = ColorTranslator.FromHtml("#a4e6fc");
            menuStrip.BackColor = ColorTranslator.FromHtml("#a4effc");
            closeFormButton.BackColor = ColorTranslator.FromHtml("#FF0000");

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
            textAbout.Text = "Лабораторная работа №2" + Environment.NewLine + Environment.NewLine +
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
            cipherTextBoxErrorProvider.Clear();
            encryptedTextBox.Text = "";

            try
            {
                byte[] ciph = gost.GammaCrypt(Encoding.UTF8.GetBytes(openTextBox.Text), keyTextBox.Text, sinchrTextBox.Text);
                encryptedTextBox.Text = BitConverter.ToString(ciph);
            }
            catch (Exception ex)
            {
                cipherTextBoxErrorProvider.SetError(keyTextBox, ex.Message);
            }
        }

        private void DecipherButton_Click(object sender, EventArgs e)
        {
            cipherTextBoxErrorProvider.Clear();

            try
            {
                byte[] ciph = gost.SplitStringIntoBytes(encryptedTextBox.Text);
                byte[] deciph = gost.GammaCrypt(ciph, keyTextBox.Text, sinchrTextBox.Text);
                openTextBox.Text = Encoding.UTF8.GetString(deciph);
            }
            catch (KeyArgumentException ex)
            {
                cipherTextBoxErrorProvider.SetError(keyTextBox, ex.Message);
            }
            catch (RGSPCArgumentException ex)
            {
                cipherTextBoxErrorProvider.SetError(sinchrTextBox, ex.Message);
            }
            catch (Exception ex)
            {
                cipherTextBoxErrorProvider.SetError(encryptedTextBox, "Не правильный формат представления байтов");
            }
        }

        private void RandomInputButton_Click(object sender, EventArgs e)
        {
            const int minASCII = 33;
            const int maxASCII = 127;

            keyTextBox.Text = "";
            for (int i = 0; i < 256 / 8; i++)
            {
                keyTextBox.Text += Convert.ToChar(_random.Next(minASCII, maxASCII));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int minASCII = 33;
            const int maxASCII = 127;

            sinchrTextBox.Text = "";
            for (int i = 0; i < 64 / 8; i++)
            {
                sinchrTextBox.Text += Convert.ToChar(_random.Next(minASCII, maxASCII));
            }
        }

        #endregion

        #region Tool strip menu 

        private void InputOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] bytes = InputData();
            if (bytes != null)
            {
                openTextBox.Text = Encoding.UTF8.GetString(bytes); ;
            }
        }

        private void InputEncryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] bytes = InputData();
            if (bytes != null)
            {
                encryptedTextBox.Text = BitConverter.ToString(bytes);
            }
        }

        private void InputKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] bytes = InputData();
            if (bytes != null)
            {
                keyTextBox.Text = Encoding.UTF8.GetString(bytes); ;
            }
        }

        private void синхропосылкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] bytes = InputData();
            if (bytes != null)
            {
                sinchrTextBox.Text = Encoding.UTF8.GetString(bytes); ;
            }
        }

        private void SaveOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData(Encoding.UTF8.GetBytes(openTextBox.Text));
        }

        private void SaveEncryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData(gost.SplitStringIntoBytes(encryptedTextBox.Text));
        }

        private void SaveKeyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveData(Encoding.UTF8.GetBytes(keyTextBox.Text));
        }

        private void синхропосылкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveData(Encoding.UTF8.GetBytes(sinchrTextBox.Text));
        }

        private byte[] InputData()
        {
            DialogResult result = openFileDialog.ShowDialog();

            byte[] bytes = null;
            if (result == DialogResult.OK)
            {
                try
                {
                    FileStream DataFile = new FileStream(openFileDialog.FileName, FileMode.Open);
                    BinaryReader br = new BinaryReader(DataFile);
                    bytes = br.ReadBytes((int)DataFile.Length);

                    br.Close();
                    DataFile.Close();
                }
                catch (System.IO.IOException e)
                {
                    MessageBox.Show("Файл не может быть прочитан.", "Ошибка!");
                }
            }

            return bytes;
        }

        private void SaveData(byte[] bytes)
        {
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    FileStream DataFile = new FileStream(saveFileDialog.FileName, FileMode.Create);
                    DataFile.Write(bytes, 0, bytes.Length);

                    DataFile.Close();
                }
                catch (System.IO.IOException e)
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
