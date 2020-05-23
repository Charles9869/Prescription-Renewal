using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prescription_Renewal
{
    public partial class MainForm : Form
    {
        Stores Stores;
        PrescriptionRenewal currentPrescriptionRenewal;
        public MainForm()
        {
            InitializeComponent();
            InitDemoData();
        }
        private void InitDemoData()
        {
            Stores = new Stores(Properties.Resources.Stores);

            //Console.WriteLine(currentPrescriptionRenewal.Client.FirstName);

            //Décommenter cette section pour vos tests
            //currentPrescriptionRenewal = new PrescriptionRenewal();
           

            //currentPrescriptionRenewal.Store = Stores[14];
            //currentPrescriptionRenewal.Client = new Client
            //{
            //    FirstName = "Martin",
            //    LastName = "Tremblant",
            //    Phone = "(555) 836-8632",
            //    PhoneExtension = "342",
            //    EMail = "martin.tremblant@gmail.ca"
            //};
            //currentPrescriptionRenewal.Add_Prescription("Rx 1431432-0089");
            //currentPrescriptionRenewal.Add_Prescription("Rx 1431422-0089");
            //currentPrescriptionRenewal.Add_Prescription("Rx 1671000-0132");
            //currentPrescriptionRenewal.Comment = "Veuillez me préparer svp deux mois de posologie.\nMerci et bonne journée!";


        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Update_UI();
        }


        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            PointF location = new PointF(30, 100);
            if (currentPrescriptionRenewal != null)
                currentPrescriptionRenewal.Draw(e.Graphics, ref location);
        }

        private void Update_UI()
        {
            BTN_Edit.Enabled = currentPrescriptionRenewal != null;
            BTN_Delete.Enabled = currentPrescriptionRenewal != null;
        }

        private void BTN_New_Click(object sender, EventArgs e)
        {
            
           DLG_PrescriptionRenewal dlg = new DLG_PrescriptionRenewal();
            dlg.Stores = Stores;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                currentPrescriptionRenewal = dlg.PrescriptionRenewal;
                this.Refresh();
                Update_UI();
            }

        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            
           DLG_PrescriptionRenewal dlg = new DLG_PrescriptionRenewal();
            dlg.Stores = Stores;
            dlg.PrescriptionRenewal = currentPrescriptionRenewal;
            dlg.Text = "Modification de renouvellement d'ordonnance";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.Refresh();
                Update_UI();
            }

        }
        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Effacer le renouvellement d'ordonnance courant?", "Attention", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                currentPrescriptionRenewal = null;
                this.Refresh();
                Update_UI();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
