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
            this.tabControlOperazioni = new System.Windows.Forms.TabControl();
            this.tabPageAggiungi = new System.Windows.Forms.TabPage();
            this.textBox_Prezzo = new System.Windows.Forms.TextBox();
            this.ComboBox_Categoria = new System.Windows.Forms.ComboBox();
            this.DataTimePicker_Data = new System.Windows.Forms.DateTimePicker();
            this.button_Aggiungi = new System.Windows.Forms.Button();
            this.tabPageVisualizza = new System.Windows.Forms.TabPage();
            this.Visualizza_Spese = new System.Windows.Forms.ListView();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.tabPageImpostazioni = new System.Windows.Forms.TabPage();
            this.tabControlOperazioni.SuspendLayout();
            this.tabPageAggiungi.SuspendLayout();
            this.tabPageVisualizza.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlOperazioni
            // 
            this.tabControlOperazioni.Controls.Add(this.tabPageAggiungi);
            this.tabControlOperazioni.Controls.Add(this.tabPageVisualizza);
            this.tabControlOperazioni.Controls.Add(this.tabPageReport);
            this.tabControlOperazioni.Controls.Add(this.tabPageImpostazioni);
            this.tabControlOperazioni.Location = new System.Drawing.Point(0, 12);
            this.tabControlOperazioni.Name = "tabControlOperazioni";
            this.tabControlOperazioni.SelectedIndex = 0;
            this.tabControlOperazioni.Size = new System.Drawing.Size(1180, 465);
            this.tabControlOperazioni.TabIndex = 1;
            // 
            // tabPageAggiungi
            // 
            this.tabPageAggiungi.Controls.Add(this.textBox_Prezzo);
            this.tabPageAggiungi.Controls.Add(this.ComboBox_Categoria);
            this.tabPageAggiungi.Controls.Add(this.DataTimePicker_Data);
            this.tabPageAggiungi.Controls.Add(this.button_Aggiungi);
            this.tabPageAggiungi.Location = new System.Drawing.Point(4, 25);
            this.tabPageAggiungi.Name = "tabPageAggiungi";
            this.tabPageAggiungi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAggiungi.Size = new System.Drawing.Size(1172, 436);
            this.tabPageAggiungi.TabIndex = 0;
            this.tabPageAggiungi.Text = "Aggiungi Spesa";
            this.tabPageAggiungi.UseVisualStyleBackColor = true;
            // 
            // textBox_Prezzo
            // 
            this.textBox_Prezzo.Location = new System.Drawing.Point(20, 83);
            this.textBox_Prezzo.Name = "textBox_Prezzo";
            this.textBox_Prezzo.Size = new System.Drawing.Size(250, 22);
            this.textBox_Prezzo.TabIndex = 5;
            // 
            // ComboBox_Categoria
            // 
            this.ComboBox_Categoria.FormattingEnabled = true;
            this.ComboBox_Categoria.Location = new System.Drawing.Point(20, 40);
            this.ComboBox_Categoria.Name = "ComboBox_Categoria";
            this.ComboBox_Categoria.Size = new System.Drawing.Size(250, 24);
            this.ComboBox_Categoria.TabIndex = 1;
            // 
            // DataTimePicker_Data
            // 
            this.DataTimePicker_Data.Location = new System.Drawing.Point(20, 123);
            this.DataTimePicker_Data.Name = "DataTimePicker_Data";
            this.DataTimePicker_Data.Size = new System.Drawing.Size(250, 22);
            this.DataTimePicker_Data.TabIndex = 3;
            // 
            // button_Aggiungi
            // 
            this.button_Aggiungi.Location = new System.Drawing.Point(20, 167);
            this.button_Aggiungi.Name = "button_Aggiungi";
            this.button_Aggiungi.Size = new System.Drawing.Size(250, 30);
            this.button_Aggiungi.TabIndex = 4;
            this.button_Aggiungi.Text = "Aggiungi";
            this.button_Aggiungi.UseVisualStyleBackColor = true;
            this.button_Aggiungi.Click += new System.EventHandler(this.button_AggiungiSpesa_Click);
            // 
            // tabPageVisualizza
            // 
            this.tabPageVisualizza.Controls.Add(this.Visualizza_Spese);
            this.tabPageVisualizza.Location = new System.Drawing.Point(4, 25);
            this.tabPageVisualizza.Name = "tabPageVisualizza";
            this.tabPageVisualizza.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVisualizza.Size = new System.Drawing.Size(1172, 436);
            this.tabPageVisualizza.TabIndex = 1;
            this.tabPageVisualizza.Text = "Visualizza Spese";
            this.tabPageVisualizza.UseVisualStyleBackColor = true;
            // 
            // Visualizza_Spese
            // 
            this.Visualizza_Spese.HideSelection = false;
            this.Visualizza_Spese.Location = new System.Drawing.Point(42, 37);
            this.Visualizza_Spese.Name = "Visualizza_Spese";
            this.Visualizza_Spese.Size = new System.Drawing.Size(1098, 373);
            this.Visualizza_Spese.TabIndex = 1;
            this.Visualizza_Spese.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageReport
            // 
            this.tabPageReport.Location = new System.Drawing.Point(4, 25);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport.Size = new System.Drawing.Size(1172, 436);
            this.tabPageReport.TabIndex = 2;
            this.tabPageReport.Text = "Report Mensile";
            this.tabPageReport.UseVisualStyleBackColor = true;
            // 
            // tabPageImpostazioni
            // 
            this.tabPageImpostazioni.Location = new System.Drawing.Point(4, 25);
            this.tabPageImpostazioni.Name = "tabPageImpostazioni";
            this.tabPageImpostazioni.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImpostazioni.Size = new System.Drawing.Size(1172, 436);
            this.tabPageImpostazioni.TabIndex = 3;
            this.tabPageImpostazioni.Text = "Impostazioni";
            this.tabPageImpostazioni.UseVisualStyleBackColor = true;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 495);
            this.Controls.Add(this.tabControlOperazioni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControlOperazioni.ResumeLayout(false);
            this.tabPageAggiungi.ResumeLayout(false);
            this.tabPageAggiungi.PerformLayout();
            this.tabPageVisualizza.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlOperazioni;
        private System.Windows.Forms.TabPage tabPageAggiungi;
        private System.Windows.Forms.TabPage tabPageVisualizza;
        private System.Windows.Forms.TabPage tabPageReport;
        private System.Windows.Forms.TabPage tabPageImpostazioni;
        private System.Windows.Forms.ComboBox ComboBox_Categoria;
        private System.Windows.Forms.DateTimePicker DataTimePicker_Data;
        private System.Windows.Forms.Button button_Aggiungi;
        private System.Windows.Forms.TextBox textBox_Prezzo;
        private System.Windows.Forms.ListView Visualizza_Spese;
    }
}