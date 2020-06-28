namespace Abarrotes_SPDV
{
    partial class frm_inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inventario));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_inventario = new System.Windows.Forms.DataGridView();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.cmb_buscar = new System.Windows.Forms.ComboBox();
            this.cmb_departamento = new System.Windows.Forms.ComboBox();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(-1, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 8);
            this.panel2.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 48);
            this.panel1.TabIndex = 33;
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
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventario";
            // 
            // dgv_inventario
            // 
            this.dgv_inventario.AllowUserToAddRows = false;
            this.dgv_inventario.AllowUserToDeleteRows = false;
            this.dgv_inventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inventario.Location = new System.Drawing.Point(26, 185);
            this.dgv_inventario.Name = "dgv_inventario";
            this.dgv_inventario.ReadOnly = true;
            this.dgv_inventario.RowHeadersVisible = false;
            this.dgv_inventario.Size = new System.Drawing.Size(878, 279);
            this.dgv_inventario.TabIndex = 40;
            this.dgv_inventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_inventario_CellClick);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(26, 131);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(152, 20);
            this.txt_buscar.TabIndex = 0;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // cmb_buscar
            // 
            this.cmb_buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_buscar.FormattingEnabled = true;
            this.cmb_buscar.Items.AddRange(new object[] {
            "Nombre",
            "Marca",
            "Categoria",
            "Departamento",
            "Cantidad Existente",
            "Todo"});
            this.cmb_buscar.Location = new System.Drawing.Point(26, 104);
            this.cmb_buscar.Name = "cmb_buscar";
            this.cmb_buscar.Size = new System.Drawing.Size(152, 21);
            this.cmb_buscar.TabIndex = 1;
            this.cmb_buscar.SelectedIndexChanged += new System.EventHandler(this.cmb_buscar_SelectedIndexChanged);
            // 
            // cmb_departamento
            // 
            this.cmb_departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_departamento.FormattingEnabled = true;
            this.cmb_departamento.Items.AddRange(new object[] {
            "Abarrotes",
            "General"});
            this.cmb_departamento.Location = new System.Drawing.Point(26, 131);
            this.cmb_departamento.Name = "cmb_departamento";
            this.cmb_departamento.Size = new System.Drawing.Size(152, 21);
            this.cmb_departamento.TabIndex = 2;
            this.cmb_departamento.SelectedIndexChanged += new System.EventHandler(this.cmb_departamento_SelectedIndexChanged);
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Items.AddRange(new object[] {
            "Pieza",
            "Kilo"});
            this.cmb_categoria.Location = new System.Drawing.Point(26, 131);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(152, 21);
            this.cmb_categoria.TabIndex = 41;
            this.cmb_categoria.SelectedIndexChanged += new System.EventHandler(this.cmb_categoria_SelectedIndexChanged);
            // 
            // frm_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(934, 486);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.cmb_departamento);
            this.Controls.Add(this.cmb_buscar);
            this.Controls.Add(this.dgv_inventario);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_inventario";
            this.Text = "Inventario";
            this.Activated += new System.EventHandler(this.frm_inventario_Activated);
            this.Deactivate += new System.EventHandler(this.frm_inventario_Deactivate);
            this.Load += new System.EventHandler(this.frm_inventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_inventario;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.ComboBox cmb_buscar;
        private System.Windows.Forms.ComboBox cmb_departamento;
        private System.Windows.Forms.ComboBox cmb_categoria;
    }
}