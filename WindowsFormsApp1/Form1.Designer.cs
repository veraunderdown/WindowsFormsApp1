namespace WindowsFormsApp1
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
            this.uiHelloWorldButton = new System.Windows.Forms.Button();
            this.uiGoodbyeDaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiHelloWorldButton
            // 
            this.uiHelloWorldButton.Location = new System.Drawing.Point(226, 97);
            this.uiHelloWorldButton.Name = "uiHelloWorldButton";
            this.uiHelloWorldButton.Size = new System.Drawing.Size(75, 23);
            this.uiHelloWorldButton.TabIndex = 0;
            this.uiHelloWorldButton.Text = "Press First";
            this.uiHelloWorldButton.UseVisualStyleBackColor = true;
            this.uiHelloWorldButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // uiGoodbyeDaveButton
            // 
            this.uiGoodbyeDaveButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.uiGoodbyeDaveButton.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiGoodbyeDaveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiGoodbyeDaveButton.Location = new System.Drawing.Point(226, 146);
            this.uiGoodbyeDaveButton.Name = "uiGoodbyeDaveButton";
            this.uiGoodbyeDaveButton.Size = new System.Drawing.Size(94, 57);
            this.uiGoodbyeDaveButton.TabIndex = 1;
            this.uiGoodbyeDaveButton.Text = "Press Second";
            this.uiGoodbyeDaveButton.UseVisualStyleBackColor = false;
            this.uiGoodbyeDaveButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click me!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uiGoodbyeDaveButton);
            this.Controls.Add(this.uiHelloWorldButton);
            this.Name = "Form1";
            this.Text = "Goodbye Dave";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiHelloWorldButton;
        private System.Windows.Forms.Button uiGoodbyeDaveButton;
        private System.Windows.Forms.Button button1;
    }
}

