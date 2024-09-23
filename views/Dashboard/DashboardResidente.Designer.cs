namespace SistemaDeAlarma.views.Dashboard
{
    partial class DashboardResidente
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asdasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaSensoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteSensoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLARMASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaAlertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteAlertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaLecturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteLecturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Image = global::SistemaDeAlarma.Properties.Resources._12;
            this.picture.InitialImage = global::SistemaDeAlarma.Properties.Resources._2;
            this.picture.Location = new System.Drawing.Point(57, 78);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(687, 294);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 3;
            this.picture.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdasToolStripMenuItem,
            this.aLARMASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // asdasToolStripMenuItem
            // 
            this.asdasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaSensoresToolStripMenuItem,
            this.reporteSensoresToolStripMenuItem});
            this.asdasToolStripMenuItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.asdasToolStripMenuItem.Name = "asdasToolStripMenuItem";
            this.asdasToolStripMenuItem.Size = new System.Drawing.Size(114, 32);
            this.asdasToolStripMenuItem.Text = "SENSORES";
            this.asdasToolStripMenuItem.Click += new System.EventHandler(this.asdasToolStripMenuItem_Click);
            // 
            // listaSensoresToolStripMenuItem
            // 
            this.listaSensoresToolStripMenuItem.Name = "listaSensoresToolStripMenuItem";
            this.listaSensoresToolStripMenuItem.Size = new System.Drawing.Size(220, 32);
            this.listaSensoresToolStripMenuItem.Text = "Lista Sensores";
            this.listaSensoresToolStripMenuItem.Click += new System.EventHandler(this.listaSensoresToolStripMenuItem_Click);
            // 
            // reporteSensoresToolStripMenuItem
            // 
            this.reporteSensoresToolStripMenuItem.Name = "reporteSensoresToolStripMenuItem";
            this.reporteSensoresToolStripMenuItem.Size = new System.Drawing.Size(220, 32);
            this.reporteSensoresToolStripMenuItem.Text = "Reporte Sensores";
            this.reporteSensoresToolStripMenuItem.Click += new System.EventHandler(this.reporteSensoresToolStripMenuItem_Click);
            // 
            // aLARMASToolStripMenuItem
            // 
            this.aLARMASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaAlertasToolStripMenuItem,
            this.reporteAlertasToolStripMenuItem,
            this.lecturasToolStripMenuItem});
            this.aLARMASToolStripMenuItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.aLARMASToolStripMenuItem.Name = "aLARMASToolStripMenuItem";
            this.aLARMASToolStripMenuItem.Size = new System.Drawing.Size(102, 32);
            this.aLARMASToolStripMenuItem.Text = "ALERTAS";
            // 
            // listaAlertasToolStripMenuItem
            // 
            this.listaAlertasToolStripMenuItem.Name = "listaAlertasToolStripMenuItem";
            this.listaAlertasToolStripMenuItem.Size = new System.Drawing.Size(208, 32);
            this.listaAlertasToolStripMenuItem.Text = "Lista Alertas";
            this.listaAlertasToolStripMenuItem.Click += new System.EventHandler(this.listaAlertasToolStripMenuItem_Click);
            // 
            // reporteAlertasToolStripMenuItem
            // 
            this.reporteAlertasToolStripMenuItem.Name = "reporteAlertasToolStripMenuItem";
            this.reporteAlertasToolStripMenuItem.Size = new System.Drawing.Size(208, 32);
            this.reporteAlertasToolStripMenuItem.Text = "Reporte Alertas";
            this.reporteAlertasToolStripMenuItem.Click += new System.EventHandler(this.reporteAlertasToolStripMenuItem_Click);
            // 
            // lecturasToolStripMenuItem
            // 
            this.lecturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaLecturasToolStripMenuItem,
            this.reporteLecturasToolStripMenuItem,
            this.notificaciónToolStripMenuItem});
            this.lecturasToolStripMenuItem.Name = "lecturasToolStripMenuItem";
            this.lecturasToolStripMenuItem.Size = new System.Drawing.Size(208, 32);
            this.lecturasToolStripMenuItem.Text = "Lecturas";
            // 
            // listaLecturasToolStripMenuItem
            // 
            this.listaLecturasToolStripMenuItem.Name = "listaLecturasToolStripMenuItem";
            this.listaLecturasToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.listaLecturasToolStripMenuItem.Text = "Lista Lecturas";
            this.listaLecturasToolStripMenuItem.Click += new System.EventHandler(this.listaLecturasToolStripMenuItem_Click);
            // 
            // reporteLecturasToolStripMenuItem
            // 
            this.reporteLecturasToolStripMenuItem.Name = "reporteLecturasToolStripMenuItem";
            this.reporteLecturasToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.reporteLecturasToolStripMenuItem.Text = "Reporte Lecturas";
            this.reporteLecturasToolStripMenuItem.Click += new System.EventHandler(this.reporteLecturasToolStripMenuItem_Click);
            // 
            // notificaciónToolStripMenuItem
            // 
            this.notificaciónToolStripMenuItem.Name = "notificaciónToolStripMenuItem";
            this.notificaciónToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.notificaciónToolStripMenuItem.Text = "Notificación";
            this.notificaciónToolStripMenuItem.Click += new System.EventHandler(this.notificaciónToolStripMenuItem_Click);
            // 
            // DashboardResidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaDeAlarma.Properties.Resources.Logo_Negocio_Floral_Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardResidente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardResidente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asdasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLARMASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaSensoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteSensoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaAlertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteAlertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaLecturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteLecturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificaciónToolStripMenuItem;
    }
}