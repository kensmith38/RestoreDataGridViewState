namespace RestoreDataGridViewState
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Column_PatientID = new DataGridViewTextBoxColumn();
            Column_LastName = new DataGridViewTextBoxColumn();
            Column_FirstName = new DataGridViewTextBoxColumn();
            Column_ExamDate = new DataGridViewTextBoxColumn();
            Column_ExamTime = new DataGridViewTextBoxColumn();
            Column_PhoneNumber = new DataGridViewTextBoxColumn();
            Column_UpdatePatient = new DataGridViewButtonColumn();
            Column_SendTextNotification = new DataGridViewButtonColumn();
            label1 = new Label();
            textBoxCtrPatients = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column_PatientID, Column_LastName, Column_FirstName, Column_ExamDate, Column_ExamTime, Column_PhoneNumber, Column_UpdatePatient, Column_SendTextNotification });
            dataGridView1.Location = new Point(26, 106);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(701, 298);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column_PatientID
            // 
            Column_PatientID.HeaderText = "ID";
            Column_PatientID.Name = "Column_PatientID";
            Column_PatientID.ReadOnly = true;
            Column_PatientID.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column_PatientID.Width = 40;
            // 
            // Column_LastName
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Column_LastName.DefaultCellStyle = dataGridViewCellStyle1;
            Column_LastName.HeaderText = "Last name";
            Column_LastName.Name = "Column_LastName";
            Column_LastName.ReadOnly = true;
            // 
            // Column_FirstName
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            Column_FirstName.DefaultCellStyle = dataGridViewCellStyle2;
            Column_FirstName.HeaderText = "First name";
            Column_FirstName.Name = "Column_FirstName";
            Column_FirstName.ReadOnly = true;
            Column_FirstName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_ExamDate
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            Column_ExamDate.DefaultCellStyle = dataGridViewCellStyle3;
            Column_ExamDate.HeaderText = "Exam date";
            Column_ExamDate.Name = "Column_ExamDate";
            Column_ExamDate.ReadOnly = true;
            Column_ExamDate.Width = 70;
            // 
            // Column_ExamTime
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.Padding = new Padding(0, 0, 2, 0);
            Column_ExamTime.DefaultCellStyle = dataGridViewCellStyle4;
            Column_ExamTime.HeaderText = "Exam time";
            Column_ExamTime.Name = "Column_ExamTime";
            Column_ExamTime.ReadOnly = true;
            Column_ExamTime.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column_ExamTime.Width = 70;
            // 
            // Column_PhoneNumber
            // 
            Column_PhoneNumber.HeaderText = "Phone number";
            Column_PhoneNumber.Name = "Column_PhoneNumber";
            Column_PhoneNumber.ReadOnly = true;
            Column_PhoneNumber.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column_PhoneNumber.Width = 80;
            // 
            // Column_UpdatePatient
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Padding = new Padding(4, 2, 4, 2);
            Column_UpdatePatient.DefaultCellStyle = dataGridViewCellStyle5;
            Column_UpdatePatient.HeaderText = "Update patient info";
            Column_UpdatePatient.Name = "Column_UpdatePatient";
            Column_UpdatePatient.ReadOnly = true;
            Column_UpdatePatient.Text = "Update...";
            Column_UpdatePatient.UseColumnTextForButtonValue = true;
            // 
            // Column_SendTextNotification
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Padding = new Padding(4, 2, 4, 2);
            Column_SendTextNotification.DefaultCellStyle = dataGridViewCellStyle6;
            Column_SendTextNotification.HeaderText = "Send text notification";
            Column_SendTextNotification.Name = "Column_SendTextNotification";
            Column_SendTextNotification.ReadOnly = true;
            Column_SendTextNotification.Text = "Send text...";
            Column_SendTextNotification.UseColumnTextForButtonValue = true;
            Column_SendTextNotification.Width = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 81);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 1;
            label1.Text = "Number of patients:";
            // 
            // textBoxCtrPatients
            // 
            textBoxCtrPatients.Location = new Point(460, 77);
            textBoxCtrPatients.Name = "textBoxCtrPatients";
            textBoxCtrPatients.ReadOnly = true;
            textBoxCtrPatients.Size = new Size(65, 23);
            textBoxCtrPatients.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 81);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Patients";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(160, 25);
            label3.TabIndex = 6;
            label3.Text = "Patient Schedule";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 455);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxCtrPatients);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBoxCtrPatients;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn Column_PatientID;
        private DataGridViewTextBoxColumn Column_LastName;
        private DataGridViewTextBoxColumn Column_FirstName;
        private DataGridViewTextBoxColumn Column_ExamDate;
        private DataGridViewTextBoxColumn Column_ExamTime;
        private DataGridViewTextBoxColumn Column_PhoneNumber;
        private DataGridViewButtonColumn Column_UpdatePatient;
        private DataGridViewButtonColumn Column_SendTextNotification;
    }
}
