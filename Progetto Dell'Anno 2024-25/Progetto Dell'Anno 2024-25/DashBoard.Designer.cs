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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.tabControlOperazioni = new System.Windows.Forms.TabControl();
            this.tabPageImpostazioni = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_MesiBudget = new System.Windows.Forms.ComboBox();
            this.label_ImpostaBudget = new System.Windows.Forms.Label();
            this.textBox_Budget = new System.Windows.Forms.TextBox();
            this.button_ImpostaBudget = new System.Windows.Forms.Button();
            this.tabPageAggiungi = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Aggiungi = new System.Windows.Forms.Label();
            this.textBox_Prezzo = new System.Windows.Forms.TextBox();
            this.ComboBox_Categoria = new System.Windows.Forms.ComboBox();
            this.DataTimePicker_Data = new System.Windows.Forms.DateTimePicker();
            this.button_Aggiungi = new System.Windows.Forms.Button();
            this.tabPageVisualizza = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_RimanentePerdita = new System.Windows.Forms.Label();
            this.textBox_Importo = new System.Windows.Forms.TextBox();
            this.comboBox_Categorie = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Data = new System.Windows.Forms.DateTimePicker();
            this.label_Budget = new System.Windows.Forms.Label();
            this.button_EliminaSpesa = new System.Windows.Forms.Button();
            this.button_ModificaSpesa = new System.Windows.Forms.Button();
            this.button_OrdinaPerData = new System.Windows.Forms.Button();
            this.label_Visualizza = new System.Windows.Forms.Label();
            this.Visualizza_Spese = new System.Windows.Forms.ListView();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_RimanenzaPerditaReportMensile = new System.Windows.Forms.Label();
            this.label_BudgetReportMensile = new System.Windows.Forms.Label();
            this.label_TotaleReportMese = new System.Windows.Forms.Label();
            this.button_EliminaReportMensile = new System.Windows.Forms.Button();
            this.button_ModificaReportMensile = new System.Windows.Forms.Button();
            this.textBox_ReportMensile = new System.Windows.Forms.TextBox();
            this.comboBox_CategorieReportMensile = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_DataReportMensile = new System.Windows.Forms.DateTimePicker();
            this.listView_ReportMensile = new System.Windows.Forms.ListView();
            this.button_ScaricaReportMensile = new System.Windows.Forms.Button();
            this.label_Report = new System.Windows.Forms.Label();
            this.comboBox_Mesi = new System.Windows.Forms.ComboBox();
            this.tabPage_ReportAnnuale = new System.Windows.Forms.TabPage();
            this.button_ScaricaReportAnnuale = new System.Windows.Forms.Button();
            this.label_SaldoAnnuale = new System.Windows.Forms.Label();
            this.label_ReportAnnuale = new System.Windows.Forms.Label();
            this.listView_ReportAnnuale = new System.Windows.Forms.ListView();
            this.tabPageGrafici = new System.Windows.Forms.TabPage();
            this.chart_ReportAnnuale = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_CategorieAnnuali = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker_Periodo1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Periodo2 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button_ControllaPeriodo = new System.Windows.Forms.Button();
            this.tabControlOperazioni.SuspendLayout();
            this.tabPageImpostazioni.SuspendLayout();
            this.tabPageAggiungi.SuspendLayout();
            this.tabPageVisualizza.SuspendLayout();
            this.tabPageReport.SuspendLayout();
            this.tabPage_ReportAnnuale.SuspendLayout();
            this.tabPageGrafici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ReportAnnuale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CategorieAnnuali)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlOperazioni
            // 
            this.tabControlOperazioni.Controls.Add(this.tabPageImpostazioni);
            this.tabControlOperazioni.Controls.Add(this.tabPageAggiungi);
            this.tabControlOperazioni.Controls.Add(this.tabPageVisualizza);
            this.tabControlOperazioni.Controls.Add(this.tabPageReport);
            this.tabControlOperazioni.Controls.Add(this.tabPage_ReportAnnuale);
            this.tabControlOperazioni.Controls.Add(this.tabPageGrafici);
            this.tabControlOperazioni.Location = new System.Drawing.Point(0, 27);
            this.tabControlOperazioni.Name = "tabControlOperazioni";
            this.tabControlOperazioni.SelectedIndex = 0;
            this.tabControlOperazioni.Size = new System.Drawing.Size(2100, 1000);
            this.tabControlOperazioni.TabIndex = 1;
            // 
            // tabPageImpostazioni
            // 
            this.tabPageImpostazioni.Controls.Add(this.label2);
            this.tabPageImpostazioni.Controls.Add(this.label1);
            this.tabPageImpostazioni.Controls.Add(this.comboBox_MesiBudget);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(793, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Inserisci importo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(793, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleziona mese";
            // 
            // comboBox_MesiBudget
            // 
            this.comboBox_MesiBudget.FormattingEnabled = true;
            this.comboBox_MesiBudget.Location = new System.Drawing.Point(919, 271);
            this.comboBox_MesiBudget.Name = "comboBox_MesiBudget";
            this.comboBox_MesiBudget.Size = new System.Drawing.Size(281, 24);
            this.comboBox_MesiBudget.TabIndex = 5;
            // 
            // label_ImpostaBudget
            // 
            this.label_ImpostaBudget.AutoSize = true;
            this.label_ImpostaBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ImpostaBudget.Location = new System.Drawing.Point(886, 212);
            this.label_ImpostaBudget.Name = "label_ImpostaBudget";
            this.label_ImpostaBudget.Size = new System.Drawing.Size(335, 38);
            this.label_ImpostaBudget.TabIndex = 4;
            this.label_ImpostaBudget.Text = "IMPOSTA BUDGET:";
            // 
            // textBox_Budget
            // 
            this.textBox_Budget.Location = new System.Drawing.Point(961, 315);
            this.textBox_Budget.Name = "textBox_Budget";
            this.textBox_Budget.Size = new System.Drawing.Size(204, 22);
            this.textBox_Budget.TabIndex = 1;
            // 
            // button_ImpostaBudget
            // 
            this.button_ImpostaBudget.Location = new System.Drawing.Point(981, 359);
            this.button_ImpostaBudget.Name = "button_ImpostaBudget";
            this.button_ImpostaBudget.Size = new System.Drawing.Size(165, 54);
            this.button_ImpostaBudget.TabIndex = 0;
            this.button_ImpostaBudget.Text = "IMPOSTA BUDGET";
            this.button_ImpostaBudget.UseVisualStyleBackColor = true;
            this.button_ImpostaBudget.Click += new System.EventHandler(this.button_ImpostaBudget_Click);
            // 
            // tabPageAggiungi
            // 
            this.tabPageAggiungi.Controls.Add(this.label3);
            this.tabPageAggiungi.Controls.Add(this.label4);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(775, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inserisci importo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(775, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Seleziona categoria";
            // 
            // label_Aggiungi
            // 
            this.label_Aggiungi.AutoSize = true;
            this.label_Aggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Aggiungi.Location = new System.Drawing.Point(830, 196);
            this.label_Aggiungi.Name = "label_Aggiungi";
            this.label_Aggiungi.Size = new System.Drawing.Size(407, 38);
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
            this.button_Aggiungi.Location = new System.Drawing.Point(958, 385);
            this.button_Aggiungi.Name = "button_Aggiungi";
            this.button_Aggiungi.Size = new System.Drawing.Size(170, 61);
            this.button_Aggiungi.TabIndex = 4;
            this.button_Aggiungi.Text = "AGGIUNGI SPESA";
            this.button_Aggiungi.UseVisualStyleBackColor = true;
            this.button_Aggiungi.Click += new System.EventHandler(this.button_AggiungiSpesa_Click);
            // 
            // tabPageVisualizza
            // 
            this.tabPageVisualizza.Controls.Add(this.label5);
            this.tabPageVisualizza.Controls.Add(this.label6);
            this.tabPageVisualizza.Controls.Add(this.label_RimanentePerdita);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Inserisci importo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Seleziona categoria";
            // 
            // label_RimanentePerdita
            // 
            this.label_RimanentePerdita.AutoSize = true;
            this.label_RimanentePerdita.Location = new System.Drawing.Point(1492, 306);
            this.label_RimanentePerdita.Name = "label_RimanentePerdita";
            this.label_RimanentePerdita.Size = new System.Drawing.Size(156, 17);
            this.label_RimanentePerdita.TabIndex = 13;
            this.label_RimanentePerdita.Text = "Nessuna spesa inserita";
            // 
            // textBox_Importo
            // 
            this.textBox_Importo.Enabled = false;
            this.textBox_Importo.Location = new System.Drawing.Point(342, 341);
            this.textBox_Importo.Name = "textBox_Importo";
            this.textBox_Importo.Size = new System.Drawing.Size(250, 22);
            this.textBox_Importo.TabIndex = 12;
            // 
            // comboBox_Categorie
            // 
            this.comboBox_Categorie.Enabled = false;
            this.comboBox_Categorie.FormattingEnabled = true;
            this.comboBox_Categorie.Location = new System.Drawing.Point(342, 298);
            this.comboBox_Categorie.Name = "comboBox_Categorie";
            this.comboBox_Categorie.Size = new System.Drawing.Size(250, 24);
            this.comboBox_Categorie.TabIndex = 10;
            // 
            // dateTimePicker_Data
            // 
            this.dateTimePicker_Data.Enabled = false;
            this.dateTimePicker_Data.Location = new System.Drawing.Point(342, 381);
            this.dateTimePicker_Data.Name = "dateTimePicker_Data";
            this.dateTimePicker_Data.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker_Data.TabIndex = 11;
            // 
            // label_Budget
            // 
            this.label_Budget.AutoSize = true;
            this.label_Budget.Location = new System.Drawing.Point(1492, 266);
            this.label_Budget.Name = "label_Budget";
            this.label_Budget.Size = new System.Drawing.Size(105, 17);
            this.label_Budget.TabIndex = 9;
            this.label_Budget.Text = "Nessun Budget";
            // 
            // button_EliminaSpesa
            // 
            this.button_EliminaSpesa.Enabled = false;
            this.button_EliminaSpesa.Location = new System.Drawing.Point(662, 389);
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
            this.button_ModificaSpesa.Location = new System.Drawing.Point(342, 435);
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
            this.button_OrdinaPerData.Location = new System.Drawing.Point(662, 295);
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
            this.label_Visualizza.Location = new System.Drawing.Point(713, 143);
            this.label_Visualizza.Name = "label_Visualizza";
            this.label_Visualizza.Size = new System.Drawing.Size(935, 38);
            this.label_Visualizza.TabIndex = 5;
            this.label_Visualizza.Text = "RIEPILOGO DELLE SPESE INSERITE DI QUESTO MESE:";
            // 
            // Visualizza_Spese
            // 
            this.Visualizza_Spese.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Visualizza_Spese.HideSelection = false;
            this.Visualizza_Spese.Location = new System.Drawing.Point(940, 244);
            this.Visualizza_Spese.Name = "Visualizza_Spese";
            this.Visualizza_Spese.Size = new System.Drawing.Size(501, 373);
            this.Visualizza_Spese.TabIndex = 1;
            this.Visualizza_Spese.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageReport
            // 
            this.tabPageReport.Controls.Add(this.label9);
            this.tabPageReport.Controls.Add(this.label7);
            this.tabPageReport.Controls.Add(this.label8);
            this.tabPageReport.Controls.Add(this.label_RimanenzaPerditaReportMensile);
            this.tabPageReport.Controls.Add(this.label_BudgetReportMensile);
            this.tabPageReport.Controls.Add(this.label_TotaleReportMese);
            this.tabPageReport.Controls.Add(this.button_EliminaReportMensile);
            this.tabPageReport.Controls.Add(this.button_ModificaReportMensile);
            this.tabPageReport.Controls.Add(this.textBox_ReportMensile);
            this.tabPageReport.Controls.Add(this.comboBox_CategorieReportMensile);
            this.tabPageReport.Controls.Add(this.dateTimePicker_DataReportMensile);
            this.tabPageReport.Controls.Add(this.listView_ReportMensile);
            this.tabPageReport.Controls.Add(this.button_ScaricaReportMensile);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(810, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Seleziona mese";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Inserisci importo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Seleziona categoria";
            // 
            // label_RimanenzaPerditaReportMensile
            // 
            this.label_RimanenzaPerditaReportMensile.AutoSize = true;
            this.label_RimanenzaPerditaReportMensile.Location = new System.Drawing.Point(1362, 335);
            this.label_RimanenzaPerditaReportMensile.Name = "label_RimanenzaPerditaReportMensile";
            this.label_RimanenzaPerditaReportMensile.Size = new System.Drawing.Size(159, 17);
            this.label_RimanenzaPerditaReportMensile.TabIndex = 21;
            this.label_RimanenzaPerditaReportMensile.Text = "Nessuna spesa inserita!";
            // 
            // label_BudgetReportMensile
            // 
            this.label_BudgetReportMensile.AutoSize = true;
            this.label_BudgetReportMensile.Location = new System.Drawing.Point(1362, 244);
            this.label_BudgetReportMensile.Name = "label_BudgetReportMensile";
            this.label_BudgetReportMensile.Size = new System.Drawing.Size(108, 17);
            this.label_BudgetReportMensile.TabIndex = 20;
            this.label_BudgetReportMensile.Text = "Nessun Budget!";
            // 
            // label_TotaleReportMese
            // 
            this.label_TotaleReportMese.AutoSize = true;
            this.label_TotaleReportMese.Location = new System.Drawing.Point(1362, 289);
            this.label_TotaleReportMese.Name = "label_TotaleReportMese";
            this.label_TotaleReportMese.Size = new System.Drawing.Size(173, 17);
            this.label_TotaleReportMese.TabIndex = 19;
            this.label_TotaleReportMese.Text = "Nessun mese selezionato!";
            // 
            // button_EliminaReportMensile
            // 
            this.button_EliminaReportMensile.Location = new System.Drawing.Point(525, 392);
            this.button_EliminaReportMensile.Name = "button_EliminaReportMensile";
            this.button_EliminaReportMensile.Size = new System.Drawing.Size(120, 48);
            this.button_EliminaReportMensile.TabIndex = 18;
            this.button_EliminaReportMensile.Text = "ELIMINA";
            this.button_EliminaReportMensile.UseVisualStyleBackColor = true;
            this.button_EliminaReportMensile.Click += new System.EventHandler(this.button_EliminaReportMensile_Click);
            // 
            // button_ModificaReportMensile
            // 
            this.button_ModificaReportMensile.Location = new System.Drawing.Point(395, 392);
            this.button_ModificaReportMensile.Name = "button_ModificaReportMensile";
            this.button_ModificaReportMensile.Size = new System.Drawing.Size(112, 48);
            this.button_ModificaReportMensile.TabIndex = 17;
            this.button_ModificaReportMensile.Text = "MODIFICA";
            this.button_ModificaReportMensile.UseVisualStyleBackColor = true;
            this.button_ModificaReportMensile.Click += new System.EventHandler(this.button_ModificaReportMensile_Click);
            // 
            // textBox_ReportMensile
            // 
            this.textBox_ReportMensile.Location = new System.Drawing.Point(395, 309);
            this.textBox_ReportMensile.Name = "textBox_ReportMensile";
            this.textBox_ReportMensile.Size = new System.Drawing.Size(250, 22);
            this.textBox_ReportMensile.TabIndex = 16;
            // 
            // comboBox_CategorieReportMensile
            // 
            this.comboBox_CategorieReportMensile.FormattingEnabled = true;
            this.comboBox_CategorieReportMensile.Location = new System.Drawing.Point(395, 266);
            this.comboBox_CategorieReportMensile.Name = "comboBox_CategorieReportMensile";
            this.comboBox_CategorieReportMensile.Size = new System.Drawing.Size(250, 24);
            this.comboBox_CategorieReportMensile.TabIndex = 14;
            // 
            // dateTimePicker_DataReportMensile
            // 
            this.dateTimePicker_DataReportMensile.Location = new System.Drawing.Point(395, 349);
            this.dateTimePicker_DataReportMensile.Name = "dateTimePicker_DataReportMensile";
            this.dateTimePicker_DataReportMensile.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker_DataReportMensile.TabIndex = 15;
            // 
            // listView_ReportMensile
            // 
            this.listView_ReportMensile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView_ReportMensile.HideSelection = false;
            this.listView_ReportMensile.Location = new System.Drawing.Point(781, 230);
            this.listView_ReportMensile.Name = "listView_ReportMensile";
            this.listView_ReportMensile.Size = new System.Drawing.Size(501, 373);
            this.listView_ReportMensile.TabIndex = 7;
            this.listView_ReportMensile.UseCompatibleStateImageBehavior = false;
            // 
            // button_ScaricaReportMensile
            // 
            this.button_ScaricaReportMensile.Location = new System.Drawing.Point(1365, 378);
            this.button_ScaricaReportMensile.Name = "button_ScaricaReportMensile";
            this.button_ScaricaReportMensile.Size = new System.Drawing.Size(216, 46);
            this.button_ScaricaReportMensile.TabIndex = 6;
            this.button_ScaricaReportMensile.Text = "SCARICA REPORT MENSILE";
            this.button_ScaricaReportMensile.UseVisualStyleBackColor = true;
            this.button_ScaricaReportMensile.Click += new System.EventHandler(this.button_ScaricaReportMensile_Click);
            // 
            // label_Report
            // 
            this.label_Report.AutoSize = true;
            this.label_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Report.Location = new System.Drawing.Point(648, 145);
            this.label_Report.Name = "label_Report";
            this.label_Report.Size = new System.Drawing.Size(667, 38);
            this.label_Report.TabIndex = 5;
            this.label_Report.Text = "VISUALIZZA TUTTE LE SPESE MENSILI:";
            // 
            // comboBox_Mesi
            // 
            this.comboBox_Mesi.FormattingEnabled = true;
            this.comboBox_Mesi.Location = new System.Drawing.Point(973, 186);
            this.comboBox_Mesi.Name = "comboBox_Mesi";
            this.comboBox_Mesi.Size = new System.Drawing.Size(250, 24);
            this.comboBox_Mesi.TabIndex = 2;
            this.comboBox_Mesi.SelectedIndexChanged += new System.EventHandler(this.comboBox_Mesi_SelectedIndexChanged);
            // 
            // tabPage_ReportAnnuale
            // 
            this.tabPage_ReportAnnuale.Controls.Add(this.button_ScaricaReportAnnuale);
            this.tabPage_ReportAnnuale.Controls.Add(this.label_SaldoAnnuale);
            this.tabPage_ReportAnnuale.Controls.Add(this.label_ReportAnnuale);
            this.tabPage_ReportAnnuale.Controls.Add(this.listView_ReportAnnuale);
            this.tabPage_ReportAnnuale.Location = new System.Drawing.Point(4, 25);
            this.tabPage_ReportAnnuale.Name = "tabPage_ReportAnnuale";
            this.tabPage_ReportAnnuale.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ReportAnnuale.Size = new System.Drawing.Size(2092, 971);
            this.tabPage_ReportAnnuale.TabIndex = 4;
            this.tabPage_ReportAnnuale.Text = "Report Annuale";
            this.tabPage_ReportAnnuale.UseVisualStyleBackColor = true;
            // 
            // button_ScaricaReportAnnuale
            // 
            this.button_ScaricaReportAnnuale.Location = new System.Drawing.Point(1321, 289);
            this.button_ScaricaReportAnnuale.Name = "button_ScaricaReportAnnuale";
            this.button_ScaricaReportAnnuale.Size = new System.Drawing.Size(230, 40);
            this.button_ScaricaReportAnnuale.TabIndex = 7;
            this.button_ScaricaReportAnnuale.Text = "SCARICA REPORT ANNUALE";
            this.button_ScaricaReportAnnuale.UseVisualStyleBackColor = true;
            this.button_ScaricaReportAnnuale.Click += new System.EventHandler(this.button_ScaricaReportAnnuale_Click);
            // 
            // label_SaldoAnnuale
            // 
            this.label_SaldoAnnuale.AutoSize = true;
            this.label_SaldoAnnuale.Location = new System.Drawing.Point(1318, 240);
            this.label_SaldoAnnuale.Name = "label_SaldoAnnuale";
            this.label_SaldoAnnuale.Size = new System.Drawing.Size(46, 17);
            this.label_SaldoAnnuale.TabIndex = 4;
            this.label_SaldoAnnuale.Text = "label1";
            // 
            // label_ReportAnnuale
            // 
            this.label_ReportAnnuale.AutoSize = true;
            this.label_ReportAnnuale.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ReportAnnuale.Location = new System.Drawing.Point(652, 143);
            this.label_ReportAnnuale.Name = "label_ReportAnnuale";
            this.label_ReportAnnuale.Size = new System.Drawing.Size(680, 38);
            this.label_ReportAnnuale.TabIndex = 3;
            this.label_ReportAnnuale.Text = "VISUALIZZA TUTTE LE SPESE ANNUALI:";
            // 
            // listView_ReportAnnuale
            // 
            this.listView_ReportAnnuale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView_ReportAnnuale.HideSelection = false;
            this.listView_ReportAnnuale.Location = new System.Drawing.Point(751, 215);
            this.listView_ReportAnnuale.Name = "listView_ReportAnnuale";
            this.listView_ReportAnnuale.Size = new System.Drawing.Size(495, 300);
            this.listView_ReportAnnuale.TabIndex = 2;
            this.listView_ReportAnnuale.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageGrafici
            // 
            this.tabPageGrafici.Controls.Add(this.button_ControllaPeriodo);
            this.tabPageGrafici.Controls.Add(this.label11);
            this.tabPageGrafici.Controls.Add(this.label10);
            this.tabPageGrafici.Controls.Add(this.dateTimePicker_Periodo2);
            this.tabPageGrafici.Controls.Add(this.dateTimePicker_Periodo1);
            this.tabPageGrafici.Controls.Add(this.chart_ReportAnnuale);
            this.tabPageGrafici.Controls.Add(this.chart_CategorieAnnuali);
            this.tabPageGrafici.Location = new System.Drawing.Point(4, 25);
            this.tabPageGrafici.Name = "tabPageGrafici";
            this.tabPageGrafici.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGrafici.Size = new System.Drawing.Size(2092, 971);
            this.tabPageGrafici.TabIndex = 5;
            this.tabPageGrafici.Text = "Grafici";
            this.tabPageGrafici.UseVisualStyleBackColor = true;
            // 
            // chart_ReportAnnuale
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_ReportAnnuale.ChartAreas.Add(chartArea1);
            legend1.Name = "Report Annuale";
            this.chart_ReportAnnuale.Legends.Add(legend1);
            this.chart_ReportAnnuale.Location = new System.Drawing.Point(1057, 79);
            this.chart_ReportAnnuale.Name = "chart_ReportAnnuale";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Spese";
            this.chart_ReportAnnuale.Series.Add(series1);
            this.chart_ReportAnnuale.Size = new System.Drawing.Size(922, 643);
            this.chart_ReportAnnuale.TabIndex = 11;
            this.chart_ReportAnnuale.Text = "REPORT ANNUALE";
            // 
            // chart_CategorieAnnuali
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_CategorieAnnuali.ChartAreas.Add(chartArea2);
            legend2.Name = "Report Annuale";
            this.chart_CategorieAnnuali.Legends.Add(legend2);
            this.chart_CategorieAnnuali.Location = new System.Drawing.Point(45, 79);
            this.chart_CategorieAnnuali.Name = "chart_CategorieAnnuali";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Spese";
            this.chart_CategorieAnnuali.Series.Add(series2);
            this.chart_CategorieAnnuali.Size = new System.Drawing.Size(922, 643);
            this.chart_CategorieAnnuali.TabIndex = 10;
            this.chart_CategorieAnnuali.Text = "REPORT ANNUALE";
            // 
            // dateTimePicker_Periodo1
            // 
            this.dateTimePicker_Periodo1.Location = new System.Drawing.Point(271, 773);
            this.dateTimePicker_Periodo1.Name = "dateTimePicker_Periodo1";
            this.dateTimePicker_Periodo1.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker_Periodo1.TabIndex = 16;
            // 
            // dateTimePicker_Periodo2
            // 
            this.dateTimePicker_Periodo2.Location = new System.Drawing.Point(271, 842);
            this.dateTimePicker_Periodo2.Name = "dateTimePicker_Periodo2";
            this.dateTimePicker_Periodo2.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker_Periodo2.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 773);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Seleziona la prima data:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 847);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Seleziona la seconda data:";
            // 
            // button_ControllaPeriodo
            // 
            this.button_ControllaPeriodo.Location = new System.Drawing.Point(618, 789);
            this.button_ControllaPeriodo.Name = "button_ControllaPeriodo";
            this.button_ControllaPeriodo.Size = new System.Drawing.Size(191, 75);
            this.button_ControllaPeriodo.TabIndex = 20;
            this.button_ControllaPeriodo.Text = "CONTROLLA PERIODO";
            this.button_ControllaPeriodo.UseVisualStyleBackColor = true;
            this.button_ControllaPeriodo.Click += new System.EventHandler(this.button_ControllaPeriodo_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 531);
            this.Controls.Add(this.tabControlOperazioni);
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
            this.tabPage_ReportAnnuale.ResumeLayout(false);
            this.tabPage_ReportAnnuale.PerformLayout();
            this.tabPageGrafici.ResumeLayout(false);
            this.tabPageGrafici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ReportAnnuale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_CategorieAnnuali)).EndInit();
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
        private System.Windows.Forms.Button button_ImpostaBudget;
        private System.Windows.Forms.TextBox textBox_Budget;
        private System.Windows.Forms.Label label_ImpostaBudget;
        private System.Windows.Forms.Label label_Visualizza;
        private System.Windows.Forms.Label label_Aggiungi;
        private System.Windows.Forms.Label label_Report;
        private System.Windows.Forms.ComboBox comboBox_Mesi;
        private System.Windows.Forms.Button button_ScaricaReportMensile;
        private System.Windows.Forms.Button button_OrdinaPerData;
        private System.Windows.Forms.Button button_EliminaSpesa;
        private System.Windows.Forms.Button button_ModificaSpesa;
        private System.Windows.Forms.Label label_Budget;
        private System.Windows.Forms.TextBox textBox_Importo;
        private System.Windows.Forms.ComboBox comboBox_Categorie;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Data;
        private System.Windows.Forms.TabPage tabPage_ReportAnnuale;
        private System.Windows.Forms.Label label_ReportAnnuale;
        private System.Windows.Forms.ListView listView_ReportAnnuale;
        private System.Windows.Forms.Label label_SaldoAnnuale;
        private System.Windows.Forms.TextBox textBox_ReportMensile;
        private System.Windows.Forms.ComboBox comboBox_CategorieReportMensile;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DataReportMensile;
        private System.Windows.Forms.ListView listView_ReportMensile;
        private System.Windows.Forms.Button button_EliminaReportMensile;
        private System.Windows.Forms.Button button_ModificaReportMensile;
        private System.Windows.Forms.Label label_TotaleReportMese;
        private System.Windows.Forms.ComboBox comboBox_MesiBudget;
        private System.Windows.Forms.Label label_BudgetReportMensile;
        private System.Windows.Forms.Button button_ScaricaReportAnnuale;
        private System.Windows.Forms.Label label_RimanentePerdita;
        private System.Windows.Forms.Label label_RimanenzaPerditaReportMensile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageGrafici;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_CategorieAnnuali;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ReportAnnuale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Periodo2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Periodo1;
        private System.Windows.Forms.Button button_ControllaPeriodo;
    }
}