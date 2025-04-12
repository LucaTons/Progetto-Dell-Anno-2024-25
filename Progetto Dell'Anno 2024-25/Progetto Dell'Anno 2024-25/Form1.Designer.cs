
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
            this.tabPageSpesa = new System.Windows.Forms.TabPage();
            this.tabPageTrasporto = new System.Windows.Forms.TabPage();
            this.tabPageVisite = new System.Windows.Forms.TabPage();
            this.tabPageSvago = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControlCategorie.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
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
            // 
            // aggiungitoolStripMenuItem1
            // 
            this.aggiungitoolStripMenuItem1.Name = "aggiungitoolStripMenuItem1";
            this.aggiungitoolStripMenuItem1.Size = new System.Drawing.Size(84, 24);
            this.aggiungitoolStripMenuItem1.Text = "Aggiungi";
            this.aggiungitoolStripMenuItem1.Click += new System.EventHandler(this.aggiungitoolStripMenuItem1_Click);
            // 
            // visualizzaToolStripMenuItem
            // 
            this.visualizzaToolStripMenuItem.Name = "visualizzaToolStripMenuItem";
            this.visualizzaToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.visualizzaToolStripMenuItem.Text = "Visualizza";
            this.visualizzaToolStripMenuItem.Click += new System.EventHandler(this.visualizzaToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // impostazioniToolStripMenuItem
            // 
            this.impostazioniToolStripMenuItem.Name = "impostazioniToolStripMenuItem";
            this.impostazioniToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.impostazioniToolStripMenuItem.Text = "Impostazioni";
            this.impostazioniToolStripMenuItem.Click += new System.EventHandler(this.impostazioniToolStripMenuItem_Click);
            // 
            // tabControlCategorie
            // 
            this.tabControlCategorie.Controls.Add(this.tabPageSpesa);
            this.tabControlCategorie.Controls.Add(this.tabPageTrasporto);
            this.tabControlCategorie.Controls.Add(this.tabPageVisite);
            this.tabControlCategorie.Controls.Add(this.tabPageSvago);
            this.tabControlCategorie.Location = new System.Drawing.Point(0, 28);
            this.tabControlCategorie.Name = "tabControlCategorie";
            this.tabControlCategorie.SelectedIndex = 0;
            this.tabControlCategorie.Size = new System.Drawing.Size(1180, 465);
            this.tabControlCategorie.TabIndex = 1;
            this.tabControlCategorie.Visible = false;
            // 
            // tabPageSpesa
            // 
            this.tabPageSpesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageSpesa.Location = new System.Drawing.Point(4, 25);
            this.tabPageSpesa.Name = "tabPageSpesa";
            this.tabPageSpesa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpesa.Size = new System.Drawing.Size(1172, 436);
            this.tabPageSpesa.TabIndex = 0;
            this.tabPageSpesa.Text = "Spesa";
            this.tabPageSpesa.UseVisualStyleBackColor = true;
            // 
            // tabPageTrasporto
            // 
            this.tabPageTrasporto.Location = new System.Drawing.Point(4, 25);
            this.tabPageTrasporto.Name = "tabPageTrasporto";
            this.tabPageTrasporto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTrasporto.Size = new System.Drawing.Size(1172, 436);
            this.tabPageTrasporto.TabIndex = 1;
            this.tabPageTrasporto.Text = "Trasporto";
            this.tabPageTrasporto.UseVisualStyleBackColor = true;
            // 
            // tabPageVisite
            // 
            this.tabPageVisite.Location = new System.Drawing.Point(4, 25);
            this.tabPageVisite.Name = "tabPageVisite";
            this.tabPageVisite.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVisite.Size = new System.Drawing.Size(1172, 436);
            this.tabPageVisite.TabIndex = 2;
            this.tabPageVisite.Text = "Visite";
            this.tabPageVisite.UseVisualStyleBackColor = true;
            // 
            // tabPageSvago
            // 
            this.tabPageSvago.Location = new System.Drawing.Point(4, 25);
            this.tabPageSvago.Name = "tabPageSvago";
            this.tabPageSvago.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSvago.Size = new System.Drawing.Size(1172, 436);
            this.tabPageSvago.TabIndex = 3;
            this.tabPageSvago.Text = "Svago";
            this.tabPageSvago.UseVisualStyleBackColor = true;
            // 
            // DashBoard
            // 
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControlCategorie;
        private System.Windows.Forms.TabPage tabPageTrasporto;
        private System.Windows.Forms.TabPage tabPageVisite;
        private System.Windows.Forms.TabPage tabPageSvago;
        private System.Windows.Forms.ToolStripMenuItem aggiungitoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem visualizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impostazioniToolStripMenuItem;
        protected System.Windows.Forms.TabPage tabPageSpesa;
    }
}

