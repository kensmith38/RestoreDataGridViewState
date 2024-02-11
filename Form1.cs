namespace RestoreDataGridViewState
{
    public partial class Form1 : Form
    {
        IPatientRepository _patientRepository;
        public Form1(IPatientRepository patientRepository)
        {
            InitializeComponent();
            _patientRepository = patientRepository;
        }
        private void refreshScreen()
        {
            PopulateGrid();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            // necessary setting to allow header cells to be colored
            dataGridView1.EnableHeadersVisualStyles = false;
            Column_ExamDate.HeaderCell.Style.ForeColor = Color.Blue;
            Column_LastName.HeaderCell.Style.ForeColor = Color.Blue;

            // taller rows for button 
            dataGridView1.RowTemplate.Height = 26;
            //
            PopulateGrid();

        }
        private void PopulateGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (Patient patient in _patientRepository.ListPatients())
            {
                DataGridViewRow dgvrow = dataGridView1.Rows[dataGridView1.Rows.Add()];
                dgvrow.Cells[Column_PatientID.Index].Value = patient.Id;
                dgvrow.Cells[Column_LastName.Index].Value = patient.LastName;
                dgvrow.Cells[Column_FirstName.Index].Value = patient.FirstName;
                dgvrow.Cells[Column_ExamDate.Index].Value = patient.ExamDate;
                dgvrow.Cells[Column_ExamTime.Index].Value = patient.ExamDate;
                dgvrow.Cells[Column_PhoneNumber.Index].Value = patient.PrimaryPhoneNumber;

            }
            textBoxCtrPatients.Text = dataGridView1.Rows.Count.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Column_SendTextNotification.Index == e.ColumnIndex)
                {
                    DataGridViewRow dgvrow = dataGridView1.Rows[e.RowIndex];
                    int selectedPatientId = (int)dgvrow.Cells[Column_PatientID.Index].Value;
                    new DlgSendTextNotification(selectedPatientId).ShowDialog();
                    // Instead of simply refreshing the screen, we must:
                    // ==================================================
                    // 1. save the datagridview characteristics using KenDgvCharacteristics
                    // 2. call method, refreshScreen
                    // 3. call method, kenDgvCharacteristics.RestoreDgvCharacteristics()
                    KenDgvCharacteristics kenDgvCharacteristics = new KenDgvCharacteristics(
                        dataGridView1, Column_PatientID, Column_LastName);
                    refreshScreen();
                    kenDgvCharacteristics.RestoreDgvCharacteristics();
                }
                if (Column_UpdatePatient.Index == e.ColumnIndex)
                {
                    DataGridViewRow dgvrow = dataGridView1.Rows[e.RowIndex];
                    int selectedPatientId = (int)dgvrow.Cells[Column_PatientID.Index].Value;
                    
                    
                    new DlgUpdatePatient(selectedPatientId).ShowDialog();


                    // Instead of simply refreshing the screen, we must:
                    // ==================================================
                    // 1. save the datagridview characteristics using KenDgvCharacteristics
                    // 2. call method, refreshScreen
                    // 3. call method, kenDgvCharacteristics.RestoreDgvCharacteristics()
                    KenDgvCharacteristics kenDgvCharacteristics = new KenDgvCharacteristics(
                        dataGridView1, Column_PatientID, Column_LastName);
                    refreshScreen();
                    kenDgvCharacteristics.RestoreDgvCharacteristics();
                }
            }
        }
    }
}
