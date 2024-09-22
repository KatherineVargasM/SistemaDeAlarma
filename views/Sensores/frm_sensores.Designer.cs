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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sensores));
            this.dtp_FechaInstalacion = new System.Windows.Forms.DateTimePicker();
            this.txt_Estado = new System.Windows.Forms.TextBox();
            this.txt_Tipo = new System.Windows.Forms.TextBox();
            this.lst_Sensores = new System.Windows.Forms.ListBox();
            this.lbl_Lista = new System.Windows.Forms.Label();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_FechaInstalacion = new System.Windows.Forms.Label();
            this.lbl_TipoSensor = new System.Windows.Forms.Label();
            this.lbl_IdUbicacion = new System.Windows.Forms.Label();
            this.cmb_IdUbicacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_FechaInstalacion
            // 
            this.dtp_FechaInstalacion.Location = new System.Drawing.Point(222, 193);
            this.dtp_FechaInstalacion.Name = "dtp_FechaInstalacion";
            this.dtp_FechaInstalacion.Size = new System.Drawing.Size(274, 26);
            this.dtp_FechaInstalacion.TabIndex = 33;
            // 
            // txt_Estado
            // 
            this.txt_Estado.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txt_Estado.Location = new System.Drawing.Point(222, 231);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.Size = new System.Drawing.Size(274, 26);
            this.txt_Estado.TabIndex = 31;
            // 
            // txt_Tipo
            // 
            this.txt_Tipo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txt_Tipo.Location = new System.Drawing.Point(222, 156);
            this.txt_Tipo.Name = "txt_Tipo";
            this.txt_Tipo.Size = new System.Drawing.Size(274, 26);
            this.txt_Tipo.TabIndex = 29;
            // 
            // lst_Sensores
            // 
            this.lst_Sensores.BackColor = System.Drawing.Color.Linen;
            this.lst_Sensores.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lst_Sensores.FormattingEnabled = true;
            this.lst_Sensores.ItemHeight = 20;
            this.lst_Sensores.Location = new System.Drawing.Point(527, 152);
            this.lst_Sensores.Name = "lst_Sensores";
            this.lst_Sensores.Size = new System.Drawing.Size(160, 164);
            this.lst_Sensores.TabIndex = 27;
            this.lst_Sensores.DoubleClick += new System.EventHandler(this.lst_Sensores_DoubleClick);
            // 
            // lbl_Lista
            // 
            this.lbl_Lista.AutoSize = true;
            this.lbl_Lista.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Lista.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lista.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Lista.Location = new System.Drawing.Point(522, 116);
            this.lbl_Lista.Name = "lbl_Lista";
            this.lbl_Lista.Size = new System.Drawing.Size(165, 28);
            this.lbl_Lista.TabIndex = 26;
            this.lbl_Lista.Text = "Número de Sensor:";
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Estado.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Estado.Location = new System.Drawing.Point(58, 233);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(160, 28);
            this.lbl_Estado.TabIndex = 23;
            this.lbl_Estado.Text = "Estado del Sensor:";
            // 
            // lbl_FechaInstalacion
            // 
            this.lbl_FechaInstalacion.AutoSize = true;
            this.lbl_FechaInstalacion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FechaInstalacion.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaInstalacion.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_FechaInstalacion.Location = new System.Drawing.Point(42, 194);
            this.lbl_FechaInstalacion.Name = "lbl_FechaInstalacion";
            this.lbl_FechaInstalacion.Size = new System.Drawing.Size(178, 28);
            this.lbl_FechaInstalacion.TabIndex = 22;
            this.lbl_FechaInstalacion.Text = "Fecha de Instalación:";
            // 
            // lbl_TipoSensor
            // 
            this.lbl_TipoSensor.AutoSize = true;
            this.lbl_TipoSensor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TipoSensor.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoSensor.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_TipoSensor.Location = new System.Drawing.Point(82, 155);
            this.lbl_TipoSensor.Name = "lbl_TipoSensor";
            this.lbl_TipoSensor.Size = new System.Drawing.Size(136, 28);
            this.lbl_TipoSensor.TabIndex = 21;
            this.lbl_TipoSensor.Text = "Tipo de Sensor:";
            // 
            // lbl_IdUbicacion
            // 
            this.lbl_IdUbicacion.AutoSize = true;
            this.lbl_IdUbicacion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IdUbicacion.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdUbicacion.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_IdUbicacion.Location = new System.Drawing.Point(125, 116);
            this.lbl_IdUbicacion.Name = "lbl_IdUbicacion";
            this.lbl_IdUbicacion.Size = new System.Drawing.Size(93, 28);
            this.lbl_IdUbicacion.TabIndex = 20;
            this.lbl_IdUbicacion.Text = "Ubicacion:";
            // 
            // cmb_IdUbicacion
            // 
            this.cmb_IdUbicacion.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cmb_IdUbicacion.FormattingEnabled = true;
            this.cmb_IdUbicacion.Location = new System.Drawing.Point(222, 117);
            this.cmb_IdUbicacion.Name = "cmb_IdUbicacion";
            this.cmb_IdUbicacion.Size = new System.Drawing.Size(274, 28);
            this.cmb_IdUbicacion.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(201, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 51);
            this.label1.TabIndex = 39;
            this.label1.Text = "Gestión de Sensores";
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.BackgroundImage")));
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Modificar.Location = new System.Drawing.Point(306, 288);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(102, 28);
            this.btn_Modificar.TabIndex = 42;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click_1);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Cancelar.Location = new System.Drawing.Point(414, 288);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(91, 28);
            this.btn_Cancelar.TabIndex = 41;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click_1);
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Grabar.BackgroundImage")));
            this.btn_Grabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Grabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Grabar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Grabar.Location = new System.Drawing.Point(217, 288);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(83, 28);
            this.btn_Grabar.TabIndex = 40;
            this.btn_Grabar.Text = "Guardar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click_1);
            // 
            // frm_sensores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaDeAlarma.Properties.Resources.Logo_Negocio_Floral_Beige;
            this.ClientSize = new System.Drawing.Size(726, 360);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Grabar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_IdUbicacion);
            this.Controls.Add(this.dtp_FechaInstalacion);
            this.Controls.Add(this.txt_Estado);
            this.Controls.Add(this.txt_Tipo);
            this.Controls.Add(this.lst_Sensores);
            this.Controls.Add(this.lbl_Lista);
            this.Controls.Add(this.lbl_Estado);
            this.Controls.Add(this.lbl_FechaInstalacion);
            this.Controls.Add(this.lbl_TipoSensor);
            this.Controls.Add(this.lbl_IdUbicacion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_sensores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SENSORES";
            this.Load += new System.EventHandler(this.frm_sensores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_FechaInstalacion;
        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.TextBox txt_Tipo;
        private System.Windows.Forms.ListBox lst_Sensores;
        private System.Windows.Forms.Label lbl_Lista;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_FechaInstalacion;
        private System.Windows.Forms.Label lbl_TipoSensor;
        private System.Windows.Forms.Label lbl_IdUbicacion;
        private System.Windows.Forms.ComboBox cmb_IdUbicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Grabar;
    }
}