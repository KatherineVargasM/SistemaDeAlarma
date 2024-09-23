namespace SistemaDeAlarma.views.Lecturas
{
    partial class frm_listaLecturas
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
            this.iDLECTURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechalecturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espesorhumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abundanciahumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaAlarmaHumoDataSet = new SistemaDeAlarma.SistemaAlarmaHumoDataSet();
            this.lecturasTableAdapter = new SistemaDeAlarma.SistemaAlarmaHumoDataSetTableAdapters.lecturasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaAlarmaHumoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Titulo.Location = new System.Drawing.Point(41, 29);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(452, 51);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "Lista de Lecturas Registradas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDLECTURADataGridViewTextBoxColumn,
            this.fechalecturaDataGridViewTextBoxColumn,
            this.espesorhumoDataGridViewTextBoxColumn,
            this.abundanciahumoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lecturasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(50, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 245);
            this.dataGridView1.TabIndex = 5;
            // 
            // iDLECTURADataGridViewTextBoxColumn
            // 
            this.iDLECTURADataGridViewTextBoxColumn.DataPropertyName = "ID_LECTURA";
            this.iDLECTURADataGridViewTextBoxColumn.HeaderText = "Código";
            this.iDLECTURADataGridViewTextBoxColumn.Name = "iDLECTURADataGridViewTextBoxColumn";
            this.iDLECTURADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDLECTURADataGridViewTextBoxColumn.Width = 80;
            // 
            // fechalecturaDataGridViewTextBoxColumn
            // 
            this.fechalecturaDataGridViewTextBoxColumn.DataPropertyName = "fecha_lectura";
            this.fechalecturaDataGridViewTextBoxColumn.HeaderText = "Fecha:";
            this.fechalecturaDataGridViewTextBoxColumn.Name = "fechalecturaDataGridViewTextBoxColumn";
            this.fechalecturaDataGridViewTextBoxColumn.Width = 150;
            // 
            // espesorhumoDataGridViewTextBoxColumn
            // 
            this.espesorhumoDataGridViewTextBoxColumn.DataPropertyName = "espesor_humo";
            this.espesorhumoDataGridViewTextBoxColumn.HeaderText = "Espesor del Humo";
            this.espesorhumoDataGridViewTextBoxColumn.Name = "espesorhumoDataGridViewTextBoxColumn";
            this.espesorhumoDataGridViewTextBoxColumn.Width = 180;
            // 
            // abundanciahumoDataGridViewTextBoxColumn
            // 
            this.abundanciahumoDataGridViewTextBoxColumn.DataPropertyName = "abundancia_humo";
            this.abundanciahumoDataGridViewTextBoxColumn.FillWeight = 150F;
            this.abundanciahumoDataGridViewTextBoxColumn.HeaderText = "Abundancia de Humo";
            this.abundanciahumoDataGridViewTextBoxColumn.Name = "abundanciahumoDataGridViewTextBoxColumn";
            this.abundanciahumoDataGridViewTextBoxColumn.Width = 200;
            // 
            // lecturasBindingSource
            // 
            this.lecturasBindingSource.DataMember = "lecturas";
            this.lecturasBindingSource.DataSource = this.sistemaAlarmaHumoDataSet;
            // 
            // sistemaAlarmaHumoDataSet
            // 
            this.sistemaAlarmaHumoDataSet.DataSetName = "SistemaAlarmaHumoDataSet";
            this.sistemaAlarmaHumoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturasTableAdapter
            // 
            this.lecturasTableAdapter.ClearBeforeFill = true;
            // 
            // frm_listaLecturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaDeAlarma.Properties.Resources.Logo_Negocio_Floral_Beige;
            this.ClientSize = new System.Drawing.Size(765, 385);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_listaLecturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Lecturas del Sensor";
            this.Load += new System.EventHandler(this.frm_listaLecturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaAlarmaHumoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SistemaAlarmaHumoDataSet sistemaAlarmaHumoDataSet;
        private System.Windows.Forms.BindingSource lecturasBindingSource;
        private SistemaAlarmaHumoDataSetTableAdapters.lecturasTableAdapter lecturasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLECTURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechalecturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn espesorhumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abundanciahumoDataGridViewTextBoxColumn;
    }
}