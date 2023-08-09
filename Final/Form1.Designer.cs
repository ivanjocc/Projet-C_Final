namespace Final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            dtpDateOfBirth = new DateTimePicker();
            label10 = new Label();
            btnAddPerson = new Button();
            label4 = new Label();
            txtPersonName = new TextBox();
            txtLastName = new TextBox();
            label8 = new Label();
            btnRemovePerson = new Button();
            groupBox1 = new GroupBox();
            dateTimePickerPublicationDate = new DateTimePicker();
            buttonAdd = new Button();
            label5 = new Label();
            textBoxTitle = new TextBox();
            textBoxAuthor = new TextBox();
            label6 = new Label();
            buttonRemove = new Button();
            label7 = new Label();
            buttonReturn = new Button();
            buttonBorrow = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvAuthorizedPeople = new DataGridView();
            dataGridViewBorrowed = new DataGridView();
            dataGridViewLibrary = new DataGridView();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuthorizedPeople).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBorrowed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLibrary).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpDateOfBirth);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(btnAddPerson);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtPersonName);
            groupBox2.Controls.Add(txtLastName);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnRemovePerson);
            groupBox2.Location = new Point(534, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(222, 263);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Form People";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(73, 104);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(131, 23);
            dtpDateOfBirth.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 110);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 12;
            label10.Text = "Born Date";
            // 
            // btnAddPerson
            // 
            btnAddPerson.Location = new Point(37, 152);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(150, 37);
            btnAddPerson.TabIndex = 13;
            btnAddPerson.Text = "Add Person";
            btnAddPerson.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 38);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 9;
            label4.Text = "Name";
            // 
            // txtPersonName
            // 
            txtPersonName.Location = new Point(73, 30);
            txtPersonName.Name = "txtPersonName";
            txtPersonName.Size = new Size(131, 23);
            txtPersonName.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(73, 68);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(131, 23);
            txtLastName.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 72);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 9;
            label8.Text = "Last Name";
            // 
            // btnRemovePerson
            // 
            btnRemovePerson.Location = new Point(37, 195);
            btnRemovePerson.Name = "btnRemovePerson";
            btnRemovePerson.Size = new Size(150, 37);
            btnRemovePerson.TabIndex = 14;
            btnRemovePerson.Text = "Delete Person";
            btnRemovePerson.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePickerPublicationDate);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxTitle);
            groupBox1.Controls.Add(textBoxAuthor);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(buttonRemove);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(284, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 263);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form Books";
            // 
            // dateTimePickerPublicationDate
            // 
            dateTimePickerPublicationDate.Location = new Point(73, 108);
            dateTimePickerPublicationDate.Name = "dateTimePickerPublicationDate";
            dateTimePickerPublicationDate.Size = new Size(127, 23);
            dateTimePickerPublicationDate.TabIndex = 7;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(40, 156);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(150, 37);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Add Book";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 38);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 9;
            label5.Text = "Name";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(73, 30);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(127, 23);
            textBoxTitle.TabIndex = 5;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(73, 68);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(127, 23);
            textBoxAuthor.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 76);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 9;
            label6.Text = "Author";
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(40, 199);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(150, 37);
            buttonRemove.TabIndex = 9;
            buttonRemove.Text = "Delete Book";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 114);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 9;
            label7.Text = "Date Pub";
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(174, 319);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(95, 53);
            buttonReturn.TabIndex = 16;
            buttonReturn.Text = "Return";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // buttonBorrow
            // 
            buttonBorrow.Location = new Point(35, 319);
            buttonBorrow.Name = "buttonBorrow";
            buttonBorrow.Size = new Size(95, 53);
            buttonBorrow.TabIndex = 15;
            buttonBorrow.Text = "Borrow";
            buttonBorrow.UseVisualStyleBackColor = true;
            buttonBorrow.Click += buttonBorrow_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(773, 39);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 16;
            label3.Text = "Authorized Persons";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 183);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 17;
            label2.Text = "Borrowed Books";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 39);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 18;
            label1.Text = "Books Availables";
            // 
            // dgvAuthorizedPeople
            // 
            dgvAuthorizedPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthorizedPeople.Location = new Point(773, 57);
            dgvAuthorizedPeople.Name = "dgvAuthorizedPeople";
            dgvAuthorizedPeople.RowTemplate.Height = 25;
            dgvAuthorizedPeople.Size = new Size(176, 100);
            dgvAuthorizedPeople.TabIndex = 25;
            // 
            // dataGridViewBorrowed
            // 
            dataGridViewBorrowed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBorrowed.Location = new Point(35, 201);
            dataGridViewBorrowed.Name = "dataGridViewBorrowed";
            dataGridViewBorrowed.RowTemplate.Height = 25;
            dataGridViewBorrowed.Size = new Size(234, 100);
            dataGridViewBorrowed.TabIndex = 23;
            // 
            // dataGridViewLibrary
            // 
            dataGridViewLibrary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLibrary.Location = new Point(35, 57);
            dataGridViewLibrary.Name = "dataGridViewLibrary";
            dataGridViewLibrary.RowTemplate.Height = 25;
            dataGridViewLibrary.Size = new Size(234, 100);
            dataGridViewLibrary.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonReturn);
            Controls.Add(buttonBorrow);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvAuthorizedPeople);
            Controls.Add(dataGridViewBorrowed);
            Controls.Add(dataGridViewLibrary);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuthorizedPeople).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBorrowed).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLibrary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private DateTimePicker dtpDateOfBirth;
        private Label label10;
        private Button btnAddPerson;
        private Label label4;
        private TextBox txtPersonName;
        private TextBox txtLastName;
        private Label label8;
        private Button btnRemovePerson;
        private GroupBox groupBox1;
        private Button buttonAdd;
        private Label label5;
        private TextBox textBoxTitle;
        private TextBox textBoxAuthor;
        private Label label6;
        private Button buttonRemove;
        private Label label7;
        private Button buttonReturn;
        private Button buttonBorrow;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvAuthorizedPeople;
        private DataGridView dataGridViewBorrowed;
        private DataGridView dataGridViewLibrary;
        private DateTimePicker dateTimePickerPublicationDate;
    }
}