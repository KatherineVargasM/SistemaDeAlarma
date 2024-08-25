namespace SistemaDeAlarma.views.Sensores
{
    partial class frm_sensores
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
            this.dtp_FechaInstalacion = new System.Windows.Forms.DateTimePicker();
            this.txt_Estado = new System.Windows.Forms.TextBox();
            this.txt_Tipo = new System.Windows.Forms.TextBox();
            this.lst_Sensores = new System.Windows.Forms.ListBox();
            this.lbl_Lista = new System.Windows.Forms.Label();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_FechaInstalacion = new System.Windows.Forms.Label();
            this.lbl_TipoSensor = new System.Windows.Forms.Label();
            this.lbl_IdUbicacion = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.cmb_IdUbicacion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(329, 288);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(89, 35);
            this.btn_Eliminar.TabIndex = 37;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(234, 288);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(89, 35);
            this.btn_Modificar.TabIndex = 36;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(329, 247);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(89, 35);
            this.btn_Cancelar.TabIndex = 35;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Location = new System.Drawing.Point(234, 247);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(89, 35);
            this.btn_Grabar.TabIndex = 34;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // dtp_FechaInstalacion
            // 
            this.dtp_FechaInstalacion.Location = new System.Drawing.Point(198, 164);
            this.dtp_FechaInstalacion.Name = "dtp_FechaInstalacion";
            this.dtp_FechaInstalacion.Size = new System.Drawing.Size(274, 26);
            this.dtp_FechaInstalacion.TabIndex = 33;
            // 
            // txt_Estado
            // 
            this.txt_Estado.Location = new System.Drawing.Point(198, 202);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.Size = new System.Drawing.Size(274, 26);
            this.txt_Estado.TabIndex = 31;
            // 
            // txt_Tipo
            // 
            this.txt_Tipo.Location = new System.Drawing.Point(198, 127);
            this.txt_Tipo.Name = "txt_Tipo";
            this.txt_Tipo.Size = new System.Drawing.Size(274, 26);
            this.txt_Tipo.TabIndex = 29;
            // 
            // lst_Sensores
            // 
            this.lst_Sensores.FormattingEnabled = true;
            this.lst_Sensores.ItemHeight = 20;
            this.lst_Sensores.Location = new System.Drawing.Point(499, 88);
            this.lst_Sensores.Name = "lst_Sensores";
            this.lst_Sensores.Size = new System.Drawing.Size(306, 224);
            this.lst_Sensores.TabIndex = 27;
            this.lst_Sensores.DoubleClick += new System.EventHandler(this.lst_Sensores_DoubleClick);
            // 
            // lbl_Lista
            // 
            this.lbl_Lista.AutoSize = true;
            this.lbl_Lista.Location = new System.Drawing.Point(495, 65);
            this.lbl_Lista.Name = "lbl_Lista";
            this.lbl_Lista.Size = new System.Drawing.Size(141, 20);
            this.lbl_Lista.TabIndex = 26;
            this.lbl_Lista.Text = "Lista de Sensores:";
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Location = new System.Drawing.Point(47, 208);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(144, 20);
            this.lbl_Estado.TabIndex = 23;
            this.lbl_Estado.Text = "Estado del Sensor:";
            // 
            // lbl_FechaInstalacion
            // 
            this.lbl_FechaInstalacion.AutoSize = true;
            this.lbl_FechaInstalacion.Location = new System.Drawing.Point(31, 169);
            this.lbl_FechaInstalacion.Name = "lbl_FechaInstalacion";
            this.lbl_FechaInstalacion.Size = new System.Drawing.Size(161, 20);
            this.lbl_FechaInstalacion.TabIndex = 22;
            this.lbl_FechaInstalacion.Text = "Fecha de Instalación:";
            // 
            // lbl_TipoSensor
            // 
            this.lbl_TipoSensor.AutoSize = true;
            this.lbl_TipoSensor.Location = new System.Drawing.Point(71, 130);
            this.lbl_TipoSensor.Name = "lbl_TipoSensor";
            this.lbl_TipoSensor.Size = new System.Drawing.Size(120, 20);
            this.lbl_TipoSensor.TabIndex = 21;
            this.lbl_TipoSensor.Text = "Tipo de Sensor:";
            // 
            // lbl_IdUbicacion
            // 
            this.lbl_IdUbicacion.AutoSize = true;
            this.lbl_IdUbicacion.Location = new System.Drawing.Point(88, 91);
            this.lbl_IdUbicacion.Name = "lbl_IdUbicacion";
            this.lbl_IdUbicacion.Size = new System.Drawing.Size(104, 20);
            this.lbl_IdUbicacion.TabIndex = 20;
            this.lbl_IdUbicacion.Text = "ID Ubicacion:";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(207, 40);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(258, 29);
            this.lbl_Titulo.TabIndex = 19;
            this.lbl_Titulo.Text = "Gestión de Sensores";
            // 
            // cmb_IdUbicacion
            // 
            this.cmb_IdUbicacion.FormattingEnabled = true;
            this.cmb_IdUbicacion.Location = new System.Drawing.Point(198, 88);
            this.cmb_IdUbicacion.Name = "cmb_IdUbicacion";
            this.cmb_IdUbicacion.Size = new System.Drawing.Size(274, 28);
            this.cmb_IdUbicacion.TabIndex = 38;
            // 
            // frm_sensores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 362);
            this.Controls.Add(this.cmb_IdUbicacion);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Grabar);
            this.Controls.Add(this.dtp_FechaInstalacion);
            this.Controls.Add(this.txt_Estado);
            this.Controls.Add(this.txt_Tipo);
            this.Controls.Add(this.lst_Sensores);
            this.Controls.Add(this.lbl_Lista);
            this.Controls.Add(this.lbl_Estado);
            this.Controls.Add(this.lbl_FechaInstalacion);
            this.Controls.Add(this.lbl_TipoSensor);
            this.Controls.Add(this.lbl_IdUbicacion);
            this.Controls.Add(this.lbl_Titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_sensores";
            this.Text = "SENSORES";
            this.Load += new System.EventHandler(this.frm_sensores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.DateTimePicker dtp_FechaInstalacion;
        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.TextBox txt_Tipo;
        private System.Windows.Forms.ListBox lst_Sensores;
        private System.Windows.Forms.Label lbl_Lista;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_FechaInstalacion;
        private System.Windows.Forms.Label lbl_TipoSensor;
        private System.Windows.Forms.Label lbl_IdUbicacion;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.ComboBox cmb_IdUbicacion;
    }
}