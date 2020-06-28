namespace Abarrotes_SPDV
{
    partial class frm_listproductoPDT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_listproductoPDT));
            this.dgv_productospdt = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productospdt)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_productospdt
            // 
            this.dgv_productospdt.AllowUserToAddRows = false;
            this.dgv_productospdt.AllowUserToDeleteRows = false;
            this.dgv_productospdt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productospdt.BackgroundColor = System.Drawing.Color.White;
            this.dgv_productospdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productospdt.Location = new System.Drawing.Point(40, 120);
            this.dgv_productospdt.Name = "dgv_productospdt";
            this.dgv_productospdt.ReadOnly = true;
            this.dgv_productospdt.RowHeadersVisible = false;
            this.dgv_productospdt.Size = new System.Drawing.Size(338, 162);
            this.dgv_productospdt.TabIndex = 67;
            this.dgv_productospdt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productospdt_CellClick);
            this.dgv_productospdt.DoubleClick += new System.EventHandler(this.dgv_productospdt_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(0, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 12);
            this.panel2.TabIndex = 66;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(40, 80);
            this.txt_buscar.MaxLength = 30;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(286, 20);
            this.txt_buscar.TabIndex = 65;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(37, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Buscar por Código  o Nombre del Producto:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 48);
            this.panel1.TabIndex = 63;
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
            this.label5.Size = new System.Drawing.Size(315, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lista de Productos Pendientes";
            // 
            // frm_listproductoPDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 325);
            this.Controls.Add(this.dgv_productospdt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_listproductoPDT";
            this.Text = "Pendientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_listproductoPDT_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_listproductoPDT_FormClosed);
            this.Load += new System.EventHandler(this.frm_listproductoPDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productospdt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_productospdt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}