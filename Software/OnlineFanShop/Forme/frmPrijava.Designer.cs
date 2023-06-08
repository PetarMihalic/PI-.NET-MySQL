
namespace OnlineFanShop
{
    partial class frmPrijava
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
            this.btnPrijavaAdmin = new System.Windows.Forms.Button();
            this.btnPrijavaModerator = new System.Windows.Forms.Button();
            this.btnPrijavaKorisnik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrijavaAdmin
            // 
            this.btnPrijavaAdmin.Location = new System.Drawing.Point(34, 29);
            this.btnPrijavaAdmin.Name = "btnPrijavaAdmin";
            this.btnPrijavaAdmin.Size = new System.Drawing.Size(222, 39);
            this.btnPrijavaAdmin.TabIndex = 0;
            this.btnPrijavaAdmin.Text = "Prijavi se kao administrator";
            this.btnPrijavaAdmin.UseVisualStyleBackColor = true;
            this.btnPrijavaAdmin.Click += new System.EventHandler(this.btnPrijavaAdmin_Click);
            // 
            // btnPrijavaModerator
            // 
            this.btnPrijavaModerator.Location = new System.Drawing.Point(34, 94);
            this.btnPrijavaModerator.Name = "btnPrijavaModerator";
            this.btnPrijavaModerator.Size = new System.Drawing.Size(222, 39);
            this.btnPrijavaModerator.TabIndex = 1;
            this.btnPrijavaModerator.Text = "Prijavi se kao moderator";
            this.btnPrijavaModerator.UseVisualStyleBackColor = true;
            this.btnPrijavaModerator.Click += new System.EventHandler(this.btnPrijavaModerator_Click);
            // 
            // btnPrijavaKorisnik
            // 
            this.btnPrijavaKorisnik.Location = new System.Drawing.Point(34, 158);
            this.btnPrijavaKorisnik.Name = "btnPrijavaKorisnik";
            this.btnPrijavaKorisnik.Size = new System.Drawing.Size(222, 39);
            this.btnPrijavaKorisnik.TabIndex = 2;
            this.btnPrijavaKorisnik.Text = "Prijavi se kao korisnik";
            this.btnPrijavaKorisnik.UseVisualStyleBackColor = true;
            this.btnPrijavaKorisnik.Click += new System.EventHandler(this.btnPrijavaKorisnik_Click);
            // 
            // frmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(292, 231);
            this.Controls.Add(this.btnPrijavaKorisnik);
            this.Controls.Add(this.btnPrijavaModerator);
            this.Controls.Add(this.btnPrijavaAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prijava";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrijavaAdmin;
        private System.Windows.Forms.Button btnPrijavaModerator;
        private System.Windows.Forms.Button btnPrijavaKorisnik;
    }
}