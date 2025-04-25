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
            this.tabPageImpostazioni = new System.Windows.Forms.TabPage();
            this.label_ImpostaBudget = new System.Windows.Forms.Label();
            this.textBox_Budget = new System.Windows.Forms.TextBox();
            this.button_ImpostaBudget = new System.Windows.Forms.Button();
            this.tabPageAggiungi = new System.Windows.Forms.TabPage();
            this.label_Aggiungi = new System.Windows.Forms.Label();
            this.textBox_Prezzo = new System.Windows.Forms.TextBox();
            this.ComboBox_Categoria = new System.Windows.Forms.ComboBox();
            this.DataTimePicker_Data = new System.Windows.Forms.DateTimePicker();
            this.button_Aggiungi = new System.Windows.Forms.Button();
            this.tabPageVisualizza = new System.Windows.Forms.TabPage();
            this.label_Budget = new System.Windows.Forms.Label();
            this.button_EliminaSpesa = new System.Windows.Forms.Button();
            this.button_ModificaSpesa = new System.Windows.Forms.Button();
            this.button_OrdinaPerData = new System.Windows.Forms.Button();
            this.label_Visualizza = new System.Windows.Forms.Label();
            this.Visualizza_Spese = new System.Windows.Forms.ListView();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.button_ScaricaReport = new System.Windows.Forms.Button();
            this.label_Report = new System.Windows.Forms.Label();
            this.comboBox_Mesi = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_CambioTema = new System.Windows.Forms.ToolStripComboBox();
            this.textBox_Importo = new System.Windows.Forms.TextBox();
            this.comboBox_Categorie = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Data = new System.Windows.Forms.DateTimePicker();
            this.tabControlOperazioni.SuspendLayout();
            this.tabPageImpostazioni.SuspendLayout();
            this.tabPageAggiungi.SuspendLayout();
            this.tabPageVisualizza.SuspendLayout();
            this.tabPageReport.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlOperazioni
            // 
            this.tabControlOperazioni.Controls.Add(this.tabPageImpostazioni);
            this.tabControlOperazioni.Controls.Add(this.tabPageAggiungi);
            this.tabControlOperazioni.Controls.Add(this.tabPageVisualizza);
            this.tabControlOperazioni.Controls.Add(this.tabPageReport);
            this.tabControlOperazioni.Location = new System.Drawing.Point(0, 27);
            this.tabControlOperazioni.Name = "tabControlOperazioni";
            this.tabControlOperazioni.SelectedIndex = 0;
            this.tabControlOperazioni.Size = new System.Drawing.Size(2100, 1000);
            this.tabControlOperazioni.TabIndex = 1;
            // 
            // tabPageImpostazioni
            // 
            this.tabPageImpostazioni.Controls.Add(this.label_ImpostaBudget);
            this.tabPageImpostazioni.Controls.Add(this.textBox_Budget);
            this.tabPageImpostazioni.Controls.Add(this.button_ImpostaBudget);
            this.tabPageImpostazioni.Location = new System.Drawing.Point(4, 25);
            this.tabPageImpostazioni.Name = "tabPageImpostazioni";
            this.tabPageImpostazioni.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImpostazioni.Size = new System.Drawing.Size(2092, 971);
            this.tabPageImpostazioni.TabIndex = 3;
            this.tabPageImpostazioni.Text = "Imposta Budget";
            this.tabPageImpostazioni.UseVisualStyleBackColor = true;
            // 
            // label_ImpostaBudget
            // 
            this.label_ImpostaBudget.AutoSize = true;
            this.label_ImpostaBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ImpostaBudget.Location = new System.Drawing.Point(969, 233);
            this.label_ImpostaBudget.Name = "label_ImpostaBudget";
            this.label_ImpostaBudget.Size = new System.Drawing.Size(179, 20);
            this.label_ImpostaBudget.TabIndex = 4;
            this.label_ImpostaBudget.Text = "IMPOSTA BUDGET:";
            // 
            // textBox_Budget
            // 
            this.textBox_Budget.Location = new System.Drawing.Point(1003, 275);
            this.textBox_Budget.Name = "textBox_Budget";
            this.textBox_Budget.Size = new System.Drawing.Size(100, 22);
            this.textBox_Budget.TabIndex = 1;
            // 
            // button_ImpostaBudget
            // 
            this.button_ImpostaBudget.Location = new System.Drawing.Point(1003, 324);
            this.button_ImpostaBudget.Name = "button_ImpostaBudget";
            this.button_ImpostaBudget.Size = new System.Drawing.Size(100, 54);
            this.button_ImpostaBudget.TabIndex = 0;
            this.button_ImpostaBudget.Text = "IMPOSTA BUDGET";
            this.button_ImpostaBudget.UseVisualStyleBackColor = true;
            this.button_ImpostaBudget.Click += new System.EventHandler(this.button_ImpostaBudget_Click);
            // 
            // tabPageAggiungi
            // 
            this.tabPageAggiungi.Controls.Add(this.label_Aggiungi);
            this.tabPageAggiungi.Controls.Add(this.textBox_Prezzo);
            this.tabPageAggiungi.Controls.Add(this.ComboBox_Categoria);
            this.tabPageAggiungi.Controls.Add(this.DataTimePicker_Data);
            this.tabPageAggiungi.Controls.Add(this.button_Aggiungi);
            this.tabPageAggiungi.Location = new System.Drawing.Point(4, 25);
            this.tabPageAggiungi.Name = "tabPageAggiungi";
            this.tabPageAggiungi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAggiungi.Size = new System.Drawing.Size(2092, 971);
            this.tabPageAggiungi.TabIndex = 0;
            this.tabPageAggiungi.Text = "Aggiungi Spesa";
            this.tabPageAggiungi.UseVisualStyleBackColor = true;
            // 
            // label_Aggiungi
            // 
            this.label_Aggiungi.AutoSize = true;
            this.label_Aggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Aggiungi.Location = new System.Drawing.Point(921, 205);
            this.label_Aggiungi.Name = "label_Aggiungi";
            this.label_Aggiungi.Size = new System.Drawing.Size(236, 24);
            this.label_Aggiungi.TabIndex = 6;
            this.label_Aggiungi.Text = "AGGIUNGI UNA SPESA:\r\n";
            // 
            // textBox_Prezzo
            // 
            this.textBox_Prezzo.Location = new System.Drawing.Point(914, 301);
            this.textBox_Prezzo.Name = "textBox_Prezzo";
            this.textBox_Prezzo.Size = new System.Drawing.Size(250, 22);
            this.textBox_Prezzo.TabIndex = 5;
            // 
            // ComboBox_Categoria
            // 
            this.ComboBox_Categoria.FormattingEnabled = true;
            this.ComboBox_Categoria.Location = new System.Drawing.Point(914, 258);
            this.ComboBox_Categoria.Name = "ComboBox_Categoria";
            this.ComboBox_Categoria.Size = new System.Drawing.Size(250, 24);
            this.ComboBox_Categoria.TabIndex = 1;
            // 
            // DataTimePicker_Data
            // 
            this.DataTimePicker_Data.Location = new System.Drawing.Point(914, 341);
            this.DataTimePicker_Data.Name = "DataTimePicker_Data";
            this.DataTimePicker_Data.Size = new System.Drawing.Size(250, 22);
            this.DataTimePicker_Data.TabIndex = 3;
            // 
            // button_Aggiungi
            // 
            this.button_Aggiungi.Location = new System.Drawing.Point(914, 385);
            this.button_Aggiungi.Name = "button_Aggiungi";
            this.button_Aggiungi.Size = new System.Drawing.Size(250, 30);
            this.button_Aggiungi.TabIndex = 4;
            this.button_Aggiungi.Text = "AGGIUNGI";
            this.button_Aggiungi.UseVisualStyleBackColor = true;
            this.button_Aggiungi.Click += new System.EventHandler(this.button_AggiungiSpesa_Click);
            // 
            // tabPageVisualizza
            // 
            this.tabPageVisualizza.Controls.Add(this.textBox_Importo);
            this.tabPageVisualizza.Controls.Add(this.comboBox_Categorie);
            this.tabPageVisualizza.Controls.Add(this.dateTimePicker_Data);
            this.tabPageVisualizza.Controls.Add(this.label_Budget);
            this.tabPageVisualizza.Controls.Add(this.button_EliminaSpesa);
            this.tabPageVisualizza.Controls.Add(this.button_ModificaSpesa);
            this.tabPageVisualizza.Controls.Add(this.button_OrdinaPerData);
            this.tabPageVisualizza.Controls.Add(this.label_Visualizza);
            this.tabPageVisualizza.Controls.Add(this.Visualizza_Spese);
            this.tabPageVisualizza.Location = new System.Drawing.Point(4, 25);
            this.tabPageVisualizza.Name = "tabPageVisualizza";
            this.tabPageVisualizza.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVisualizza.Size = new System.Drawing.Size(2092, 971);
            this.tabPageVisualizza.TabIndex = 1;
            this.tabPageVisualizza.Text = "Visualizza Spese";
            this.tabPageVisualizza.UseVisualStyleBackColor = true;
            // 
            // label_Budget
            // 
            this.label_Budget.AutoSize = true;
            this.label_Budget.Location = new System.Drawing.Point(1326, 181);
            this.label_Budget.Name = "label_Budget";
            this.label_Budget.Size = new System.Drawing.Size(105, 17);
            this.label_Budget.TabIndex = 9;
            this.label_Budget.Text = "Nessun Budget";
            // 
            // button_EliminaSpesa
            // 
            this.button_EliminaSpesa.Enabled = false;
            this.button_EliminaSpesa.Location = new System.Drawing.Point(496, 304);
            this.button_EliminaSpesa.Name = "button_EliminaSpesa";
            this.button_EliminaSpesa.Size = new System.Drawing.Size(153, 48);
            this.button_EliminaSpesa.TabIndex = 8;
            this.button_EliminaSpesa.Text = "ELIMINA SPESA";
            this.button_EliminaSpesa.UseVisualStyleBackColor = true;
            this.button_EliminaSpesa.Click += new System.EventHandler(this.button_EliminaSpesa_Click);
            // 
            // button_ModificaSpesa
            // 
            this.button_ModificaSpesa.Enabled = false;
            this.button_ModificaSpesa.Location = new System.Drawing.Point(112, 358);
            this.button_ModificaSpesa.Name = "button_ModificaSpesa";
            this.button_ModificaSpesa.Size = new System.Drawing.Size(153, 48);
            this.button_ModificaSpesa.TabIndex = 7;
            this.button_ModificaSpesa.Text = "MODIFICA SPESA";
            this.button_ModificaSpesa.UseVisualStyleBackColor = true;
            this.button_ModificaSpesa.Click += new System.EventHandler(this.button_ModificaSpesa_Click);
            // 
            // button_OrdinaPerData
            // 
            this.button_OrdinaPerData.Enabled = false;
            this.button_OrdinaPerData.Location = new System.Drawing.Point(496, 210);
            this.button_OrdinaPerData.Name = "button_OrdinaPerData";
            this.button_OrdinaPerData.Size = new System.Drawing.Size(153, 45);
            this.button_OrdinaPerData.TabIndex = 6;
            this.button_OrdinaPerData.Text = "ORDINA PER DATA";
            this.button_OrdinaPerData.UseVisualStyleBackColor = true;
            this.button_OrdinaPerData.Click += new System.EventHandler(this.button_OrdinaPerData_Click);
            // 
            // label_Visualizza
            // 
            this.label_Visualizza.AutoSize = true;
            this.label_Visualizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Visualizza.Location = new System.Drawing.Point(575, 58);
            this.label_Visualizza.Name = "label_Visualizza";
            this.label_Visualizza.Size = new System.Drawing.Size(843, 38);
            this.label_Visualizza.TabIndex = 5;
            this.label_Visualizza.Text = "VISUALIZZA TUTTE LE SPESE CHE HAI INSERITO:";
            // 
            // Visualizza_Spese
            // 
            this.Visualizza_Spese.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Visualizza_Spese.HideSelection = false;
            this.Visualizza_Spese.Location = new System.Drawing.Point(774, 159);
            this.Visualizza_Spese.Name = "Visualizza_Spese";
            this.Visualizza_Spese.Size = new System.Drawing.Size(501, 373);
            this.Visualizza_Spese.TabIndex = 1;
            this.Visualizza_Spese.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageReport
            // 
            this.tabPageReport.Controls.Add(this.button_ScaricaReport);
            this.tabPageReport.Controls.Add(this.label_Report);
            this.tabPageReport.Controls.Add(this.comboBox_Mesi);
            this.tabPageReport.Location = new System.Drawing.Point(4, 25);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport.Size = new System.Drawing.Size(2092, 971);
            this.tabPageReport.TabIndex = 2;
            this.tabPageReport.Text = "Report Mensile";
            this.tabPageReport.UseVisualStyleBackColor = true;
            // 
            // button_ScaricaReport
            // 
            this.button_ScaricaReport.Location = new System.Drawing.Point(938, 333);
            this.button_ScaricaReport.Name = "button_ScaricaReport";
            this.button_ScaricaReport.Size = new System.Drawing.Size(144, 23);
            this.button_ScaricaReport.TabIndex = 6;
            this.button_ScaricaReport.Text = "SCARICA REPORT";
            this.button_ScaricaReport.UseVisualStyleBackColor = true;
            this.button_ScaricaReport.Click += new System.EventHandler(this.button_ScaricaReport_Click);
            // 
            // label_Report
            // 
            this.label_Report.AutoSize = true;
            this.label_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Bold);
            this.label_Report.Location = new System.Drawing.Point(695, 224);
            this.label_Report.Name = "label_Report";
            this.label_Report.Size = new System.Drawing.Size(645, 25);
            this.label_Report.TabIndex = 5;
            this.label_Report.Text = "SELEZIONA IL MESE DEL REPORT CHE VUOI SCARICARE:";
            // 
            // comboBox_Mesi
            // 
            this.comboBox_Mesi.FormattingEnabled = true;
            this.comboBox_Mesi.Location = new System.Drawing.Point(882, 282);
            this.comboBox_Mesi.Name = "comboBox_Mesi";
            this.comboBox_Mesi.Size = new System.Drawing.Size(250, 24);
            this.comboBox_Mesi.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1680, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_CambioTema});
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.toolStripMenuItem.Text = "Imposta Tema";
            // 
            // toolStripComboBox_CambioTema
            // 
            this.toolStripComboBox_CambioTema.Name = "toolStripComboBox_CambioTema";
            this.toolStripComboBox_CambioTema.Size = new System.Drawing.Size(121, 28);
            // 
            // textBox_Importo
            // 
            this.textBox_Importo.Enabled = false;
            this.textBox_Importo.Location = new System.Drawing.Point(112, 264);
            this.textBox_Importo.Name = "textBox_Importo";
            this.textBox_Importo.Size = new System.Drawing.Size(250, 22);
            this.textBox_Importo.TabIndex = 12;
            // 
            // comboBox_Categorie
            // 
            this.comboBox_Categorie.Enabled = false;
            this.comboBox_Categorie.FormattingEnabled = true;
            this.comboBox_Categorie.Location = new System.Drawing.Point(112, 221);
            this.comboBox_Categorie.Name = "comboBox_Categorie";
            this.comboBox_Categorie.Size = new System.Drawing.Size(250, 24);
            this.comboBox_Categorie.TabIndex = 10;
            // 
            // dateTimePicker_Data
            // 
            this.dateTimePicker_Data.Enabled = false;
            this.dateTimePicker_Data.Location = new System.Drawing.Point(112, 304);
            this.dateTimePicker_Data.Name = "dateTimePicker_Data";
            this.dateTimePicker_Data.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker_Data.TabIndex = 11;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 624);
            this.Controls.Add(this.tabControlOperazioni);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControlOperazioni.ResumeLayout(false);
            this.tabPageImpostazioni.ResumeLayout(false);
            this.tabPageImpostazioni.PerformLayout();
            this.tabPageAggiungi.ResumeLayout(false);
            this.tabPageAggiungi.PerformLayout();
            this.tabPageVisualizza.ResumeLayout(false);
            this.tabPageVisualizza.PerformLayout();
            this.tabPageReport.ResumeLayout(false);
            this.tabPageReport.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button button_ImpostaBudget;
        private System.Windows.Forms.TextBox textBox_Budget;
        private System.Windows.Forms.Label label_ImpostaBudget;
        private System.Windows.Forms.Label label_Visualizza;
        private System.Windows.Forms.Label label_Aggiungi;
        private System.Windows.Forms.Label label_Report;
        private System.Windows.Forms.ComboBox comboBox_Mesi;
        private System.Windows.Forms.Button button_ScaricaReport;
        private System.Windows.Forms.Button button_OrdinaPerData;
        private System.Windows.Forms.Button button_EliminaSpesa;
        private System.Windows.Forms.Button button_ModificaSpesa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_CambioTema;
        private System.Windows.Forms.Label label_Budget;
        private System.Windows.Forms.TextBox textBox_Importo;
        private System.Windows.Forms.ComboBox comboBox_Categorie;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Data;
    }
}