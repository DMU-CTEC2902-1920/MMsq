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
            this.lblSufiyaan = new System.Windows.Forms.Label();
            this.btnConflict = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblSufiyaan
            // 
            this.lblSufiyaan.AutoSize = true;
            this.lblSufiyaan.Location = new System.Drawing.Point(351, 188);
            this.lblSufiyaan.Name = "lblSufiyaan";
            this.lblSufiyaan.Size = new System.Drawing.Size(77, 13);
            this.lblSufiyaan.TabIndex = 0;
            this.lblSufiyaan.Text = "Sufiyaan Label";
            // 
            // btnConflict
            // 
            this.btnConflict.Location = new System.Drawing.Point(337, 243);
            this.btnConflict.Name = "btnConflict";
            this.btnConflict.Size = new System.Drawing.Size(75, 23);
            this.btnConflict.TabIndex = 1;
            this.btnConflict.Text = "Conflict";
            this.btnConflict.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(345, 238);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConflict);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblSufiyaan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSufiyaan;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnConflict;
    }
}

