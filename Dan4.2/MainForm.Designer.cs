
namespace Program
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputEncryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveEncryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveKeyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
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
            this.closeFormButton.Location = new System.Drawing.Point(881, 4);
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
            this.fileToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 40);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(914, 30);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputOpenToolStripMenuItem,
            this.inputEncryptToolStripMenuItem,
            this.inputKeyToolStripMenuItem});
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.inputToolStripMenuItem.Text = "Ввод";
            // 
            // inputOpenToolStripMenuItem
            // 
            this.inputOpenToolStripMenuItem.Name = "inputOpenToolStripMenuItem";
            this.inputOpenToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.inputOpenToolStripMenuItem.Text = "Исходного текста";
            this.inputOpenToolStripMenuItem.Click += new System.EventHandler(this.InputOpenToolStripMenuItem_Click);
            // 
            // inputEncryptToolStripMenuItem
            // 
            this.inputEncryptToolStripMenuItem.Name = "inputEncryptToolStripMenuItem";
            this.inputEncryptToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.inputEncryptToolStripMenuItem.Text = "Зашифрованного текста";
            this.inputEncryptToolStripMenuItem.Click += new System.EventHandler(this.InputEncryptToolStripMenuItem_Click);
            // 
            // inputKeyToolStripMenuItem
            // 
            this.inputKeyToolStripMenuItem.Name = "inputKeyToolStripMenuItem";
            this.inputKeyToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.inputKeyToolStripMenuItem.Text = "Ключа";
            this.inputKeyToolStripMenuItem.Click += new System.EventHandler(this.InputKeyToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveOpenToolStripMenuItem,
            this.saveEncryptToolStripMenuItem,
            this.saveKeyToolStripMenuItem1});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.saveToolStripMenuItem.Text = "Сохранить";
            // 
            // saveOpenToolStripMenuItem
            // 
            this.saveOpenToolStripMenuItem.Name = "saveOpenToolStripMenuItem";
            this.saveOpenToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.saveOpenToolStripMenuItem.Text = "Исходный текст";
            this.saveOpenToolStripMenuItem.Click += new System.EventHandler(this.SaveOpenToolStripMenuItem_Click);
            // 
            // saveEncryptToolStripMenuItem
            // 
            this.saveEncryptToolStripMenuItem.Name = "saveEncryptToolStripMenuItem";
            this.saveEncryptToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.saveEncryptToolStripMenuItem.Text = "Зашифрованный текст";
            this.saveEncryptToolStripMenuItem.Click += new System.EventHandler(this.SaveEncryptToolStripMenuItem_Click);
            // 
            // saveKeyToolStripMenuItem1
            // 
            this.saveKeyToolStripMenuItem1.Name = "saveKeyToolStripMenuItem1";
            this.saveKeyToolStripMenuItem1.Size = new System.Drawing.Size(249, 26);
            this.saveKeyToolStripMenuItem1.Text = "Ключ";
            this.saveKeyToolStripMenuItem1.Click += new System.EventHandler(this.SaveKeyToolStripMenuItem1_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.aboutProgramToolStripMenuItem.Text = "О программе";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramToolStripMenuItem_Click);
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
            this.decipherButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.decipherButton.Location = new System.Drawing.Point(616, 556);
            this.decipherButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decipherButton.Name = "decipherButton";
            this.decipherButton.Size = new System.Drawing.Size(139, 31);
            this.decipherButton.TabIndex = 9;
            this.decipherButton.Text = "Расшифровать";
            this.decipherButton.UseVisualStyleBackColor = true;
            this.decipherButton.Click += new System.EventHandler(this.DecipherButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(763, 556);
            this.encryptButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(139, 31);
            this.encryptButton.TabIndex = 10;
            this.encryptButton.Text = "Зашифровать";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
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
            this.randomInputButton.Click += new System.EventHandler(this.RandomInputButton_Click);
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
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
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
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputEncryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveEncryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveKeyToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox openTextBox;
        private System.Windows.Forms.TextBox encryptedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button decipherButton;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button randomInputButton;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton gammaXoringRadioButton;
        private System.Windows.Forms.RadioButton gostRadioButton;
        private System.Windows.Forms.ErrorProvider encryptedTextBoxErrorProvider;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

