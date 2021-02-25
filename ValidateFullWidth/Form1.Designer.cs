
namespace ValidateFullWidth
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
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblContainsFullWidthChar = new System.Windows.Forms.Label();
            this.lblOutput2 = new System.Windows.Forms.Label();
            this.lblContainsFullWidthChar2 = new System.Windows.Forms.Label();
            this.lblOutput3 = new System.Windows.Forms.Label();
            this.lblContainsFullWidthChar3 = new System.Windows.Forms.Label();
            this.lblOutput4 = new System.Windows.Forms.Label();
            this.lblContainsFullWidthChar4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(12, 12);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(148, 22);
            this.tbxInput.TabIndex = 0;
            this.tbxInput.TextChanged += new System.EventHandler(this.tbxInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "轉成半型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "是否包含全型字：";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(119, 48);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(37, 12);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "Output";
            // 
            // lblContainsFullWidthChar
            // 
            this.lblContainsFullWidthChar.AutoSize = true;
            this.lblContainsFullWidthChar.Location = new System.Drawing.Point(119, 76);
            this.lblContainsFullWidthChar.Name = "lblContainsFullWidthChar";
            this.lblContainsFullWidthChar.Size = new System.Drawing.Size(22, 12);
            this.lblContainsFullWidthChar.TabIndex = 1;
            this.lblContainsFullWidthChar.Text = "Yes";
            // 
            // lblOutput2
            // 
            this.lblOutput2.AutoSize = true;
            this.lblOutput2.Location = new System.Drawing.Point(181, 48);
            this.lblOutput2.Name = "lblOutput2";
            this.lblOutput2.Size = new System.Drawing.Size(37, 12);
            this.lblOutput2.TabIndex = 1;
            this.lblOutput2.Text = "Output";
            // 
            // lblContainsFullWidthChar2
            // 
            this.lblContainsFullWidthChar2.AutoSize = true;
            this.lblContainsFullWidthChar2.Location = new System.Drawing.Point(181, 76);
            this.lblContainsFullWidthChar2.Name = "lblContainsFullWidthChar2";
            this.lblContainsFullWidthChar2.Size = new System.Drawing.Size(22, 12);
            this.lblContainsFullWidthChar2.TabIndex = 1;
            this.lblContainsFullWidthChar2.Text = "Yes";
            // 
            // lblOutput3
            // 
            this.lblOutput3.AutoSize = true;
            this.lblOutput3.Location = new System.Drawing.Point(246, 48);
            this.lblOutput3.Name = "lblOutput3";
            this.lblOutput3.Size = new System.Drawing.Size(37, 12);
            this.lblOutput3.TabIndex = 1;
            this.lblOutput3.Text = "Output";
            // 
            // lblContainsFullWidthChar3
            // 
            this.lblContainsFullWidthChar3.AutoSize = true;
            this.lblContainsFullWidthChar3.Location = new System.Drawing.Point(246, 76);
            this.lblContainsFullWidthChar3.Name = "lblContainsFullWidthChar3";
            this.lblContainsFullWidthChar3.Size = new System.Drawing.Size(22, 12);
            this.lblContainsFullWidthChar3.TabIndex = 1;
            this.lblContainsFullWidthChar3.Text = "Yes";
            // 
            // lblOutput4
            // 
            this.lblOutput4.AutoSize = true;
            this.lblOutput4.Location = new System.Drawing.Point(313, 48);
            this.lblOutput4.Name = "lblOutput4";
            this.lblOutput4.Size = new System.Drawing.Size(37, 12);
            this.lblOutput4.TabIndex = 1;
            this.lblOutput4.Text = "Output";
            // 
            // lblContainsFullWidthChar4
            // 
            this.lblContainsFullWidthChar4.AutoSize = true;
            this.lblContainsFullWidthChar4.Location = new System.Drawing.Point(313, 76);
            this.lblContainsFullWidthChar4.Name = "lblContainsFullWidthChar4";
            this.lblContainsFullWidthChar4.Size = new System.Drawing.Size(22, 12);
            this.lblContainsFullWidthChar4.TabIndex = 1;
            this.lblContainsFullWidthChar4.Text = "Yes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 116);
            this.Controls.Add(this.lblContainsFullWidthChar4);
            this.Controls.Add(this.lblContainsFullWidthChar3);
            this.Controls.Add(this.lblContainsFullWidthChar2);
            this.Controls.Add(this.lblContainsFullWidthChar);
            this.Controls.Add(this.lblOutput4);
            this.Controls.Add(this.lblOutput3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOutput2);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblOutput4;
        private System.Windows.Forms.Label lblContainsFullWidthChar4;

        private System.Windows.Forms.Label lblOutput3;
        private System.Windows.Forms.Label lblContainsFullWidthChar3;

        private System.Windows.Forms.Label lblContainsFullWidthChar2;
        private System.Windows.Forms.Label lblOutput2;

        #endregion

        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblContainsFullWidthChar;
    }
}

