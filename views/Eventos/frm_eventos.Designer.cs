namespace SistemaDeAlarma.views.Eventos
{
    partial class frm_eventos
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
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_Nivel = new System.Windows.Forms.TextBox();
            this.txt_Tipo = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.lst_Eventos = new System.Windows.Forms.ListBox();
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
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(351, 399);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(89, 35);
            this.btn_Eliminar.TabIndex = 37;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(256, 399);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(89, 35);
            this.btn_Modificar.TabIndex = 36;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(351, 358);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(89, 35);
            this.btn_Cancelar.TabIndex = 35;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Location = new System.Drawing.Point(256, 358);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(89, 35);
            this.btn_Grabar.TabIndex = 34;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Location = new System.Drawing.Point(217, 164);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(274, 26);
            this.dtp_Fecha.TabIndex = 33;
            // 
            // txt_Nivel
            // 
            this.txt_Nivel.Location = new System.Drawing.Point(217, 243);
            this.txt_Nivel.Name = "txt_Nivel";
            this.txt_Nivel.Size = new System.Drawing.Size(274, 26);
            this.txt_Nivel.TabIndex = 32;
            // 
            // txt_Tipo
            // 
            this.txt_Tipo.Location = new System.Drawing.Point(217, 202);
            this.txt_Tipo.Name = "txt_Tipo";
            this.txt_Tipo.Size = new System.Drawing.Size(274, 26);
            this.txt_Tipo.TabIndex = 31;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(217, 281);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(274, 57);
            this.txt_Descripcion.TabIndex = 30;
            // 
            // lst_Eventos
            // 
            this.lst_Eventos.FormattingEnabled = true;
            this.lst_Eventos.ItemHeight = 20;
            this.lst_Eventos.Location = new System.Drawing.Point(518, 88);
            this.lst_Eventos.Name = "lst_Eventos";
            this.lst_Eventos.Size = new System.Drawing.Size(306, 224);
            this.lst_Eventos.TabIndex = 27;
            this.lst_Eventos.DoubleClick += new System.EventHandler(this.lst_Eventos_DoubleClick);
            // 
            // lbl_Lista
            // 
            this.lbl_Lista.AutoSize = true;
            this.lbl_Lista.Location = new System.Drawing.Point(514, 65);
            this.lbl_Lista.Name = "lbl_Lista";
            this.lbl_Lista.Size = new System.Drawing.Size(131, 20);
            this.lbl_Lista.TabIndex = 26;
            this.lbl_Lista.Text = "Lista de Eventos:";
            // 
            // lbl_Descipcion
            // 
            this.lbl_Descipcion.AutoSize = true;
            this.lbl_Descipcion.Location = new System.Drawing.Point(115, 281);
            this.lbl_Descipcion.Name = "lbl_Descipcion";
            this.lbl_Descipcion.Size = new System.Drawing.Size(96, 20);
            this.lbl_Descipcion.TabIndex = 25;
            this.lbl_Descipcion.Text = "Descripción:";
            // 
            // lbl_Nivel
            // 
            this.lbl_Nivel.AutoSize = true;
            this.lbl_Nivel.Location = new System.Drawing.Point(89, 243);
            this.lbl_Nivel.Name = "lbl_Nivel";
            this.lbl_Nivel.Size = new System.Drawing.Size(122, 20);
            this.lbl_Nivel.TabIndex = 24;
            this.lbl_Nivel.Text = "Nivel de Alarma:";
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Location = new System.Drawing.Point(92, 202);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(119, 20);
            this.lbl_Tipo.TabIndex = 23;
            this.lbl_Tipo.Text = "Tipo de Evento:";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(77, 164);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(134, 20);
            this.lbl_Fecha.TabIndex = 22;
            this.lbl_Fecha.Text = "Fecha de Evento:";
            // 
            // lbl_IdSensor
            // 
            this.lbl_IdSensor.AutoSize = true;
            this.lbl_IdSensor.Location = new System.Drawing.Point(121, 127);
            this.lbl_IdSensor.Name = "lbl_IdSensor";
            this.lbl_IdSensor.Size = new System.Drawing.Size(90, 20);
            this.lbl_IdSensor.TabIndex = 21;
            this.lbl_IdSensor.Text = "ID_Sensor:";
            // 
            // lbl_IdUsuario
            // 
            this.lbl_IdUsuario.AutoSize = true;
            this.lbl_IdUsuario.Location = new System.Drawing.Point(143, 86);
            this.lbl_IdUsuario.Name = "lbl_IdUsuario";
            this.lbl_IdUsuario.Size = new System.Drawing.Size(68, 20);
            this.lbl_IdUsuario.TabIndex = 20;
            this.lbl_IdUsuario.Text = "Usuario:";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(226, 40);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(247, 29);
            this.lbl_Titulo.TabIndex = 19;
            this.lbl_Titulo.Text = "Gestión de Eventos:";
            // 
            // cmb_Usuario
            // 
            this.cmb_Usuario.FormattingEnabled = true;
            this.cmb_Usuario.Location = new System.Drawing.Point(217, 83);
            this.cmb_Usuario.Name = "cmb_Usuario";
            this.cmb_Usuario.Size = new System.Drawing.Size(274, 28);
            this.cmb_Usuario.TabIndex = 38;
            // 
            // cmb_Sensor
            // 
            this.cmb_Sensor.FormattingEnabled = true;
            this.cmb_Sensor.Location = new System.Drawing.Point(217, 119);
            this.cmb_Sensor.Name = "cmb_Sensor";
            this.cmb_Sensor.Size = new System.Drawing.Size(274, 28);
            this.cmb_Sensor.TabIndex = 39;
            // 
            // frm_eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 458);
            this.Controls.Add(this.cmb_Sensor);
            this.Controls.Add(this.cmb_Usuario);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Grabar);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.txt_Nivel);
            this.Controls.Add(this.txt_Tipo);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.lst_Eventos);
            this.Controls.Add(this.lbl_Lista);
            this.Controls.Add(this.lbl_Descipcion);
            this.Controls.Add(this.lbl_Nivel);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.lbl_IdSensor);
            this.Controls.Add(this.lbl_IdUsuario);
            this.Controls.Add(this.lbl_Titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_eventos";
            this.Text = "EVENTOS";
            this.Load += new System.EventHandler(this.frm_eventos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.TextBox txt_Nivel;
        private System.Windows.Forms.TextBox txt_Tipo;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.ListBox lst_Eventos;
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
    }
}