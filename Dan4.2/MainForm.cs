using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dan4._2
{
    public partial class MainForm : Form
    {
        private bool _isHeaderMoving = false;
        private Point _cursorPosition;

        public MainForm()
        {
            InitializeComponent();

            headerPictureBox.BackColor = ColorTranslator.FromHtml("#a4e6fc");
            menuStrip.BackColor = ColorTranslator.FromHtml("#a4effc");
            closeFormButton.BackColor = ColorTranslator.FromHtml("#FF0000");

            gostRadioButton.Checked = true;
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

        private void encryptButton_Click(object sender, EventArgs e)
        {
            ICipher cipher = null;

            if (gostRadioButton.Checked == true)
            {
                Byte[] keyBytes = Encoding.UTF8.GetBytes(keyTextBox.Text);

                const int countBytesInKey = 32;

                if (keyBytes.Length != countBytesInKey)
                {
                    encryptedTextBoxErrorProvider.SetError(keyTextBox, "Пароль долже состоять из 32 символов");
                    return;
                }

                cipher = new Gost28147_89();
            }
            else if (gammaXoringRadioButton.Checked == true)
            {
                if (keyTextBox.Text.Length == 0)
                {
                    encryptedTextBoxErrorProvider.SetError(keyTextBox, "Пароль долже быть длинее 0");
                    return;
                }

                if (keyTextBox.Text.Length > openTextBox.Text.Length)
                {
                    encryptedTextBoxErrorProvider.SetError(keyTextBox, "Пароль долже быть меньше длины введенного текста");
                    return;
                }

                cipher = new GammaXoring();
            }
            else
            {
                return;
            }

            Byte[] encryptedDataByte = cipher.Encode(openTextBox.Text, keyTextBox.Text);

            encryptedTextBox.Text = BitConverter.ToString(encryptedDataByte, 0);

            encryptedTextBoxErrorProvider.Clear();
        }

        private void decipherButton_Click(object sender, EventArgs e)
        {
            Byte[] encryptedDataByte;

            try
            {
                encryptedDataByte = SplitStringIntoBytes(encryptedTextBox.Text);
            }
            catch (Exception )
            {
                encryptedTextBoxErrorProvider.SetError(encryptedTextBox, "Введены некорректные данные");
                return;
            }

            ICipher cipher = null;

            if (gostRadioButton.Checked == true)
            {
                if (encryptedDataByte.Length % 8 != 0)
                {
                    encryptedTextBoxErrorProvider.SetError(encryptedTextBox, "Шифр должен быть кратен 8");
                    return;
                }

                Byte[] keyBytes = Encoding.UTF8.GetBytes(keyTextBox.Text);

                const int countBytesInKey = 32;

                if (keyBytes.Length != countBytesInKey)
                {
                    encryptedTextBoxErrorProvider.SetError(keyTextBox, "Пароль долже состоять из 32 символов");
                    return;
                }

                cipher = new Gost28147_89();
            }
            else if (gammaXoringRadioButton.Checked == true)
            {
                if (keyTextBox.Text.Length == 0)
                {
                    encryptedTextBoxErrorProvider.SetError(keyTextBox, "Пароль долже быть длинее 0");
                    return;
                }

                cipher = new GammaXoring();
            }
            else
            {
                return;
            }

            String encryptedData = cipher.Decode(encryptedDataByte, keyTextBox.Text);

            openTextBox.Text = encryptedData;

            encryptedTextBoxErrorProvider.Clear();
        }

        private Byte[] SplitStringIntoBytes(String data)
        {
            String[] splitData = new String[data.Length];

            int byteIndex = 0;

            for (int i = 0; i < data.Length; i++)
            { 
                if(data[i] == '-')
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

        private void randomInputButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

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
    }
}
