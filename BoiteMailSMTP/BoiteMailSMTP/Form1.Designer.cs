namespace BoiteMailSMTP
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.tbxObjet = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSMTP = new System.Windows.Forms.Button();
            this.btnExpediteur = new System.Windows.Forms.Button();
            this.tbxExpediteur = new System.Windows.Forms.TextBox();
            this.tbxNomExpediteur = new System.Windows.Forms.TextBox();
            this.btnDestinataires = new System.Windows.Forms.Button();
            this.btnPieceJointe = new System.Windows.Forms.Button();
            this.btnNomExpediteur = new System.Windows.Forms.Button();
            this.ofdPieceJointe = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbPieceJointe = new System.Windows.Forms.ListBox();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.tbxMotDePasse = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxPort = new System.Windows.Forms.ComboBox();
            this.cbxSMTP = new System.Windows.Forms.ComboBox();
            this.ccbxDestinataireCache = new UtilityLibrary.Combos.CheckCombo();
            this.ccbxDestinataire = new UtilityLibrary.Combos.CheckCombo();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Location = new System.Drawing.Point(532, 402);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(75, 37);
            this.btnEnvoyer.TabIndex = 1;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "SuperSlowMail";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(532, 105);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(319, 288);
            this.tbxMessage.TabIndex = 3;
            // 
            // tbxObjet
            // 
            this.tbxObjet.Location = new System.Drawing.Point(532, 79);
            this.tbxObjet.Name = "tbxObjet";
            this.tbxObjet.Size = new System.Drawing.Size(319, 20);
            this.tbxObjet.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(694, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Reload";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(776, 403);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 36);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(613, 402);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 37);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Serveur SMTP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Expéditeur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nom Expéditeur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Destinataire(s)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Dest. Caché";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(445, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Objet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(445, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Message";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Pièces jointes";
            // 
            // btnSMTP
            // 
            this.btnSMTP.Location = new System.Drawing.Point(666, 37);
            this.btnSMTP.Name = "btnSMTP";
            this.btnSMTP.Size = new System.Drawing.Size(25, 20);
            this.btnSMTP.TabIndex = 26;
            this.btnSMTP.Text = "...";
            this.btnSMTP.UseVisualStyleBackColor = true;
            this.btnSMTP.Click += new System.EventHandler(this.btnSMTP_Click);
            // 
            // btnExpediteur
            // 
            this.btnExpediteur.Location = new System.Drawing.Point(419, 377);
            this.btnExpediteur.Name = "btnExpediteur";
            this.btnExpediteur.Size = new System.Drawing.Size(25, 20);
            this.btnExpediteur.TabIndex = 28;
            this.btnExpediteur.Text = "...";
            this.btnExpediteur.UseVisualStyleBackColor = true;
            this.btnExpediteur.Visible = false;
            // 
            // tbxExpediteur
            // 
            this.tbxExpediteur.Location = new System.Drawing.Point(155, 131);
            this.tbxExpediteur.Name = "tbxExpediteur";
            this.tbxExpediteur.Size = new System.Drawing.Size(214, 20);
            this.tbxExpediteur.TabIndex = 27;
            // 
            // tbxNomExpediteur
            // 
            this.tbxNomExpediteur.Location = new System.Drawing.Point(155, 157);
            this.tbxNomExpediteur.Name = "tbxNomExpediteur";
            this.tbxNomExpediteur.Size = new System.Drawing.Size(214, 20);
            this.tbxNomExpediteur.TabIndex = 29;
            // 
            // btnDestinataires
            // 
            this.btnDestinataires.Location = new System.Drawing.Point(820, 37);
            this.btnDestinataires.Name = "btnDestinataires";
            this.btnDestinataires.Size = new System.Drawing.Size(25, 20);
            this.btnDestinataires.TabIndex = 32;
            this.btnDestinataires.Text = "...";
            this.btnDestinataires.UseVisualStyleBackColor = true;
            this.btnDestinataires.Click += new System.EventHandler(this.btnDestinataires_Click);
            // 
            // btnPieceJointe
            // 
            this.btnPieceJointe.Location = new System.Drawing.Point(374, 265);
            this.btnPieceJointe.Name = "btnPieceJointe";
            this.btnPieceJointe.Size = new System.Drawing.Size(25, 20);
            this.btnPieceJointe.TabIndex = 36;
            this.btnPieceJointe.Text = "...";
            this.btnPieceJointe.UseVisualStyleBackColor = true;
            this.btnPieceJointe.Click += new System.EventHandler(this.btnPieceJointe_Click);
            // 
            // btnNomExpediteur
            // 
            this.btnNomExpediteur.Location = new System.Drawing.Point(419, 402);
            this.btnNomExpediteur.Name = "btnNomExpediteur";
            this.btnNomExpediteur.Size = new System.Drawing.Size(25, 20);
            this.btnNomExpediteur.TabIndex = 30;
            this.btnNomExpediteur.Text = "...";
            this.btnNomExpediteur.UseVisualStyleBackColor = true;
            this.btnNomExpediteur.Visible = false;
            // 
            // ofdPieceJointe
            // 
            this.ofdPieceJointe.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSMTP);
            this.panel1.Controls.Add(this.btnDestinataires);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 70);
            this.panel1.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(733, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Contacts";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(537, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Serveur SMTP";
            // 
            // lbPieceJointe
            // 
            this.lbPieceJointe.FormattingEnabled = true;
            this.lbPieceJointe.Location = new System.Drawing.Point(155, 265);
            this.lbPieceJointe.Name = "lbPieceJointe";
            this.lbPieceJointe.Size = new System.Drawing.Size(214, 43);
            this.lbPieceJointe.TabIndex = 38;
            // 
            // tbxPort
            // 
            this.tbxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPort.Location = new System.Drawing.Point(94, 347);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(214, 20);
            this.tbxPort.TabIndex = 39;
            this.tbxPort.Visible = false;
            // 
            // tbxMotDePasse
            // 
            this.tbxMotDePasse.Location = new System.Drawing.Point(155, 181);
            this.tbxMotDePasse.Name = "tbxMotDePasse";
            this.tbxMotDePasse.Size = new System.Drawing.Size(214, 20);
            this.tbxMotDePasse.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 41;
            this.label11.Text = "Mot de passe";
            // 
            // cbxPort
            // 
            this.cbxPort.FormattingEnabled = true;
            this.cbxPort.Location = new System.Drawing.Point(155, 104);
            this.cbxPort.Name = "cbxPort";
            this.cbxPort.Size = new System.Drawing.Size(214, 21);
            this.cbxPort.TabIndex = 42;
            // 
            // cbxSMTP
            // 
            this.cbxSMTP.FormattingEnabled = true;
            this.cbxSMTP.Location = new System.Drawing.Point(155, 77);
            this.cbxSMTP.Name = "cbxSMTP";
            this.cbxSMTP.Size = new System.Drawing.Size(214, 21);
            this.cbxSMTP.TabIndex = 43;
            this.cbxSMTP.SelectedIndexChanged += new System.EventHandler(this.cbxSMTP_SelectedIndexChanged);
            // 
            // ccbxDestinataireCache
            // 
            this.ccbxDestinataireCache.Location = new System.Drawing.Point(155, 236);
            this.ccbxDestinataireCache.Name = "ccbxDestinataireCache";
            this.ccbxDestinataireCache.Size = new System.Drawing.Size(214, 23);
            this.ccbxDestinataireCache.TabIndex = 44;
            this.ccbxDestinataireCache.TreeImageList = null;
            this.ccbxDestinataireCache.DataFill += new UtilityLibrary.Combos.TreeCombo.FillTreeByDataHandler(this.checkCombo1_DataFill);
            // 
            // ccbxDestinataire
            // 
            this.ccbxDestinataire.Location = new System.Drawing.Point(155, 207);
            this.ccbxDestinataire.Name = "ccbxDestinataire";
            this.ccbxDestinataire.Size = new System.Drawing.Size(214, 23);
            this.ccbxDestinataire.TabIndex = 45;
            this.ccbxDestinataire.TreeImageList = null;
            this.ccbxDestinataire.DataFill += new UtilityLibrary.Combos.TreeCombo.FillTreeByDataHandler(this.checkCombo1_DataFill);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ccbxDestinataireCache);
            this.Controls.Add(this.ccbxDestinataire);
            this.Controls.Add(this.cbxSMTP);
            this.Controls.Add(this.cbxPort);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbxMotDePasse);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.lbPieceJointe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPieceJointe);
            this.Controls.Add(this.btnNomExpediteur);
            this.Controls.Add(this.tbxNomExpediteur);
            this.Controls.Add(this.btnExpediteur);
            this.Controls.Add(this.tbxExpediteur);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbxObjet);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.btnEnvoyer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.TextBox tbxObjet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSMTP;
        private System.Windows.Forms.Button btnExpediteur;
        private System.Windows.Forms.TextBox tbxExpediteur;
        private System.Windows.Forms.TextBox tbxNomExpediteur;
        private System.Windows.Forms.Button btnDestinataires;
        private System.Windows.Forms.Button btnPieceJointe;
        private System.Windows.Forms.Button btnNomExpediteur;
        private System.Windows.Forms.OpenFileDialog ofdPieceJointe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbPieceJointe;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.TextBox tbxMotDePasse;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxPort;
        private System.Windows.Forms.ComboBox cbxSMTP;
        private UtilityLibrary.Combos.CheckCombo ccbxDestinataireCache;
        private UtilityLibrary.Combos.CheckCombo ccbxDestinataire;
        private System.Windows.Forms.Label label10;
    }
}

