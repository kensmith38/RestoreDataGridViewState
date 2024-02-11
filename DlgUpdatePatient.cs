using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoreDataGridViewState
{
    public partial class DlgUpdatePatient : Form
    {
        private IPatientRepository _patientRepository;
        public int PatientId { get; set; }
        public DlgUpdatePatient(int patientId)
        {
            InitializeComponent();
            _patientRepository = Program.ServiceProvider.GetRequiredService<IPatientRepository>();
            PatientId = patientId;
        }

        private void DlgUpdatePatient_Load(object sender, EventArgs e)
        {
            Patient patient = _patientRepository.GetPatientById(PatientId);
            textBoxPatientNameLF.Text = patient.LastName + ", " + patient.FirstName;
            textBoxPatientPhone.Text = patient.PrimaryPhoneNumber;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            MessageBox.Show($"Updated phone number for: {textBoxPatientNameLF.Text}",
                "Update patient info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Patient patient = _patientRepository.GetPatientById(PatientId);
            patient.PrimaryPhoneNumber = textBoxPatientPhone.Text;
            this.Close();
        }
    }
}
