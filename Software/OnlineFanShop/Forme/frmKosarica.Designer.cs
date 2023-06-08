
namespace OnlineFanShop
{
    partial class frmKosarica
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
            this.dgvKosarica = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKupi = new System.Windows.Forms.Button();
            this.btnFanKviz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKosarica)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKosarica
            // 
            this.dgvKosarica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKosarica.Location = new System.Drawing.Point(5, 6);
            this.dgvKosarica.Name = "dgvKosarica";
            this.dgvKosarica.Size = new System.Drawing.Size(574, 276);
            this.dgvKosarica.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(36, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odabirom jednog od proizvoda u Vašoj košarici imate priliku riješiti fan kviz te " +
    "ostvariti popust!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(104, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fan kviz će biti iste tematike kao i odabrani proizvod, birajte pametno!";
            // 
            // btnKupi
            // 
            this.btnKupi.Location = new System.Drawing.Point(336, 336);
            this.btnKupi.Name = "btnKupi";
            this.btnKupi.Size = new System.Drawing.Size(99, 35);
            this.btnKupi.TabIndex = 3;
            this.btnKupi.Text = "Kupi";
            this.btnKupi.UseVisualStyleBackColor = true;
            // 
            // btnFanKviz
            // 
            this.btnFanKviz.Location = new System.Drawing.Point(171, 336);
            this.btnFanKviz.Name = "btnFanKviz";
            this.btnFanKviz.Size = new System.Drawing.Size(99, 35);
            this.btnFanKviz.TabIndex = 4;
            this.btnFanKviz.Text = "Fan kviz";
            this.btnFanKviz.UseVisualStyleBackColor = true;
            this.btnFanKviz.Click += new System.EventHandler(this.btnFanKviz_Click);
            // 
            // frmKosarica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 383);
            this.Controls.Add(this.btnFanKviz);
            this.Controls.Add(this.btnKupi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKosarica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmKosarica";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kosarica";
            this.Load += new System.EventHandler(this.frmKosarica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKosarica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKosarica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKupi;
        private System.Windows.Forms.Button btnFanKviz;
    }
}