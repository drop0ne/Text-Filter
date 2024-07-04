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
            this.textBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.overwriteCheckbox = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(776, 300);
            this.textBox.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 318);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(776, 23);
            this.progressBar.TabIndex = 1;
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(12, 344);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(776, 23);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Status";
            // 
            // overwriteCheckbox
            // 
            this.overwriteCheckbox.AutoSize = true;
            this.overwriteCheckbox.Location = new System.Drawing.Point(12, 370);
            this.overwriteCheckbox.Name = "overwriteCheckbox";
            this.overwriteCheckbox.Size = new System.Drawing.Size(128, 17);
            this.overwriteCheckbox.TabIndex = 3;
            this.overwriteCheckbox.Text = "Overwrite existing files";
            this.overwriteCheckbox.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 393);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.RunApplication);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(713, 393);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.Close);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.overwriteCheckbox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "TextToWordConverter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
