namespace LLBlazeModdingTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openTextureButton = new System.Windows.Forms.Button();
            this.importInGameButton = new System.Windows.Forms.Button();
            this.skinListBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.unzipButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openTextureButton
            // 
            this.openTextureButton.Enabled = false;
            this.openTextureButton.Location = new System.Drawing.Point(77, 74);
            this.openTextureButton.Name = "openTextureButton";
            this.openTextureButton.Size = new System.Drawing.Size(130, 23);
            this.openTextureButton.TabIndex = 0;
            this.openTextureButton.Text = "Open .dds texture file(s)";
            this.openTextureButton.UseVisualStyleBackColor = true;
            this.openTextureButton.Click += new System.EventHandler(this.openTextureButton_Click);
            // 
            // importInGameButton
            // 
            this.importInGameButton.Enabled = false;
            this.importInGameButton.Location = new System.Drawing.Point(77, 200);
            this.importInGameButton.Name = "importInGameButton";
            this.importInGameButton.Size = new System.Drawing.Size(130, 23);
            this.importInGameButton.TabIndex = 1;
            this.importInGameButton.Text = "Import in game";
            this.importInGameButton.UseVisualStyleBackColor = true;
            this.importInGameButton.Click += new System.EventHandler(this.importInGameButton_Click);
            // 
            // skinListBox
            // 
            this.skinListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinListBox.FormattingEnabled = true;
            this.skinListBox.Location = new System.Drawing.Point(77, 150);
            this.skinListBox.Name = "skinListBox";
            this.skinListBox.Size = new System.Drawing.Size(130, 21);
            this.skinListBox.TabIndex = 2;
            this.skinListBox.SelectedIndexChanged += new System.EventHandler(this.skinListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Which skin to replace?\r\n(The name will be changed accordingly)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "LLBlaze dds Files|*tex.dds";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // unzipButton
            // 
            this.unzipButton.Location = new System.Drawing.Point(77, 27);
            this.unzipButton.Name = "unzipButton";
            this.unzipButton.Size = new System.Drawing.Size(130, 23);
            this.unzipButton.TabIndex = 5;
            this.unzipButton.Text = "Unzip the archive";
            this.unzipButton.UseVisualStyleBackColor = true;
            this.unzipButton.Click += new System.EventHandler(this.unzipButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(253, 244);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(20, 20);
            this.infoButton.TabIndex = 6;
            this.infoButton.Text = "?";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 274);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.unzipButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skinListBox);
            this.Controls.Add(this.importInGameButton);
            this.Controls.Add(this.openTextureButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "LLBlaze Palette Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openTextureButton;
        private System.Windows.Forms.Button importInGameButton;
        private System.Windows.Forms.ComboBox skinListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button unzipButton;
        private System.Windows.Forms.Button infoButton;
    }
}

