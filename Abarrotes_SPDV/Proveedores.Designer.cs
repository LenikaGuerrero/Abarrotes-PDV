namespace Abarrotes_SPDV
{
    partial class frm_proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_proveedores));
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_proveedores = new System.Windows.Forms.DataGridView();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_nomempresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dirempresa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_pendiente = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.pbx_buscar = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pendiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_buscar)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_eliminar.Location = new System.Drawing.Point(121, 447);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(97, 60);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Eliminar Proveedor";
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
            this.btn_modificar.Location = new System.Drawing.Point(11, 447);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(97, 60);
            this.btn_modificar.TabIndex = 9;
            this.btn_modificar.Text = "Modificar\r\nProveedor";
            this.btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(343, 94);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(327, 20);
            this.txt_buscar.TabIndex = 1;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(342, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Buscar por Nombre o Empresa:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(-1, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 8);
            this.panel2.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 48);
            this.panel1.TabIndex = 24;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 17.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedores";
            // 
            // dgv_proveedores
            // 
            this.dgv_proveedores.AllowUserToAddRows = false;
            this.dgv_proveedores.AllowUserToDeleteRows = false;
            this.dgv_proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proveedores.Location = new System.Drawing.Point(343, 141);
            this.dgv_proveedores.Name = "dgv_proveedores";
            this.dgv_proveedores.ReadOnly = true;
            this.dgv_proveedores.RowHeadersVisible = false;
            this.dgv_proveedores.Size = new System.Drawing.Size(564, 164);
            this.dgv_proveedores.TabIndex = 11;
            this.dgv_proveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_proveedores_CellClick);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(108, 167);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(167, 20);
            this.txt_telefono.TabIndex = 3;
            this.txt_telefono.TextChanged += new System.EventHandler(this.txt_telefono_TextChanged);
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Limpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_Limpiar.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Limpiar.Image")));
            this.btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Limpiar.Location = new System.Drawing.Point(176, 383);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(97, 34);
            this.btn_Limpiar.TabIndex = 8;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_guardar.ForeColor = System.Drawing.Color.Maroon;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(65, 383);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(97, 34);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(39, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Telefono:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(108, 134);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(167, 20);
            this.txt_nombre.TabIndex = 2;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_nomempresa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_dirempresa);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(42, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 101);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Empresa";
            // 
            // txt_nomempresa
            // 
            this.txt_nomempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_nomempresa.Location = new System.Drawing.Point(66, 28);
            this.txt_nomempresa.Name = "txt_nomempresa";
            this.txt_nomempresa.Size = new System.Drawing.Size(167, 20);
            this.txt_nomempresa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nombre:";
            // 
            // txt_dirempresa
            // 
            this.txt_dirempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_dirempresa.Location = new System.Drawing.Point(66, 58);
            this.txt_dirempresa.Name = "txt_dirempresa";
            this.txt_dirempresa.Size = new System.Drawing.Size(167, 20);
            this.txt_dirempresa.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-3, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(39, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nombre:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.label19);
            this.panel3.Location = new System.Drawing.Point(25, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 21);
            this.panel3.TabIndex = 61;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(67, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(160, 18);
            this.label19.TabIndex = 0;
            this.label19.Text = "Datos del Proveedor";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(292, 337);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Maroon;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(343, 120);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(564, 21);
            this.panel5.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(253, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "General";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(343, 308);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(564, 21);
            this.panel4.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(183, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Pendientes a Modificar";
            // 
            // dgv_pendiente
            // 
            this.dgv_pendiente.AllowUserToAddRows = false;
            this.dgv_pendiente.AllowUserToDeleteRows = false;
            this.dgv_pendiente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pendiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pendiente.Location = new System.Drawing.Point(343, 329);
            this.dgv_pendiente.Name = "dgv_pendiente";
            this.dgv_pendiente.ReadOnly = true;
            this.dgv_pendiente.RowHeadersVisible = false;
            this.dgv_pendiente.Size = new System.Drawing.Size(564, 104);
            this.dgv_pendiente.TabIndex = 12;
            this.dgv_pendiente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pendiente_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(237, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 60);
            this.button1.TabIndex = 11;
            this.button1.Text = "Seleccion de Producto";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(8, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 62;
            this.label5.Text = "Producto:";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_producto
            // 
            this.txt_producto.Location = new System.Drawing.Point(77, 10);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(144, 20);
            this.txt_producto.TabIndex = 6;
            this.txt_producto.Visible = false;
            this.txt_producto.TextChanged += new System.EventHandler(this.txt_producto_TextChanged);
            // 
            // pbx_buscar
            // 
            this.pbx_buscar.Image = ((System.Drawing.Image)(resources.GetObject("pbx_buscar.Image")));
            this.pbx_buscar.Location = new System.Drawing.Point(220, 10);
            this.pbx_buscar.Name = "pbx_buscar";
            this.pbx_buscar.Size = new System.Drawing.Size(24, 19);
            this.pbx_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_buscar.TabIndex = 64;
            this.pbx_buscar.TabStop = false;
            this.pbx_buscar.Visible = false;
            this.pbx_buscar.Click += new System.EventHandler(this.pbx_buscar_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pbx_buscar);
            this.panel6.Controls.Add(this.txt_producto);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(31, 318);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(262, 39);
            this.panel6.TabIndex = 0;
            // 
            // frm_proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(936, 519);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgv_pendiente);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_proveedores);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_proveedores";
            this.Text = "Proveedores";
            this.Activated += new System.EventHandler(this.frm_proveedores_Activated);
            this.Deactivate += new System.EventHandler(this.frm_proveedores_Deactivate);
            this.Load += new System.EventHandler(this.frm_proveedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pendiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_buscar)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_proveedores;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_nomempresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_pendiente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_dirempresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.PictureBox pbx_buscar;
        private System.Windows.Forms.Panel panel6;
    }
}