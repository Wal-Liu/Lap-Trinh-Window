using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaiThucHanh1
{
    public partial class FStudent : Form
    {
        StudentDAO studentDAO = new StudentDAO();
        Student student;
        public FStudent()
        {
            InitializeComponent();
            ucThongTin_Student.BtnAdd.Click += BtnAdd_Click;
            ucThongTin_Student.BtnDelete.Click += BtnDelete_Click;
            ucThongTin_Student.BtnEdit.Click += BtnEdit_Click;
            //ucInfo_Student.BtnChangeTeacherForm.Click += BtnChangeTeacherForm_Click;
            ucThongTin_Student.GvData.CellContentClick += GvStudents_CellContentClick;
            ucThongTin_Student.GvData.CellClick += GvStudents_CellContentClick;
        }
        public void LoadDataFromStudentDAO()
        {
            DataTable dtSinhVien = studentDAO.Load();
            ucThongTin_Student.GvData.DataSource = dtSinhVien;
        }


        public void LoadDataFromRow(DataGridViewRow row)
        {
            ucThongTin_Student.Lbl_ID.Text = row.Cells[0].Value.ToString();
            ucThongTin_Student.TxtName.Text = row.Cells[1].Value.ToString();
            ucThongTin_Student.TxtAddress.Text = row.Cells[2].Value.ToString();
            ucThongTin_Student.TxtGid.Text = row.Cells[3].Value.ToString();
            ucThongTin_Student.TxtPhoneNumber.Text = row.Cells[5].Value.ToString();
            ucThongTin_Student.TxtEmail.Text = row.Cells[6].Value.ToString();
            ucThongTin_Student.DtpBirthDate.Value = DateTime.Parse(row.Cells[4].Value.ToString());
            ucThongTin_Student.TxtSex.Text = row.Cells[7].Value.ToString();
        }

        private void GvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataFromRow(ucThongTin_Student.GvData.SelectedRows[0]);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDataFromUC();
                studentDAO.Add(student);
                LoadDataFromStudentDAO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void LoadDataFromUC()
        {
            student = new Student(ucThongTin_Student.TxtName.Text, ucThongTin_Student.TxtSex.Text, ucThongTin_Student.TxtAddress.Text, ucThongTin_Student.TxtGid.Text, ucThongTin_Student.DtpBirthDate.Value, ucThongTin_Student.TxtPhoneNumber.Text, ucThongTin_Student.TxtEmail.Text, ucThongTin_Student.Lbl_ID.Text);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = ucThongTin_Student.Lbl_ID.Text;
                if (id.Length == 0)
                {
                    throw new Exception("Could you provide id for me? then I can help you.");
                }
                studentDAO.Delete(id);
                LoadDataFromStudentDAO();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDataFromUC();
                studentDAO.Edit(student);
                LoadDataFromStudentDAO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void ResetForm()
        {
            ucThongTin_Student.TxtAddress.Clear();
            ucThongTin_Student.TxtName.Clear();
            ucThongTin_Student.TxtGid.Clear();
            ucThongTin_Student.TxtPhoneNumber.Clear();
            ucThongTin_Student.Lbl_ID.Text = "";
            ucThongTin_Student.TxtEmail.Text = "";
            ucThongTin_Student.TxtSex.Text = "";
        }

        private void BtnChangeTeacherForm_Click(object sender, EventArgs e)
        {
            FTeacher fGiaoVien = new FTeacher();
            fGiaoVien.Show();
            this.Hide();
        }

        private void FStudent_Load(object sender, EventArgs e)
        {
            LoadDataFromStudentDAO();
        }
    }
}
