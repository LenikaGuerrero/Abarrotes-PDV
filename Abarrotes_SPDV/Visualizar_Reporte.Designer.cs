namespace Abarrotes_SPDV
{
    partial class Visualizar_Reporte
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.report_Productos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Reportes_Ventas = new Abarrotes_SPDV.Reportes_Ventas();
            this.VentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VentaTableAdapter = new Abarrotes_SPDV.Reportes_VentasTableAdapters.VentaTableAdapter();
            this.Credito_Total = new Abarrotes_SPDV.Credito_Total();
            this.Total_Efectivo = new Abarrotes_SPDV.Total_Efectivo();
            this.Total_Venta = new Abarrotes_SPDV.Total_Venta();
            this.Detalle_VentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_Productos_Ventas = new Abarrotes_SPDV.Reporte_Productos_Ventas();
            this.Detalle_VentaTableAdapter = new Abarrotes_SPDV.Reporte_Productos_VentasTableAdapters.Detalle_VentaTableAdapter();
            this.DataSet1 = new Abarrotes_SPDV.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.Reportes_Ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Credito_Total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Efectivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Venta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_VentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Productos_Ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // report_Productos
            // 
            reportDataSource1.Name = "data1";
            reportDataSource1.Value = this.VentaBindingSource;
            this.report_Productos.LocalReport.DataSources.Add(reportDataSource1);
            this.report_Productos.LocalReport.ReportEmbeddedResource = "Abarrotes_SPDV.Report2.rdlc";
            this.report_Productos.Location = new System.Drawing.Point(187, 80);
            this.report_Productos.Name = "report_Productos";
            this.report_Productos.Size = new System.Drawing.Size(396, 246);
            this.report_Productos.TabIndex = 1;
            // 
            // Reportes_Ventas
            // 
            this.Reportes_Ventas.DataSetName = "Reportes_Ventas";
            this.Reportes_Ventas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VentaBindingSource
            // 
            this.VentaBindingSource.DataMember = "Venta";
            this.VentaBindingSource.DataSource = this.Reportes_Ventas;
            // 
            // VentaTableAdapter
            // 
            this.VentaTableAdapter.ClearBeforeFill = true;
            // 
            // Credito_Total
            // 
            this.Credito_Total.DataSetName = "Credito_Total";
            this.Credito_Total.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Total_Efectivo
            // 
            this.Total_Efectivo.DataSetName = "Total_Efectivo";
            this.Total_Efectivo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Total_Venta
            // 
            this.Total_Venta.DataSetName = "Total_Venta";
            this.Total_Venta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Detalle_VentaBindingSource
            // 
            this.Detalle_VentaBindingSource.DataMember = "Detalle_Venta";
            this.Detalle_VentaBindingSource.DataSource = this.Reporte_Productos_Ventas;
            // 
            // Reporte_Productos_Ventas
            // 
            this.Reporte_Productos_Ventas.DataSetName = "Reporte_Productos_Ventas";
            this.Reporte_Productos_Ventas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Detalle_VentaTableAdapter
            // 
            this.Detalle_VentaTableAdapter.ClearBeforeFill = true;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Visualizar_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 469);
            this.Controls.Add(this.report_Productos);
            this.Name = "Visualizar_Reporte";
            this.Text = "Visualizar_Reporte";
            this.Load += new System.EventHandler(this.Visualizar_Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reportes_Ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Credito_Total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Efectivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Venta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_VentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Productos_Ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer report_Productos;
        private System.Windows.Forms.BindingSource VentaBindingSource;
        private Reportes_Ventas Reportes_Ventas;
        private Reportes_VentasTableAdapters.VentaTableAdapter VentaTableAdapter;
        private Credito_Total Credito_Total;
        private Total_Efectivo Total_Efectivo;
        private Total_Venta Total_Venta;
        private System.Windows.Forms.BindingSource Detalle_VentaBindingSource;
        private Reporte_Productos_Ventas Reporte_Productos_Ventas;
        private Reporte_Productos_VentasTableAdapters.Detalle_VentaTableAdapter Detalle_VentaTableAdapter;
        private DataSet1 DataSet1;
    }
}