namespace RestoreDataGridViewState
{
    partial class DlgUpdatePatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgUpdatePatient));
            label3 = new Label();
            textBoxPatientNameLF = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            textBoxPatientPhone = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 56);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 17;
            label3.Text = "Patient name:";
            // 
            // textBoxPatientNameLF
            // 
            textBoxPatientNameLF.Location = new Point(121, 53);
            textBoxPatientNameLF.Name = "textBoxPatientNameLF";
            textBoxPatientNameLF.ReadOnly = true;
            textBoxPatientNameLF.Size = new Size(261, 23);
            textBoxPatientNameLF.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 234);
            label2.Name = "label2";
            label2.Size = new Size(690, 240);
            label2.TabIndex = 14;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 25);
            label1.TabIndex = 13;
            label1.Text = "Update patient info";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 85);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 19;
            label4.Text = "Patient phone:";
            // 
            // textBoxPatientPhone
            // 
            textBoxPatientPhone.Location = new Point(121, 82);
            textBoxPatientPhone.Name = "textBoxPatientPhone";
            textBoxPatientPhone.Size = new Size(165, 23);
            textBoxPatientPhone.TabIndex = 18;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(175, 167);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 23);
            buttonSave.TabIndex = 20;
            buttonSave.Text = "Save changes";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(307, 168);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 21;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 129);
            label5.Name = "label5";
            label5.Size = new Size(602, 21);
            label5.TabIndex = 22;
            label5.Text = "<A realistic form would have many more fields to be updated  (address, etc.)>";
            // 
            // DlgUpdatePatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 503);
            Controls.Add(label5);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(label4);
            Controls.Add(textBoxPatientPhone);
            Controls.Add(label3);
            Controls.Add(textBoxPatientNameLF);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DlgUpdatePatient";
            Text = "DlgUpdatePatient";
            Load += DlgUpdatePatient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBoxPatientNameLF;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox textBoxPatientPhone;
        private Button buttonSave;
        private Button buttonCancel;
        private Label label5;
    }
}