namespace Klijent.KorisnickiInterfejs
{
    partial class IzmenaTreninga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmenaTreninga));
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtTrajanjeTreninga = new System.Windows.Forms.TextBox();
            this.cmbVrstaTrening = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSacuvajTrening = new System.Windows.Forms.Button();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnObrisiIgraca = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDodajIgraca = new System.Windows.Forms.Button();
            this.txtVrednost = new System.Windows.Forms.TextBox();
            this.cmbNazivStatistike = new System.Windows.Forms.ComboBox();
            this.cmbIgrac = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 223);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 45;
            this.label8.Text = "Statistika igrača";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(730, 106);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(205, 22);
            this.dtpDatum.TabIndex = 44;
            // 
            // txtTrajanjeTreninga
            // 
            this.txtTrajanjeTreninga.Location = new System.Drawing.Point(970, 164);
            this.txtTrajanjeTreninga.Margin = new System.Windows.Forms.Padding(5);
            this.txtTrajanjeTreninga.Name = "txtTrajanjeTreninga";
            this.txtTrajanjeTreninga.Size = new System.Drawing.Size(57, 22);
            this.txtTrajanjeTreninga.TabIndex = 42;
            // 
            // cmbVrstaTrening
            // 
            this.cmbVrstaTrening.FormattingEnabled = true;
            this.cmbVrstaTrening.Location = new System.Drawing.Point(730, 161);
            this.cmbVrstaTrening.Margin = new System.Windows.Forms.Padding(5);
            this.cmbVrstaTrening.Name = "cmbVrstaTrening";
            this.cmbVrstaTrening.Size = new System.Drawing.Size(205, 24);
            this.cmbVrstaTrening.TabIndex = 41;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(730, 52);
            this.txtID.Margin = new System.Windows.Forms.Padding(5);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(205, 22);
            this.txtID.TabIndex = 40;
            // 
            // btnSacuvajTrening
            // 
            this.btnSacuvajTrening.Location = new System.Drawing.Point(15, 524);
            this.btnSacuvajTrening.Margin = new System.Windows.Forms.Padding(5);
            this.btnSacuvajTrening.Name = "btnSacuvajTrening";
            this.btnSacuvajTrening.Size = new System.Drawing.Size(1180, 81);
            this.btnSacuvajTrening.TabIndex = 39;
            this.btnSacuvajTrening.Text = "Izmeni trening";
            this.btnSacuvajTrening.UseVisualStyleBackColor = true;
            this.btnSacuvajTrening.Click += new System.EventHandler(this.btnSacuvajTrening_Click);
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(730, 247);
            this.txtNapomena.Margin = new System.Windows.Forms.Padding(5);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(463, 266);
            this.txtNapomena.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(724, 223);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 37;
            this.label9.Text = "Napomena:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(964, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Trajanje treninga:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(724, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Trening:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(724, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(724, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "ID treninga:";
            // 
            // btnObrisiIgraca
            // 
            this.btnObrisiIgraca.Location = new System.Drawing.Point(420, 137);
            this.btnObrisiIgraca.Margin = new System.Windows.Forms.Padding(5);
            this.btnObrisiIgraca.Name = "btnObrisiIgraca";
            this.btnObrisiIgraca.Size = new System.Drawing.Size(276, 54);
            this.btnObrisiIgraca.TabIndex = 32;
            this.btnObrisiIgraca.Text = "Obriši igrača";
            this.btnObrisiIgraca.UseVisualStyleBackColor = true;
            this.btnObrisiIgraca.Click += new System.EventHandler(this.btnObrisiIgraca_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 247);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 268);
            this.dataGridView1.TabIndex = 31;
            // 
            // btnDodajIgraca
            // 
            this.btnDodajIgraca.Location = new System.Drawing.Point(15, 137);
            this.btnDodajIgraca.Margin = new System.Windows.Forms.Padding(5);
            this.btnDodajIgraca.Name = "btnDodajIgraca";
            this.btnDodajIgraca.Size = new System.Drawing.Size(276, 54);
            this.btnDodajIgraca.TabIndex = 30;
            this.btnDodajIgraca.Text = "Dodaj igrača";
            this.btnDodajIgraca.UseVisualStyleBackColor = true;
            this.btnDodajIgraca.Click += new System.EventHandler(this.btnDodajIgraca_Click);
            // 
            // txtVrednost
            // 
            this.txtVrednost.Location = new System.Drawing.Point(503, 77);
            this.txtVrednost.Margin = new System.Windows.Forms.Padding(5);
            this.txtVrednost.Name = "txtVrednost";
            this.txtVrednost.Size = new System.Drawing.Size(192, 22);
            this.txtVrednost.TabIndex = 29;
            // 
            // cmbNazivStatistike
            // 
            this.cmbNazivStatistike.FormattingEnabled = true;
            this.cmbNazivStatistike.Location = new System.Drawing.Point(166, 76);
            this.cmbNazivStatistike.Margin = new System.Windows.Forms.Padding(5);
            this.cmbNazivStatistike.Name = "cmbNazivStatistike";
            this.cmbNazivStatistike.Size = new System.Drawing.Size(213, 24);
            this.cmbNazivStatistike.TabIndex = 28;
            // 
            // cmbIgrac
            // 
            this.cmbIgrac.FormattingEnabled = true;
            this.cmbIgrac.Location = new System.Drawing.Point(166, 28);
            this.cmbIgrac.Margin = new System.Windows.Forms.Padding(5);
            this.cmbIgrac.Name = "cmbIgrac";
            this.cmbIgrac.Size = new System.Drawing.Size(529, 24);
            this.cmbIgrac.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Vrednost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Naziv statistike:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Igrač:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(1039, 165);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "( minuta )";
            // 
            // IzmenaTreninga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 615);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDatum);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IzmenaTreninga";
            this.Text = "[OKK Zlatar] Izmena treninga";
            this.Load += new System.EventHandler(this.IzmenaTreninga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox txtTrajanjeTreninga;
        private System.Windows.Forms.ComboBox cmbVrstaTrening;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSacuvajTrening;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnObrisiIgraca;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDodajIgraca;
        private System.Windows.Forms.TextBox txtVrednost;
        private System.Windows.Forms.ComboBox cmbNazivStatistike;
        private System.Windows.Forms.ComboBox cmbIgrac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
    }
}