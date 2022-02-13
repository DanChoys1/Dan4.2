
namespace Dan4._2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerPictureBox = new System.Windows.Forms.PictureBox();
            this.closeFormButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вводToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исходногоТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зашифрованногоТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ключToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исходныйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зашифрованныхТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ключToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.тестироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.headerPictureBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPictureBox
            // 
            this.headerPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPictureBox.Location = new System.Drawing.Point(0, 0);
            this.headerPictureBox.Name = "headerPictureBox";
            this.headerPictureBox.Size = new System.Drawing.Size(800, 30);
            this.headerPictureBox.TabIndex = 0;
            this.headerPictureBox.TabStop = false;
            this.headerPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPictureBox_MouseDown);
            this.headerPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderPictureBox_MouseMove);
            this.headerPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeaderPictureBox_MouseUp);
            // 
            // closeFormButton
            // 
            this.closeFormButton.Location = new System.Drawing.Point(770, 2);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(25, 25);
            this.closeFormButton.TabIndex = 1;
            this.closeFormButton.UseVisualStyleBackColor = true;
            this.closeFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.тестироватьToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 30);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вводToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // вводToolStripMenuItem
            // 
            this.вводToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.исходногоТекстаToolStripMenuItem,
            this.зашифрованногоТекстаToolStripMenuItem,
            this.ключToolStripMenuItem});
            this.вводToolStripMenuItem.Name = "вводToolStripMenuItem";
            this.вводToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.вводToolStripMenuItem.Text = "Ввод";
            // 
            // исходногоТекстаToolStripMenuItem
            // 
            this.исходногоТекстаToolStripMenuItem.Name = "исходногоТекстаToolStripMenuItem";
            this.исходногоТекстаToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.исходногоТекстаToolStripMenuItem.Text = "Исходного текста";
            // 
            // зашифрованногоТекстаToolStripMenuItem
            // 
            this.зашифрованногоТекстаToolStripMenuItem.Name = "зашифрованногоТекстаToolStripMenuItem";
            this.зашифрованногоТекстаToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.зашифрованногоТекстаToolStripMenuItem.Text = "Зашифрованного текста";
            // 
            // ключToolStripMenuItem
            // 
            this.ключToolStripMenuItem.Name = "ключToolStripMenuItem";
            this.ключToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.ключToolStripMenuItem.Text = "Ключа";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.исходныйТекстToolStripMenuItem,
            this.зашифрованныхТекстToolStripMenuItem,
            this.ключToolStripMenuItem1});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // исходныйТекстToolStripMenuItem
            // 
            this.исходныйТекстToolStripMenuItem.Name = "исходныйТекстToolStripMenuItem";
            this.исходныйТекстToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.исходныйТекстToolStripMenuItem.Text = "Исходный текст";
            // 
            // зашифрованныхТекстToolStripMenuItem
            // 
            this.зашифрованныхТекстToolStripMenuItem.Name = "зашифрованныхТекстToolStripMenuItem";
            this.зашифрованныхТекстToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.зашифрованныхТекстToolStripMenuItem.Text = "Зашифрованный текст";
            // 
            // ключToolStripMenuItem1
            // 
            this.ключToolStripMenuItem1.Name = "ключToolStripMenuItem1";
            this.ключToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.ключToolStripMenuItem1.Text = "Ключ";
            // 
            // тестироватьToolStripMenuItem
            // 
            this.тестироватьToolStripMenuItem.Name = "тестироватьToolStripMenuItem";
            this.тестироватьToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.тестироватьToolStripMenuItem.Text = "О программе";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Исходный текст";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(627, 23);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(627, 23);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Зашифрованный текст";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(21, 234);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(627, 23);
            this.textBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ключ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Расшифровать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(570, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Зашифровать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(655, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Подобрать ключ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(21, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 121);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод шифрования";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(108, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Гаммирование";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Гост 28147-89";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeFormButton);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.headerPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Coder";
            ((System.ComponentModel.ISupportInitialize)(this.headerPictureBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox headerPictureBox;
        private System.Windows.Forms.Button closeFormButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вводToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исходногоТекстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зашифрованногоТекстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ключToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исходныйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зашифрованныхТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ключToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem тестироватьToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

