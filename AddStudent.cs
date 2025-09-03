using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psychic_train_terry_was_right
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm exit?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEnrollment.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();
            txtContact.Clear();
            txtEmail.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtEnrollment.Text == "" || txtName.Text == "" || txtDepartment.Text == "" || txtSemester.Text == "" || txtContact.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtContact.Text.Length != 10)
            {
                MessageBox.Show("Invalid Contact Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(txtContact.Text, out _))
            {
                MessageBox.Show("Contact Number must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            String name = txtName.Text;
            String enroll = txtEnrollment.Text;
            String dep = txtDepartment.Text;
            String sem = txtSemester.Text;
            Int64 mobile = Int64.Parse(txtContact.Text);
            String email = txtEmail.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\booktool; database = library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into NewStudent (sname,enroll,dep,sem,contact,email) values ('" + name + "','" + enroll + "','" + dep + "','" + sem + "'," + mobile + ",'" + email + "')";
            cmd.ExecuteNonQuery(); 
            con.Close();

            MessageBox.Show("Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
