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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectDirButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // openTextureButton
            // 
            this.openTextureButton.Location = new System.Drawing.Point(45, 74);
            this.openTextureButton.Name = "openTextureButton";
            this.openTextureButton.Size = new System.Drawing.Size(130, 23);
            this.openTextureButton.TabIndex = 0;
            this.openTextureButton.Text = "Open texture file";
            this.openTextureButton.UseVisualStyleBackColor = true;
            this.openTextureButton.Click += new System.EventHandler(this.openTextureButton_Click);
            // 
            // importInGameButton
            // 
            this.importInGameButton.Location = new System.Drawing.Point(45, 161);
            this.importInGameButton.Name = "importInGameButton";
            this.importInGameButton.Size = new System.Drawing.Size(130, 23);
            this.importInGameButton.TabIndex = 1;
            this.importInGameButton.Text = "Import in game";
            this.importInGameButton.UseVisualStyleBackColor = true;
            this.importInGameButton.Click += new System.EventHandler(this.importInGameButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Which skin to replace?";
            // 
            // selectDirButton
            // 
            this.selectDirButton.Location = new System.Drawing.Point(45, 23);
            this.selectDirButton.Name = "selectDirButton";
            this.selectDirButton.Size = new System.Drawing.Size(130, 23);
            this.selectDirButton.TabIndex = 4;
            this.selectDirButton.Text = "Select game directory";
            this.selectDirButton.UseVisualStyleBackColor = true;
            this.selectDirButton.Click += new System.EventHandler(this.selectDirButton_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select the LLBlaze folder located in your steam/SteamApps/common directory";
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "LLBlaze dds Files|*tex.dds";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectDirButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.importInGameButton);
            this.Controls.Add(this.openTextureButton);
            this.Name = "Form1";
            this.Text = "LLBlaze Palette Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openTextureButton;
        private System.Windows.Forms.Button importInGameButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectDirButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

