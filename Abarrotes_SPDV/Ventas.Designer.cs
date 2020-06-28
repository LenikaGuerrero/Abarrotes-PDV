namespace Abarrotes_SPDV
{
    partial class frm_ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ventas));
            this.txt_vimporta = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_vcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_vcantidad = new System.Windows.Forms.TextBox();
            this.txt_vesxistencia = new System.Windows.Forms.TextBox();
            this.txt_vinventario = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cod_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_vcartera = new System.Windows.Forms.Button();
            this.txt_vcambio = new System.Windows.Forms.TextBox();
            this.txt_vpago = new System.Windows.Forms.TextBox();
            this.txt_vtotal = new System.Windows.Forms.TextBox();
            this.lbl_cambio = new System.Windows.Forms.Label();
            this.lbl_pago = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.txt_vprecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_vtipo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_importa = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.pbx_buscar = new System.Windows.Forms.PictureBox();
            this.txt_vimporta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_vimporta
            // 
            this.txt_vimporta.BackColor = System.Drawing.Color.Maroon;
            this.txt_vimporta.Controls.Add(this.label7);
            this.txt_vimporta.Controls.Add(this.pictureBox1);
            this.txt_vimporta.Controls.Add(this.label1);
            this.txt_vimporta.Location = new System.Drawing.Point(-3, 0);
            this.txt_vimporta.Name = "txt_vimporta";
            this.txt_vimporta.Size = new System.Drawing.Size(939, 48);
            this.txt_vimporta.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(772, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "No. de Venta:";
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
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(-1, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 8);
            this.panel2.TabIndex = 1;
            // 
            // txt_vcodigo
            // 
            this.txt_vcodigo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vcodigo.Location = new System.Drawing.Point(92, 93);
            this.txt_vcodigo.Name = "txt_vcodigo";
            this.txt_vcodigo.Size = new System.Drawing.Size(158, 33);
            this.txt_vcodigo.TabIndex = 1;
            this.txt_vcodigo.TextChanged += new System.EventHandler(this.txt_vcodigo_TextChanged);
            this.txt_vcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vcodigo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(30, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(650, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Existencia:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(394, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(653, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Inventario:";
            // 
            // txt_vcantidad
            // 
            this.txt_vcantidad.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txt_vcantidad.Location = new System.Drawing.Point(473, 71);
            this.txt_vcantidad.Name = "txt_vcantidad";
            this.txt_vcantidad.Size = new System.Drawing.Size(100, 22);
            this.txt_vcantidad.TabIndex = 3;
            this.txt_vcantidad.TextChanged += new System.EventHandler(this.txt_vcantidad_TextChanged);
            this.txt_vcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vcantidad_KeyPress);
            // 
            // txt_vesxistencia
            // 
            this.txt_vesxistencia.Enabled = false;
            this.txt_vesxistencia.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vesxistencia.Location = new System.Drawing.Point(732, 71);
            this.txt_vesxistencia.Name = "txt_vesxistencia";
            this.txt_vesxistencia.Size = new System.Drawing.Size(77, 22);
            this.txt_vesxistencia.TabIndex = 6;
            this.txt_vesxistencia.TextChanged += new System.EventHandler(this.txt_vesxistencia_TextChanged);
            // 
            // txt_vinventario
            // 
            this.txt_vinventario.Enabled = false;
            this.txt_vinventario.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txt_vinventario.Location = new System.Drawing.Point(732, 101);
            this.txt_vinventario.Name = "txt_vinventario";
            this.txt_vinventario.Size = new System.Drawing.Size(77, 22);
            this.txt_vinventario.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(722, 426);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 60);
            this.button3.TabIndex = 15;
            this.button3.Text = "Eliminar Producto";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Maroon;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(825, 426);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 60);
            this.button4.TabIndex = 16;
            this.button4.Text = "          Eliminar Venta";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button5.Enabled = false;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Maroon;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(619, 426);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 60);
            this.button5.TabIndex = 14;
            this.button5.Text = "Realizar Venta";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_producto,
            this.Descripcion,
            this.canti,
            this.cate,
            this.prec,
            this.sub});
            this.dataGridView1.Location = new System.Drawing.Point(26, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(547, 313);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cod_producto
            // 
            this.cod_producto.HeaderText = "codigo";
            this.cod_producto.Name = "cod_producto";
            this.cod_producto.ReadOnly = true;
            this.cod_producto.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // canti
            // 
            this.canti.HeaderText = "Cantidad";
            this.canti.Name = "canti";
            this.canti.ReadOnly = true;
            // 
            // cate
            // 
            this.cate.HeaderText = "Categoria";
            this.cate.Name = "cate";
            this.cate.ReadOnly = true;
            // 
            // prec
            // 
            this.prec.HeaderText = "Precio";
            this.prec.Name = "prec";
            this.prec.ReadOnly = true;
            // 
            // sub
            // 
            this.sub.HeaderText = "Importe";
            this.sub.Name = "sub";
            this.sub.ReadOnly = true;
            // 
            // btn_vcartera
            // 
            this.btn_vcartera.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_vcartera.Enabled = false;
            this.btn_vcartera.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_vcartera.ForeColor = System.Drawing.Color.Maroon;
            this.btn_vcartera.Location = new System.Drawing.Point(748, 285);
            this.btn_vcartera.Name = "btn_vcartera";
            this.btn_vcartera.Size = new System.Drawing.Size(75, 23);
            this.btn_vcartera.TabIndex = 12;
            this.btn_vcartera.Text = "Cartera";
            this.btn_vcartera.UseVisualStyleBackColor = false;
            this.btn_vcartera.Click += new System.EventHandler(this.btn_vcartera_Click_1);
            // 
            // txt_vcambio
            // 
            this.txt_vcambio.Enabled = false;
            this.txt_vcambio.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txt_vcambio.Location = new System.Drawing.Point(722, 336);
            this.txt_vcambio.Name = "txt_vcambio";
            this.txt_vcambio.Size = new System.Drawing.Size(130, 22);
            this.txt_vcambio.TabIndex = 13;
            // 
            // txt_vpago
            // 
            this.txt_vpago.Enabled = false;
            this.txt_vpago.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txt_vpago.Location = new System.Drawing.Point(722, 253);
            this.txt_vpago.Name = "txt_vpago";
            this.txt_vpago.Size = new System.Drawing.Size(130, 22);
            this.txt_vpago.TabIndex = 11;
            this.txt_vpago.TextChanged += new System.EventHandler(this.txt_vpago_TextChanged);
            this.txt_vpago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vpago_KeyPress);
            // 
            // txt_vtotal
            // 
            this.txt_vtotal.Enabled = false;
            this.txt_vtotal.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vtotal.Location = new System.Drawing.Point(722, 194);
            this.txt_vtotal.Name = "txt_vtotal";
            this.txt_vtotal.Size = new System.Drawing.Size(130, 40);
            this.txt_vtotal.TabIndex = 10;
            this.txt_vtotal.TextChanged += new System.EventHandler(this.txt_vtotal_TextChanged);
            // 
            // lbl_cambio
            // 
            this.lbl_cambio.AutoSize = true;
            this.lbl_cambio.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cambio.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_cambio.Location = new System.Drawing.Point(643, 340);
            this.lbl_cambio.Name = "lbl_cambio";
            this.lbl_cambio.Size = new System.Drawing.Size(61, 18);
            this.lbl_cambio.TabIndex = 21;
            this.lbl_cambio.Text = "Cambio:";
            // 
            // lbl_pago
            // 
            this.lbl_pago.AutoSize = true;
            this.lbl_pago.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pago.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_pago.Location = new System.Drawing.Point(643, 257);
            this.lbl_pago.Name = "lbl_pago";
            this.lbl_pago.Size = new System.Drawing.Size(45, 18);
            this.lbl_pago.TabIndex = 20;
            this.lbl_pago.Text = "Pago:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(643, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total:";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_limpiar.ForeColor = System.Drawing.Color.Maroon;
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar.Location = new System.Drawing.Point(827, 113);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(97, 32);
            this.btn_limpiar.TabIndex = 9;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_vprecio
            // 
            this.txt_vprecio.Enabled = false;
            this.txt_vprecio.Location = new System.Drawing.Point(473, 99);
            this.txt_vprecio.Name = "txt_vprecio";
            this.txt_vprecio.Size = new System.Drawing.Size(100, 20);
            this.txt_vprecio.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(394, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Precio:";
            // 
            // lbl_vtipo
            // 
            this.lbl_vtipo.AutoSize = true;
            this.lbl_vtipo.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.lbl_vtipo.Location = new System.Drawing.Point(579, 76);
            this.lbl_vtipo.Name = "lbl_vtipo";
            this.lbl_vtipo.Size = new System.Drawing.Size(36, 18);
            this.lbl_vtipo.TabIndex = 24;
            this.lbl_vtipo.Text = "Tipo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(394, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Importe:";
            // 
            // txt_importa
            // 
            this.txt_importa.Enabled = false;
            this.txt_importa.Location = new System.Drawing.Point(473, 125);
            this.txt_importa.Name = "txt_importa";
            this.txt_importa.Size = new System.Drawing.Size(100, 20);
            this.txt_importa.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(619, 173);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(303, 208);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_agregar.ForeColor = System.Drawing.Color.Maroon;
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.Location = new System.Drawing.Point(827, 68);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(97, 37);
            this.btn_agregar.TabIndex = 8;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // pbx_buscar
            // 
            this.pbx_buscar.Image = ((System.Drawing.Image)(resources.GetObject("pbx_buscar.Image")));
            this.pbx_buscar.Location = new System.Drawing.Point(256, 99);
            this.pbx_buscar.Name = "pbx_buscar";
            this.pbx_buscar.Size = new System.Drawing.Size(24, 23);
            this.pbx_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_buscar.TabIndex = 29;
            this.pbx_buscar.TabStop = false;
            this.pbx_buscar.Click += new System.EventHandler(this.pbx_buscar_Click);
            // 
            // frm_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(936, 519);
            this.Controls.Add(this.pbx_buscar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_importa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.lbl_vtipo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_vprecio);
            this.Controls.Add(this.btn_vcartera);
            this.Controls.Add(this.txt_vcambio);
            this.Controls.Add(this.txt_vpago);
            this.Controls.Add(this.txt_vtotal);
            this.Controls.Add(this.lbl_cambio);
            this.Controls.Add(this.lbl_pago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_vinventario);
            this.Controls.Add(this.txt_vesxistencia);
            this.Controls.Add(this.txt_vcantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_vcodigo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_vimporta);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "s";
            this.Activated += new System.EventHandler(this.frm_ventas_Activated);
            this.Deactivate += new System.EventHandler(this.frm_ventas_Deactivate);
            this.Load += new System.EventHandler(this.frm_ventas_Load);
            this.txt_vimporta.ResumeLayout(false);
            this.txt_vimporta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_buscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel txt_vimporta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_vcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_vcantidad;
        private System.Windows.Forms.TextBox txt_vesxistencia;
        private System.Windows.Forms.TextBox txt_vinventario;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_vcartera;
        private System.Windows.Forms.TextBox txt_vcambio;
        private System.Windows.Forms.TextBox txt_vpago;
        private System.Windows.Forms.TextBox txt_vtotal;
        private System.Windows.Forms.Label lbl_cambio;
        private System.Windows.Forms.Label lbl_pago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_vprecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_vtipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_importa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn canti;
        private System.Windows.Forms.DataGridViewTextBoxColumn cate;
        private System.Windows.Forms.DataGridViewTextBoxColumn prec;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.PictureBox pbx_buscar;
    }
}