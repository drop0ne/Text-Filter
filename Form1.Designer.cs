namespace TextToWordConverter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.CheckBox overwriteCheckbox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBox = new System.Windows.Forms.TextBox();
            progressBar = new System.Windows.Forms.ProgressBar();
            statusLabel = new System.Windows.Forms.Label();
            overwriteCheckbox = new System.Windows.Forms.CheckBox();
            startButton = new System.Windows.Forms.Button();
            exitButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new System.Drawing.Point(14, 14);
            textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new System.Drawing.Size(905, 346);
            textBox.TabIndex = 0;
            // 
            // progressBar
            // 
            progressBar.Location = new System.Drawing.Point(14, 367);
            progressBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(905, 27);
            progressBar.TabIndex = 1;
            // 
            // statusLabel
            // 
            statusLabel.Location = new System.Drawing.Point(14, 397);
            statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(905, 27);
            statusLabel.TabIndex = 2;
            statusLabel.Text = "Status";
            // 
            // overwriteCheckbox
            // 
            overwriteCheckbox.AutoSize = true;
            overwriteCheckbox.Location = new System.Drawing.Point(14, 427);
            overwriteCheckbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            overwriteCheckbox.Name = "overwriteCheckbox";
            overwriteCheckbox.Size = new System.Drawing.Size(145, 19);
            overwriteCheckbox.TabIndex = 3;
            overwriteCheckbox.Text = "Overwrite existing files";
            overwriteCheckbox.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            startButton.Location = new System.Drawing.Point(14, 453);
            startButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            startButton.Name = "startButton";
            startButton.Size = new System.Drawing.Size(88, 27);
            startButton.TabIndex = 4;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += RunApplication;
            // 
            // exitButton
            // 
            exitButton.Location = new System.Drawing.Point(110, 453);
            exitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            exitButton.Name = "exitButton";
            exitButton.Size = new System.Drawing.Size(88, 27);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += Close;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(exitButton);
            Controls.Add(startButton);
            Controls.Add(overwriteCheckbox);
            Controls.Add(statusLabel);
            Controls.Add(progressBar);
            Controls.Add(textBox);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "TextToWordConverter";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
