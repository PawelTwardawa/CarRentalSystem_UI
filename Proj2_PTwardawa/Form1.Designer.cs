namespace Proj2_PTwardawa
{
    partial class Form1
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
            this.dodaj_klienta_button = new System.Windows.Forms.Button();
            this.dodaj_pracownika_button = new System.Windows.Forms.Button();
            this.klienciGridView = new System.Windows.Forms.DataGridView();
            this.pracownicyGridView = new System.Windows.Forms.DataGridView();
            this.dodaj_samochod_button = new System.Windows.Forms.Button();
            this.nowe_wypozyczenie_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.klienci_tabPage = new System.Windows.Forms.TabPage();
            this.pracownicy_tabPage = new System.Windows.Forms.TabPage();
            this.samochody_tabPage = new System.Windows.Forms.TabPage();
            this.samochodyDataGridView = new System.Windows.Forms.DataGridView();
            this.zwrot_samochodu_button = new System.Windows.Forms.Button();
            this.usun_klienta_button = new System.Windows.Forms.Button();
            this.usun_pracownika_button = new System.Windows.Forms.Button();
            this.usun_samochod_button = new System.Windows.Forms.Button();
            this.do_pliku_button = new System.Windows.Forms.Button();
            this.zamknij_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.osobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.klienciGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.klienci_tabPage.SuspendLayout();
            this.pracownicy_tabPage.SuspendLayout();
            this.samochody_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.samochodyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dodaj_klienta_button
            // 
            this.dodaj_klienta_button.Location = new System.Drawing.Point(12, 12);
            this.dodaj_klienta_button.Name = "dodaj_klienta_button";
            this.dodaj_klienta_button.Size = new System.Drawing.Size(117, 23);
            this.dodaj_klienta_button.TabIndex = 4;
            this.dodaj_klienta_button.Text = "Dodaj Klienta";
            this.dodaj_klienta_button.UseVisualStyleBackColor = true;
            this.dodaj_klienta_button.Click += new System.EventHandler(this.dodaj_klienta_button_Click);
            // 
            // dodaj_pracownika_button
            // 
            this.dodaj_pracownika_button.Location = new System.Drawing.Point(12, 41);
            this.dodaj_pracownika_button.Name = "dodaj_pracownika_button";
            this.dodaj_pracownika_button.Size = new System.Drawing.Size(117, 23);
            this.dodaj_pracownika_button.TabIndex = 5;
            this.dodaj_pracownika_button.Text = "Dodaj Pracownika";
            this.dodaj_pracownika_button.UseVisualStyleBackColor = true;
            this.dodaj_pracownika_button.Click += new System.EventHandler(this.dodaj_pracownika_button_Click);
            // 
            // klienciGridView
            // 
            this.klienciGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.klienciGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.klienciGridView.Location = new System.Drawing.Point(3, 3);
            this.klienciGridView.MultiSelect = false;
            this.klienciGridView.Name = "klienciGridView";
            this.klienciGridView.Size = new System.Drawing.Size(854, 531);
            this.klienciGridView.TabIndex = 13;
            this.klienciGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.klienciGridView_CellClick);
            // 
            // pracownicyGridView
            // 
            this.pracownicyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pracownicyGridView.Location = new System.Drawing.Point(3, 3);
            this.pracownicyGridView.MultiSelect = false;
            this.pracownicyGridView.Name = "pracownicyGridView";
            this.pracownicyGridView.Size = new System.Drawing.Size(854, 531);
            this.pracownicyGridView.TabIndex = 14;
            this.pracownicyGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pracownicyGridView_CellClick);
            // 
            // dodaj_samochod_button
            // 
            this.dodaj_samochod_button.Location = new System.Drawing.Point(12, 70);
            this.dodaj_samochod_button.Name = "dodaj_samochod_button";
            this.dodaj_samochod_button.Size = new System.Drawing.Size(117, 23);
            this.dodaj_samochod_button.TabIndex = 15;
            this.dodaj_samochod_button.Text = "Dodaj Samochod";
            this.dodaj_samochod_button.UseVisualStyleBackColor = true;
            this.dodaj_samochod_button.Click += new System.EventHandler(this.dodaj_samochod_button_Click);
            // 
            // nowe_wypozyczenie_button
            // 
            this.nowe_wypozyczenie_button.Location = new System.Drawing.Point(12, 99);
            this.nowe_wypozyczenie_button.Name = "nowe_wypozyczenie_button";
            this.nowe_wypozyczenie_button.Size = new System.Drawing.Size(117, 23);
            this.nowe_wypozyczenie_button.TabIndex = 18;
            this.nowe_wypozyczenie_button.Text = "Nowe Wypozyczenie";
            this.nowe_wypozyczenie_button.UseVisualStyleBackColor = true;
            this.nowe_wypozyczenie_button.Click += new System.EventHandler(this.nowe_wypozyczenie_button_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.klienci_tabPage);
            this.tabControl1.Controls.Add(this.pracownicy_tabPage);
            this.tabControl1.Controls.Add(this.samochody_tabPage);
            this.tabControl1.Location = new System.Drawing.Point(135, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(868, 563);
            this.tabControl1.TabIndex = 19;
            // 
            // klienci_tabPage
            // 
            this.klienci_tabPage.Controls.Add(this.klienciGridView);
            this.klienci_tabPage.Location = new System.Drawing.Point(4, 22);
            this.klienci_tabPage.Name = "klienci_tabPage";
            this.klienci_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.klienci_tabPage.Size = new System.Drawing.Size(860, 537);
            this.klienci_tabPage.TabIndex = 1;
            this.klienci_tabPage.Text = "Klienci";
            this.klienci_tabPage.UseVisualStyleBackColor = true;
            // 
            // pracownicy_tabPage
            // 
            this.pracownicy_tabPage.Controls.Add(this.pracownicyGridView);
            this.pracownicy_tabPage.Location = new System.Drawing.Point(4, 22);
            this.pracownicy_tabPage.Name = "pracownicy_tabPage";
            this.pracownicy_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pracownicy_tabPage.Size = new System.Drawing.Size(860, 537);
            this.pracownicy_tabPage.TabIndex = 0;
            this.pracownicy_tabPage.Text = "Pracownicy";
            this.pracownicy_tabPage.UseVisualStyleBackColor = true;
            // 
            // samochody_tabPage
            // 
            this.samochody_tabPage.Controls.Add(this.samochodyDataGridView);
            this.samochody_tabPage.Location = new System.Drawing.Point(4, 22);
            this.samochody_tabPage.Name = "samochody_tabPage";
            this.samochody_tabPage.Size = new System.Drawing.Size(860, 537);
            this.samochody_tabPage.TabIndex = 2;
            this.samochody_tabPage.Text = "Samochody";
            this.samochody_tabPage.UseVisualStyleBackColor = true;
            // 
            // samochodyDataGridView
            // 
            this.samochodyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.samochodyDataGridView.Location = new System.Drawing.Point(3, 3);
            this.samochodyDataGridView.MultiSelect = false;
            this.samochodyDataGridView.Name = "samochodyDataGridView";
            this.samochodyDataGridView.Size = new System.Drawing.Size(854, 531);
            this.samochodyDataGridView.TabIndex = 0;
            this.samochodyDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.samochodyDataGridView_CellClick);
            // 
            // zwrot_samochodu_button
            // 
            this.zwrot_samochodu_button.Location = new System.Drawing.Point(12, 128);
            this.zwrot_samochodu_button.Name = "zwrot_samochodu_button";
            this.zwrot_samochodu_button.Size = new System.Drawing.Size(117, 23);
            this.zwrot_samochodu_button.TabIndex = 20;
            this.zwrot_samochodu_button.Text = "Zwrot samochodu";
            this.zwrot_samochodu_button.UseVisualStyleBackColor = true;
            this.zwrot_samochodu_button.Click += new System.EventHandler(this.zwrot_samochodu_button_Click);
            // 
            // usun_klienta_button
            // 
            this.usun_klienta_button.Location = new System.Drawing.Point(12, 157);
            this.usun_klienta_button.Name = "usun_klienta_button";
            this.usun_klienta_button.Size = new System.Drawing.Size(117, 23);
            this.usun_klienta_button.TabIndex = 21;
            this.usun_klienta_button.Text = "Usun klienta";
            this.usun_klienta_button.UseVisualStyleBackColor = true;
            this.usun_klienta_button.Click += new System.EventHandler(this.usun_klienta_button_Click);
            // 
            // usun_pracownika_button
            // 
            this.usun_pracownika_button.Location = new System.Drawing.Point(12, 186);
            this.usun_pracownika_button.Name = "usun_pracownika_button";
            this.usun_pracownika_button.Size = new System.Drawing.Size(117, 23);
            this.usun_pracownika_button.TabIndex = 22;
            this.usun_pracownika_button.Text = "Usun pracownika";
            this.usun_pracownika_button.UseVisualStyleBackColor = true;
            this.usun_pracownika_button.Click += new System.EventHandler(this.usun_pracownika_button_Click);
            // 
            // usun_samochod_button
            // 
            this.usun_samochod_button.Location = new System.Drawing.Point(12, 215);
            this.usun_samochod_button.Name = "usun_samochod_button";
            this.usun_samochod_button.Size = new System.Drawing.Size(117, 23);
            this.usun_samochod_button.TabIndex = 23;
            this.usun_samochod_button.Text = "Usun samochod";
            this.usun_samochod_button.UseVisualStyleBackColor = true;
            this.usun_samochod_button.Click += new System.EventHandler(this.usun_samochod_button_Click);
            // 
            // do_pliku_button
            // 
            this.do_pliku_button.Location = new System.Drawing.Point(12, 244);
            this.do_pliku_button.Name = "do_pliku_button";
            this.do_pliku_button.Size = new System.Drawing.Size(117, 23);
            this.do_pliku_button.TabIndex = 24;
            this.do_pliku_button.Text = "Zapisz";
            this.do_pliku_button.UseVisualStyleBackColor = true;
            this.do_pliku_button.Click += new System.EventHandler(this.do_pliku_button_Click);
            // 
            // zamknij_button
            // 
            this.zamknij_button.Location = new System.Drawing.Point(12, 273);
            this.zamknij_button.Name = "zamknij_button";
            this.zamknij_button.Size = new System.Drawing.Size(117, 23);
            this.zamknij_button.TabIndex = 25;
            this.zamknij_button.Text = "Zamknij";
            this.zamknij_button.UseVisualStyleBackColor = true;
            this.zamknij_button.Click += new System.EventHandler(this.zamknij_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Zalogowany jako:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 27;
            // 
            // osobaBindingSource
            // 
            this.osobaBindingSource.DataSource = typeof(Proj2_PTwardawa.Osoba);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 580);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zamknij_button);
            this.Controls.Add(this.do_pliku_button);
            this.Controls.Add(this.usun_samochod_button);
            this.Controls.Add(this.usun_pracownika_button);
            this.Controls.Add(this.usun_klienta_button);
            this.Controls.Add(this.zwrot_samochodu_button);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.nowe_wypozyczenie_button);
            this.Controls.Add(this.dodaj_samochod_button);
            this.Controls.Add(this.dodaj_pracownika_button);
            this.Controls.Add(this.dodaj_klienta_button);
            this.MaximumSize = new System.Drawing.Size(1025, 619);
            this.MinimumSize = new System.Drawing.Size(1025, 619);
            this.Name = "Form1";
            this.Text = "Proj2_PTwardawa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klienciGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.klienci_tabPage.ResumeLayout(false);
            this.pracownicy_tabPage.ResumeLayout(false);
            this.samochody_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.samochodyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dodaj_klienta_button;
        private System.Windows.Forms.Button dodaj_pracownika_button;
        public System.Windows.Forms.DataGridView klienciGridView;
        public System.Windows.Forms.DataGridView pracownicyGridView;
        private System.Windows.Forms.Button dodaj_samochod_button;
        private System.Windows.Forms.Button nowe_wypozyczenie_button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pracownicy_tabPage;
        private System.Windows.Forms.TabPage klienci_tabPage;
        private System.Windows.Forms.TabPage samochody_tabPage;
        public System.Windows.Forms.DataGridView samochodyDataGridView;
        private System.Windows.Forms.Button zwrot_samochodu_button;
        private System.Windows.Forms.Button usun_klienta_button;
        private System.Windows.Forms.Button usun_pracownika_button;
        private System.Windows.Forms.Button usun_samochod_button;
        private System.Windows.Forms.Button do_pliku_button;
        private System.Windows.Forms.Button zamknij_button;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource osobaBindingSource;
    }
}

