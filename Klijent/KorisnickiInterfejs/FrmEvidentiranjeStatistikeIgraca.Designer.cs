namespace Klijent.KorisnickiInterfejs
{
    partial class FrmEvidentiranjeStatistikeIgraca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEvidentiranjeStatistikeIgraca));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIgrac = new System.Windows.Forms.ComboBox();
            this.cmbNazivStatistike = new System.Windows.Forms.ComboBox();
            this.txtVrednost = new System.Windows.Forms.TextBox();
            this.btnDodajIgraca = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnObrisiIgraca = new System.Windows.Forms.Button();
            this.btnSacuvajTrening = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbVrstaTrening = new System.Windows.Forms.ComboBox();
            this.txtTrajanjeTreninga = new System.Windows.Forms.TextBox();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Igrač:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv statistike:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(755, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vrednost:";
            // 
            // cmbIgrac
            // 
            this.cmbIgrac.FormattingEnabled = true;
            this.cmbIgrac.Location = new System.Drawing.Point(557, 25);
            this.cmbIgrac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbIgrac.Name = "cmbIgrac";
            this.cmbIgrac.Size = new System.Drawing.Size(447, 28);
            this.cmbIgrac.TabIndex = 3;
            // 
            // cmbNazivStatistike
            // 
            this.cmbNazivStatistike.FormattingEnabled = true;
            this.cmbNazivStatistike.Location = new System.Drawing.Point(557, 74);
            this.cmbNazivStatistike.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNazivStatistike.Name = "cmbNazivStatistike";
            this.cmbNazivStatistike.Size = new System.Drawing.Size(190, 28);
            this.cmbNazivStatistike.TabIndex = 4;
            // 
            // txtVrednost
            // 
            this.txtVrednost.Location = new System.Drawing.Point(842, 75);
            this.txtVrednost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVrednost.Name = "txtVrednost";
            this.txtVrednost.Size = new System.Drawing.Size(163, 26);
            this.txtVrednost.TabIndex = 5;
            // 
            // btnDodajIgraca
            // 
            this.btnDodajIgraca.Location = new System.Drawing.Point(430, 135);
            this.btnDodajIgraca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDodajIgraca.Name = "btnDodajIgraca";
            this.btnDodajIgraca.Size = new System.Drawing.Size(233, 55);
            this.btnDodajIgraca.TabIndex = 6;
            this.btnDodajIgraca.Text = "Dodaj igrača";
            this.btnDodajIgraca.UseVisualStyleBackColor = true;
            this.btnDodajIgraca.Click += new System.EventHandler(this.btnDodajIgraca_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(430, 248);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 272);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnObrisiIgraca
            // 
            this.btnObrisiIgraca.Location = new System.Drawing.Point(772, 135);
            this.btnObrisiIgraca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnObrisiIgraca.Name = "btnObrisiIgraca";
            this.btnObrisiIgraca.Size = new System.Drawing.Size(233, 55);
            this.btnObrisiIgraca.TabIndex = 8;
            this.btnObrisiIgraca.Text = "Obriši igrača";
            this.btnObrisiIgraca.UseVisualStyleBackColor = true;
            this.btnObrisiIgraca.Click += new System.EventHandler(this.btnObrisiIgraca_Click);
            // 
            // btnSacuvajTrening
            // 
            this.btnSacuvajTrening.Location = new System.Drawing.Point(8, 529);
            this.btnSacuvajTrening.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSacuvajTrening.Name = "btnSacuvajTrening";
            this.btnSacuvajTrening.Size = new System.Drawing.Size(996, 82);
            this.btnSacuvajTrening.TabIndex = 16;
            this.btnSacuvajTrening.Text = "Sačuvaj trening";
            this.btnSacuvajTrening.UseVisualStyleBackColor = true;
            this.btnSacuvajTrening.Click += new System.EventHandler(this.btnSacuvajTrening_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(426, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Statistika igrača";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID treninga:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Datum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Trening:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Trajanje treninga:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 222);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Napomena:";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(15, 248);
            this.txtNapomena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(391, 270);
            this.txtNapomena.TabIndex = 15;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(15, 49);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(193, 26);
            this.txtID.TabIndex = 17;
            // 
            // cmbVrstaTrening
            // 
            this.cmbVrstaTrening.FormattingEnabled = true;
            this.cmbVrstaTrening.Location = new System.Drawing.Point(15, 160);
            this.cmbVrstaTrening.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbVrstaTrening.Name = "cmbVrstaTrening";
            this.cmbVrstaTrening.Size = new System.Drawing.Size(193, 28);
            this.cmbVrstaTrening.TabIndex = 19;
            // 
            // txtTrajanjeTreninga
            // 
            this.txtTrajanjeTreninga.Location = new System.Drawing.Point(235, 162);
            this.txtTrajanjeTreninga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTrajanjeTreninga.Name = "txtTrajanjeTreninga";
            this.txtTrajanjeTreninga.Size = new System.Drawing.Size(79, 26);
            this.txtTrajanjeTreninga.TabIndex = 20;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKreiraj.Location = new System.Drawing.Point(235, 45);
            this.btnKreiraj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(171, 35);
            this.btnKreiraj.TabIndex = 21;
            this.btnKreiraj.Text = "Kreiraj trening";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(15, 104);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(193, 26);
            this.dtpDatum.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(325, 169);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "( minuta )";
            // 
            // FrmEvidentiranjeStatistikeIgraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 630);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.txtTrajanjeTreninga);
            this.Controls.Add(this.cmbVrstaTrening);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSacuvajTrening);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnObrisiIgraca);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDodajIgraca);
            this.Controls.Add(this.txtVrednost);
            this.Controls.Add(this.cmbNazivStatistike);
            this.Controls.Add(this.cmbIgrac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmEvidentiranjeStatistikeIgraca";
            this.Text = "[OKK] Zlatar - Statistika igrača";
            this.Load += new System.EventHandler(this.FrmEvidentiranjeStatistikeIgraca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIgrac;
        private System.Windows.Forms.ComboBox cmbNazivStatistike;
        private System.Windows.Forms.TextBox txtVrednost;
        private System.Windows.Forms.Button btnDodajIgraca;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnObrisiIgraca;
        private System.Windows.Forms.Button btnSacuvajTrening;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cmbVrstaTrening;
        private System.Windows.Forms.TextBox txtTrajanjeTreninga;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label10;
    }
}