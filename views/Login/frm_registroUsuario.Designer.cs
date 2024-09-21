namespace SistemaDeAlarma.views.Login
{
    partial class frm_registroUsuario
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
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_rol = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_FechaNaci = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.lbl_Nombres = new System.Windows.Forms.Label();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.dtp_fechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_siguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txt_email.Location = new System.Drawing.Point(65, 319);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(274, 26);
            this.txt_email.TabIndex = 26;
            // 
            // txt_telefono
            // 
            this.txt_telefono.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txt_telefono.Location = new System.Drawing.Point(65, 267);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(274, 26);
            this.txt_telefono.TabIndex = 25;
            // 
            // txt_rol
            // 
            this.txt_rol.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txt_rol.Location = new System.Drawing.Point(65, 215);
            this.txt_rol.Name = "txt_rol";
            this.txt_rol.Size = new System.Drawing.Size(274, 26);
            this.txt_rol.TabIndex = 24;
            // 
            // txt_nombre
            // 
            this.txt_nombre.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txt_nombre.Location = new System.Drawing.Point(65, 163);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(274, 26);
            this.txt_nombre.TabIndex = 23;
            // 
            // txt_apellido
            // 
            this.txt_apellido.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txt_apellido.Location = new System.Drawing.Point(65, 111);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(274, 26);
            this.txt_apellido.TabIndex = 22;
            // 
            // lbl_FechaNaci
            // 
            this.lbl_FechaNaci.AutoSize = true;
            this.lbl_FechaNaci.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FechaNaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaNaci.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_FechaNaci.Location = new System.Drawing.Point(64, 359);
            this.lbl_FechaNaci.Name = "lbl_FechaNaci";
            this.lbl_FechaNaci.Size = new System.Drawing.Size(183, 20);
            this.lbl_FechaNaci.TabIndex = 21;
            this.lbl_FechaNaci.Text = "Fecha de Nacimiento:";
            this.lbl_FechaNaci.Click += new System.EventHandler(this.lbl_FechaNaci_Click);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Email.Location = new System.Drawing.Point(64, 296);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(58, 20);
            this.lbl_Email.TabIndex = 20;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Telefono.Location = new System.Drawing.Point(64, 244);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(84, 20);
            this.lbl_Telefono.TabIndex = 19;
            this.lbl_Telefono.Text = "Teléfono:";
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rol.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Rol.Location = new System.Drawing.Point(63, 192);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(41, 20);
            this.lbl_Rol.TabIndex = 18;
            this.lbl_Rol.Text = "Rol:";
            // 
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombres.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Nombres.Location = new System.Drawing.Point(63, 140);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(85, 20);
            this.lbl_Nombres.TabIndex = 17;
            this.lbl_Nombres.Text = "Nombres:";
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellidos.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Apellidos.Location = new System.Drawing.Point(61, 88);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(87, 20);
            this.lbl_Apellidos.TabIndex = 16;
            this.lbl_Apellidos.Text = "Apellidos:";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Titulo.Location = new System.Drawing.Point(71, 30);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(225, 29);
            this.lbl_Titulo.TabIndex = 15;
            this.lbl_Titulo.Text = "Ingresa tus Datos";
            // 
            // dtp_fechanacimiento
            // 
            this.dtp_fechanacimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechanacimiento.CalendarForeColor = System.Drawing.Color.White;
            this.dtp_fechanacimiento.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtp_fechanacimiento.CalendarTitleForeColor = System.Drawing.Color.SaddleBrown;
            this.dtp_fechanacimiento.Location = new System.Drawing.Point(65, 382);
            this.dtp_fechanacimiento.Name = "dtp_fechanacimiento";
            this.dtp_fechanacimiento.Size = new System.Drawing.Size(274, 26);
            this.dtp_fechanacimiento.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaDeAlarma.Properties.Resources.a;
            this.pictureBox1.Location = new System.Drawing.Point(302, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_siguiente.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_siguiente.Image = global::SistemaDeAlarma.Properties.Resources.Logo_Negocio_Floral_Beige;
            this.btn_siguiente.Location = new System.Drawing.Point(240, 429);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(99, 29);
            this.btn_siguiente.TabIndex = 29;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            this.btn_siguiente.MouseEnter += new System.EventHandler(this.btn_siguiente_MouseEnter);
            this.btn_siguiente.MouseLeave += new System.EventHandler(this.btn_siguiente_MouseLeave);
            // 
            // frm_registroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaDeAlarma.Properties.Resources.Logo_Negocio_Floral_Beige;
            this.ClientSize = new System.Drawing.Size(398, 487);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtp_fechanacimiento);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_rol);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.lbl_FechaNaci);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_Rol);
            this.Controls.Add(this.lbl_Nombres);
            this.Controls.Add(this.lbl_Apellidos);
            this.Controls.Add(this.lbl_Titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_registroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Regístese!";
            this.Load += new System.EventHandler(this.frm_registroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_rol;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbl_FechaNaci;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.Label lbl_Nombres;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.DateTimePicker dtp_fechanacimiento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_siguiente;
    }
}