namespace RSAfFile
{
    partial class EnkriptimiRSAfrFILE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnkriptimiRSAfrFILE));
            this.txtShtegu = new System.Windows.Forms.TextBox();
            this.btnShfleto = new System.Windows.Forms.Button();
            this.lblShtegu = new System.Windows.Forms.Label();
            this.btnEnkripto = new System.Windows.Forms.Button();
            this.btnDekripto = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tstStatusi = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstStatusiMomental = new System.Windows.Forms.ToolStripStatusLabel();
            this.progresi = new System.Windows.Forms.ToolStripProgressBar();
            this.tstKohaaktuale = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menOpsione = new System.Windows.Forms.ToolStripMenuItem();
            this.menOpsione_Mbyll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGjuha = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGjuha_Shqip = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGjuha_Anglisht = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNdihma = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNdihma_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNdihma_RrethNesh = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrOra = new System.Windows.Forms.Timer(this.components);
            this.lblCelsi = new System.Windows.Forms.Label();
            this.btnShfletoCelsin = new System.Windows.Forms.Button();
            this.txtShtegCelsi = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtShtegu
            // 
            this.txtShtegu.Enabled = false;
            this.txtShtegu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShtegu.Location = new System.Drawing.Point(95, 131);
            this.txtShtegu.Name = "txtShtegu";
            this.txtShtegu.Size = new System.Drawing.Size(321, 26);
            this.txtShtegu.TabIndex = 5;
            // 
            // btnShfleto
            // 
            this.btnShfleto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShfleto.BackgroundImage")));
            this.btnShfleto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShfleto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShfleto.Font = new System.Drawing.Font("Arial", 12F);
            this.btnShfleto.ForeColor = System.Drawing.Color.Maroon;
            this.btnShfleto.Location = new System.Drawing.Point(422, 125);
            this.btnShfleto.Name = "btnShfleto";
            this.btnShfleto.Size = new System.Drawing.Size(80, 38);
            this.btnShfleto.TabIndex = 6;
            this.btnShfleto.Text = "Shfleto";
            this.btnShfleto.UseVisualStyleBackColor = true;
            this.btnShfleto.Click += new System.EventHandler(this.btnShfleto_Click);
            // 
            // lblShtegu
            // 
            this.lblShtegu.AutoSize = true;
            this.lblShtegu.BackColor = System.Drawing.Color.Transparent;
            this.lblShtegu.Font = new System.Drawing.Font("Arial", 12F);
            this.lblShtegu.ForeColor = System.Drawing.Color.Maroon;
            this.lblShtegu.Location = new System.Drawing.Point(92, 110);
            this.lblShtegu.Name = "lblShtegu";
            this.lblShtegu.Size = new System.Drawing.Size(103, 18);
            this.lblShtegu.TabIndex = 7;
            this.lblShtegu.Text = "Shtegu i fajllit:";
            // 
            // btnEnkripto
            // 
            this.btnEnkripto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnkripto.BackgroundImage")));
            this.btnEnkripto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnkripto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnkripto.Font = new System.Drawing.Font("Arial", 12F);
            this.btnEnkripto.ForeColor = System.Drawing.Color.Maroon;
            this.btnEnkripto.Location = new System.Drawing.Point(95, 233);
            this.btnEnkripto.Name = "btnEnkripto";
            this.btnEnkripto.Size = new System.Drawing.Size(175, 64);
            this.btnEnkripto.TabIndex = 8;
            this.btnEnkripto.Text = "Enkripto";
            this.btnEnkripto.UseVisualStyleBackColor = true;
            this.btnEnkripto.Click += new System.EventHandler(this.btnEnkripto_Click);
            // 
            // btnDekripto
            // 
            this.btnDekripto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDekripto.BackgroundImage")));
            this.btnDekripto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDekripto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDekripto.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDekripto.ForeColor = System.Drawing.Color.Maroon;
            this.btnDekripto.Location = new System.Drawing.Point(327, 233);
            this.btnDekripto.Name = "btnDekripto";
            this.btnDekripto.Size = new System.Drawing.Size(175, 64);
            this.btnDekripto.TabIndex = 9;
            this.btnDekripto.Text = "Dekripto";
            this.btnDekripto.UseVisualStyleBackColor = true;
            this.btnDekripto.Click += new System.EventHandler(this.Dekripto_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip1.BackgroundImage")));
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstStatusi,
            this.tstStatusiMomental,
            this.progresi,
            this.tstKohaaktuale,
            this.tstora,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 336);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(602, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tstStatusi
            // 
            this.tstStatusi.ForeColor = System.Drawing.Color.Maroon;
            this.tstStatusi.Name = "tstStatusi";
            this.tstStatusi.Size = new System.Drawing.Size(45, 17);
            this.tstStatusi.Text = "Statusi:";
            this.tstStatusi.ToolTipText = "Gjendja e statusit";
            // 
            // tstStatusiMomental
            // 
            this.tstStatusiMomental.ForeColor = System.Drawing.Color.Maroon;
            this.tstStatusiMomental.Name = "tstStatusiMomental";
            this.tstStatusiMomental.Size = new System.Drawing.Size(52, 17);
            this.tstStatusiMomental.Text = "Në pritje";
            this.tstStatusiMomental.ToolTipText = "Gjendja momentale e statusit";
            // 
            // progresi
            // 
            this.progresi.Name = "progresi";
            this.progresi.Size = new System.Drawing.Size(360, 16);
            // 
            // tstKohaaktuale
            // 
            this.tstKohaaktuale.ForeColor = System.Drawing.Color.Maroon;
            this.tstKohaaktuale.Name = "tstKohaaktuale";
            this.tstKohaaktuale.Size = new System.Drawing.Size(78, 17);
            this.tstKohaaktuale.Text = "Koha aktuale:";
            // 
            // tstora
            // 
            this.tstora.ForeColor = System.Drawing.Color.Maroon;
            this.tstora.Name = "tstora";
            this.tstora.Size = new System.Drawing.Size(19, 17);
            this.tstora.Text = "....";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 15);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menOpsione,
            this.mnuGjuha,
            this.mnuNdihma});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menOpsione
            // 
            this.menOpsione.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menOpsione_Mbyll});
            this.menOpsione.Image = global::RSAfFile.Properties.Resources.Ampeross_Qetto_2_Settings;
            this.menOpsione.Name = "menOpsione";
            this.menOpsione.Size = new System.Drawing.Size(79, 20);
            this.menOpsione.Text = "Opsione";
            // 
            // menOpsione_Mbyll
            // 
            this.menOpsione_Mbyll.Image = global::RSAfFile.Properties.Resources.cancelcon;
            this.menOpsione_Mbyll.Name = "menOpsione_Mbyll";
            this.menOpsione_Mbyll.Size = new System.Drawing.Size(104, 22);
            this.menOpsione_Mbyll.Text = "Mbyll";
            this.menOpsione_Mbyll.Click += new System.EventHandler(this.menOpsione_Mbyll_Click);
            // 
            // mnuGjuha
            // 
            this.mnuGjuha.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGjuha_Shqip,
            this.mnuGjuha_Anglisht});
            this.mnuGjuha.Image = global::RSAfFile.Properties.Resources.Gjuh;
            this.mnuGjuha.Name = "mnuGjuha";
            this.mnuGjuha.Size = new System.Drawing.Size(66, 20);
            this.mnuGjuha.Text = "Gjuha";
            // 
            // mnuGjuha_Shqip
            // 
            this.mnuGjuha_Shqip.Image = global::RSAfFile.Properties.Resources.Shqip;
            this.mnuGjuha_Shqip.Name = "mnuGjuha_Shqip";
            this.mnuGjuha_Shqip.Size = new System.Drawing.Size(118, 22);
            this.mnuGjuha_Shqip.Text = "Shqip";
            this.mnuGjuha_Shqip.Click += new System.EventHandler(this.mnuGjuha_Shqip_Click);
            // 
            // mnuGjuha_Anglisht
            // 
            this.mnuGjuha_Anglisht.Name = "mnuGjuha_Anglisht";
            this.mnuGjuha_Anglisht.Size = new System.Drawing.Size(118, 22);
            this.mnuGjuha_Anglisht.Text = "Anglisht";
            this.mnuGjuha_Anglisht.Click += new System.EventHandler(this.mnuGjuha_Anglisht_Click);
            // 
            // mnuNdihma
            // 
            this.mnuNdihma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNdihma_Info,
            this.mnuNdihma_RrethNesh});
            this.mnuNdihma.Image = global::RSAfFile.Properties.Resources.Aroche_Delta_Help;
            this.mnuNdihma.Name = "mnuNdihma";
            this.mnuNdihma.Size = new System.Drawing.Size(78, 20);
            this.mnuNdihma.Text = "Ndihma";
            // 
            // mnuNdihma_Info
            // 
            this.mnuNdihma_Info.Image = global::RSAfFile.Properties.Resources._1463917220_help_browser;
            this.mnuNdihma_Info.Name = "mnuNdihma_Info";
            this.mnuNdihma_Info.Size = new System.Drawing.Size(152, 22);
            this.mnuNdihma_Info.Text = "Info";
            this.mnuNdihma_Info.Click += new System.EventHandler(this.mnuNdihma_Info_Click);
            // 
            // mnuNdihma_RrethNesh
            // 
            this.mnuNdihma_RrethNesh.Image = global::RSAfFile.Properties.Resources._1463917402_help_forum_lb;
            this.mnuNdihma_RrethNesh.Name = "mnuNdihma_RrethNesh";
            this.mnuNdihma_RrethNesh.Size = new System.Drawing.Size(152, 22);
            this.mnuNdihma_RrethNesh.Text = "Rreth nesh";
            this.mnuNdihma_RrethNesh.Click += new System.EventHandler(this.mnuNdihma_RrethNesh_Click);
            // 
            // tmrOra
            // 
            this.tmrOra.Enabled = true;
            this.tmrOra.Interval = 1000;
            this.tmrOra.Tick += new System.EventHandler(this.tmrOra_Tick);
            // 
            // lblCelsi
            // 
            this.lblCelsi.AutoSize = true;
            this.lblCelsi.BackColor = System.Drawing.Color.Transparent;
            this.lblCelsi.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCelsi.ForeColor = System.Drawing.Color.Maroon;
            this.lblCelsi.Location = new System.Drawing.Point(92, 52);
            this.lblCelsi.Name = "lblCelsi";
            this.lblCelsi.Size = new System.Drawing.Size(118, 18);
            this.lblCelsi.TabIndex = 14;
            this.lblCelsi.Text = "Shtegu i celesit:";
            // 
            // btnShfletoCelsin
            // 
            this.btnShfletoCelsin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShfletoCelsin.BackgroundImage")));
            this.btnShfletoCelsin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShfletoCelsin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShfletoCelsin.Font = new System.Drawing.Font("Arial", 12F);
            this.btnShfletoCelsin.ForeColor = System.Drawing.Color.Maroon;
            this.btnShfletoCelsin.Location = new System.Drawing.Point(422, 67);
            this.btnShfletoCelsin.Name = "btnShfletoCelsin";
            this.btnShfletoCelsin.Size = new System.Drawing.Size(80, 38);
            this.btnShfletoCelsin.TabIndex = 13;
            this.btnShfletoCelsin.Text = "Shfleto";
            this.btnShfletoCelsin.UseVisualStyleBackColor = true;
            this.btnShfletoCelsin.Click += new System.EventHandler(this.btnShfletoCelsin_Click);
            // 
            // txtShtegCelsi
            // 
            this.txtShtegCelsi.Enabled = false;
            this.txtShtegCelsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShtegCelsi.Location = new System.Drawing.Point(95, 73);
            this.txtShtegCelsi.Name = "txtShtegCelsi";
            this.txtShtegCelsi.Size = new System.Drawing.Size(321, 26);
            this.txtShtegCelsi.TabIndex = 12;
            // 
            // EnkriptimiRSAfrFILE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 358);
            this.Controls.Add(this.lblCelsi);
            this.Controls.Add(this.btnShfletoCelsin);
            this.Controls.Add(this.txtShtegCelsi);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDekripto);
            this.Controls.Add(this.btnEnkripto);
            this.Controls.Add(this.lblShtegu);
            this.Controls.Add(this.btnShfleto);
            this.Controls.Add(this.txtShtegu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "EnkriptimiRSAfrFILE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enkriptimi/Dekriptimi i nje file me RSA";
            this.TopMost = true;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtShtegu;
        private System.Windows.Forms.Button btnShfleto;
        private System.Windows.Forms.Label lblShtegu;
        private System.Windows.Forms.Button btnEnkripto;
        private System.Windows.Forms.Button btnDekripto;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tstStatusi;
        private System.Windows.Forms.ToolStripStatusLabel tstStatusiMomental;
        private System.Windows.Forms.ToolStripStatusLabel tstKohaaktuale;
        private System.Windows.Forms.ToolStripStatusLabel tstora;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menOpsione;
        private System.Windows.Forms.ToolStripMenuItem menOpsione_Mbyll;
        private System.Windows.Forms.ToolStripMenuItem mnuGjuha;
        private System.Windows.Forms.ToolStripMenuItem mnuGjuha_Shqip;
        private System.Windows.Forms.ToolStripMenuItem mnuGjuha_Anglisht;
        private System.Windows.Forms.ToolStripMenuItem mnuNdihma;
        private System.Windows.Forms.ToolStripMenuItem mnuNdihma_Info;
        private System.Windows.Forms.ToolStripMenuItem mnuNdihma_RrethNesh;
        private System.Windows.Forms.Timer tmrOra;
        private System.Windows.Forms.Label lblCelsi;
        private System.Windows.Forms.Button btnShfletoCelsin;
        private System.Windows.Forms.TextBox txtShtegCelsi;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar progresi;

    }
}

