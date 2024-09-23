namespace SistemaDeAlarma.views.Alertas
{
    partial class frm_listaAlertas
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
            this.alertasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaAlarmaHumoDataSet = new SistemaDeAlarma.SistemaAlarmaHumoDataSet();
            this.alertasTableAdapter = new SistemaDeAlarma.SistemaAlarmaHumoDataSetTableAdapters.alertasTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alertasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDALERTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidousuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechalecturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarubicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoalertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelalarmaalertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionalertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechahoraalertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.alertasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaAlarmaHumoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Titulo.Location = new System.Drawing.Point(61, 34);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(252, 51);
            this.lbl_Titulo.TabIndex = 5;
            this.lbl_Titulo.Text = "Lista de Alertas";
            // 
            // alertasBindingSource
            // 
            this.alertasBindingSource.DataMember = "alertas";
            this.alertasBindingSource.DataSource = this.sistemaAlarmaHumoDataSet;
            // 
            // sistemaAlarmaHumoDataSet
            // 
            this.sistemaAlarmaHumoDataSet.DataSetName = "SistemaAlarmaHumoDataSet";
            this.sistemaAlarmaHumoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alertasTableAdapter
            // 
            this.alertasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDALERTADataGridViewTextBoxColumn,
            this.apellidousuarioDataGridViewTextBoxColumn,
            this.fechalecturaDataGridViewTextBoxColumn,
            this.lugarubicacionDataGridViewTextBoxColumn,
            this.tipoalertaDataGridViewTextBoxColumn,
            this.nivelalarmaalertaDataGridViewTextBoxColumn,
            this.descripcionalertaDataGridViewTextBoxColumn,
            this.fechahoraalertaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alertasBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(70, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1045, 244);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // alertasBindingSource1
            // 
            this.alertasBindingSource1.DataMember = "alertas";
            this.alertasBindingSource1.DataSource = this.sistemaAlarmaHumoDataSet;
            // 
            // iDALERTADataGridViewTextBoxColumn
            // 
            this.iDALERTADataGridViewTextBoxColumn.DataPropertyName = "ID_ALERTA";
            this.iDALERTADataGridViewTextBoxColumn.HeaderText = "Código";
            this.iDALERTADataGridViewTextBoxColumn.Name = "iDALERTADataGridViewTextBoxColumn";
            this.iDALERTADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDALERTADataGridViewTextBoxColumn.Width = 80;
            // 
            // apellidousuarioDataGridViewTextBoxColumn
            // 
            this.apellidousuarioDataGridViewTextBoxColumn.DataPropertyName = "apellido_usuario";
            this.apellidousuarioDataGridViewTextBoxColumn.HeaderText = "Apellido del Usuario";
            this.apellidousuarioDataGridViewTextBoxColumn.Name = "apellidousuarioDataGridViewTextBoxColumn";
            this.apellidousuarioDataGridViewTextBoxColumn.Width = 175;
            // 
            // fechalecturaDataGridViewTextBoxColumn
            // 
            this.fechalecturaDataGridViewTextBoxColumn.DataPropertyName = "fecha_lectura";
            this.fechalecturaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechalecturaDataGridViewTextBoxColumn.Name = "fechalecturaDataGridViewTextBoxColumn";
            this.fechalecturaDataGridViewTextBoxColumn.Width = 165;
            // 
            // lugarubicacionDataGridViewTextBoxColumn
            // 
            this.lugarubicacionDataGridViewTextBoxColumn.DataPropertyName = "lugar_ubicacion";
            this.lugarubicacionDataGridViewTextBoxColumn.HeaderText = "Ubicación";
            this.lugarubicacionDataGridViewTextBoxColumn.Name = "lugarubicacionDataGridViewTextBoxColumn";
            this.lugarubicacionDataGridViewTextBoxColumn.Width = 150;
            // 
            // tipoalertaDataGridViewTextBoxColumn
            // 
            this.tipoalertaDataGridViewTextBoxColumn.DataPropertyName = "tipo_alerta";
            this.tipoalertaDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoalertaDataGridViewTextBoxColumn.Name = "tipoalertaDataGridViewTextBoxColumn";
            // 
            // nivelalarmaalertaDataGridViewTextBoxColumn
            // 
            this.nivelalarmaalertaDataGridViewTextBoxColumn.DataPropertyName = "nivel_alarma_alerta";
            this.nivelalarmaalertaDataGridViewTextBoxColumn.HeaderText = "Nivel de Alarma";
            this.nivelalarmaalertaDataGridViewTextBoxColumn.Name = "nivelalarmaalertaDataGridViewTextBoxColumn";
            this.nivelalarmaalertaDataGridViewTextBoxColumn.Width = 150;
            // 
            // descripcionalertaDataGridViewTextBoxColumn
            // 
            this.descripcionalertaDataGridViewTextBoxColumn.DataPropertyName = "descripcion_alerta";
            this.descripcionalertaDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionalertaDataGridViewTextBoxColumn.Name = "descripcionalertaDataGridViewTextBoxColumn";
            this.descripcionalertaDataGridViewTextBoxColumn.Width = 300;
            // 
            // fechahoraalertaDataGridViewTextBoxColumn
            // 
            this.fechahoraalertaDataGridViewTextBoxColumn.DataPropertyName = "fecha_hora_alerta";
            this.fechahoraalertaDataGridViewTextBoxColumn.HeaderText = "Fecha Registro";
            this.fechahoraalertaDataGridViewTextBoxColumn.Name = "fechahoraalertaDataGridViewTextBoxColumn";
            this.fechahoraalertaDataGridViewTextBoxColumn.Visible = false;
            // 
            // frm_listaAlertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaDeAlarma.Properties.Resources.Logo_Negocio_Floral_Beige;
            this.ClientSize = new System.Drawing.Size(1162, 385);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_listaAlertas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Alerta";
            this.Load += new System.EventHandler(this.frm_listaAlertas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alertasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaAlarmaHumoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private SistemaAlarmaHumoDataSet sistemaAlarmaHumoDataSet;
        private System.Windows.Forms.BindingSource alertasBindingSource;
        private SistemaAlarmaHumoDataSetTableAdapters.alertasTableAdapter alertasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSENSORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLECTURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource alertasBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDALERTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidousuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechalecturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarubicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoalertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelalarmaalertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionalertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechahoraalertaDataGridViewTextBoxColumn;
    }
}