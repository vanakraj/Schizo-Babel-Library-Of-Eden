namespace Psychic_train_terry_was_right
{
    partial class ViewStudentInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentInformation));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnRefresh = new Button();
            txtSearchEnrollment = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            txtSemester = new TextBox();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtDepartment = new TextBox();
            txtEnrollment = new TextBox();
            txtSName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(895, 33);
            label1.Name = "label1";
            label1.Size = new Size(511, 54);
            label1.TabIndex = 6;
            label1.Text = "View Student Information";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(642, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1660, 131);
            panel2.TabIndex = 7;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI", 20F);
            btnRefresh.Location = new Point(1081, 152);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(232, 72);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearchEnrollment
            // 
            txtSearchEnrollment.Location = new Point(598, 178);
            txtSearchEnrollment.Name = "txtSearchEnrollment";
            txtSearchEnrollment.Size = new Size(401, 31);
            txtSearchEnrollment.TabIndex = 9;
            txtSearchEnrollment.TextChanged += txtSearchEnrollment_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(305, 158);
            label2.Name = "label2";
            label2.Size = new Size(279, 54);
            label2.TabIndex = 8;
            label2.Text = "Enrollment No";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 265);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1545, 433);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Controls.Add(txtSemester);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtContact);
            panel3.Controls.Add(txtDepartment);
            panel3.Controls.Add(txtEnrollment);
            panel3.Controls.Add(txtSName);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(31, 731);
            panel3.Name = "panel3";
            panel3.Size = new Size(1545, 395);
            panel3.TabIndex = 12;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(1057, 82);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(320, 31);
            txtSemester.TabIndex = 15;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 20F);
            btnCancel.Location = new Point(1113, 298);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(264, 61);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 20F);
            btnDelete.Location = new Point(725, 298);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(255, 61);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 20F);
            btnUpdate.Location = new Point(363, 298);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(217, 61);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(1057, 241);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 31);
            txtEmail.TabIndex = 10;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(1057, 160);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(320, 31);
            txtContact.TabIndex = 9;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(363, 231);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(337, 31);
            txtDepartment.TabIndex = 8;
            // 
            // txtEnrollment
            // 
            txtEnrollment.Location = new Point(363, 153);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(337, 31);
            txtEnrollment.TabIndex = 7;
            // 
            // txtSName
            // 
            txtSName.Location = new Point(363, 76);
            txtSName.Name = "txtSName";
            txtSName.Size = new Size(337, 31);
            txtSName.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(791, 235);
            label8.Name = "label8";
            label8.Size = new Size(171, 32);
            label8.TabIndex = 5;
            label8.Text = "Student Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(791, 160);
            label7.Name = "label7";
            label7.Size = new Size(192, 32);
            label7.TabIndex = 4;
            label7.Text = "Student Contact";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(791, 79);
            label6.Name = "label6";
            label6.Size = new Size(207, 32);
            label6.TabIndex = 3;
            label6.Text = "Student Semester";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(105, 156);
            label5.Name = "label5";
            label5.Size = new Size(178, 32);
            label5.TabIndex = 2;
            label5.Text = "Enrollment No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(105, 231);
            label4.Name = "label4";
            label4.Size = new Size(148, 32);
            label4.TabIndex = 1;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(105, 76);
            label3.Name = "label3";
            label3.Size = new Size(173, 32);
            label3.TabIndex = 0;
            label3.Text = "Student Name";
            // 
            // ViewStudentInformation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1689, 766);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearchEnrollment);
            Controls.Add(label2);
            Controls.Add(panel2);
            Name = "ViewStudentInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewStudentInformation";
            Load += ViewStudentInformation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnRefresh;
        private TextBox txtSearchEnrollment;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private TextBox txtSemester;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtDepartment;
        private TextBox txtEnrollment;
        private TextBox txtSName;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}