
namespace BoiteMailSMTP
{
    partial class Contact
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact));
            this.btnSupprimer1 = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lvContacts = new System.Windows.Forms.ListView();
            this.iconcontacts = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxClasse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxBAC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSupprimer1
            // 
            this.btnSupprimer1.Location = new System.Drawing.Point(647, 225);
            this.btnSupprimer1.Name = "btnSupprimer1";
            this.btnSupprimer1.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer1.TabIndex = 21;
            this.btnSupprimer1.Text = "Supprimer";
            this.btnSupprimer1.UseVisualStyleBackColor = true;
            this.btnSupprimer1.Click += new System.EventHandler(this.btnSupprimer1_Click_1);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(572, 225);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 20;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lvContacts
            // 
            this.lvContacts.HideSelection = false;
            this.lvContacts.LargeImageList = this.iconcontacts;
            this.lvContacts.Location = new System.Drawing.Point(10, 60);
            this.lvContacts.Name = "lvContacts";
            this.lvContacts.Size = new System.Drawing.Size(450, 290);
            this.lvContacts.SmallImageList = this.iconcontacts;
            this.lvContacts.TabIndex = 19;
            this.lvContacts.UseCompatibleStateImageBehavior = false;
            this.lvContacts.View = System.Windows.Forms.View.Details;
            // 
            // iconcontacts
            // 
            this.iconcontacts.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconcontacts.ImageStream")));
            this.iconcontacts.TransparentColor = System.Drawing.Color.Transparent;
            this.iconcontacts.Images.SetKeyName(0, "icons8-contacts-9.png");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(497, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mail:";
            // 
            // tbxMail
            // 
            this.tbxMail.Location = new System.Drawing.Point(572, 173);
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.Size = new System.Drawing.Size(150, 20);
            this.tbxMail.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(497, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Classe:";
            // 
            // tbxClasse
            // 
            this.tbxClasse.Location = new System.Drawing.Point(572, 147);
            this.tbxClasse.Name = "tbxClasse";
            this.tbxClasse.Size = new System.Drawing.Size(150, 20);
            this.tbxClasse.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(497, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "BAC:";
            // 
            // tbxBAC
            // 
            this.tbxBAC.Location = new System.Drawing.Point(572, 121);
            this.tbxBAC.Name = "tbxBAC";
            this.tbxBAC.Size = new System.Drawing.Size(150, 20);
            this.tbxBAC.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nom:";
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(572, 68);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(150, 20);
            this.tbxNom.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(497, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Id:";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(572, 199);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(150, 20);
            this.tbxId.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 50);
            this.panel1.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Contacts";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(497, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Prénom:";
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Location = new System.Drawing.Point(572, 95);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(150, 20);
            this.tbxPrenom.TabIndex = 25;
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxPrenom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.btnSupprimer1);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lvContacts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxClasse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxBAC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNom);
            this.Name = "Contact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact";
            this.Load += new System.EventHandler(this.Contact_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSupprimer1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ListView lvContacts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxClasse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxBAC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.ImageList iconcontacts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxPrenom;
    }
}