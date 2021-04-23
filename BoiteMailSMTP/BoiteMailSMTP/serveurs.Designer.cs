
namespace BoiteMailSMTP
{
    partial class serveurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serveurs));
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxHost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.lvServeurs = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSupprimer2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(557, 72);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(150, 20);
            this.tbxNom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "URL:";
            // 
            // tbxURL
            // 
            this.tbxURL.Location = new System.Drawing.Point(557, 98);
            this.tbxURL.Name = "tbxURL";
            this.tbxURL.Size = new System.Drawing.Size(150, 20);
            this.tbxURL.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(493, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Host:";
            // 
            // tbxHost
            // 
            this.tbxHost.Location = new System.Drawing.Point(557, 124);
            this.tbxHost.Name = "tbxHost";
            this.tbxHost.Size = new System.Drawing.Size(150, 20);
            this.tbxHost.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port:";
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(557, 150);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(150, 20);
            this.tbxPort.TabIndex = 6;
            // 
            // lvServeurs
            // 
            this.lvServeurs.HideSelection = false;
            this.lvServeurs.Location = new System.Drawing.Point(10, 60);
            this.lvServeurs.Name = "lvServeurs";
            this.lvServeurs.Size = new System.Drawing.Size(450, 290);
            this.lvServeurs.SmallImageList = this.imageList1;
            this.lvServeurs.TabIndex = 8;
            this.lvServeurs.UseCompatibleStateImageBehavior = false;
            this.lvServeurs.View = System.Windows.Forms.View.Details;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-server-10.png");
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(557, 194);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(779, 152);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            //this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 50);
            this.panel1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Serveurs";
            // 
            // btnSupprimer2
            // 
            this.btnSupprimer2.Location = new System.Drawing.Point(632, 194);
            this.btnSupprimer2.Name = "btnSupprimer2";
            this.btnSupprimer2.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer2.TabIndex = 26;
            this.btnSupprimer2.Text = "Supprimer";
            this.btnSupprimer2.UseVisualStyleBackColor = true;
            this.btnSupprimer2.Click += new System.EventHandler(this.btnSupprimer2_Click);
            // 
            // serveurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.btnSupprimer2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lvServeurs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNom);
            this.Name = "serveurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "serveurs";
            this.Load += new System.EventHandler(this.serveurs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.ListView lvServeurs;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSupprimer2;
    }
}