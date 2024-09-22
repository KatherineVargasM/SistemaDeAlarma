namespace SistemaDeAlarma.views.Usuarios
{
    partial class frm_usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_usuarios));
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.lbl_Nombres = new System.Windows.Forms.Label();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_FechaIngreso = new System.Windows.Forms.Label();
            this.lbl_Lista = new System.Windows.Forms.Label();
            this.lst_Usuarios = new System.Windows.Forms.ListBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Rol = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.dtp_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Titulo.Location = new System.Drawing.Point(217, 30);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(306, 51);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Gestión de Usuarios";
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Apellidos.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellidos.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Apellidos.Location = new System.Drawing.Point(139, 99);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(89, 28);
            this.lbl_Apellidos.TabIndex = 1;
            this.lbl_Apellidos.Text = "Apellidos:";
            // 
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nombres.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombres.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Nombres.Location = new System.Drawing.Point(141, 138);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(87, 28);
            this.lbl_Nombres.TabIndex = 2;
            this.lbl_Nombres.Text = "Nombres:";
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Rol.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rol.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Rol.Location = new System.Drawing.Point(89, 175);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(139, 28);
            this.lbl_Rol.TabIndex = 3;
            this.lbl_Rol.Text = "Rol del Usuario:";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Telefono.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Telefono.Location = new System.Drawing.Point(141, 213);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(84, 28);
            this.lbl_Telefono.TabIndex = 4;
            this.lbl_Telefono.Text = "Teléfono:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Email.Location = new System.Drawing.Point(166, 254);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(63, 28);
            this.lbl_Email.TabIndex = 5;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_FechaIngreso
            // 
            this.lbl_FechaIngreso.AutoSize = true;
            this.lbl_FechaIngreso.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FechaIngreso.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaIngreso.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_FechaIngreso.Location = new System.Drawing.Point(41, 292);
            this.lbl_FechaIngreso.Name = "lbl_FechaIngreso";
            this.lbl_FechaIngreso.Size = new System.Drawing.Size(183, 28);
            this.lbl_FechaIngreso.TabIndex = 6;
            this.lbl_FechaIngreso.Text = "Fecha de Nacimiento:";
            // 
            // lbl_Lista
            // 
            this.lbl_Lista.AutoSize = true;
            this.lbl_Lista.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Lista.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lista.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Lista.Location = new System.Drawing.Point(529, 97);
            this.lbl_Lista.Name = "lbl_Lista";
            this.lbl_Lista.Size = new System.Drawing.Size(153, 28);
            this.lbl_Lista.TabIndex = 7;
            this.lbl_Lista.Text = "Lista de Usuarios:";
            // 
            // lst_Usuarios
            // 
            this.lst_Usuarios.BackColor = System.Drawing.Color.Linen;
            this.lst_Usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_Usuarios.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lst_Usuarios.FormattingEnabled = true;
            this.lst_Usuarios.ItemHeight = 20;
            this.lst_Usuarios.Location = new System.Drawing.Point(534, 128);
            this.lst_Usuarios.Name = "lst_Usuarios";
            this.lst_Usuarios.Size = new System.Drawing.Size(180, 180);
            this.lst_Usuarios.TabIndex = 8;
            this.lst_Usuarios.DoubleClick += new System.EventHandler(this.lst_Usuarios_DoubleClick);
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txt_Apellido.Location = new System.Drawing.Point(232, 99);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(274, 26);
            this.txt_Apellido.TabIndex = 9;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txt_Nombre.Location = new System.Drawing.Point(232, 138);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(274, 26);
            this.txt_Nombre.TabIndex = 10;
            // 
            // txt_Rol
            // 
            this.txt_Rol.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txt_Rol.Location = new System.Drawing.Point(232, 175);
            this.txt_Rol.Name = "txt_Rol";
            this.txt_Rol.Size = new System.Drawing.Size(274, 26);
            this.txt_Rol.TabIndex = 11;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txt_Telefono.Location = new System.Drawing.Point(232, 213);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(274, 26);
            this.txt_Telefono.TabIndex = 12;
            // 
            // txt_Email
            // 
            this.txt_Email.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txt_Email.Location = new System.Drawing.Point(232, 254);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(274, 26);
            this.txt_Email.TabIndex = 13;
            // 
            // dtp_FechaNacimiento
            // 
            this.dtp_FechaNacimiento.Location = new System.Drawing.Point(232, 292);
            this.dtp_FechaNacimiento.Name = "dtp_FechaNacimiento";
            this.dtp_FechaNacimiento.Size = new System.Drawing.Size(274, 26);
            this.dtp_FechaNacimiento.TabIndex = 14;
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Grabar.BackgroundImage")));
            this.btn_Grabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Grabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Grabar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Grabar.Location = new System.Drawing.Point(189, 363);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(135, 28);
            this.btn_Grabar.TabIndex = 15;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Cancelar.Location = new System.Drawing.Point(471, 363);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(131, 28);
            this.btn_Cancelar.TabIndex = 16;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.BackgroundImage")));
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Modificar.Location = new System.Drawing.Point(330, 363);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(135, 28);
            this.btn_Modificar.TabIndex = 17;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaDeAlarma.Properties.Resources.Logo_Negocio_Floral_Beige;
            this.ClientSize = new System.Drawing.Size(768, 420);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Grabar);
            this.Controls.Add(this.dtp_FechaNacimiento);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Rol);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.lst_Usuarios);
            this.Controls.Add(this.lbl_Lista);
            this.Controls.Add(this.lbl_FechaIngreso);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_Rol);
            this.Controls.Add(this.lbl_Nombres);
            this.Controls.Add(this.lbl_Apellidos);
            this.Controls.Add(this.lbl_Titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USUARIOS";
            this.Load += new System.EventHandler(this.frm_usuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.Label lbl_Nombres;
        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_FechaIngreso;
        private System.Windows.Forms.Label lbl_Lista;
        private System.Windows.Forms.ListBox lst_Usuarios;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Rol;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.DateTimePicker dtp_FechaNacimiento;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Modificar;
    }
}