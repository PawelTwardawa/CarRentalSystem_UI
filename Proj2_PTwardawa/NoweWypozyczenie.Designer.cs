namespace Proj2_PTwardawa
{
    partial class NoweWypozyczenie
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.samochod_label = new System.Windows.Forms.Label();
            this.klient_label = new System.Windows.Forms.Label();
            this.wypozycz_button = new System.Windows.Forms.Button();
            this.Anuluj_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(514, 12);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(500, 450);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Klient: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Samochod: ";
            // 
            // samochod_label
            // 
            this.samochod_label.AutoSize = true;
            this.samochod_label.Location = new System.Drawing.Point(83, 493);
            this.samochod_label.Name = "samochod_label";
            this.samochod_label.Size = new System.Drawing.Size(0, 13);
            this.samochod_label.TabIndex = 4;
            // 
            // klient_label
            // 
            this.klient_label.AutoSize = true;
            this.klient_label.Location = new System.Drawing.Point(83, 476);
            this.klient_label.Name = "klient_label";
            this.klient_label.Size = new System.Drawing.Size(0, 13);
            this.klient_label.TabIndex = 5;
            // 
            // wypozycz_button
            // 
            this.wypozycz_button.Location = new System.Drawing.Point(12, 519);
            this.wypozycz_button.Name = "wypozycz_button";
            this.wypozycz_button.Size = new System.Drawing.Size(86, 23);
            this.wypozycz_button.TabIndex = 6;
            this.wypozycz_button.Text = "Wypozycz";
            this.wypozycz_button.UseVisualStyleBackColor = true;
            this.wypozycz_button.Click += new System.EventHandler(this.wypozycz_button_Click);
            // 
            // Anuluj_button
            // 
            this.Anuluj_button.Location = new System.Drawing.Point(123, 519);
            this.Anuluj_button.Name = "Anuluj_button";
            this.Anuluj_button.Size = new System.Drawing.Size(86, 23);
            this.Anuluj_button.TabIndex = 7;
            this.Anuluj_button.Text = "Anuluj";
            this.Anuluj_button.UseVisualStyleBackColor = true;
            this.Anuluj_button.Click += new System.EventHandler(this.Anuluj_button_Click);
            // 
            // NoweWypozyczenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 554);
            this.Controls.Add(this.Anuluj_button);
            this.Controls.Add(this.wypozycz_button);
            this.Controls.Add(this.klient_label);
            this.Controls.Add(this.samochod_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(1042, 593);
            this.MinimumSize = new System.Drawing.Size(1042, 593);
            this.Name = "NoweWypozyczenie";
            this.Text = "NoweWypozyczenie";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label samochod_label;
        private System.Windows.Forms.Label klient_label;
        private System.Windows.Forms.Button wypozycz_button;
        private System.Windows.Forms.Button Anuluj_button;
    }
}