namespace SistemaDeAlarma.views.Alertas
{
    partial class frm_alertas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_alertas));
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_Nivel = new System.Windows.Forms.TextBox();
            this.txt_Tipo = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.lst_Alertas = new System.Windows.Forms.ListBox();
            this.lbl_Lista = new System.Windows.Forms.Label();
            this.lbl_Descipcion = new System.Windows.Forms.Label();
            this.lbl_Nivel = new System.Windows.Forms.Label();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_IdSensor = new System.Windows.Forms.Label();
            this.lbl_IdUsuario = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.cmb_Usuario = new System.Windows.Forms.ComboBox();
            this.cmb_Sensor = new System.Windows.Forms.ComboBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.cmb_Lecturas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Location = new System.Drawing.Point(240, 208);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(274, 26);
            this.dtp_Fecha.TabIndex = 33;
            // 
            // txt_Nivel
            // 
            this.txt_Nivel.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Nivel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txt_Nivel.Location = new System.Drawing.Point(240, 287);
            this.txt_Nivel.Name = "txt_Nivel";
            this.txt_Nivel.Size = new System.Drawing.Size(274, 26);
            this.txt_Nivel.TabIndex = 32;
            // 
            // txt_Tipo
            // 
            this.txt_Tipo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Tipo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txt_Tipo.Location = new System.Drawing.Point(240, 246);
            this.txt_Tipo.Name = "txt_Tipo";
            this.txt_Tipo.Size = new System.Drawing.Size(274, 26);
            this.txt_Tipo.TabIndex = 31;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Descripcion.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txt_Descripcion.Location = new System.Drawing.Point(240, 325);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(274, 57);
            this.txt_Descripcion.TabIndex = 30;
            // 
            // lst_Alertas
            // 
            this.lst_Alertas.BackColor = System.Drawing.Color.Linen;
            this.lst_Alertas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_Alertas.FormattingEnabled = true;
            this.lst_Alertas.ItemHeight = 20;
            this.lst_Alertas.Location = new System.Drawing.Point(541, 139);
            this.lst_Alertas.Name = "lst_Alertas";
            this.lst_Alertas.Size = new System.Drawing.Size(209, 240);
            this.lst_Alertas.TabIndex = 27;
            this.lst_Alertas.DoubleClick += new System.EventHandler(this.lst_Alertas_DoubleClick);
            // 
            // lbl_Lista
            // 
            this.lbl_Lista.AutoSize = true;
            this.lbl_Lista.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Lista.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lista.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Lista.Location = new System.Drawing.Point(536, 103);
            this.lbl_Lista.Name = "lbl_Lista";
            this.lbl_Lista.Size = new System.Drawing.Size(163, 28);
            this.lbl_Lista.TabIndex = 26;
            this.lbl_Lista.Text = "Alertas por Fechas:";
            // 
            // lbl_Descipcion
            // 
            this.lbl_Descipcion.AutoSize = true;
            this.lbl_Descipcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Descipcion.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descipcion.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Descipcion.Location = new System.Drawing.Point(128, 324);
            this.lbl_Descipcion.Name = "lbl_Descipcion";
            this.lbl_Descipcion.Size = new System.Drawing.Size(109, 28);
            this.lbl_Descipcion.TabIndex = 25;
            this.lbl_Descipcion.Text = "Descripción:";
            // 
            // lbl_Nivel
            // 
            this.lbl_Nivel.AutoSize = true;
            this.lbl_Nivel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nivel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nivel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Nivel.Location = new System.Drawing.Point(100, 285);
            this.lbl_Nivel.Name = "lbl_Nivel";
            this.lbl_Nivel.Size = new System.Drawing.Size(137, 28);
            this.lbl_Nivel.TabIndex = 24;
            this.lbl_Nivel.Text = "Nivel de Alerta:";
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Tipo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tipo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Tipo.Location = new System.Drawing.Point(99, 244);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(138, 28);
            this.lbl_Tipo.TabIndex = 23;
            this.lbl_Tipo.Text = "Tipo de Evento:";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Fecha.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Fecha.Location = new System.Drawing.Point(77, 206);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(157, 28);
            this.lbl_Fecha.TabIndex = 22;
            this.lbl_Fecha.Text = "Fecha de Registro:";
            // 
            // lbl_IdSensor
            // 
            this.lbl_IdSensor.AutoSize = true;
            this.lbl_IdSensor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IdSensor.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdSensor.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_IdSensor.Location = new System.Drawing.Point(52, 140);
            this.lbl_IdSensor.Name = "lbl_IdSensor";
            this.lbl_IdSensor.Size = new System.Drawing.Size(182, 28);
            this.lbl_IdSensor.TabIndex = 21;
            this.lbl_IdSensor.Text = "Ubicación del Sensor:";
            // 
            // lbl_IdUsuario
            // 
            this.lbl_IdUsuario.AutoSize = true;
            this.lbl_IdUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IdUsuario.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdUsuario.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_IdUsuario.Location = new System.Drawing.Point(160, 103);
            this.lbl_IdUsuario.Name = "lbl_IdUsuario";
            this.lbl_IdUsuario.Size = new System.Drawing.Size(77, 28);
            this.lbl_IdUsuario.TabIndex = 20;
            this.lbl_IdUsuario.Text = "Usuario:";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Titulo.Location = new System.Drawing.Point(232, 41);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(279, 47);
            this.lbl_Titulo.TabIndex = 19;
            this.lbl_Titulo.Text = "Gestión de Alertas:";
            this.lbl_Titulo.Click += new System.EventHandler(this.lbl_Titulo_Click);
            // 
            // cmb_Usuario
            // 
            this.cmb_Usuario.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cmb_Usuario.FormattingEnabled = true;
            this.cmb_Usuario.Location = new System.Drawing.Point(240, 104);
            this.cmb_Usuario.Name = "cmb_Usuario";
            this.cmb_Usuario.Size = new System.Drawing.Size(274, 28);
            this.cmb_Usuario.TabIndex = 38;
            // 
            // cmb_Sensor
            // 
            this.cmb_Sensor.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cmb_Sensor.FormattingEnabled = true;
            this.cmb_Sensor.Location = new System.Drawing.Point(240, 140);
            this.cmb_Sensor.Name = "cmb_Sensor";
            this.cmb_Sensor.Size = new System.Drawing.Size(274, 28);
            this.cmb_Sensor.TabIndex = 39;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.BackgroundImage")));
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Modificar.Location = new System.Drawing.Point(325, 402);
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
            this.btn_Cancelar.Location = new System.Drawing.Point(423, 402);
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
            this.btn_Grabar.Location = new System.Drawing.Point(240, 402);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(79, 28);
            this.btn_Grabar.TabIndex = 40;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // cmb_Lecturas
            // 
            this.cmb_Lecturas.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cmb_Lecturas.FormattingEnabled = true;
            this.cmb_Lecturas.Location = new System.Drawing.Point(240, 174);
            this.cmb_Lecturas.Name = "cmb_Lecturas";
            this.cmb_Lecturas.Size = new System.Drawing.Size(274, 28);
            this.cmb_Lecturas.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(52, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 28);
            this.label1.TabIndex = 43;
            this.label1.Text = "Lecturas Registradas:";
            // 
            // frm_alertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::SistemaDeAlarma.Properties.Resources.Logo_Negocio_Floral_Beige;
            this.ClientSize = new System.Drawing.Size(808, 471);
            this.Controls.Add(this.cmb_Lecturas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Grabar);
            this.Controls.Add(this.cmb_Sensor);
            this.Controls.Add(this.cmb_Usuario);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.txt_Nivel);
            this.Controls.Add(this.txt_Tipo);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.lst_Alertas);
            this.Controls.Add(this.lbl_Lista);
            this.Controls.Add(this.lbl_Descipcion);
            this.Controls.Add(this.lbl_Nivel);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.lbl_IdSensor);
            this.Controls.Add(this.lbl_IdUsuario);
            this.Controls.Add(this.lbl_Titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_alertas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALERTAS";
            this.Load += new System.EventHandler(this.frm_alertas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.TextBox txt_Nivel;
        private System.Windows.Forms.TextBox txt_Tipo;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.ListBox lst_Alertas;
        private System.Windows.Forms.Label lbl_Lista;
        private System.Windows.Forms.Label lbl_Descipcion;
        private System.Windows.Forms.Label lbl_Nivel;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_IdSensor;
        private System.Windows.Forms.Label lbl_IdUsuario;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.ComboBox cmb_Usuario;
        private System.Windows.Forms.ComboBox cmb_Sensor;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.ComboBox cmb_Lecturas;
        private System.Windows.Forms.Label label1;
    }
}