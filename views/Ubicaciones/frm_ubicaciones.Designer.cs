namespace SistemaDeAlarma.views.Ubicaciones
{
    partial class frm_ubicaciones
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
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_Lugar = new System.Windows.Forms.TextBox();
            this.lst_Ubicaciones = new System.Windows.Forms.ListBox();
            this.lbl_Lista = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_Lugar = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(269, 214);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(89, 35);
            this.btn_Eliminar.TabIndex = 37;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(174, 214);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(89, 35);
            this.btn_Modificar.TabIndex = 36;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(269, 173);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(89, 35);
            this.btn_Cancelar.TabIndex = 35;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Location = new System.Drawing.Point(174, 173);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(89, 35);
            this.btn_Grabar.TabIndex = 34;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(130, 126);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(274, 26);
            this.txt_Descripcion.TabIndex = 29;
            // 
            // txt_Lugar
            // 
            this.txt_Lugar.Location = new System.Drawing.Point(130, 87);
            this.txt_Lugar.Name = "txt_Lugar";
            this.txt_Lugar.Size = new System.Drawing.Size(274, 26);
            this.txt_Lugar.TabIndex = 28;
            // 
            // lst_Ubicaciones
            // 
            this.lst_Ubicaciones.FormattingEnabled = true;
            this.lst_Ubicaciones.ItemHeight = 20;
            this.lst_Ubicaciones.Location = new System.Drawing.Point(431, 87);
            this.lst_Ubicaciones.Name = "lst_Ubicaciones";
            this.lst_Ubicaciones.Size = new System.Drawing.Size(306, 164);
            this.lst_Ubicaciones.TabIndex = 27;
            this.lst_Ubicaciones.DoubleClick += new System.EventHandler(this.lst_Ubicaciones_DoubleClick);
            // 
            // lbl_Lista
            // 
            this.lbl_Lista.AutoSize = true;
            this.lbl_Lista.Location = new System.Drawing.Point(427, 64);
            this.lbl_Lista.Name = "lbl_Lista";
            this.lbl_Lista.Size = new System.Drawing.Size(160, 20);
            this.lbl_Lista.TabIndex = 26;
            this.lbl_Lista.Text = "Lista de Ubicaciones:";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(34, 126);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(96, 20);
            this.lbl_Descripcion.TabIndex = 21;
            this.lbl_Descripcion.Text = "Descripción:";
            // 
            // lbl_Lugar
            // 
            this.lbl_Lugar.AutoSize = true;
            this.lbl_Lugar.Location = new System.Drawing.Point(47, 90);
            this.lbl_Lugar.Name = "lbl_Lugar";
            this.lbl_Lugar.Size = new System.Drawing.Size(83, 20);
            this.lbl_Lugar.TabIndex = 20;
            this.lbl_Lugar.Text = "Ubicación:";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(125, 42);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(284, 29);
            this.lbl_Titulo.TabIndex = 19;
            this.lbl_Titulo.Text = "Ubicación de Sensores";
            // 
            // frm_ubicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 287);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Grabar);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_Lugar);
            this.Controls.Add(this.lst_Ubicaciones);
            this.Controls.Add(this.lbl_Lista);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.lbl_Lugar);
            this.Controls.Add(this.lbl_Titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ubicaciones";
            this.Text = "UBICACIONES";
            this.Load += new System.EventHandler(this.frm_ubicaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Lugar;
        private System.Windows.Forms.ListBox lst_Ubicaciones;
        private System.Windows.Forms.Label lbl_Lista;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Lugar;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}