using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psychic_train_terry_was_right
{
    public partial class Dashboard : Form
    {
        //No duplicate forms allowed, opens the form if not already open
        private void OpenForm<T>() where T : Form, new()
        {

            foreach (Form form in Application.OpenForms)
            {
                if (form is T)
                {
                    form.Activate();
                    return;
                }
            }

            // If no instance is found, create a new one
            T newForm = new T();
            newForm.MdiParent = this;
            newForm.Show();
        }
        public Dashboard()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to leave this world?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<AddBooks>();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<ViewBooks>();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<AddStudent>();
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<ViewStudentInformation>();
        }

        private void copleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<ViewBooks>();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<ReturnBook>();
        }

        private void bonusToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=dQw4w9WgXcQ&list=RDdQw4w9WgXcQ&start_radio=1",
                UseShellExecute = true
            });

        }
    }
}
