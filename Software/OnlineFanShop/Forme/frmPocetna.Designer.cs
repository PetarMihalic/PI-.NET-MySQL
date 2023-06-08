
namespace OnlineFanShop
{
    partial class frmPocetna
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
            this.btnPrijava = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKosarica = new System.Windows.Forms.Button();
            this.dgvPonuda = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.cmbFranšiza = new System.Windows.Forms.ComboBox();
            this.cmbVeličina = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCijenaMax = new System.Windows.Forms.TextBox();
            this.txtCijenaMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSortiranje = new System.Windows.Forms.ComboBox();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btnDodajUKosaricu = new System.Windows.Forms.Button();
            this.btnPrikaziDetalje = new System.Windows.Forms.Button();
            this.btnResetiraj = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.helpProviderPocetnaGost = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonuda)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(941, 51);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(68, 26);
            this.btnPrijava.TabIndex = 0;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPrijava);
            this.groupBox1.Controls.Add(this.btnKosarica);
            this.groupBox1.Location = new System.Drawing.Point(-3, -7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1024, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(941, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Izlaz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(328, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online Fan Shop";
            // 
            // btnKosarica
            // 
            this.btnKosarica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnKosarica.Location = new System.Drawing.Point(407, 80);
            this.btnKosarica.Name = "btnKosarica";
            this.btnKosarica.Size = new System.Drawing.Size(150, 35);
            this.btnKosarica.TabIndex = 0;
            this.btnKosarica.Text = "Kosarica";
            this.btnKosarica.UseVisualStyleBackColor = true;
            // 
            // dgvPonuda
            // 
            this.dgvPonuda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPonuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonuda.Location = new System.Drawing.Point(5, 168);
            this.dgvPonuda.Name = "dgvPonuda";
            this.dgvPonuda.Size = new System.Drawing.Size(706, 423);
            this.dgvPonuda.TabIndex = 3;
            this.dgvPonuda.SelectionChanged += new System.EventHandler(this.dgvPonuda_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(472, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sortiranje:";
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
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtriranje";
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(20, 164);
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
            this.cmbFranšiza.Location = new System.Drawing.Point(85, 128);
            this.cmbFranšiza.Name = "cmbFranšiza";
            this.cmbFranšiza.Size = new System.Drawing.Size(177, 24);
            this.cmbFranšiza.TabIndex = 11;
            // 
            // cmbVeličina
            // 
            this.cmbVeličina.FormattingEnabled = true;
            this.cmbVeličina.Location = new System.Drawing.Point(85, 94);
            this.cmbVeličina.Name = "cmbVeličina";
            this.cmbVeličina.Size = new System.Drawing.Size(177, 24);
            this.cmbVeličina.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Franšiza:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Veličina:";
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Location = new System.Drawing.Point(85, 59);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(177, 24);
            this.cmbVrsta.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vrsta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "-";
            // 
            // txtCijenaMax
            // 
            this.txtCijenaMax.Location = new System.Drawing.Point(184, 25);
            this.txtCijenaMax.Name = "txtCijenaMax";
            this.txtCijenaMax.Size = new System.Drawing.Size(78, 23);
            this.txtCijenaMax.TabIndex = 2;
            // 
            // txtCijenaMin
            // 
            this.txtCijenaMin.Location = new System.Drawing.Point(85, 25);
            this.txtCijenaMin.Name = "txtCijenaMin";
            this.txtCijenaMin.Size = new System.Drawing.Size(78, 23);
            this.txtCijenaMin.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cijena:";
            // 
            // cmbSortiranje
            // 
            this.cmbSortiranje.FormattingEnabled = true;
            this.cmbSortiranje.Location = new System.Drawing.Point(551, 131);
            this.cmbSortiranje.Name = "cmbSortiranje";
            this.cmbSortiranje.Size = new System.Drawing.Size(160, 21);
            this.cmbSortiranje.TabIndex = 5;
            this.cmbSortiranje.SelectedIndexChanged += new System.EventHandler(this.cmbSortiranje_SelectedIndexChanged);
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPretrazi.Location = new System.Drawing.Point(210, 131);
            this.txtPretrazi.Multiline = true;
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(217, 24);
            this.txtPretrazi.TabIndex = 9;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // btnDodajUKosaricu
            // 
            this.btnDodajUKosaricu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDodajUKosaricu.Location = new System.Drawing.Point(726, 417);
            this.btnDodajUKosaricu.Name = "btnDodajUKosaricu";
            this.btnDodajUKosaricu.Size = new System.Drawing.Size(280, 31);
            this.btnDodajUKosaricu.TabIndex = 10;
            this.btnDodajUKosaricu.Text = "Dodaj u košaricu";
            this.btnDodajUKosaricu.UseVisualStyleBackColor = true;
            // 
            // btnPrikaziDetalje
            // 
            this.btnPrikaziDetalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrikaziDetalje.Location = new System.Drawing.Point(726, 380);
            this.btnPrikaziDetalje.Name = "btnPrikaziDetalje";
            this.btnPrikaziDetalje.Size = new System.Drawing.Size(280, 31);
            this.btnPrikaziDetalje.TabIndex = 12;
            this.btnPrikaziDetalje.Text = "Prikaži detalje o proizvodu";
            this.btnPrikaziDetalje.UseVisualStyleBackColor = true;
            this.btnPrikaziDetalje.Click += new System.EventHandler(this.btnPrikaziDetalje_Click);
            // 
            // btnResetiraj
            // 
            this.btnResetiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnResetiraj.Location = new System.Drawing.Point(726, 560);
            this.btnResetiraj.Name = "btnResetiraj";
            this.btnResetiraj.Size = new System.Drawing.Size(280, 31);
            this.btnResetiraj.TabIndex = 13;
            this.btnResetiraj.Text = "Resetiraj prikaz ponude";
            this.btnResetiraj.UseVisualStyleBackColor = true;
            this.btnResetiraj.Click += new System.EventHandler(this.btnResetiraj_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(12, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pretraži po nazivu proizvoda:";
            // 
            // helpProviderPocetnaGost
            // 
            this.helpProviderPocetnaGost.HelpNamespace = "OnlineFanShopHelp.chm";
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1018, 595);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnResetiraj);
            this.Controls.Add(this.btnPrikaziDetalje);
            this.Controls.Add(this.btnDodajUKosaricu);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.cmbSortiranje);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPonuda);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.helpProviderPocetnaGost.SetHelpKeyword(this, "30");
            this.helpProviderPocetnaGost.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.MaximizeBox = false;
            this.Name = "frmPocetna";
            this.helpProviderPocetnaGost.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Fan Shop";
            this.Load += new System.EventHandler(this.frmPocetna_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonuda)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPonuda;
        private System.Windows.Forms.Button btnKosarica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.ComboBox cmbFranšiza;
        private System.Windows.Forms.ComboBox cmbVeličina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCijenaMax;
        private System.Windows.Forms.TextBox txtCijenaMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSortiranje;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Button btnDodajUKosaricu;
        private System.Windows.Forms.Button btnPrikaziDetalje;
        private System.Windows.Forms.Button btnResetiraj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.HelpProvider helpProviderPocetnaGost;
        private System.Windows.Forms.Button button1;
    }
}