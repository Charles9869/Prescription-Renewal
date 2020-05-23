namespace Prescription_Renewal
{
    partial class DLG_PrescriptionRenewal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MTBX_ZipCode = new System.Windows.Forms.MaskedTextBox();
            this.CBB_StoreSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MTBX_Phone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBX_EMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBX_PhoneExtension = new System.Windows.Forms.TextBox();
            this.TBX_LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBX_FirstName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FBTN_Edit = new FlashButton.FlashButton();
            this.FBTN_Delete = new FlashButton.FlashButton();
            this.FBTN_Abort = new FlashButton.FlashButton();
            this.FBTN_Add = new FlashButton.FlashButton();
            this.label7 = new System.Windows.Forms.Label();
            this.LBX_PrescriptionNumber = new System.Windows.Forms.ListBox();
            this.RTBX_Comment = new System.Windows.Forms.RichTextBox();
            this.MTBX_PrescriptionNumber = new System.Windows.Forms.MaskedTextBox();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MTBX_ZipCode);
            this.groupBox1.Controls.Add(this.CBB_StoreSelector);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(582, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix de succursale";
            // 
            // MTBX_ZipCode
            // 
            this.MTBX_ZipCode.Location = new System.Drawing.Point(493, 24);
            this.MTBX_ZipCode.Margin = new System.Windows.Forms.Padding(2);
            this.MTBX_ZipCode.Name = "MTBX_ZipCode";
            this.MTBX_ZipCode.Size = new System.Drawing.Size(61, 24);
            this.MTBX_ZipCode.TabIndex = 0;
            this.MTBX_ZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MTBX_ZipCode.TextChanged += new System.EventHandler(this.MTBX_ZipCode_TextChanged);
            // 
            // CBB_StoreSelector
            // 
            this.CBB_StoreSelector.FormattingEnabled = true;
            this.CBB_StoreSelector.Location = new System.Drawing.Point(4, 58);
            this.CBB_StoreSelector.Margin = new System.Windows.Forms.Padding(2);
            this.CBB_StoreSelector.Name = "CBB_StoreSelector";
            this.CBB_StoreSelector.Size = new System.Drawing.Size(549, 25);
            this.CBB_StoreSelector.TabIndex = 2;
            this.CBB_StoreSelector.TextChanged += new System.EventHandler(this.CBB_StoreSelector_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recherche par code postal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MTBX_Phone);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TBX_EMail);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TBX_PhoneExtension);
            this.groupBox2.Controls.Add(this.TBX_LastName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TBX_FirstName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 117);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(582, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information sur le client";
            // 
            // MTBX_Phone
            // 
            this.MTBX_Phone.Location = new System.Drawing.Point(87, 111);
            this.MTBX_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.MTBX_Phone.Mask = "(000)-000-0000";
            this.MTBX_Phone.Name = "MTBX_Phone";
            this.MTBX_Phone.Size = new System.Drawing.Size(126, 24);
            this.MTBX_Phone.TabIndex = 3;
            this.MTBX_Phone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Courriel";
            // 
            // TBX_EMail
            // 
            this.TBX_EMail.Location = new System.Drawing.Point(87, 145);
            this.TBX_EMail.Margin = new System.Windows.Forms.Padding(2);
            this.TBX_EMail.Name = "TBX_EMail";
            this.TBX_EMail.Size = new System.Drawing.Size(467, 24);
            this.TBX_EMail.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Poste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Téléphone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nom";
            // 
            // TBX_PhoneExtension
            // 
            this.TBX_PhoneExtension.Location = new System.Drawing.Point(295, 109);
            this.TBX_PhoneExtension.Margin = new System.Windows.Forms.Padding(2);
            this.TBX_PhoneExtension.Name = "TBX_PhoneExtension";
            this.TBX_PhoneExtension.Size = new System.Drawing.Size(54, 24);
            this.TBX_PhoneExtension.TabIndex = 4;
            this.TBX_PhoneExtension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBX_PhoneExtension_KeyPress);
            // 
            // TBX_LastName
            // 
            this.TBX_LastName.Location = new System.Drawing.Point(87, 70);
            this.TBX_LastName.Margin = new System.Windows.Forms.Padding(2);
            this.TBX_LastName.Name = "TBX_LastName";
            this.TBX_LastName.Size = new System.Drawing.Size(467, 24);
            this.TBX_LastName.TabIndex = 2;
            this.TBX_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBX_LastName_KeyPress);
            this.TBX_LastName.Leave += new System.EventHandler(this.TBX_LastName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // TBX_FirstName
            // 
            this.TBX_FirstName.Location = new System.Drawing.Point(87, 32);
            this.TBX_FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.TBX_FirstName.Name = "TBX_FirstName";
            this.TBX_FirstName.Size = new System.Drawing.Size(467, 24);
            this.TBX_FirstName.TabIndex = 1;
            this.TBX_FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBX_FirstName_KeyPress);
            this.TBX_FirstName.Leave += new System.EventHandler(this.TBX_FirstName_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FBTN_Edit);
            this.groupBox3.Controls.Add(this.FBTN_Delete);
            this.groupBox3.Controls.Add(this.FBTN_Abort);
            this.groupBox3.Controls.Add(this.FBTN_Add);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.LBX_PrescriptionNumber);
            this.groupBox3.Controls.Add(this.RTBX_Comment);
            this.groupBox3.Controls.Add(this.MTBX_PrescriptionNumber);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 304);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(582, 207);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste des numéros d\'ordonnance";
            // 
            // FBTN_Edit
            // 
            this.FBTN_Edit.BackgroundImage = global::Prescription_Renewal.Properties.Resources.ICON_Editer_Neutre;
            this.FBTN_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_Edit.ImageClick = global::Prescription_Renewal.Properties.Resources.ICON_Editer_Click;
            this.FBTN_Edit.ImageDisable = global::Prescription_Renewal.Properties.Resources.ICON_Editer_Disable;
            this.FBTN_Edit.ImageNeutral = global::Prescription_Renewal.Properties.Resources.ICON_Editer_Neutre;
            this.FBTN_Edit.ImageOver = global::Prescription_Renewal.Properties.Resources.ICON_Editer_Survol;
            this.FBTN_Edit.Location = new System.Drawing.Point(140, 34);
            this.FBTN_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.FBTN_Edit.Name = "FBTN_Edit";
            this.FBTN_Edit.Size = new System.Drawing.Size(22, 22);
            this.FBTN_Edit.TabIndex = 17;
            this.FBTN_Edit.Visible = false;
            this.FBTN_Edit.Click += new System.EventHandler(this.FBTN_Edit_Click);
            // 
            // FBTN_Delete
            // 
            this.FBTN_Delete.BackgroundImage = global::Prescription_Renewal.Properties.Resources.ICON_Delete_Neutral;
            this.FBTN_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_Delete.ImageClick = global::Prescription_Renewal.Properties.Resources.ICON_Delete_Click;
            this.FBTN_Delete.ImageDisable = global::Prescription_Renewal.Properties.Resources.ICON_Delete_Disable;
            this.FBTN_Delete.ImageNeutral = global::Prescription_Renewal.Properties.Resources.ICON_Delete_Neutral;
            this.FBTN_Delete.ImageOver = global::Prescription_Renewal.Properties.Resources.ICON_Delete_Over;
            this.FBTN_Delete.Location = new System.Drawing.Point(140, 33);
            this.FBTN_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.FBTN_Delete.Name = "FBTN_Delete";
            this.FBTN_Delete.Size = new System.Drawing.Size(22, 22);
            this.FBTN_Delete.TabIndex = 16;
            this.FBTN_Delete.Visible = false;
            this.FBTN_Delete.Click += new System.EventHandler(this.FBTN_Delete_Click);
            // 
            // FBTN_Abort
            // 
            this.FBTN_Abort.BackgroundImage = global::Prescription_Renewal.Properties.Resources.ICON_Annuler_Neutral;
            this.FBTN_Abort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_Abort.ImageClick = global::Prescription_Renewal.Properties.Resources.ICON_Annuler_Click;
            this.FBTN_Abort.ImageDisable = global::Prescription_Renewal.Properties.Resources.ICON_Annuler_Disable;
            this.FBTN_Abort.ImageNeutral = global::Prescription_Renewal.Properties.Resources.ICON_Annuler_Neutral;
            this.FBTN_Abort.ImageOver = global::Prescription_Renewal.Properties.Resources.ICON_Annuler_Over;
            this.FBTN_Abort.Location = new System.Drawing.Point(164, 33);
            this.FBTN_Abort.Margin = new System.Windows.Forms.Padding(4);
            this.FBTN_Abort.Name = "FBTN_Abort";
            this.FBTN_Abort.Size = new System.Drawing.Size(22, 22);
            this.FBTN_Abort.TabIndex = 15;
            this.FBTN_Abort.Visible = false;
            this.FBTN_Abort.Click += new System.EventHandler(this.FBTN_Abort_Click);
            // 
            // FBTN_Add
            // 
            this.FBTN_Add.BackgroundImage = global::Prescription_Renewal.Properties.Resources.ICON_Add_Neutral;
            this.FBTN_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_Add.ImageClick = global::Prescription_Renewal.Properties.Resources.ICON_Add_Click;
            this.FBTN_Add.ImageDisable = global::Prescription_Renewal.Properties.Resources.ICON_ADD_Disable;
            this.FBTN_Add.ImageNeutral = global::Prescription_Renewal.Properties.Resources.ICON_Add_Neutral;
            this.FBTN_Add.ImageOver = global::Prescription_Renewal.Properties.Resources.ICON_Add_Over;
            this.FBTN_Add.Location = new System.Drawing.Point(139, 33);
            this.FBTN_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FBTN_Add.Name = "FBTN_Add";
            this.FBTN_Add.Size = new System.Drawing.Size(22, 22);
            this.FBTN_Add.TabIndex = 14;
            this.FBTN_Add.Visible = false;
            this.FBTN_Add.Click += new System.EventHandler(this.FBTN_Add_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Commentaire au pharmacien";
            // 
            // LBX_PrescriptionNumber
            // 
            this.LBX_PrescriptionNumber.FormattingEnabled = true;
            this.LBX_PrescriptionNumber.ItemHeight = 17;
            this.LBX_PrescriptionNumber.Location = new System.Drawing.Point(8, 61);
            this.LBX_PrescriptionNumber.Margin = new System.Windows.Forms.Padding(2);
            this.LBX_PrescriptionNumber.Name = "LBX_PrescriptionNumber";
            this.LBX_PrescriptionNumber.Size = new System.Drawing.Size(126, 123);
            this.LBX_PrescriptionNumber.TabIndex = 12;
            this.LBX_PrescriptionNumber.Click += new System.EventHandler(this.LBX_PrescriptionNumber_Click);
            this.LBX_PrescriptionNumber.SelectedIndexChanged += new System.EventHandler(this.LBX_PrescriptionNumber_SelectedIndexChanged);
            this.LBX_PrescriptionNumber.Leave += new System.EventHandler(this.LBX_PrescriptionNumber_Leave);
            // 
            // RTBX_Comment
            // 
            this.RTBX_Comment.AcceptsTab = true;
            this.RTBX_Comment.Location = new System.Drawing.Point(194, 61);
            this.RTBX_Comment.Margin = new System.Windows.Forms.Padding(2);
            this.RTBX_Comment.Name = "RTBX_Comment";
            this.RTBX_Comment.Size = new System.Drawing.Size(360, 123);
            this.RTBX_Comment.TabIndex = 11;
            this.RTBX_Comment.Text = "";
            // 
            // MTBX_PrescriptionNumber
            // 
            this.MTBX_PrescriptionNumber.Location = new System.Drawing.Point(8, 32);
            this.MTBX_PrescriptionNumber.Margin = new System.Windows.Forms.Padding(2);
            this.MTBX_PrescriptionNumber.Mask = "Rx 0000000-0000";
            this.MTBX_PrescriptionNumber.Name = "MTBX_PrescriptionNumber";
            this.MTBX_PrescriptionNumber.Size = new System.Drawing.Size(126, 24);
            this.MTBX_PrescriptionNumber.TabIndex = 0;
            this.MTBX_PrescriptionNumber.Click += new System.EventHandler(this.MTBX_PrescriptionNumber_Click);
            this.MTBX_PrescriptionNumber.TextChanged += new System.EventHandler(this.MTBX_PrescriptionNumber_TextChanged);
            this.MTBX_PrescriptionNumber.Enter += new System.EventHandler(this.MTBX_PrescriptionNumber_Enter);
            this.MTBX_PrescriptionNumber.Leave += new System.EventHandler(this.MTBX_PrescriptionNumber_Leave);
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ok.Location = new System.Drawing.Point(322, 530);
            this.BTN_Ok.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(129, 33);
            this.BTN_Ok.TabIndex = 3;
            this.BTN_Ok.Text = "Renouveler";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cancel.Location = new System.Drawing.Point(462, 530);
            this.BTN_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(129, 33);
            this.BTN_Cancel.TabIndex = 4;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // DLG_PrescriptionRenewal
            // 
            this.AcceptButton = this.BTN_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 573);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DLG_PrescriptionRenewal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renouvellement d\'ordonnance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DLG_PrescriptionRenewal_FormClosing);
            this.Load += new System.EventHandler(this.DLG_PrescriptionRenewal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBB_StoreSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TBX_LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBX_FirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBX_PhoneExtension;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBX_EMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox MTBX_Phone;
        private System.Windows.Forms.MaskedTextBox MTBX_ZipCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox LBX_PrescriptionNumber;
        private System.Windows.Forms.RichTextBox RTBX_Comment;
        private System.Windows.Forms.MaskedTextBox MTBX_PrescriptionNumber;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_Cancel;
        private FlashButton.FlashButton FBTN_Add;
        private FlashButton.FlashButton FBTN_Abort;
        private FlashButton.FlashButton FBTN_Delete;
        private FlashButton.FlashButton FBTN_Edit;
    }
}