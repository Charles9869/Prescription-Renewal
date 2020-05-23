using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validation;
using System.Text.RegularExpressions;
namespace Prescription_Renewal
{
    public partial class DLG_PrescriptionRenewal : Form
    {
        private ValidationProvider mValidationProvider;
        public Stores Stores;
        public string Nom { get; set; }
        public Store mStore;
        public PrescriptionRenewal PrescriptionRenewal;

        private const string mRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

        public DLG_PrescriptionRenewal()
        {
            InitializeComponent();
        }

        private void Init_UI()
        {
            TBX_FirstName.MaxLength = 32;

            TBX_LastName.MaxLength = 32;

            MTBX_ZipCode.Mask = "L0L";
            MTBX_ZipCode.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;

            MTBX_Phone.Mask = "(000) 000-0000";
            MTBX_Phone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            MTBX_PrescriptionNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;

            if (PrescriptionRenewal == null)
            {
                PrescriptionRenewal = new PrescriptionRenewal();
            }
            else
            {
                BTN_Ok.Text = "Modifier";
                Contact_To_Dlg();
            }
        }

        private void DLG_PrescriptionRenewal_Load(object sender, EventArgs e)
        {
            InitialiserValidationProvider();
            GenererStore();
            Init_UI();
        }

        private void Dlg_To_Contact()
        {
            PrescriptionRenewal.Store = CBB_StoreSelector.SelectedItem as Store;
            PrescriptionRenewal.Client.EMail = TBX_EMail.Text;
            PrescriptionRenewal.Client.FirstName = TBX_FirstName.Text;
            PrescriptionRenewal.Client.LastName = TBX_LastName.Text;
            PrescriptionRenewal.Client.Phone = MTBX_Phone.Text;
            PrescriptionRenewal.Comment = RTBX_Comment.Text;
            PrescriptionRenewal.Client.PhoneExtension = TBX_PhoneExtension.Text;
        }

        private void Contact_To_Dlg()
        {
            if (PrescriptionRenewal != null)
            {
                RTBX_Comment.Text = PrescriptionRenewal.Comment;
                MTBX_Phone.Text = PrescriptionRenewal.Client.Phone;
                CBB_StoreSelector.SelectedItem = PrescriptionRenewal.Store;
                TBX_EMail.Text = PrescriptionRenewal.Client.EMail;
                TBX_FirstName.Text = PrescriptionRenewal.Client.FirstName;
                TBX_LastName.Text = PrescriptionRenewal.Client.LastName;
                TBX_PhoneExtension.Text = PrescriptionRenewal.Client.PhoneExtension;

                foreach (var item in PrescriptionRenewal.PrescriptionNumbers)
                {
                    LBX_PrescriptionNumber.Items.Add(item);
                }
            }
        }

        private void MTBX_ZipCode_TextChanged(object sender, EventArgs e)
        {
            if (MTBX_ZipCode.MaskCompleted)
            {
                CBB_StoreSelector.SelectedItem = Stores.FindByZipCode(MTBX_ZipCode.Text);
            }
        }

        private void GenererStore()
        {
            for (int i = 0; i < Stores.Count; ++i)
            {
                CBB_StoreSelector.Items.Add(Stores[i]);
            }
        }

        // Responsable des ValidationProvider //
        private void InitialiserValidationProvider()
        {
            mValidationProvider = new ValidationProvider(this);
            mValidationProvider.AddControlToValidate(TBX_FirstName, Validate_TBX_FirstName);
            mValidationProvider.AddControlToValidate(MTBX_ZipCode, Validate_MTBX_ZipCode);
            mValidationProvider.AddControlToValidate(TBX_LastName, Validate_TBX_LastName);
            mValidationProvider.AddControlToValidate(MTBX_Phone, Validate_MTBX_Phone);
            mValidationProvider.AddControlToValidate(TBX_EMail, Validate_TBX_EMail);
            mValidationProvider.AddControlToValidate(LBX_PrescriptionNumber, Validate_LBX_PrescriptionNumber);
            mValidationProvider.AddControlToValidate(CBB_StoreSelector, Validate_CBB_StoreSelector);
            mValidationProvider.AddControlToValidate(MTBX_PrescriptionNumber, Validate_MTBX_PrescriptionNumber);
        }

        private bool Validate_TBX_LastName(ref string Error)
        {
            Error = "Nom absent";
            return TBX_LastName.Text != "";
        }

        private bool Validate_TBX_FirstName(ref string Error)
        {
            Error = "Prénom absent";
            return TBX_FirstName.Text != "";
        }

        private bool Validate_MTBX_ZipCode(ref string Error)
        {
            bool EstValide = true;
            if (!MTBX_ZipCode.MaskCompleted)
            {
                Error = "Code Postal incomplet";
                EstValide = false;
            }

            if (CBB_StoreSelector.Text == "" && MTBX_ZipCode.MaskCompleted)
            {
                Error = "Succursale non trouvée";
                EstValide = false;
            }
            return EstValide;
        }

        private bool Validate_CBB_StoreSelector(ref string Error)
        {
            bool EstValide = true;
            if (string.IsNullOrEmpty(CBB_StoreSelector.Text))
            {
                Error = "Aucune succursale sélectionnée";
                EstValide = false;
            }
            return EstValide;
        }

        private bool Validate_MTBX_Phone(ref string Error)
        {
            bool EstValide = true;
            if (string.IsNullOrEmpty(MTBX_Phone.Text))
            {
                Error = "Téléphone absent";
                EstValide = false;
            }
            else if (!MTBX_Phone.MaskCompleted)
            {
                Error = "Téléphone incorrecte";
                EstValide = false;
            }
            return EstValide;
        }

        private bool Validate_TBX_EMail(ref string Error)
        {
            Regex mRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            bool EstValide = mRegex.Match(TBX_EMail.Text).Success;

            if (TBX_EMail.Text == "")
            {
                Error = "Adresse courriel absente";
                EstValide = false;
            }
            else if (!mRegex.Match(TBX_EMail.Text).Success)
            {
                Error = "incomplet";
                EstValide = false;
            }
            return EstValide;
        }

        private bool Validate_MTBX_PrescriptionNumber(ref string Error)
        {
            bool Existe = true;
            if (LBX_PrescriptionNumber.Items.Contains(MTBX_PrescriptionNumber.Text) && LBX_PrescriptionNumber.SelectedItem == null)
            {
                Error = "Ce numéro d’ordonnance figure déjà dans la liste";
                Existe = false;
            }
            return Existe;
        }

        private bool Validate_LBX_PrescriptionNumber(ref string Message)
        {
            Message = "Aucun numéro d'ordonnance";
            return LBX_PrescriptionNumber.Items.Count > 0;
        }

        private void CBB_StoreSelector_TextChanged(object sender, EventArgs e)
        {
            Store s = (Store)CBB_StoreSelector.SelectedItem;

            if (s != null)
            {
                MTBX_ZipCode.Text = s.ZipCode;
            }
        }

        private void TBX_FirstName_Leave(object sender, EventArgs e)
        {
            var t = sender as TextBox;
            t.Text = ReformatName(t.Text);
        }

        private string ReformatName(string name)
        {
            // exemple: jean-françois devient Jean-François
            string reformattedName = "";
            for (int i = 0; i < name.Length; i++)
            {
                if ((i == 0) || ((i > 0) && (name[i - 1] == '\'' || name[i - 1] == '-')))
                    reformattedName += char.ToUpper(name[i]);
                else
                    reformattedName += name[i];
            }
            return reformattedName;
        }

        private void TBX_LastName_Leave(object sender, EventArgs e)
        {
            var Nom = sender as TextBox;
            Nom.Text = ReformatName(Nom.Text);

        }

        private void TBX_PhoneExtension_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DLG_PrescriptionRenewal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                Dlg_To_Contact();
            }
        }

        private bool VerifierSiPrescriptionExiste()
        {
            return LBX_PrescriptionNumber.Items.Contains(MTBX_PrescriptionNumber.Text);
        }

        private void Add()
        {
            LBX_PrescriptionNumber.Items.Add(MTBX_PrescriptionNumber.Text);
            PrescriptionRenewal.Add_Prescription(MTBX_PrescriptionNumber.Text);
            MTBX_PrescriptionNumber.Text = "";
            FBTN_Add.Visible = false;
            FBTN_Abort.Visible = false;
        }

        private void Retablir()
        {
            MTBX_PrescriptionNumber.Text = "";
            FBTN_Abort.Visible = false;
            FBTN_Delete.Visible = false;
            FBTN_Edit.Visible = false;
            FBTN_Add.Visible = false;
            BTN_Ok.Enabled = true;
            BTN_Cancel.Enabled = true;
            LBX_PrescriptionNumber.ClearSelected();
        }

        private void Delete()
        {
            LBX_PrescriptionNumber.Items.Remove(MTBX_PrescriptionNumber.Text);
            PrescriptionRenewal.Remove_Prescription(MTBX_PrescriptionNumber.Text);
            Retablir();
        }

        private void MTBX_PrescriptionNumber_Leave(object sender, EventArgs e)
        {
            LBX_PrescriptionNumber.Enabled = true;
            BTN_Ok.Enabled = true;
            BTN_Cancel.Enabled = true;
        }

        private void FBTN_Add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void LBX_PrescriptionNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            BTN_Ok.Enabled = false;
            BTN_Cancel.Enabled = false;
            if (LBX_PrescriptionNumber.SelectedItem != null)
                MTBX_PrescriptionNumber.Text = LBX_PrescriptionNumber.SelectedItem.ToString();

            FBTN_Abort.Visible = true;
            FBTN_Delete.Visible = true;
        }

        private void FBTN_Abort_Click(object sender, EventArgs e)
        {
            Retablir();
        }

        private void FBTN_Delete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void FBTN_Edit_Click(object sender, EventArgs e)
        {
            PrescriptionRenewal.PrescriptionNumbers[LBX_PrescriptionNumber.SelectedIndex] = MTBX_PrescriptionNumber.Text.ToString();
            LBX_PrescriptionNumber.Items.Insert(LBX_PrescriptionNumber.SelectedIndex, MTBX_PrescriptionNumber.Text.ToString());
            LBX_PrescriptionNumber.Items.Remove(LBX_PrescriptionNumber.SelectedItem);
            Retablir();
        }

        private void LBX_PrescriptionNumber_Leave(object sender, EventArgs e)
        {
            BTN_Ok.Enabled = true;
            BTN_Cancel.Enabled = true;
        }

        private void LBX_PrescriptionNumber_Click(object sender, EventArgs e)
        {
            MTBX_PrescriptionNumber.Select();
        }

        private void MTBX_PrescriptionNumber_Click(object sender, EventArgs e)
        {
            LBX_PrescriptionNumber.Enabled = false;
            FBTN_Abort.Visible = true;
        }

        private void MTBX_PrescriptionNumber_TextChanged(object sender, EventArgs e)
        {
            if (MTBX_PrescriptionNumber.MaskCompleted && LBX_PrescriptionNumber.SelectedItem == null && !VerifierSiPrescriptionExiste())
                FBTN_Add.Visible = true;
            else
                FBTN_Add.Visible = false;

            if (LBX_PrescriptionNumber.SelectedItem != null && PrescriptionRenewal != null)
            {
                if (MTBX_PrescriptionNumber.Text != LBX_PrescriptionNumber.SelectedItem.ToString() && MTBX_PrescriptionNumber.MaskCompleted)
                {
                    FBTN_Delete.Visible = false;
                    FBTN_Edit.Visible = true;
                }
                else
                {
                    FBTN_Edit.Visible = false;
                }

                if (MTBX_PrescriptionNumber.Text == LBX_PrescriptionNumber.SelectedItem.ToString() && MTBX_PrescriptionNumber.MaskCompleted)
                    FBTN_Delete.Visible = true;
                else
                    FBTN_Delete.Visible = false;
            }
        }

        private void TBX_FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                    && !char.IsLetter(e.KeyChar)
                    && e.KeyChar != '-' && e.KeyChar != '\'')
            {
                e.Handled = true;
            }
        }

        private void TBX_LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                    && !char.IsLetter(e.KeyChar)
                    && e.KeyChar != '-' && e.KeyChar != '\'')
            {
                e.Handled = true;
            }
        }

        private void MTBX_PrescriptionNumber_Enter(object sender, EventArgs e)
        {
            FBTN_Abort.Visible = true;
        }
    }
}
