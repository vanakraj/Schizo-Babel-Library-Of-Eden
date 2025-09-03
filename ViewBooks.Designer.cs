namespace Psychic_train_terry_was_right
{
    partial class ViewBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBooks));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            txtBookName = new TextBox();
            label2 = new Label();
            btnRefresh = new Button();
            panel3 = new Panel();
            txtPDate = new TextBox();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtPublication = new TextBox();
            txtAuthor = new TextBox();
            txtBName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1601, 112);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(905, 51);
            label1.Name = "label1";
            label1.Size = new Size(222, 54);
            label1.TabIndex = 1;
            label1.Text = "View Book";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(684, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSlateBlue;
            panel2.Location = new Point(3, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(1660, 154);
            panel2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 290);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1545, 433);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(652, 197);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(401, 31);
            txtBookName.TabIndex = 2;
            txtBookName.TextChanged += txtBookName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(359, 177);
            label2.Name = "label2";
            label2.Size = new Size(228, 54);
            label2.TabIndex = 1;
            label2.Text = "Book Name";
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI", 20F);
            btnRefresh.Location = new Point(1135, 171);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(232, 72);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Controls.Add(txtPDate);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(txtQuantity);
            panel3.Controls.Add(txtPrice);
            panel3.Controls.Add(txtPublication);
            panel3.Controls.Add(txtAuthor);
            panel3.Controls.Add(txtBName);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(23, 745);
            panel3.Name = "panel3";
            panel3.Size = new Size(1545, 395);
            panel3.TabIndex = 7;
            // 
            // txtPDate
            // 
            txtPDate.Location = new Point(1057, 82);
            txtPDate.Name = "txtPDate";
            txtPDate.Size = new Size(320, 31);
            txtPDate.TabIndex = 15;
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
            // txtQuantity
            // 
            txtQuantity.Location = new Point(1057, 241);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(320, 31);
            txtQuantity.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(1057, 160);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(320, 31);
            txtPrice.TabIndex = 9;
            // 
            // txtPublication
            // 
            txtPublication.Location = new Point(363, 231);
            txtPublication.Name = "txtPublication";
            txtPublication.Size = new Size(337, 31);
            txtPublication.TabIndex = 8;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(363, 153);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(337, 31);
            txtAuthor.TabIndex = 7;
            // 
            // txtBName
            // 
            txtBName.Location = new Point(363, 76);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(337, 31);
            txtBName.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(791, 235);
            label8.Name = "label8";
            label8.Size = new Size(177, 32);
            label8.TabIndex = 5;
            label8.Text = "Book Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(791, 160);
            label7.Name = "label7";
            label7.Size = new Size(134, 32);
            label7.TabIndex = 4;
            label7.Text = "Book Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(791, 79);
            label6.Name = "label6";
            label6.Size = new Size(239, 32);
            label6.TabIndex = 3;
            label6.Text = "Book Purchase Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(105, 156);
            label5.Name = "label5";
            label5.Size = new Size(230, 32);
            label5.TabIndex = 2;
            label5.Text = "Book Author Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(105, 231);
            label4.Name = "label4";
            label4.Size = new Size(207, 32);
            label4.TabIndex = 1;
            label4.Text = "Book Publication";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(105, 76);
            label3.Name = "label3";
            label3.Size = new Size(145, 32);
            label3.TabIndex = 0;
            label3.Text = "Book Name";
            // 
            // ViewBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1603, 771);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(txtBookName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "ViewBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBook";
            Load += ViewBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox txtBookName;
        private Label label2;
        private Button btnRefresh;
        private Panel panel3;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtPublication;
        private TextBox txtAuthor;
        private TextBox txtBName;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtPDate;
    }
}