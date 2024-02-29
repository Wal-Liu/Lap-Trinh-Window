using System.Windows.Forms;

namespace BaiThucHanh1
{
    partial class UCThongTin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtGid = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.gvData = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(68, 97);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(26, 20);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sex";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Goverment ID";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone Number";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Address";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Birthdate";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(214, 135);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(318, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(214, 179);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(318, 26);
            this.txtSex.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(214, 219);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(318, 26);
            this.txtAddress.TabIndex = 1;
            // 
            // txtGid
            // 
            this.txtGid.Location = new System.Drawing.Point(214, 255);
            this.txtGid.Name = "txtGid";
            this.txtGid.Size = new System.Drawing.Size(318, 26);
            this.txtGid.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(214, 340);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(318, 26);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(214, 388);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(318, 26);
            this.txtEmail.TabIndex = 1;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(214, 302);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(318, 26);
            this.dtpBirthDate.TabIndex = 2;
            // 
            // gvData
            // 
            this.gvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvData.Location = new System.Drawing.Point(568, 97);
            this.gvData.Name = "gvData";
            this.gvData.RowHeadersWidth = 62;
            this.gvData.RowTemplate.Height = 28;
            this.gvData.Size = new System.Drawing.Size(479, 422);
            this.gvData.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(66, 464);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 55);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(214, 464);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 55);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(363, 464);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 55);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // UCThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gvData);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtGid);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_ID);
            this.Name = "UCThongTin";
            this.Size = new System.Drawing.Size(1114, 662);
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtGid;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.DataGridView gvData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;

        public Label Lbl_ID { get => lbl_ID; set => lbl_ID = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public Label Label8 { get => label8; set => label8 = value; }
        public TextBox TxtName { get => txtName; set => txtName = value; }
        public TextBox TxtSex { get => txtSex; set => txtSex = value; }
        public TextBox TxtAddress { get => txtAddress; set => txtAddress = value; }
        public TextBox TxtGid { get => txtGid; set => txtGid = value; }
        public TextBox TxtPhoneNumber { get => txtPhoneNumber; set => txtPhoneNumber = value; }
        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
        public DateTimePicker DtpBirthDate { get => dtpBirthDate; set => dtpBirthDate = value; }
        public DataGridView GvData { get => gvData; set => gvData = value; }
        public Button BtnAdd { get => btnAdd; set => btnAdd = value; }
        public Button Button1 { get => button1; set => button1 = value; }
        public Button BtnDelete { get => btnDelete; set => btnDelete = value; }
        public Button BtnEdit { get => btnEdit; set => btnEdit = value; }
    }
}
