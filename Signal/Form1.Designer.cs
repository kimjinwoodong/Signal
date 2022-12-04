namespace Signal
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
            this.LampRed = new System.Windows.Forms.Button();
            this.LampYellow = new System.Windows.Forms.Button();
            this.LampGreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LampRed
            // 
            this.LampRed.Location = new System.Drawing.Point(115, 37);
            this.LampRed.Name = "LampRed";
            this.LampRed.Size = new System.Drawing.Size(112, 104);
            this.LampRed.TabIndex = 0;
            this.LampRed.Text = "button1";
            this.LampRed.UseVisualStyleBackColor = true;
            // 
            // LampYellow
            // 
            this.LampYellow.Location = new System.Drawing.Point(115, 158);
            this.LampYellow.Name = "LampYellow";
            this.LampYellow.Size = new System.Drawing.Size(112, 104);
            this.LampYellow.TabIndex = 1;
            this.LampYellow.Text = "button2";
            this.LampYellow.UseVisualStyleBackColor = true;
            // 
            // LampGreen
            // 
            this.LampGreen.Location = new System.Drawing.Point(115, 279);
            this.LampGreen.Name = "LampGreen";
            this.LampGreen.Size = new System.Drawing.Size(112, 104);
            this.LampGreen.TabIndex = 2;
            this.LampGreen.Text = "button3";
            this.LampGreen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LampGreen);
            this.Controls.Add(this.LampYellow);
            this.Controls.Add(this.LampRed);
            this.Name = "Form1";
            this.Text = "Form1";

            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LampRed;
        private System.Windows.Forms.Button LampYellow;
        private System.Windows.Forms.Button LampGreen;
    }
}

