namespace BaiThucHanh1
{
    partial class FStudent
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
            this.ucThongTin_Student = new BaiThucHanh1.UCThongTin();
            this.SuspendLayout();
            // 
            // ucThongTin1
            // 
            this.ucThongTin_Student.Location = new System.Drawing.Point(-1, 1);
            this.ucThongTin_Student.Name = "ucThongTin1";
            this.ucThongTin_Student .Size = new System.Drawing.Size(1114, 662);
            this.ucThongTin_Student.TabIndex = 0;
            // 
            // FStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 546);
            this.Controls.Add(this.ucThongTin_Student);
            this.Name = "FStudent";
            this.Text = "FStudent";
            this.ResumeLayout(false);

        }

        #endregion

        private UCThongTin ucThongTin_Student;
    }
}