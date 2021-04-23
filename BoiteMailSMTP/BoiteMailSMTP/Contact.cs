using System;
using System.IO;
using System.Windows.Forms;

namespace BoiteMailSMTP
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void Contact_Load(object sender, EventArgs e)
        {
            //voir commentaires de serveur ce sont les meme programmes aux variables près
            lvContacts.Sorting = SortOrder.Ascending;

            lvContacts.FullRowSelect = true;
            lvContacts.GridLines = true;
            lvContacts.Sorting = SortOrder.Ascending;
            lvContacts.View = View.Details;

            lvContacts.Columns.Add("Nom Prenom", 200, HorizontalAlignment.Left);
            lvContacts.Columns.Add("Host", 200, HorizontalAlignment.Left);
            lvContacts.Columns.Add("Id", 50, HorizontalAlignment.Left);


            init();
        }

        private void init()
        {
            {
                lvContacts.Items.Clear();
                string[] ligne = File.ReadAllLines(@"contact.txt");
                foreach (string value in ligne)
                {
                    if (value != "")
                    {
                        string[] tabContact = value.Split(';');

                        ListViewItem lst = new ListViewItem();
                        lst.Text = (tabContact[0]);
                        lst.SubItems.Add(tabContact[1]);
                        lst.SubItems.Add(tabContact[2]);
                        lst.SubItems.Add(tabContact[3]);

                        lst.ImageIndex = 0;
                        lvContacts.Items.Add(lst);
                    }
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //lire le fichier
            System.IO.StreamReader sr = new System.IO.StreamReader(@"contact.txt");
            string fileContact = sr.ReadToEnd();
            sr.Close();

            string str1 = tbxNom.Text + ";" + tbxPrenom.Text + ";" + tbxClasse.Text +";"+ tbxBAC + ";" + tbxMail.Text +";" + tbxId.Text;


            if (!fileContact.Contains(str1))
            {
                string strRes = fileContact.Insert(fileContact.Length, "\n" + str1);

                string str2 = Form1.RemoveEmptyLines(strRes);
               

                File.WriteAllText(@"contact.txt", str2);
                init();

                tbxId.Text = "";
                tbxPrenom.Text = "";
                tbxBAC.Text = "";
                tbxNom.Text = "";
                tbxClasse.Text = "";
                tbxMail.Text = "";

                lvContacts.Enabled = true;
               

            }
            else
            {
                MessageBox.Show("Ce serveur existe déjà !");
            }
        }

        

        private void btnSupprimer1_Click_1(object sender, EventArgs e)
        {
            if (lvContacts.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Êtes vous sûres de vouloir supprimer ce contact ?", "Suppression d'un contact", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {   //supprime (si on a validé précédement) l'élement selectionné
                    ListViewItem item = lvContacts.SelectedItems[lvContacts.SelectedItems.Count - 1];
                    if (item != null)
                        foreach (ListViewItem lv in lvContacts.SelectedItems)
                        {

                            string fileContact = "";
                            string firstRamplace = "";

                            System.IO.StreamReader sr1 = new System.IO.StreamReader(@"contact.txt");
                            fileContact = sr1.ReadToEnd();
                            sr1.Close();

                            firstRamplace = fileContact.Replace(
                            lv.SubItems[0].Text + ";" +
                            lv.SubItems[1].Text + ";" +
                            lv.SubItems[2].Text + ";" +
                            lv.SubItems[3].Text + ";" +
                            lv.SubItems[4].Text, "");



                            string str2 = Form1.RemoveEmptyLines(firstRamplace);

                            File.WriteAllText(@"contact.txt", str2);

                            init();
                        }

                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un contact a supprimer.");
            }
        }
    }
}
