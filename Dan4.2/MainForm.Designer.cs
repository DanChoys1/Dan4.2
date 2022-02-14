
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
            this.components = new System.ComponentModel.Container();
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
            this.openTextBox = new System.Windows.Forms.TextBox();
            this.encryptedTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.decipherButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.randomInputButton = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.gammaXoringRadioButton = new System.Windows.Forms.RadioButton();
            this.gostRadioButton = new System.Windows.Forms.RadioButton();
            this.encryptedTextBoxErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.headerPictureBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encryptedTextBoxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPictureBox
            // 
            this.headerPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPictureBox.Location = new System.Drawing.Point(0, 0);
            this.headerPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.headerPictureBox.Name = "headerPictureBox";
            this.headerPictureBox.Size = new System.Drawing.Size(914, 40);
            this.headerPictureBox.TabIndex = 0;
            this.headerPictureBox.TabStop = false;
            this.headerPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPictureBox_MouseDown);
            this.headerPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderPictureBox_MouseMove);
            this.headerPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeaderPictureBox_MouseUp);
            // 
            // closeFormButton
            // 
            this.closeFormButton.Location = new System.Drawing.Point(880, 5);
            this.closeFormButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(30, 30);
            this.closeFormButton.TabIndex = 1;
            this.closeFormButton.UseVisualStyleBackColor = true;
            this.closeFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.тестироватьToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 40);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(914, 30);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вводToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // вводToolStripMenuItem
            // 
            this.вводToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.исходногоТекстаToolStripMenuItem,
            this.зашифрованногоТекстаToolStripMenuItem,
            this.ключToolStripMenuItem});
            this.вводToolStripMenuItem.Name = "вводToolStripMenuItem";
            this.вводToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.вводToolStripMenuItem.Text = "Ввод";
            // 
            // исходногоТекстаToolStripMenuItem
            // 
            this.исходногоТекстаToolStripMenuItem.Name = "исходногоТекстаToolStripMenuItem";
            this.исходногоТекстаToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.исходногоТекстаToolStripMenuItem.Text = "Исходного текста";
            // 
            // зашифрованногоТекстаToolStripMenuItem
            // 
            this.зашифрованногоТекстаToolStripMenuItem.Name = "зашифрованногоТекстаToolStripMenuItem";
            this.зашифрованногоТекстаToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.зашифрованногоТекстаToolStripMenuItem.Text = "Зашифрованного текста";
            // 
            // ключToolStripMenuItem
            // 
            this.ключToolStripMenuItem.Name = "ключToolStripMenuItem";
            this.ключToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.ключToolStripMenuItem.Text = "Ключа";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.исходныйТекстToolStripMenuItem,
            this.зашифрованныхТекстToolStripMenuItem,
            this.ключToolStripMenuItem1});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // исходныйТекстToolStripMenuItem
            // 
            this.исходныйТекстToolStripMenuItem.Name = "исходныйТекстToolStripMenuItem";
            this.исходныйТекстToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.исходныйТекстToolStripMenuItem.Text = "Исходный текст";
            // 
            // зашифрованныхТекстToolStripMenuItem
            // 
            this.зашифрованныхТекстToolStripMenuItem.Name = "зашифрованныхТекстToolStripMenuItem";
            this.зашифрованныхТекстToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.зашифрованныхТекстToolStripMenuItem.Text = "Зашифрованный текст";
            // 
            // ключToolStripMenuItem1
            // 
            this.ключToolStripMenuItem1.Name = "ключToolStripMenuItem1";
            this.ключToolStripMenuItem1.Size = new System.Drawing.Size(249, 26);
            this.ключToolStripMenuItem1.Text = "Ключ";
            // 
            // тестироватьToolStripMenuItem
            // 
            this.тестироватьToolStripMenuItem.Name = "тестироватьToolStripMenuItem";
            this.тестироватьToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.тестироватьToolStripMenuItem.Text = "О программе";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Исходный текст";
            // 
            // openTextBox
            // 
            this.openTextBox.Location = new System.Drawing.Point(24, 128);
            this.openTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.openTextBox.Name = "openTextBox";
            this.openTextBox.Size = new System.Drawing.Size(716, 27);
            this.openTextBox.TabIndex = 4;
            // 
            // encryptedTextBox
            // 
            this.encryptedTextBox.Location = new System.Drawing.Point(24, 220);
            this.encryptedTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.encryptedTextBox.Name = "encryptedTextBox";
            this.encryptedTextBox.Size = new System.Drawing.Size(716, 27);
            this.encryptedTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Зашифрованный текст";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(24, 312);
            this.keyTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(716, 27);
            this.keyTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ключ";
            // 
            // decipherButton
            // 
            this.decipherButton.Location = new System.Drawing.Point(762, 556);
            this.decipherButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decipherButton.Name = "decipherButton";
            this.decipherButton.Size = new System.Drawing.Size(140, 31);
            this.decipherButton.TabIndex = 9;
            this.decipherButton.Text = "Расшифровать";
            this.decipherButton.UseVisualStyleBackColor = true;
            this.decipherButton.Click += new System.EventHandler(this.decipherButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(616, 556);
            this.encryptButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(140, 31);
            this.encryptButton.TabIndex = 10;
            this.encryptButton.Text = "Зашифровать";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // randomInputButton
            // 
            this.randomInputButton.Location = new System.Drawing.Point(749, 311);
            this.randomInputButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.randomInputButton.Name = "randomInputButton";
            this.randomInputButton.Size = new System.Drawing.Size(127, 31);
            this.randomInputButton.TabIndex = 11;
            this.randomInputButton.Text = "Подобрать ключ";
            this.randomInputButton.UseVisualStyleBackColor = true;
            this.randomInputButton.Click += new System.EventHandler(this.randomInputButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.gammaXoringRadioButton);
            this.groupBox.Controls.Add(this.gostRadioButton);
            this.groupBox.Location = new System.Drawing.Point(24, 376);
            this.groupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox.Size = new System.Drawing.Size(223, 161);
            this.groupBox.TabIndex = 12;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Метод шифрования";
            // 
            // gammaXoringRadioButton
            // 
            this.gammaXoringRadioButton.AutoSize = true;
            this.gammaXoringRadioButton.Location = new System.Drawing.Point(7, 63);
            this.gammaXoringRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gammaXoringRadioButton.Name = "gammaXoringRadioButton";
            this.gammaXoringRadioButton.Size = new System.Drawing.Size(136, 24);
            this.gammaXoringRadioButton.TabIndex = 1;
            this.gammaXoringRadioButton.TabStop = true;
            this.gammaXoringRadioButton.Text = "Гаммирование";
            this.gammaXoringRadioButton.UseVisualStyleBackColor = true;
            // 
            // gostRadioButton
            // 
            this.gostRadioButton.AutoSize = true;
            this.gostRadioButton.Location = new System.Drawing.Point(7, 29);
            this.gostRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gostRadioButton.Name = "gostRadioButton";
            this.gostRadioButton.Size = new System.Drawing.Size(125, 24);
            this.gostRadioButton.TabIndex = 0;
            this.gostRadioButton.TabStop = true;
            this.gostRadioButton.Text = "Гост 28147-89";
            this.gostRadioButton.UseVisualStyleBackColor = true;
            // 
            // encryptedTextBoxErrorProvider
            // 
            this.encryptedTextBoxErrorProvider.ContainerControl = this;
            this.encryptedTextBoxErrorProvider.RightToLeft = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.randomInputButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.decipherButton);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encryptedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeFormButton);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.headerPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Coder";
            ((System.ComponentModel.ISupportInitialize)(this.headerPictureBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encryptedTextBoxErrorProvider)).EndInit();
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
        private System.Windows.Forms.TextBox openTextBox;
        private System.Windows.Forms.TextBox encryptedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button decipherButton;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button randomInputButton;
        private System.Windows.Forms.ToolStripMenuItem тестироватьToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton gammaXoringRadioButton;
        private System.Windows.Forms.RadioButton gostRadioButton;
        private System.Windows.Forms.ErrorProvider encryptedTextBoxErrorProvider;
    }
}

