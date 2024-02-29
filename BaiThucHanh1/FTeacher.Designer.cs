namespace BaiThucHanh1
{
    partial class FTeacher
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
            this.ucThongTin1 = new BaiThucHanh1.UCThongTin();
            this.SuspendLayout();
            // 
            // ucThongTin1
            // 
            this.ucThongTin1.Location = new System.Drawing.Point(-1, 3);
            this.ucThongTin1.Name = "ucThongTin1";
            this.ucThongTin1.Size = new System.Drawing.Size(1081, 551);
            this.ucThongTin1.TabIndex = 0;
            // 
            // FTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 552);
            this.Controls.Add(this.ucThongTin1);
            this.Name = "FTeacher";
            this.Text = "FTeacher";
            this.ResumeLayout(false);

        }

        #endregion

        private UCThongTin ucThongTin1;
    }
}