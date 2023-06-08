
namespace OnlineFanShop
{
    partial class frmPocetnaKorisnik
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
            this.btnPrikaziDetalje = new System.Windows.Forms.Button();
            this.btnDodajNaListuZelja = new System.Windows.Forms.Button();
            this.btnDodajUKosaricu = new System.Windows.Forms.Button();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.cmbSortiranje = new System.Windows.Forms.ComboBox();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.cmbFranšiza = new System.Windows.Forms.ComboBox();
            this.cmbVeličina = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKosarica = new System.Windows.Forms.Button();
            this.btnListaZelja = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCijenaMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCijenaMin = new System.Windows.Forms.TextBox();
            this.dgvPonuda = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResetiraj = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDodano = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonuda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikaziDetalje
            // 
            this.btnPrikaziDetalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrikaziDetalje.Location = new System.Drawing.Point(726, 380);
            this.btnPrikaziDetalje.Name = "btnPrikaziDetalje";
            this.btnPrikaziDetalje.Size = new System.Drawing.Size(280, 31);
            this.btnPrikaziDetalje.TabIndex = 22;
            this.btnPrikaziDetalje.Text = "Prikaži detalje o proizvodu";
            this.btnPrikaziDetalje.UseVisualStyleBackColor = true;
            this.btnPrikaziDetalje.Click += new System.EventHandler(this.btnPrikaziDetalje_Click);
            // 
            // btnDodajNaListuZelja
            // 
            this.btnDodajNaListuZelja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDodajNaListuZelja.Location = new System.Drawing.Point(726, 454);
            this.btnDodajNaListuZelja.Name = "btnDodajNaListuZelja";
            this.btnDodajNaListuZelja.Size = new System.Drawing.Size(280, 31);
            this.btnDodajNaListuZelja.TabIndex = 21;
            this.btnDodajNaListuZelja.Text = "Dodaj na listu želja";
            this.btnDodajNaListuZelja.UseVisualStyleBackColor = true;
            this.btnDodajNaListuZelja.Click += new System.EventHandler(this.btnDodajNaListuZelja_Click);
            // 
            // btnDodajUKosaricu
            // 
            this.btnDodajUKosaricu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDodajUKosaricu.Location = new System.Drawing.Point(726, 417);
            this.btnDodajUKosaricu.Name = "btnDodajUKosaricu";
            this.btnDodajUKosaricu.Size = new System.Drawing.Size(280, 31);
            this.btnDodajUKosaricu.TabIndex = 20;
            this.btnDodajUKosaricu.Text = "Dodaj u košaricu";
            this.btnDodajUKosaricu.UseVisualStyleBackColor = true;
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPretrazi.Location = new System.Drawing.Point(210, 131);
            this.txtPretrazi.Multiline = true;
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(217, 24);
            this.txtPretrazi.TabIndex = 19;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // cmbSortiranje
            // 
            this.cmbSortiranje.FormattingEnabled = true;
            this.cmbSortiranje.Location = new System.Drawing.Point(551, 131);
            this.cmbSortiranje.Name = "cmbSortiranje";
            this.cmbSortiranje.Size = new System.Drawing.Size(160, 21);
            this.cmbSortiranje.TabIndex = 15;
            this.cmbSortiranje.SelectedIndexChanged += new System.EventHandler(this.cmbSortiranje_SelectedIndexChanged);
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(20, 159);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(242, 31);
            this.btnFiltriraj.TabIndex = 12;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // cmbFranšiza
            // 
            this.cmbFranšiza.FormattingEnabled = true;
            this.cmbFranšiza.Location = new System.Drawing.Point(85, 123);
            this.cmbFranšiza.Name = "cmbFranšiza";
            this.cmbFranšiza.Size = new System.Drawing.Size(177, 24);
            this.cmbFranšiza.TabIndex = 11;
            // 
            // cmbVeličina
            // 
            this.cmbVeličina.FormattingEnabled = true;
            this.cmbVeličina.Location = new System.Drawing.Point(85, 89);
            this.cmbVeličina.Name = "cmbVeličina";
            this.cmbVeličina.Size = new System.Drawing.Size(177, 24);
            this.cmbVeličina.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Franšiza:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox1.Controls.Add(this.btnOdjava);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnKosarica);
            this.groupBox1.Controls.Add(this.btnListaZelja);
            this.groupBox1.Location = new System.Drawing.Point(-3, -7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1024, 125);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(941, 19);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(68, 26);
            this.btnOdjava.TabIndex = 6;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(328, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online Fan Shop";
            // 
            // btnKosarica
            // 
            this.btnKosarica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnKosarica.Location = new System.Drawing.Point(340, 75);
            this.btnKosarica.Name = "btnKosarica";
            this.btnKosarica.Size = new System.Drawing.Size(150, 35);
            this.btnKosarica.TabIndex = 0;
            this.btnKosarica.Text = "Kosarica";
            this.btnKosarica.UseVisualStyleBackColor = true;
            this.btnKosarica.Click += new System.EventHandler(this.btnKosarica_Click);
            // 
            // btnListaZelja
            // 
            this.btnListaZelja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnListaZelja.Location = new System.Drawing.Point(497, 75);
            this.btnListaZelja.Name = "btnListaZelja";
            this.btnListaZelja.Size = new System.Drawing.Size(150, 35);
            this.btnListaZelja.TabIndex = 1;
            this.btnListaZelja.Text = "Lista Zelja";
            this.btnListaZelja.UseVisualStyleBackColor = true;
            this.btnListaZelja.Click += new System.EventHandler(this.btnListaZelja_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Veličina:";
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Location = new System.Drawing.Point(85, 54);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(177, 24);
            this.cmbVrsta.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vrsta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "-";
            // 
            // txtCijenaMax
            // 
            this.txtCijenaMax.Location = new System.Drawing.Point(184, 20);
            this.txtCijenaMax.Name = "txtCijenaMax";
            this.txtCijenaMax.Size = new System.Drawing.Size(78, 23);
            this.txtCijenaMax.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cijena:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFiltriraj);
            this.groupBox2.Controls.Add(this.cmbFranšiza);
            this.groupBox2.Controls.Add(this.cmbVeličina);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbVrsta);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCijenaMax);
            this.groupBox2.Controls.Add(this.txtCijenaMin);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(726, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 205);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtriranje";
            // 
            // txtCijenaMin
            // 
            this.txtCijenaMin.Location = new System.Drawing.Point(85, 20);
            this.txtCijenaMin.Name = "txtCijenaMin";
            this.txtCijenaMin.Size = new System.Drawing.Size(78, 23);
            this.txtCijenaMin.TabIndex = 1;
            // 
            // dgvPonuda
            // 
            this.dgvPonuda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPonuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonuda.Location = new System.Drawing.Point(5, 168);
            this.dgvPonuda.Name = "dgvPonuda";
            this.dgvPonuda.Size = new System.Drawing.Size(706, 423);
            this.dgvPonuda.TabIndex = 14;
            this.dgvPonuda.SelectionChanged += new System.EventHandler(this.dgvPonuda_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(472, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sortiranje:";
            // 
            // btnResetiraj
            // 
            this.btnResetiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnResetiraj.Location = new System.Drawing.Point(726, 560);
            this.btnResetiraj.Name = "btnResetiraj";
            this.btnResetiraj.Size = new System.Drawing.Size(280, 31);
            this.btnResetiraj.TabIndex = 23;
            this.btnResetiraj.Text = "Resetiraj prikaz ponude";
            this.btnResetiraj.UseVisualStyleBackColor = true;
            this.btnResetiraj.Click += new System.EventHandler(this.btnResetiraj_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(12, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Pretraži po nazivu proizvoda:";
            // 
            // lblDodano
            // 
            this.lblDodano.AutoSize = true;
            this.lblDodano.Location = new System.Drawing.Point(808, 499);
            this.lblDodano.Name = "lblDodano";
            this.lblDodano.Size = new System.Drawing.Size(108, 13);
            this.lblDodano.TabIndex = 25;
            this.lblDodano.Text = "Dodano na listu želja!";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "OnlineFanShopHelp.chm";
            // 
            // frmPocetnaKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 595);
            this.Controls.Add(this.lblDodano);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnResetiraj);
            this.Controls.Add(this.btnPrikaziDetalje);
            this.Controls.Add(this.btnDodajNaListuZelja);
            this.Controls.Add(this.btnDodajUKosaricu);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.cmbSortiranje);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvPonuda);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.helpProvider1.SetHelpKeyword(this, "10");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.MaximizeBox = false;
            this.Name = "frmPocetnaKorisnik";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Online Fan Shop";
            this.Load += new System.EventHandler(this.FrmPocetnaKorisnik_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrikaziDetalje;
        private System.Windows.Forms.Button btnDodajNaListuZelja;
        private System.Windows.Forms.Button btnDodajUKosaricu;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.ComboBox cmbSortiranje;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.ComboBox cmbFranšiza;
        private System.Windows.Forms.ComboBox cmbVeličina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKosarica;
        private System.Windows.Forms.Button btnListaZelja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCijenaMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCijenaMin;
        private System.Windows.Forms.DataGridView dgvPonuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResetiraj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Label lblDodano;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}