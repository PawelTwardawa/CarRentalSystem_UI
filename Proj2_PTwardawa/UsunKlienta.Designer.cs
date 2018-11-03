namespace Proj2_PTwardawa
{
    partial class UsunKlienta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.anuluj_button = new System.Windows.Forms.Button();
            this.usun_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Klient do usuniecia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // anuluj_button
            // 
            this.anuluj_button.Location = new System.Drawing.Point(402, 342);
            this.anuluj_button.Name = "anuluj_button";
            this.anuluj_button.Size = new System.Drawing.Size(75, 23);
            this.anuluj_button.TabIndex = 3;
            this.anuluj_button.Text = "Anuluj";
            this.anuluj_button.UseVisualStyleBackColor = true;
            this.anuluj_button.Click += new System.EventHandler(this.anuluj_button_Click);
            // 
            // usun_button
            // 
            this.usun_button.Location = new System.Drawing.Point(321, 342);
            this.usun_button.Name = "usun_button";
            this.usun_button.Size = new System.Drawing.Size(75, 23);
            this.usun_button.TabIndex = 4;
            this.usun_button.Text = "Usun";
            this.usun_button.UseVisualStyleBackColor = true;
            this.usun_button.Click += new System.EventHandler(this.usun_button_Click);
            // 
            // UsunKlienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 375);
            this.Controls.Add(this.usun_button);
            this.Controls.Add(this.anuluj_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(506, 414);
            this.MinimumSize = new System.Drawing.Size(506, 414);
            this.Name = "UsunKlienta";
            this.Text = "UsunKlienta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button anuluj_button;
        private System.Windows.Forms.Button usun_button;
    }
}