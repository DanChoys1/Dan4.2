
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
            components = new System.ComponentModel.Container();
            headerPictureBox = new System.Windows.Forms.PictureBox();
            closeFormButton = new System.Windows.Forms.Button();
            menuStrip = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            inputOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            inputEncryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            inputKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveEncryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveKeyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            keyTextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            encryptButton = new System.Windows.Forms.Button();
            randomInputButton = new System.Windows.Forms.Button();
            cipherTextBoxErrorProvider = new System.Windows.Forms.ErrorProvider(components);
            openFileDialog = new System.Windows.Forms.OpenFileDialog();
            saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            openTextBox = new System.Windows.Forms.RichTextBox();
            encryptedTextBox = new System.Windows.Forms.RichTextBox();
            decipherButton = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            sinchrTextBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            синхропосылкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            синхропосылкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)headerPictureBox).BeginInit();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cipherTextBoxErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // headerPictureBox
            // 
            headerPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            headerPictureBox.Location = new System.Drawing.Point(0, 0);
            headerPictureBox.Name = "headerPictureBox";
            headerPictureBox.Size = new System.Drawing.Size(800, 30);
            headerPictureBox.TabIndex = 0;
            headerPictureBox.TabStop = false;
            headerPictureBox.MouseDown += HeaderPictureBox_MouseDown;
            headerPictureBox.MouseMove += HeaderPictureBox_MouseMove;
            headerPictureBox.MouseUp += HeaderPictureBox_MouseUp;
            // 
            // closeFormButton
            // 
            closeFormButton.Location = new System.Drawing.Point(771, 3);
            closeFormButton.Name = "closeFormButton";
            closeFormButton.Size = new System.Drawing.Size(26, 22);
            closeFormButton.TabIndex = 1;
            closeFormButton.UseVisualStyleBackColor = true;
            closeFormButton.Click += CloseFormButton_Click;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, aboutProgramToolStripMenuItem });
            menuStrip.Location = new System.Drawing.Point(0, 30);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new System.Drawing.Size(800, 24);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { inputToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // inputToolStripMenuItem
            // 
            inputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { inputOpenToolStripMenuItem, inputEncryptToolStripMenuItem, inputKeyToolStripMenuItem, синхропосылкаToolStripMenuItem });
            inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            inputToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            inputToolStripMenuItem.Text = "Ввод";
            // 
            // inputOpenToolStripMenuItem
            // 
            inputOpenToolStripMenuItem.Name = "inputOpenToolStripMenuItem";
            inputOpenToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            inputOpenToolStripMenuItem.Text = "Исходного текста";
            inputOpenToolStripMenuItem.Click += InputOpenToolStripMenuItem_Click;
            // 
            // inputEncryptToolStripMenuItem
            // 
            inputEncryptToolStripMenuItem.Name = "inputEncryptToolStripMenuItem";
            inputEncryptToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            inputEncryptToolStripMenuItem.Text = "Зашифрованного текста";
            inputEncryptToolStripMenuItem.Click += InputEncryptToolStripMenuItem_Click;
            // 
            // inputKeyToolStripMenuItem
            // 
            inputKeyToolStripMenuItem.Name = "inputKeyToolStripMenuItem";
            inputKeyToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            inputKeyToolStripMenuItem.Text = "Ключа";
            inputKeyToolStripMenuItem.Click += InputKeyToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { saveOpenToolStripMenuItem, saveEncryptToolStripMenuItem, saveKeyToolStripMenuItem1, синхропосылкаToolStripMenuItem1 });
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            saveToolStripMenuItem.Text = "Сохранить";
            // 
            // saveOpenToolStripMenuItem
            // 
            saveOpenToolStripMenuItem.Name = "saveOpenToolStripMenuItem";
            saveOpenToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            saveOpenToolStripMenuItem.Text = "Исходный текст";
            saveOpenToolStripMenuItem.Click += SaveOpenToolStripMenuItem_Click;
            // 
            // saveEncryptToolStripMenuItem
            // 
            saveEncryptToolStripMenuItem.Name = "saveEncryptToolStripMenuItem";
            saveEncryptToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            saveEncryptToolStripMenuItem.Text = "Зашифрованный текст";
            saveEncryptToolStripMenuItem.Click += SaveEncryptToolStripMenuItem_Click;
            // 
            // saveKeyToolStripMenuItem1
            // 
            saveKeyToolStripMenuItem1.Name = "saveKeyToolStripMenuItem1";
            saveKeyToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            saveKeyToolStripMenuItem1.Text = "Ключ";
            saveKeyToolStripMenuItem1.Click += SaveKeyToolStripMenuItem1_Click;
            // 
            // aboutProgramToolStripMenuItem
            // 
            aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            aboutProgramToolStripMenuItem.Text = "О программе";
            aboutProgramToolStripMenuItem.Click += AboutProgramToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 69);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 15);
            label1.TabIndex = 3;
            label1.Text = "Исходный текст";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(21, 189);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(134, 15);
            label2.TabIndex = 5;
            label2.Text = "Зашифрованный текст";
            // 
            // keyTextBox
            // 
            keyTextBox.Location = new System.Drawing.Point(21, 292);
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new System.Drawing.Size(640, 23);
            keyTextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(21, 274);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "Ключ";
            // 
            // encryptButton
            // 
            encryptButton.Location = new System.Drawing.Point(668, 417);
            encryptButton.Name = "encryptButton";
            encryptButton.Size = new System.Drawing.Size(122, 23);
            encryptButton.TabIndex = 10;
            encryptButton.Text = "Зашифровать";
            encryptButton.UseVisualStyleBackColor = true;
            encryptButton.Click += EncryptButton_Click;
            // 
            // randomInputButton
            // 
            randomInputButton.Location = new System.Drawing.Point(677, 291);
            randomInputButton.Name = "randomInputButton";
            randomInputButton.Size = new System.Drawing.Size(111, 23);
            randomInputButton.TabIndex = 11;
            randomInputButton.Text = "Ключ";
            randomInputButton.UseVisualStyleBackColor = true;
            randomInputButton.Click += RandomInputButton_Click;
            // 
            // cipherTextBoxErrorProvider
            // 
            cipherTextBoxErrorProvider.ContainerControl = this;
            cipherTextBoxErrorProvider.RightToLeft = true;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // openTextBox
            // 
            openTextBox.Location = new System.Drawing.Point(21, 87);
            openTextBox.Name = "openTextBox";
            openTextBox.Size = new System.Drawing.Size(767, 100);
            openTextBox.TabIndex = 13;
            openTextBox.Text = "";
            // 
            // encryptedTextBox
            // 
            encryptedTextBox.Location = new System.Drawing.Point(21, 207);
            encryptedTextBox.Name = "encryptedTextBox";
            encryptedTextBox.Size = new System.Drawing.Size(767, 64);
            encryptedTextBox.TabIndex = 14;
            encryptedTextBox.Text = "";
            // 
            // decipherButton
            // 
            decipherButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            decipherButton.Location = new System.Drawing.Point(539, 417);
            decipherButton.Name = "decipherButton";
            decipherButton.Size = new System.Drawing.Size(122, 23);
            decipherButton.TabIndex = 9;
            decipherButton.Text = "Расшифровать";
            decipherButton.UseVisualStyleBackColor = true;
            decipherButton.Click += DecipherButton_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(677, 340);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(111, 23);
            button1.TabIndex = 17;
            button1.Text = "Синхропосылка";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sinchrTextBox
            // 
            sinchrTextBox.Location = new System.Drawing.Point(21, 341);
            sinchrTextBox.Name = "sinchrTextBox";
            sinchrTextBox.Size = new System.Drawing.Size(640, 23);
            sinchrTextBox.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(21, 323);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(97, 15);
            label4.TabIndex = 15;
            label4.Text = "Синхропосылка";
            // 
            // синхропосылкаToolStripMenuItem
            // 
            синхропосылкаToolStripMenuItem.Name = "синхропосылкаToolStripMenuItem";
            синхропосылкаToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            синхропосылкаToolStripMenuItem.Text = "Синхропосылка";
            синхропосылкаToolStripMenuItem.Click += синхропосылкаToolStripMenuItem_Click;
            // 
            // синхропосылкаToolStripMenuItem1
            // 
            синхропосылкаToolStripMenuItem1.Name = "синхропосылкаToolStripMenuItem1";
            синхропосылкаToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            синхропосылкаToolStripMenuItem1.Text = "Синхропосылка";
            синхропосылкаToolStripMenuItem1.Click += синхропосылкаToolStripMenuItem1_Click;
            // 
            // MainForm
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(800, 450);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(sinchrTextBox);
            Controls.Add(label4);
            Controls.Add(encryptedTextBox);
            Controls.Add(openTextBox);
            Controls.Add(randomInputButton);
            Controls.Add(encryptButton);
            Controls.Add(decipherButton);
            Controls.Add(keyTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(closeFormButton);
            Controls.Add(menuStrip);
            Controls.Add(headerPictureBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Coder";
            ((System.ComponentModel.ISupportInitialize)headerPictureBox).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cipherTextBoxErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button randomInputButton;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider cipherTextBoxErrorProvider;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RichTextBox encryptedTextBox;
        private System.Windows.Forms.RichTextBox openTextBox;
        private System.Windows.Forms.Button decipherButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sinchrTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem синхропосылкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синхропосылкаToolStripMenuItem1;
    }
}

