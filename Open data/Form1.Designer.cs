namespace Open_data
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchBoxPilota = new System.Windows.Forms.TextBox();
            this.ComboBoxPilota = new System.Windows.Forms.ComboBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ListViewPiloti = new System.Windows.Forms.ListView();
            this.NationalityBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxTrueFalse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResetFilterButton = new System.Windows.Forms.Button();
            this.ListLinkButton = new System.Windows.Forms.Button();
            this.WinsButton = new System.Windows.Forms.Button();
            this.PoleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchBoxPilota
            // 
            this.SearchBoxPilota.Location = new System.Drawing.Point(43, 31);
            this.SearchBoxPilota.Name = "SearchBoxPilota";
            this.SearchBoxPilota.Size = new System.Drawing.Size(235, 20);
            this.SearchBoxPilota.TabIndex = 4;
            this.SearchBoxPilota.Text = "Cerca un Pilota";
            this.SearchBoxPilota.TextChanged += new System.EventHandler(this.SearchBoxPilota_TextChanged);
            // 
            // ComboBoxPilota
            // 
            this.ComboBoxPilota.FormattingEnabled = true;
            this.ComboBoxPilota.Location = new System.Drawing.Point(299, 32);
            this.ComboBoxPilota.Name = "ComboBoxPilota";
            this.ComboBoxPilota.Size = new System.Drawing.Size(145, 21);
            this.ComboBoxPilota.TabIndex = 5;
            this.ComboBoxPilota.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPilota_SelectedIndexChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(931, 516);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(101, 37);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ListViewPiloti
            // 
            this.ListViewPiloti.HideSelection = false;
            this.ListViewPiloti.Location = new System.Drawing.Point(43, 123);
            this.ListViewPiloti.Name = "ListViewPiloti";
            this.ListViewPiloti.Size = new System.Drawing.Size(866, 430);
            this.ListViewPiloti.TabIndex = 8;
            this.ListViewPiloti.UseCompatibleStateImageBehavior = false;
            // 
            // NationalityBox
            // 
            this.NationalityBox.Location = new System.Drawing.Point(297, 86);
            this.NationalityBox.Name = "NationalityBox";
            this.NationalityBox.Size = new System.Drawing.Size(145, 20);
            this.NationalityBox.TabIndex = 9;
            this.NationalityBox.TextChanged += new System.EventHandler(this.NationalityBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inserire una nazionalità";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Inserire true o false";
            // 
            // ComboBoxTrueFalse
            // 
            this.ComboBoxTrueFalse.FormattingEnabled = true;
            this.ComboBoxTrueFalse.Location = new System.Drawing.Point(478, 31);
            this.ComboBoxTrueFalse.Name = "ComboBoxTrueFalse";
            this.ComboBoxTrueFalse.Size = new System.Drawing.Size(145, 21);
            this.ComboBoxTrueFalse.TabIndex = 13;
            this.ComboBoxTrueFalse.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTrueFalse_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Seleziona filtri";
            // 
            // ResetFilterButton
            // 
            this.ResetFilterButton.Location = new System.Drawing.Point(931, 23);
            this.ResetFilterButton.Name = "ResetFilterButton";
            this.ResetFilterButton.Size = new System.Drawing.Size(101, 37);
            this.ResetFilterButton.TabIndex = 15;
            this.ResetFilterButton.Text = "RESET FILTER";
            this.ResetFilterButton.UseVisualStyleBackColor = true;
            this.ResetFilterButton.Click += new System.EventHandler(this.ResetFilterButton_Click);
            // 
            // ListLinkButton
            // 
            this.ListLinkButton.Location = new System.Drawing.Point(43, 69);
            this.ListLinkButton.Name = "ListLinkButton";
            this.ListLinkButton.Size = new System.Drawing.Size(235, 37);
            this.ListLinkButton.TabIndex = 16;
            this.ListLinkButton.Text = "OPEN UPDATED LIST LINK";
            this.ListLinkButton.UseVisualStyleBackColor = true;
            this.ListLinkButton.Click += new System.EventHandler(this.ListLinkButton_Click);
            // 
            // WinsButton
            // 
            this.WinsButton.Location = new System.Drawing.Point(670, 23);
            this.WinsButton.Name = "WinsButton";
            this.WinsButton.Size = new System.Drawing.Size(101, 37);
            this.WinsButton.TabIndex = 17;
            this.WinsButton.Text = "Ordina per Vittorie";
            this.WinsButton.UseVisualStyleBackColor = true;
            this.WinsButton.Click += new System.EventHandler(this.WinsButton_Click);
            // 
            // PoleButton
            // 
            this.PoleButton.Location = new System.Drawing.Point(794, 22);
            this.PoleButton.Name = "PoleButton";
            this.PoleButton.Size = new System.Drawing.Size(101, 37);
            this.PoleButton.TabIndex = 18;
            this.PoleButton.Text = "Ordina per PolePosition";
            this.PoleButton.UseVisualStyleBackColor = true;
            this.PoleButton.Click += new System.EventHandler(this.PoleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Open_data.Properties.Resources.sfondo_bandiera_a_scacchi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 580);
            this.Controls.Add(this.PoleButton);
            this.Controls.Add(this.WinsButton);
            this.Controls.Add(this.ListLinkButton);
            this.Controls.Add(this.ResetFilterButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBoxTrueFalse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NationalityBox);
            this.Controls.Add(this.ListViewPiloti);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ComboBoxPilota);
            this.Controls.Add(this.SearchBoxPilota);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchBoxPilota;
        private System.Windows.Forms.ComboBox ComboBoxPilota;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ListView ListViewPiloti;
        private System.Windows.Forms.TextBox NationalityBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxTrueFalse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ResetFilterButton;
        private System.Windows.Forms.Button ListLinkButton;
        private System.Windows.Forms.Button WinsButton;
        private System.Windows.Forms.Button PoleButton;
    }
}

