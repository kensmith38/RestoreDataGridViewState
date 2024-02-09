namespace RestoreDataGridViewState
{
    partial class DlgSendTextNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgSendTextNotification));
            label3 = new Label();
            textBoxPatientNameLF = new TextBox();
            buttonSendText = new Button();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 56);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 9;
            label3.Text = "Patient name:";
            // 
            // textBoxPatientNameLF
            // 
            textBoxPatientNameLF.Location = new Point(121, 53);
            textBoxPatientNameLF.Name = "textBoxPatientNameLF";
            textBoxPatientNameLF.ReadOnly = true;
            textBoxPatientNameLF.Size = new Size(261, 23);
            textBoxPatientNameLF.TabIndex = 8;
            // 
            // buttonSendText
            // 
            buttonSendText.Location = new Point(299, 161);
            buttonSendText.Name = "buttonSendText";
            buttonSendText.Size = new Size(115, 23);
            buttonSendText.TabIndex = 7;
            buttonSendText.Text = "Send text message";
            buttonSendText.UseVisualStyleBackColor = true;
            buttonSendText.Click += buttonSendText_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 201);
            label2.Name = "label2";
            label2.Size = new Size(690, 240);
            label2.TabIndex = 6;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 25);
            label1.TabIndex = 5;
            label1.Text = "Send Text Notification";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 85);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 11;
            label4.Text = "Text message:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 82);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(389, 63);
            textBox1.TabIndex = 10;
            textBox1.Text = "<Enter text here>";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(438, 161);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // DlgSendTextNotification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(textBoxPatientNameLF);
            Controls.Add(buttonSendText);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DlgSendTextNotification";
            Text = "DlgSendTextNotification";
            Load += DlgSendTextNotification_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBoxPatientNameLF;
        private Button buttonSendText;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox textBox1;
        private Button button1;
    }
}