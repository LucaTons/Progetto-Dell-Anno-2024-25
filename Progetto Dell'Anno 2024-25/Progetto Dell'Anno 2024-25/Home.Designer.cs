
namespace Progetto_Dell_Anno_2024_25
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.button_chiudi = new System.Windows.Forms.Button();
            this.button_Inizio = new System.Windows.Forms.Button();
            this.Label_Titolo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_chiudi
            // 
            this.button_chiudi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_chiudi.BackColor = System.Drawing.Color.Red;
            this.button_chiudi.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_chiudi.ForeColor = System.Drawing.Color.Black;
            this.button_chiudi.Location = new System.Drawing.Point(162, 257);
            this.button_chiudi.Margin = new System.Windows.Forms.Padding(4);
            this.button_chiudi.Name = "button_chiudi";
            this.button_chiudi.Size = new System.Drawing.Size(345, 186);
            this.button_chiudi.TabIndex = 8;
            this.button_chiudi.Text = "CHIUDI";
            this.button_chiudi.UseVisualStyleBackColor = false;
            this.button_chiudi.Visible = false;
            this.button_chiudi.Click += new System.EventHandler(this.button_chiudi_Click);
            // 
            // button_Inizio
            // 
            this.button_Inizio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Inizio.BackColor = System.Drawing.Color.Lime;
            this.button_Inizio.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Inizio.ForeColor = System.Drawing.Color.Black;
            this.button_Inizio.Location = new System.Drawing.Point(676, 257);
            this.button_Inizio.Margin = new System.Windows.Forms.Padding(4);
            this.button_Inizio.Name = "button_Inizio";
            this.button_Inizio.Size = new System.Drawing.Size(345, 186);
            this.button_Inizio.TabIndex = 7;
            this.button_Inizio.Text = "AVVIA";
            this.button_Inizio.UseVisualStyleBackColor = false;
            this.button_Inizio.Visible = false;
            this.button_Inizio.Click += new System.EventHandler(this.button_Inizio_Click);
            // 
            // Label_Titolo
            // 
            this.Label_Titolo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Titolo.BackColor = System.Drawing.Color.Transparent;
            this.Label_Titolo.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Titolo.Location = new System.Drawing.Point(152, 0);
            this.Label_Titolo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Titolo.Name = "Label_Titolo";
            this.Label_Titolo.Size = new System.Drawing.Size(869, 94);
            this.Label_Titolo.TabIndex = 6;
            this.Label_Titolo.Text = "GUARDIAN OF THE MONEY";
            this.Label_Titolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Titolo.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 531);
            this.Controls.Add(this.button_chiudi);
            this.Controls.Add(this.button_Inizio);
            this.Controls.Add(this.Label_Titolo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_chiudi;
        private System.Windows.Forms.Button button_Inizio;
        private System.Windows.Forms.Label Label_Titolo;
    }
}