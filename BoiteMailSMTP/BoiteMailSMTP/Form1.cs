using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BoiteMailSMTP
{
    public partial class Form1 : Form
    {
        public string serveur;
        public string port;


        List<Attachment> pieceJointe;
        public Form1()
        {
            InitializeComponent();
            pieceJointe = new List<Attachment>();
        }

        private void btnPieceJointe_Click(object sender, EventArgs e)
        {
            //ouvre l openfile dialog pour sélectionner une pièce jointe
            DialogResult dr = ofdPieceJointe.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //ajoute une pièce jointe a la listbox
                pieceJointe.Add(new Attachment(ofdPieceJointe.FileName, MediaTypeNames.Application.Octet));
                lbPieceJointe.Items.Add(ofdPieceJointe.SafeFileName);
            }


        }

        private void btnEnvoyer_Click_1(object sender, EventArgs e)
        {
            string file = ofdPieceJointe.FileName;
            //Créé une classe mail avec pour destinaire les destinataires normaux
            MessageBox.Show(ccbxDestinataire.Text);
            if (ccbxDestinataire.Value != "")
            {
                MailMessage mail = new MailMessage(tbxExpediteur.Text, ccbxDestinataire.Value, tbxObjet.Text, tbxMessage.Text);
            }
            //créé une classe mail avec pour destinataire les destinatiares cachés
            if (ccbxDestinataireCache.Value != "")
            {
                MailMessage mail = new MailMessage(tbxExpediteur.Text, ccbxDestinataireCache.Value, tbxObjet.Text, tbxMessage.Text);
            }

            //création da la classe client SMTP
            SmtpClient clientSmtp = new SmtpClient(cbxSMTP.Text);
            MailMessage monMessage = new MailMessage();
            try
            {
                clientSmtp.Port = int.Parse(cbxPort.Text); // on regarde si le port est valide
            }
            catch
            {
                MessageBox.Show("Veuillez sélectionner un port valide.");
            }

            try
            {
                clientSmtp.Host = cbxSMTP.Text; //On regarde si le serveur SMTP est valide
            }
            catch
            {
                MessageBox.Show("Veuillez sélectionner un serveur valide.");
            }
            //Settings du serveur SMTP (possible évolution voir travail Valentin partie paramètres)
            clientSmtp.EnableSsl = true;
            clientSmtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            clientSmtp.UseDefaultCredentials = true;
            //Identifaints du serveur SMTP si je veux m en servir a la maison
            clientSmtp.Credentials = new NetworkCredential(tbxExpediteur.Text, tbxMotDePasse.Text);
            //Création du contenu du mail ( en dehors des pièces jointes)
            monMessage.Body = Convert.ToString(tbxMessage.Text);
            monMessage.Subject = Convert.ToString(tbxObjet.Text);

            //On vérifie qu'un destinataire est selectionné
            if (ccbxDestinataire.Value == "" && ccbxDestinataireCache.Value == "")
            {
                MessageBox.Show("Veuillez sélectionner un destinataire (caché ou non) valide.");
            }
            //création de l'expediteur (@ mail + nom)
            try
            {
                MailAddress expediteur = new MailAddress(Convert.ToString(tbxExpediteur.Text), Convert.ToString(tbxNomExpediteur.Text));
                monMessage.From = expediteur;
                //Pour destinataire normal
                if (ccbxDestinataire.Value != "")
                {
                    monMessage = new MailMessage(tbxExpediteur.Text, ccbxDestinataire.Value, tbxObjet.Text, tbxMessage.Text);
                    monMessage.IsBodyHtml = false;
                }
                //Pour Destinataire caché
                else
                {
                    monMessage = new MailMessage(tbxExpediteur.Text, ccbxDestinataireCache.Value, tbxObjet.Text, tbxMessage.Text);
                    monMessage.IsBodyHtml = false;
                }
            }
            catch
            {
                //MessageBox.Show("Veuillez vérifier que toutes ces informations soient valides :" +
                //    " \n-Expéditeur " +
                //    " \n-Destinataire (caché) " +
                //    " \n-l'Objet.");
            }
            //vérifie la validitée des pièces jointes
            try
            {
                foreach (Attachment attach in pieceJointe)
                {
                    monMessage.Attachments.Add(attach);
                }
            }
            catch
            {
                MessageBox.Show("Veuillez sélectionner une pièce jointe valide.");
            }
            //Sépare les adresses mail du tbx nom destinataire si plusierus adresses sont entrées.
            if (ccbxDestinataire.Value != "")
            {
                foreach (var address in ccbxDestinataire.Value.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                {
                    monMessage.To.Add(address);
                }
            }
            //Même chose pour les destinataires cachés
            if (ccbxDestinataireCache.Value != "")
            {
                foreach (var address in ccbxDestinataireCache.Value.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                {
                    monMessage.Bcc.Add(address);
                }
            }
            //self-explinatory
            try
            {
                clientSmtp.Send(monMessage);
                MessageBox.Show("Le message a été envoyé");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Paint += DrawBorder;

            string[] ligne = File.ReadAllLines(@"serveur.txt");
            foreach (string value in ligne)
            {
                string[] tabServeur = value.Split(';');
                if (value != "")
                {

                    cbxSMTP.Items.Add(tabServeur[2]);
                    cbxPort.Items.Add(tabServeur[3]);
                }
            }

        }

        private void DrawBorder(object sender, PaintEventArgs e)
        {

            //ccbxDestinataireCache
            Rectangle rect1 = new Rectangle(this.ccbxDestinataireCache.Location.X - 1, this.ccbxDestinataireCache.Location.Y - 1, this.ccbxDestinataireCache.Width + 1, this.ccbxDestinataireCache.Height + 1);

            Pen pen1 = new Pen(Color.Black, 1);
            Graphics g1 = e.Graphics;
            g1.DrawRectangle(pen1, rect1);

            Rectangle rect = new Rectangle(this.ccbxDestinataire.Location.X - 1, this.ccbxDestinataire.Location.Y - 1, this.ccbxDestinataire.Width + 1, this.ccbxDestinataire.Height + 1);

            Pen pen = new Pen(Color.Black, 1);
            Graphics g = e.Graphics;
            g.DrawRectangle(pen, rect);
        }
        private void checkCombo1_DataFill(object sender, UtilityLibrary.Combos.TreeCombo.EventArgsTreeDataFill e)
        {
            string[] ligne1 = File.ReadAllLines(@"contact.txt");
            foreach (string value in ligne1)
            {
                string[] tabContact = value.Split(';');
                if (value != "")
                {
                    e.BindedControl.Nodes.Add(tabContact[4]);

                }
            }


        }

        private void btnSMTP_Click(object sender, EventArgs e)
        {
            serveurs dlg = new serveurs();
            dlg.Show();
        }

        private void btnDestinataires_Click(object sender, EventArgs e)
        {
            Contact dlg = new Contact();
            dlg.Show();
        }
        public static string RemoveEmptyLines(string lines)
        {
            return Regex.Replace(lines, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).TrimEnd();
        }

        private void cbxSMTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("" + cbxSMTP.SelectedItem);
            string[] ligne = File.ReadAllLines(@"serveur.txt");
            foreach (string value in ligne)
            {
                string[] tabServeur = value.Split(';');
                //  MessageBox.Show("" + tabServeur[2]);
                if (tabServeur[2] == cbxSMTP.SelectedText)
                {
                    cbxPort.Text = tabServeur[3];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Paint += DrawBorder;

            string[] ligne = File.ReadAllLines(@"serveur.txt");
            foreach (string value in ligne)
            {
                string[] tabServeur = value.Split(';');
                if (value != "")
                {

                    cbxSMTP.Items.Add(tabServeur[2]);
                    cbxPort.Items.Add(tabServeur[3]);
                }
            }

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            cbxSMTP.Text = "";
            tbxExpediteur.Text = "";
            ccbxDestinataire.Value = "";
            ccbxDestinataireCache.Value = "";
            tbxObjet.Text = "";
            tbxMotDePasse.Text = "";
            cbxPort.Text = "";
            tbxNomExpediteur.Text = "";
            tbxMessage.Text = "";
            lbPieceJointe.Items.Clear();
        }
    }
}
