using System;
using System.IO;
using System.Windows.Forms;

namespace BoiteMailSMTP
{
    public partial class serveurs : Form
    {


        

        public serveurs()
        {
            InitializeComponent();
        }

        private void serveurs_Load(object sender, EventArgs e)
        {

            lvServeurs.Sorting = SortOrder.Ascending;

            lvServeurs.FullRowSelect = true;
            lvServeurs.GridLines = true;
            //trie par ordre alphabétique
            lvServeurs.Sorting = SortOrder.Ascending;
            //Permet de voir en liste
            lvServeurs.View = View.Details;

            lvServeurs.Columns.Add("Nom", 180, HorizontalAlignment.Left);
            lvServeurs.Columns.Add("Host", 150, HorizontalAlignment.Left);
            lvServeurs.Columns.Add("URL", 180, HorizontalAlignment.Left);
            lvServeurs.Columns.Add("Port", 50, HorizontalAlignment.Left);

            init();
        }
        //méthide qui initialise le listview qui servira a chaque modification de ce dernier
        private void init()
        {
            lvServeurs.Items.Clear();
            string[] ligne = File.ReadAllLines(@"serveur.txt");
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
                    //Sert pour les logos devant le listveiw sert a selectionner l index de limage qu on a mit dans l imagebox
                    lst.ImageIndex = 0;
                    lvServeurs.Items.Add(lst);
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //lire le fichier
            System.IO.StreamReader sr = new System.IO.StreamReader(@"serveur.txt");
            string fileContact = sr.ReadToEnd();
            sr.Close();
            //Créé la ligne qui va aetre rentrée dans le tableau
            string str1 = tbxURL.Text + ";" + tbxNom.Text + ";" + tbxHost.Text + ";" + tbxPort.Text;


            if (!fileContact.Contains(str1))
            {
                //supprime les lignes vides
                string strRes = fileContact.Insert(fileContact.Length, "\n" + str1);


                string str2 = Form1.RemoveEmptyLines(strRes);


                File.WriteAllText(@"serveur.txt", str2);
                init();
                //Remet les tbx a vide
                tbxURL.Text = "";
                tbxNom.Text = "";
                tbxHost.Text = "";
                tbxPort.Text = "";




            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un serveur qui n'existe pas déjà.");
            }
        }



        private void btnSupprimer2_Click(object sender, EventArgs e)
        {
            if (lvServeurs.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Êtes vous sûres de vouloir supprimer ce serveur ?", "Suppression d'un serveur", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {   //supprime (si on a validé précédement) l'élement selectionné
                    ListViewItem item = lvServeurs.SelectedItems[lvServeurs.SelectedItems.Count - 1];
                    if (item != null)
                        foreach (ListViewItem lv in lvServeurs.SelectedItems)
                        {

                            string fileContact = "";
                            string firstRamplace = "";

                            System.IO.StreamReader sr1 = new System.IO.StreamReader(@"serveur.txt");
                            fileContact = sr1.ReadToEnd();
                            sr1.Close();
                            //On remplace les éléments indiqués par les variables (sui sont vides ) inttroduites juste avant
                            firstRamplace = fileContact.Replace(
                            lv.SubItems[0].Text + ";" +
                            lv.SubItems[1].Text + ";" +
                            lv.SubItems[2].Text + ";" +
                            lv.SubItems[3].Text, "");

                            string str2 = Form1.RemoveEmptyLines(firstRamplace);

                            File.WriteAllText(@"serveur.txt", str2);

                            init();
                        }

                }
            }
        }
    }
}
