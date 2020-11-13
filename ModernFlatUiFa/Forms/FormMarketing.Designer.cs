
namespace ModernFlatUiFa.Forms
{
    partial class FormMarketing
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
            this.labelMarketing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMarketing
            // 
            this.labelMarketing.AutoSize = true;
            this.labelMarketing.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMarketing.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMarketing.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelMarketing.Location = new System.Drawing.Point(0, 0);
            this.labelMarketing.Name = "labelMarketing";
            this.labelMarketing.Size = new System.Drawing.Size(123, 32);
            this.labelMarketing.TabIndex = 1;
            this.labelMarketing.Text = "Marketing";
            // 
            // FormMarketing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(821, 509);
            this.Controls.Add(this.labelMarketing);
            this.Name = "FormMarketing";
            this.Text = "Marketing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMarketing;
    }
}