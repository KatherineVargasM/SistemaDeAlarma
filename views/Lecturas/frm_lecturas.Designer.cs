namespace SistemaDeAlarma.views.Lecturas
{
    partial class frm_lecturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_lecturas));
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.txt_abundancia = new System.Windows.Forms.TextBox();
            this.txt_espesor = new System.Windows.Forms.TextBox();
            this.lst_lecturas = new System.Windows.Forms.ListBox();
            this.lbl_lecturas = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_Lugar = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.BackgroundImage")));
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Modificar.Location = new System.Drawing.Point(327, 198);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(92, 28);
            this.btn_Modificar.TabIndex = 42;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Cancelar.Location = new System.Drawing.Point(425, 198);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(91, 28);
            this.btn_Cancelar.TabIndex = 41;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Grabar.BackgroundImage")));
            this.btn_Grabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Grabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Grabar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Grabar.Location = new System.Drawing.Point(242, 198);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(79, 28);
            this.btn_Grabar.TabIndex = 40;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // txt_abundancia
            // 
            this.txt_abundancia.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txt_abundancia.Location = new System.Drawing.Point(242, 143);
            this.txt_abundancia.Name = "txt_abundancia";
            this.txt_abundancia.Size = new System.Drawing.Size(274, 26);
            this.txt_abundancia.TabIndex = 39;
            // 
            // txt_espesor
            // 
            this.txt_espesor.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txt_espesor.Location = new System.Drawing.Point(242, 103);
            this.txt_espesor.Name = "txt_espesor";
            this.txt_espesor.Size = new System.Drawing.Size(274, 26);
            this.txt_espesor.TabIndex = 38;
            // 
            // lst_lecturas
            // 
            this.lst_lecturas.BackColor = System.Drawing.Color.Linen;
            this.lst_lecturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_lecturas.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lst_lecturas.FormattingEnabled = true;
            this.lst_lecturas.ItemHeight = 20;
            this.lst_lecturas.Location = new System.Drawing.Point(543, 126);
            this.lst_lecturas.Name = "lst_lecturas";
            this.lst_lecturas.Size = new System.Drawing.Size(203, 100);
            this.lst_lecturas.TabIndex = 37;
            this.lst_lecturas.DoubleClick += new System.EventHandler(this.lst_lecturas_DoubleClick);
            // 
            // lbl_lecturas
            // 
            this.lbl_lecturas.AutoSize = true;
            this.lbl_lecturas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lecturas.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lecturas.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_lecturas.Location = new System.Drawing.Point(538, 95);
            this.lbl_lecturas.Name = "lbl_lecturas";
            this.lbl_lecturas.Size = new System.Drawing.Size(163, 28);
            this.lbl_lecturas.TabIndex = 36;
            this.lbl_lecturas.Text = "Lecturas Captadas:";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Descripcion.Location = new System.Drawing.Point(48, 142);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(191, 28);
            this.lbl_Descripcion.TabIndex = 35;
            this.lbl_Descripcion.Text = "Abundancia de Humo:";
            // 
            // lbl_Lugar
            // 
            this.lbl_Lugar.AutoSize = true;
            this.lbl_Lugar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Lugar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lugar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Lugar.Location = new System.Drawing.Point(78, 101);
            this.lbl_Lugar.Name = "lbl_Lugar";
            this.lbl_Lugar.Size = new System.Drawing.Size(161, 28);
            this.lbl_Lugar.TabIndex = 34;
            this.lbl_Lugar.Text = "Espesor del Humo:";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Titulo.Location = new System.Drawing.Point(234, 41);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(286, 47);
            this.lbl_Titulo.TabIndex = 33;
            this.lbl_Titulo.Text = "Lecturas del Sensor";
            // 
            // frm_lecturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaDeAlarma.Properties.Resources.Logo_Negocio_Floral_Beige;
            this.ClientSize = new System.Drawing.Size(830, 280);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Grabar);
            this.Controls.Add(this.txt_abundancia);
            this.Controls.Add(this.txt_espesor);
            this.Controls.Add(this.lst_lecturas);
            this.Controls.Add(this.lbl_lecturas);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.lbl_Lugar);
            this.Controls.Add(this.lbl_Titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_lecturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LECTURAS";
            this.Load += new System.EventHandler(this.frm_lecturas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.TextBox txt_abundancia;
        private System.Windows.Forms.TextBox txt_espesor;
        private System.Windows.Forms.ListBox lst_lecturas;
        private System.Windows.Forms.Label lbl_lecturas;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Lugar;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}