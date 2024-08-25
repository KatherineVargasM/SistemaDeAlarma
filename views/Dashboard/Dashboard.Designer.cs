namespace SistemaDeAlarma.views.Dashboard
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sENSORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uBICACIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eVENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picture = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOSToolStripMenuItem,
            this.sENSORESToolStripMenuItem,
            this.uBICACIONESToolStripMenuItem,
            this.eVENTOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(568, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            this.uSUARIOSToolStripMenuItem.Click += new System.EventHandler(this.uSUARIOSToolStripMenuItem_Click);
            // 
            // sENSORESToolStripMenuItem
            // 
            this.sENSORESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sENSORESToolStripMenuItem.Name = "sENSORESToolStripMenuItem";
            this.sENSORESToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.sENSORESToolStripMenuItem.Text = "SENSORES";
            this.sENSORESToolStripMenuItem.Click += new System.EventHandler(this.sENSORESToolStripMenuItem_Click);
            // 
            // uBICACIONESToolStripMenuItem
            // 
            this.uBICACIONESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uBICACIONESToolStripMenuItem.Name = "uBICACIONESToolStripMenuItem";
            this.uBICACIONESToolStripMenuItem.Size = new System.Drawing.Size(121, 25);
            this.uBICACIONESToolStripMenuItem.Text = "UBICACIONES";
            this.uBICACIONESToolStripMenuItem.Click += new System.EventHandler(this.uBICACIONESToolStripMenuItem_Click);
            // 
            // eVENTOSToolStripMenuItem
            // 
            this.eVENTOSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eVENTOSToolStripMenuItem.Name = "eVENTOSToolStripMenuItem";
            this.eVENTOSToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.eVENTOSToolStripMenuItem.Text = "EVENTOS";
            this.eVENTOSToolStripMenuItem.Click += new System.EventHandler(this.eVENTOSToolStripMenuItem_Click);
            // 
            // picture
            // 
            this.picture.Image = global::SistemaDeAlarma.Properties.Resources._2;
            this.picture.InitialImage = global::SistemaDeAlarma.Properties.Resources._2;
            this.picture.Location = new System.Drawing.Point(44, 58);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(463, 218);
            this.picture.TabIndex = 1;
            this.picture.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(568, 315);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.Dashboard_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sENSORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uBICACIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eVENTOSToolStripMenuItem;
        private System.Windows.Forms.PictureBox picture;
    }
}