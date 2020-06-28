namespace Abarrotes_SPDV
{
    partial class frm_pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pedidos));
            this.dpk_fecha = new System.Windows.Forms.DateTimePicker();
            this.mtc_calendario = new System.Windows.Forms.MonthCalendar();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_general = new System.Windows.Forms.DataGridView();
            this.dgv_dia = new System.Windows.Forms.DataGridView();
            this.txt_empresa = new System.Windows.Forms.TextBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.pbx_buscar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_general)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // dpk_fecha
            // 
            this.dpk_fecha.Location = new System.Drawing.Point(119, 372);
            this.dpk_fecha.MaxDate = new System.DateTime(2060, 1, 1, 0, 0, 0, 0);
            this.dpk_fecha.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dpk_fecha.Name = "dpk_fecha";
            this.dpk_fecha.Size = new System.Drawing.Size(196, 20);
            this.dpk_fecha.TabIndex = 4;
            this.dpk_fecha.ValueChanged += new System.EventHandler(this.dpk_fecha_ValueChanged);
            // 
            // mtc_calendario
            // 
            this.mtc_calendario.BackColor = System.Drawing.Color.Wheat;
            this.mtc_calendario.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.mtc_calendario.ForeColor = System.Drawing.Color.Maroon;
            this.mtc_calendario.Location = new System.Drawing.Point(52, 74);
            this.mtc_calendario.MaxDate = new System.DateTime(2060, 1, 1, 0, 0, 0, 0);
            this.mtc_calendario.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.mtc_calendario.Name = "mtc_calendario";
            this.mtc_calendario.TabIndex = 44;
            this.mtc_calendario.TitleBackColor = System.Drawing.Color.DarkOrange;
            this.mtc_calendario.TitleForeColor = System.Drawing.Color.Maroon;
            this.mtc_calendario.TrailingForeColor = System.Drawing.Color.Maroon;
            this.mtc_calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mtc_calendario_DateChanged);
            this.mtc_calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mtc_calendario_DateSelected);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(119, 302);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(196, 20);
            this.txt_descripcion.TabIndex = 2;
            this.txt_descripcion.TextChanged += new System.EventHandler(this.txt_descripcion_TextChanged);
            // 
            // txt_producto
            // 
            this.txt_producto.Location = new System.Drawing.Point(119, 262);
            this.txt_producto.MaxLength = 10;
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(161, 20);
            this.txt_producto.TabIndex = 1;
            this.txt_producto.TextChanged += new System.EventHandler(this.txt_producto_TextChanged);
            this.txt_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_producto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(22, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "Empresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(22, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Fecha Pedido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(22, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(22, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cód Producto:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(-1, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 8);
            this.panel2.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 48);
            this.panel1.TabIndex = 47;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 17.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(62, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pedidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(23, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 49;
            this.label6.Text = "Cantidad:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Enabled = false;
            this.txt_cantidad.Location = new System.Drawing.Point(119, 414);
            this.txt_cantidad.MaxLength = 5;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(87, 20);
            this.txt_cantidad.TabIndex = 5;
            this.txt_cantidad.TextChanged += new System.EventHandler(this.txt_cantidad_TextChanged);
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_eliminar.ForeColor = System.Drawing.Color.Maroon;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(696, 443);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(97, 60);
            this.btn_eliminar.TabIndex = 8;
            this.btn_eliminar.Text = "Eliminar Pedido";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_modificar.ForeColor = System.Drawing.Color.Maroon;
            this.btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificar.Image")));
            this.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificar.Location = new System.Drawing.Point(799, 443);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(97, 60);
            this.btn_modificar.TabIndex = 9;
            this.btn_modificar.Text = "Modificar Pedido";
            this.btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_guardar.Enabled = false;
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_guardar.ForeColor = System.Drawing.Color.Maroon;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(52, 464);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(97, 39);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Maroon;
            this.panel5.Controls.Add(this.label19);
            this.panel5.Location = new System.Drawing.Point(332, 74);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(564, 21);
            this.panel5.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(253, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 18);
            this.label19.TabIndex = 0;
            this.label19.Text = "General";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Maroon;
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(332, 239);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(564, 21);
            this.panel6.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(270, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Día";
            // 
            // dgv_general
            // 
            this.dgv_general.AllowUserToAddRows = false;
            this.dgv_general.AllowUserToDeleteRows = false;
            this.dgv_general.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_general.BackgroundColor = System.Drawing.Color.White;
            this.dgv_general.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_general.Location = new System.Drawing.Point(332, 95);
            this.dgv_general.Name = "dgv_general";
            this.dgv_general.ReadOnly = true;
            this.dgv_general.RowHeadersVisible = false;
            this.dgv_general.Size = new System.Drawing.Size(564, 141);
            this.dgv_general.TabIndex = 10;
            this.dgv_general.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_general_CellClick);
            // 
            // dgv_dia
            // 
            this.dgv_dia.AllowUserToAddRows = false;
            this.dgv_dia.AllowUserToDeleteRows = false;
            this.dgv_dia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dia.BackgroundColor = System.Drawing.Color.White;
            this.dgv_dia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dia.Location = new System.Drawing.Point(332, 260);
            this.dgv_dia.Name = "dgv_dia";
            this.dgv_dia.ReadOnly = true;
            this.dgv_dia.RowHeadersVisible = false;
            this.dgv_dia.Size = new System.Drawing.Size(564, 148);
            this.dgv_dia.TabIndex = 11;
            this.dgv_dia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dia_CellClick);
            // 
            // txt_empresa
            // 
            this.txt_empresa.Location = new System.Drawing.Point(119, 336);
            this.txt_empresa.Name = "txt_empresa";
            this.txt_empresa.Size = new System.Drawing.Size(196, 20);
            this.txt_empresa.TabIndex = 3;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_limpiar.Enabled = false;
            this.btn_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_limpiar.ForeColor = System.Drawing.Color.Maroon;
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar.Location = new System.Drawing.Point(203, 464);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(97, 39);
            this.btn_limpiar.TabIndex = 7;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // pbx_buscar
            // 
            this.pbx_buscar.Image = ((System.Drawing.Image)(resources.GetObject("pbx_buscar.Image")));
            this.pbx_buscar.Location = new System.Drawing.Point(290, 258);
            this.pbx_buscar.Name = "pbx_buscar";
            this.pbx_buscar.Size = new System.Drawing.Size(25, 25);
            this.pbx_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbx_buscar.TabIndex = 62;
            this.pbx_buscar.TabStop = false;
            this.pbx_buscar.Click += new System.EventHandler(this.pbx_buscar_Click);
            // 
            // frm_pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(934, 517);
            this.Controls.Add(this.pbx_buscar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.txt_empresa);
            this.Controls.Add(this.dgv_dia);
            this.Controls.Add(this.dgv_general);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dpk_fecha);
            this.Controls.Add(this.mtc_calendario);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_pedidos";
            this.Text = "Pedidos";
            this.Activated += new System.EventHandler(this.frm_pedidos_Activated);
            this.Deactivate += new System.EventHandler(this.frm_pedidos_Deactivate);
            this.Load += new System.EventHandler(this.frm_pedidos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_general)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_buscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dpk_fecha;
        private System.Windows.Forms.MonthCalendar mtc_calendario;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_general;
        private System.Windows.Forms.DataGridView dgv_dia;
        private System.Windows.Forms.TextBox txt_empresa;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.PictureBox pbx_buscar;
    }
}