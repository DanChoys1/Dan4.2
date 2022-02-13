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
