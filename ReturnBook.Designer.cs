namespace Psychic_train_terry_was_right
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnExit = new Button();
            btnRefresh = new Button();
            btnSearchStudent = new Button();
            label2 = new Label();
            txtEnterEnroll = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnCancel = new Button();
            btnReturn = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            txtBookName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(654, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(962, 487);
            dataGridView1.TabIndex = 12;
         
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnSearchStudent);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtEnterEnroll);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(47, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 487);
            panel1.TabIndex = 13;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(292, 384);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 12;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(84, 384);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.Location = new Point(438, 296);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(112, 34);
            btnSearchStudent.TabIndex = 10;
            btnSearchStudent.Text = "SEARCH";
            btnSearchStudent.UseVisualStyleBackColor = true;
            btnSearchStudent.Click += btnSearchStudent_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(84, 221);
            label2.Name = "label2";
            label2.Size = new Size(382, 54);
            label2.TabIndex = 9;
            label2.Text = "Enter Enrollment No";
            // 
            // txtEnterEnroll
            // 
            txtEnterEnroll.Location = new Point(84, 299);
            txtEnterEnroll.Name = "txtEnterEnroll";
            txtEnterEnroll.Size = new Size(320, 31);
            txtEnterEnroll.TabIndex = 1;
            txtEnterEnroll.TextChanged += txtEnterEnroll_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(193, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnReturn);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(654, 567);
            panel2.Name = "panel2";
            panel2.Size = new Size(962, 433);
            panel2.TabIndex = 14;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(817, 302);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(817, 207);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(112, 34);
            btnReturn.TabIndex = 10;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(431, 302);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(337, 31);
            dateTimePicker1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(431, 209);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(337, 31);
            textBox2.TabIndex = 8;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(431, 123);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(337, 31);
            txtBookName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.White;
            label4.Location = new Point(137, 290);
            label4.Name = "label4";
            label4.Size = new Size(180, 28);
            label4.TabIndex = 3;
            label4.Text = "Book Return Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(137, 209);
            label3.Name = "label3";
            label3.Size = new Size(263, 28);
            label3.TabIndex = 2;
            label3.Text = "Book Issue Date (optional)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(137, 123);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 1;
            label1.Text = "Book Name";
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1689, 1110);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "ReturnBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnBook";
          
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtEnterEnroll;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnExit;
        private Button btnRefresh;
        private Button btnSearchStudent;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnCancel;
        private Button btnReturn;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox txtBookName;
    }
}