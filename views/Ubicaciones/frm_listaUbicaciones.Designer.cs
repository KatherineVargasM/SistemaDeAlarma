namespace SistemaDeAlarma.views.Ubicaciones
{
    partial class frm_listaUbicaciones
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
            this.sistemaAlarmaHumoDataSet = new SistemaDeAlarma.SistemaAlarmaHumoDataSet();
            this.ubicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ubicacionesTableAdapter = new SistemaDeAlarma.SistemaAlarmaHumoDataSetTableAdapters.ubicacionesTableAdapter();
            this.iDUBICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarubicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionubicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaAlarmaHumoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Titulo.Location = new System.Drawing.Point(47, 27);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(313, 51);
            this.lbl_Titulo.TabIndex = 3;
            this.lbl_Titulo.Text = "Lista de Ubicaciones";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUBICACIONDataGridViewTextBoxColumn,
            this.lugarubicacionDataGridViewTextBoxColumn,
            this.descripcionubicacionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ubicacionesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(56, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(708, 261);
            this.dataGridView1.TabIndex = 4;
            // 
            // sistemaAlarmaHumoDataSet
            // 
            this.sistemaAlarmaHumoDataSet.DataSetName = "SistemaAlarmaHumoDataSet";
            this.sistemaAlarmaHumoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ubicacionesBindingSource
            // 
            this.ubicacionesBindingSource.DataMember = "ubicaciones";
            this.ubicacionesBindingSource.DataSource = this.sistemaAlarmaHumoDataSet;
            // 
            // ubicacionesTableAdapter
            // 
            this.ubicacionesTableAdapter.ClearBeforeFill = true;
            // 
            // iDUBICACIONDataGridViewTextBoxColumn
            // 
            this.iDUBICACIONDataGridViewTextBoxColumn.DataPropertyName = "ID_UBICACION";
            this.iDUBICACIONDataGridViewTextBoxColumn.HeaderText = "Código";
            this.iDUBICACIONDataGridViewTextBoxColumn.Name = "iDUBICACIONDataGridViewTextBoxColumn";
            this.iDUBICACIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDUBICACIONDataGridViewTextBoxColumn.Width = 80;
            // 
            // lugarubicacionDataGridViewTextBoxColumn
            // 
            this.lugarubicacionDataGridViewTextBoxColumn.DataPropertyName = "lugar_ubicacion";
            this.lugarubicacionDataGridViewTextBoxColumn.HeaderText = "Ubicación";
            this.lugarubicacionDataGridViewTextBoxColumn.Name = "lugarubicacionDataGridViewTextBoxColumn";
            this.lugarubicacionDataGridViewTextBoxColumn.Width = 180;
            // 
            // descripcionubicacionDataGridViewTextBoxColumn
            // 
            this.descripcionubicacionDataGridViewTextBoxColumn.DataPropertyName = "descripcion_ubicacion";
            this.descripcionubicacionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionubicacionDataGridViewTextBoxColumn.Name = "descripcionubicacionDataGridViewTextBoxColumn";
            this.descripcionubicacionDataGridViewTextBoxColumn.Width = 400;
            // 
            // frm_listaUbicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaDeAlarma.Properties.Resources.Logo_Negocio_Floral_Beige;
            this.ClientSize = new System.Drawing.Size(830, 385);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_listaUbicaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Ubicaciones";
            this.Load += new System.EventHandler(this.frm_listaUbicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaAlarmaHumoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SistemaAlarmaHumoDataSet sistemaAlarmaHumoDataSet;
        private System.Windows.Forms.BindingSource ubicacionesBindingSource;
        private SistemaAlarmaHumoDataSetTableAdapters.ubicacionesTableAdapter ubicacionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUBICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarubicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionubicacionDataGridViewTextBoxColumn;
    }
}