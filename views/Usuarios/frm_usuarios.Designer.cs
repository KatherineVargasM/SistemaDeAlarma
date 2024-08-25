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
            this.dtp_FechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(236, 42);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(250, 29);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Gestión de Usuarios";
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.Location = new System.Drawing.Point(144, 93);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(77, 20);
            this.lbl_Apellidos.TabIndex = 1;
            this.lbl_Apellidos.Text = "Apellidos:";
            // 
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.Location = new System.Drawing.Point(144, 132);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(77, 20);
            this.lbl_Nombres.TabIndex = 2;
            this.lbl_Nombres.Text = "Nombres:";
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Location = new System.Drawing.Point(100, 166);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(121, 20);
            this.lbl_Rol.TabIndex = 3;
            this.lbl_Rol.Text = "Rol del Usuario:";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(144, 204);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(75, 20);
            this.lbl_Telefono.TabIndex = 4;
            this.lbl_Telefono.Text = "Teléfono:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(169, 248);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(52, 20);
            this.lbl_Email.TabIndex = 5;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_FechaIngreso
            // 
            this.lbl_FechaIngreso.AutoSize = true;
            this.lbl_FechaIngreso.Location = new System.Drawing.Point(46, 283);
            this.lbl_FechaIngreso.Name = "lbl_FechaIngreso";
            this.lbl_FechaIngreso.Size = new System.Drawing.Size(175, 20);
            this.lbl_FechaIngreso.TabIndex = 6;
            this.lbl_FechaIngreso.Text = "Fecha Ingreso Usuario:";
            // 
            // lbl_Lista
            // 
            this.lbl_Lista.AutoSize = true;
            this.lbl_Lista.Location = new System.Drawing.Point(524, 67);
            this.lbl_Lista.Name = "lbl_Lista";
            this.lbl_Lista.Size = new System.Drawing.Size(136, 20);
            this.lbl_Lista.TabIndex = 7;
            this.lbl_Lista.Text = "Lista de Usuarios:";
            // 
            // lst_Usuarios
            // 
            this.lst_Usuarios.FormattingEnabled = true;
            this.lst_Usuarios.ItemHeight = 20;
            this.lst_Usuarios.Location = new System.Drawing.Point(528, 90);
            this.lst_Usuarios.Name = "lst_Usuarios";
            this.lst_Usuarios.Size = new System.Drawing.Size(306, 224);
            this.lst_Usuarios.TabIndex = 8;
            this.lst_Usuarios.DoubleClick += new System.EventHandler(this.lst_Usuarios_DoubleClick);
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(227, 90);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(274, 26);
            this.txt_Apellido.TabIndex = 9;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(227, 129);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(274, 26);
            this.txt_Nombre.TabIndex = 10;
            // 
            // txt_Rol
            // 
            this.txt_Rol.Location = new System.Drawing.Point(227, 166);
            this.txt_Rol.Name = "txt_Rol";
            this.txt_Rol.Size = new System.Drawing.Size(274, 26);
            this.txt_Rol.TabIndex = 11;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(227, 204);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(274, 26);
            this.txt_Telefono.TabIndex = 12;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(227, 245);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(274, 26);
            this.txt_Email.TabIndex = 13;
            // 
            // dtp_FechaIngreso
            // 
            this.dtp_FechaIngreso.Location = new System.Drawing.Point(227, 283);
            this.dtp_FechaIngreso.Name = "dtp_FechaIngreso";
            this.dtp_FechaIngreso.Size = new System.Drawing.Size(274, 26);
            this.dtp_FechaIngreso.TabIndex = 14;
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Location = new System.Drawing.Point(271, 324);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(89, 35);
            this.btn_Grabar.TabIndex = 15;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(366, 324);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(89, 35);
            this.btn_Cancelar.TabIndex = 16;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(271, 365);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(89, 35);
            this.btn_Modificar.TabIndex = 17;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(366, 365);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(89, 35);
            this.btn_Eliminar.TabIndex = 18;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 429);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Grabar);
            this.Controls.Add(this.dtp_FechaIngreso);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_usuarios";
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
        private System.Windows.Forms.DateTimePicker dtp_FechaIngreso;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}