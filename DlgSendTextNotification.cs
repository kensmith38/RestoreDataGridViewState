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
    public partial class DlgSendTextNotification : Form
    {
        private IPatientRepository _patientRepository;
        public int PatientId { get; set; }

        public DlgSendTextNotification(int patientId)
        {
            InitializeComponent();
            _patientRepository = Program.ServiceProvider.GetRequiredService<IPatientRepository>();
            PatientId = patientId;
        }

        private void DlgSendTextNotification_Load(object sender, EventArgs e)
        {
            Patient patient = _patientRepository.GetPatientById(PatientId);
            textBoxPatientNameLF.Text = patient.LastName + ", " + patient.FirstName;
        }

        private void buttonSendText_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            MessageBox.Show($"Text message sent to {textBoxPatientNameLF.Text}", 
                "Send Text Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
