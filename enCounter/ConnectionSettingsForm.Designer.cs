namespace enCounter
{
    partial class ConnectionSettingsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.hostBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.portBox = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.hostBox.SuspendLayout();
            this.portBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.portBox);
            this.panel1.Controls.Add(this.hostBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 110);
            this.panel1.TabIndex = 0;
            // 
            // hostBox
            // 
            this.hostBox.Controls.Add(this.textBox1);
            this.hostBox.Location = new System.Drawing.Point(4, 3);
            this.hostBox.Name = "hostBox";
            this.hostBox.Size = new System.Drawing.Size(245, 41);
            this.hostBox.TabIndex = 0;
            this.hostBox.TabStop = false;
            this.hostBox.Text = "Host";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 20);
            this.textBox1.TabIndex = 0;
            // 
            // portBox
            // 
            this.portBox.Controls.Add(this.textBox2);
            this.portBox.Location = new System.Drawing.Point(7, 50);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(236, 43);
            this.portBox.TabIndex = 1;
            this.portBox.TabStop = false;
            this.portBox.Text = "Port";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 20);
            this.textBox2.TabIndex = 0;
            // 
            // ConnectionSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 134);
            this.Controls.Add(this.panel1);
            this.Name = "ConnectionSettingsForm";
            this.Text = "ConnectionSettingsForm";
            this.panel1.ResumeLayout(false);
            this.hostBox.ResumeLayout(false);
            this.hostBox.PerformLayout();
            this.portBox.ResumeLayout(false);
            this.portBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox portBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox hostBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}