namespace Progetto_Dell_Anno_2024_25
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aggiungitoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impostazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlCategorie = new System.Windows.Forms.TabControl();
            this.tabPageAggiungi = new System.Windows.Forms.TabPage();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.nudImporto = new System.Windows.Forms.NumericUpDown();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnAggiungiSpesa = new System.Windows.Forms.Button();
            this.tabPageVisualizza = new System.Windows.Forms.TabPage();
            this.dgvSpese = new System.Windows.Forms.DataGridView();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.tabPageImpostazioni = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControlCategorie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpese)).BeginInit();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.aggiungitoolStripMenuItem1,
                this.visualizzaToolStripMenuItem,
                this.reportToolStripMenuItem,
                this.impostazioniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1180, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // aggiungitoolStripMenuItem1
            this.aggiungitoolStripMenuItem1.Name = "aggiungitoolStripMenuItem1";
            this.aggiungitoolStripMenuItem1.Size = new System.Drawing.Size(84, 24);
            this.aggiungitoolStripMenuItem1.Text = "Aggiungi";
            this.aggiungitoolStripMenuItem1.Click += new System.EventHandler(this.aggiungitoolStripMenuItem1_Click);

            // visualizzaToolStripMenuItem
            this.visualizzaToolStripMenuItem.Name = "visualizzaToolStripMenuItem";
            this.visualizzaToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.visualizzaToolStripMenuItem.Text = "Visualizza";
            this.visualizzaToolStripMenuItem.Click += new System.EventHandler(this.visualizzaToolStripMenuItem_Click);

            // reportToolStripMenuItem
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);

            // impostazioniToolStripMenuItem
            this.impostazioniToolStripMenuItem.Name = "impostazioniToolStripMenuItem";
            this.impostazioniToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.impostazioniToolStripMenuItem.Text = "Impostazioni";
            this.impostazioniToolStripMenuItem.Click += new System.EventHandler(this.impostazioniToolStripMenuItem_Click);

            // tabControlCategorie
            this.tabControlCategorie.Controls.Add(this.tabPageAggiungi);
            this.tabControlCategorie.Controls.Add(this.tabPageVisualizza);
            this.tabControlCategorie.Controls.Add(this.tabPageReport);
            this.tabControlCategorie.Controls.Add(this.tabPageImpostazioni);
            this.tabControlCategorie.Location = new System.Drawing.Point(0, 28);
            this.tabControlCategorie.Name = "tabControlCategorie";
            this.tabControlCategorie.SelectedIndex = 0;
            this.tabControlCategorie.Size = new System.Drawing.Size(1180, 465);
            this.tabControlCategorie.TabIndex = 1;
            this.tabControlCategorie.Visible = false;

            // tabPageAggiungi
            this.tabPageAggiungi.Controls.Add(this.txtDescrizione);
            this.tabPageAggiungi.Controls.Add(this.cmbCategoria);
            this.tabPageAggiungi.Controls.Add(this.nudImporto);
            this.tabPageAggiungi.Controls.Add(this.dtpData);
            this.tabPageAggiungi.Controls.Add(this.btnAggiungiSpesa);
            this.tabPageAggiungi.Location = new System.Drawing.Point(4, 25);
            this.tabPageAggiungi.Name = "tabPageAggiungi";
            this.tabPageAggiungi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAggiungi.Size = new System.Drawing.Size(1172, 436);
            this.tabPageAggiungi.TabIndex = 0;
            this.tabPageAggiungi.Text = "Aggiungi Spesa";
            this.tabPageAggiungi.UseVisualStyleBackColor = true;

            // txtDescrizione
            this.txtDescrizione.Location = new System.Drawing.Point(20, 20);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(250, 22);
            this.txtDescrizione.TabIndex = 0;

            // cmbCategoria
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(20, 60);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(250, 24);
            this.cmbCategoria.TabIndex = 1;

            // nudImporto
            this.nudImporto.Location = new System.Drawing.Point(20, 100);
            this.nudImporto.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudImporto.Name = "nudImporto";
            this.nudImporto.Size = new System.Drawing.Size(250, 22);
            this.nudImporto.TabIndex = 2;

            // dtpData
            this.dtpData.Location = new System.Drawing.Point(20, 140);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(250, 22);
            this.dtpData.TabIndex = 3;

            // btnAggiungiSpesa
            this.btnAggiungiSpesa.Location = new System.Drawing.Point(20, 180);
            this.btnAggiungiSpesa.Name = "btnAggiungiSpesa";
            this.btnAggiungiSpesa.Size = new System.Drawing.Size(250, 30);
            this.btnAggiungiSpesa.TabIndex = 4;
            this.btnAggiungiSpesa.Text = "Aggiungi Spesa";
            this.btnAggiungiSpesa.UseVisualStyleBackColor = true;
            this.btnAggiungiSpesa.Click += new System.EventHandler(this.btnAggiungiSpesa_Click);

            // tabPageVisualizza
            this.tabPageVisualizza.Controls.Add(this.dgvSpese);
            this.tabPageVisualizza.Location = new System.Drawing.Point(4, 25);
            this.tabPageVisualizza.Name = "tabPageVisualizza";
            this.tabPageVisualizza.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVisualizza.Size = new System.Drawing.Size(1172, 436);
            this.tabPageVisualizza.TabIndex = 1;
            this.tabPageVisualizza.Text = "Visualizza Spese";
            this.tabPageVisualizza.UseVisualStyleBackColor = true;

            // dgvSpese
            this.dgvSpese.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpese.Location = new System.Drawing.Point(6, 6);
            this.dgvSpese.Name = "dgvSpese";
            this.dgvSpese.RowHeadersWidth = 51;
            this.dgvSpese.RowTemplate.Height = 24;
            this.dgvSpese.Size = new System.Drawing.Size(1160, 424);
            this.dgvSpese.TabIndex = 0;

            // tabPageReport
            this.tabPageReport.Location = new System.Drawing.Point(4, 25);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport.Size = new System.Drawing.Size(1172, 436);
            this.tabPageReport.TabIndex = 2;
            this.tabPageReport.Text = "Report Mensile";
            this.tabPageReport.UseVisualStyleBackColor = true;

            // tabPageImpostazioni
            this.tabPageImpostazioni.Location = new System.Drawing.Point(4, 25);
            this.tabPageImpostazioni.Name = "tabPageImpostazioni";
            this.tabPageImpostazioni.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImpostazioni.Size = new System.Drawing.Size(1172, 436);
            this.tabPageImpostazioni.TabIndex = 3;
            this.tabPageImpostazioni.Text = "Impostazioni";
            this.tabPageImpostazioni.UseVisualStyleBackColor = true;

            // DashBoard
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 495);
            this.Controls.Add(this.tabControlCategorie);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlCategorie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudImporto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpese)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aggiungitoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem visualizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impostazioniToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlCategorie;
        private System.Windows.Forms.TabPage tabPageAggiungi;
        private System.Windows.Forms.TabPage tabPageVisualizza;
        private System.Windows.Forms.TabPage tabPageReport;
        private System.Windows.Forms.TabPage tabPageImpostazioni;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.NumericUpDown nudImporto;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnAggiungiSpesa;
        private System.Windows.Forms.DataGridView dgvSpese;
    }
}