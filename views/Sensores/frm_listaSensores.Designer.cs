namespace SistemaDeAlarma.views.Sensores
{
    partial class frm_listaSensores
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDSENSORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiposensorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechainstalacionsensorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadosensorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarubicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaAlarmaHumoDataSet = new SistemaDeAlarma.SistemaAlarmaHumoDataSet();
            this.sensoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sensoresTableAdapter = new SistemaDeAlarma.SistemaAlarmaHumoDataSetTableAdapters.sensoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaAlarmaHumoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Titulo.Location = new System.Drawing.Point(45, 26);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(271, 51);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "Lista de Sensores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSENSORDataGridViewTextBoxColumn,
            this.tiposensorDataGridViewTextBoxColumn,
            this.fechainstalacionsensorDataGridViewTextBoxColumn,
            this.estadosensorDataGridViewTextBoxColumn,
            this.lugarubicacionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sensoresBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(54, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 248);
            this.dataGridView1.TabIndex = 3;
            // 
            // iDSENSORDataGridViewTextBoxColumn
            // 
            this.iDSENSORDataGridViewTextBoxColumn.DataPropertyName = "ID_SENSOR";
            this.iDSENSORDataGridViewTextBoxColumn.HeaderText = "Código";
            this.iDSENSORDataGridViewTextBoxColumn.Name = "iDSENSORDataGridViewTextBoxColumn";
            this.iDSENSORDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSENSORDataGridViewTextBoxColumn.Width = 70;
            // 
            // tiposensorDataGridViewTextBoxColumn
            // 
            this.tiposensorDataGridViewTextBoxColumn.DataPropertyName = "tipo_sensor";
            this.tiposensorDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tiposensorDataGridViewTextBoxColumn.Name = "tiposensorDataGridViewTextBoxColumn";
            this.tiposensorDataGridViewTextBoxColumn.Width = 120;
            // 
            // fechainstalacionsensorDataGridViewTextBoxColumn
            // 
            this.fechainstalacionsensorDataGridViewTextBoxColumn.DataPropertyName = "fecha_instalacion_sensor";
            this.fechainstalacionsensorDataGridViewTextBoxColumn.HeaderText = "Fecha de Instalación";
            this.fechainstalacionsensorDataGridViewTextBoxColumn.Name = "fechainstalacionsensorDataGridViewTextBoxColumn";
            this.fechainstalacionsensorDataGridViewTextBoxColumn.Width = 180;
            // 
            // estadosensorDataGridViewTextBoxColumn
            // 
            this.estadosensorDataGridViewTextBoxColumn.DataPropertyName = "estado_sensor";
            this.estadosensorDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadosensorDataGridViewTextBoxColumn.Name = "estadosensorDataGridViewTextBoxColumn";
            this.estadosensorDataGridViewTextBoxColumn.Width = 80;
            // 
            // lugarubicacionDataGridViewTextBoxColumn
            // 
            this.lugarubicacionDataGridViewTextBoxColumn.DataPropertyName = "lugar_ubicacion";
            this.lugarubicacionDataGridViewTextBoxColumn.HeaderText = "Ubicación";
            this.lugarubicacionDataGridViewTextBoxColumn.Name = "lugarubicacionDataGridViewTextBoxColumn";
            this.lugarubicacionDataGridViewTextBoxColumn.Width = 175;
            // 
            // sensoresBindingSource1
            // 
            this.sensoresBindingSource1.DataMember = "sensores";
            this.sensoresBindingSource1.DataSource = this.sistemaAlarmaHumoDataSet;
            // 
            // sistemaAlarmaHumoDataSet
            // 
            this.sistemaAlarmaHumoDataSet.DataSetName = "SistemaAlarmaHumoDataSet";
            this.sistemaAlarmaHumoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sensoresBindingSource
            // 
            this.sensoresBindingSource.DataMember = "sensores";
            this.sensoresBindingSource.DataSource = this.sistemaAlarmaHumoDataSet;
            // 
            // sensoresTableAdapter
            // 
            this.sensoresTableAdapter.ClearBeforeFill = true;
            // 
            // frm_listaSensores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaDeAlarma.Properties.Resources.Logo_Negocio_Floral_Beige;
            this.ClientSize = new System.Drawing.Size(791, 385);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_listaSensores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Sensores";
            this.Load += new System.EventHandler(this.frm_listaSensores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaAlarmaHumoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SistemaAlarmaHumoDataSet sistemaAlarmaHumoDataSet;
        private System.Windows.Forms.BindingSource sensoresBindingSource;
        private SistemaAlarmaHumoDataSetTableAdapters.sensoresTableAdapter sensoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUBICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sensoresBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSENSORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposensorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainstalacionsensorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadosensorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarubicacionDataGridViewTextBoxColumn;
    }
}