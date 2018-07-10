namespace CRUD_Mercado.Vendas
{
    partial class Pesquisa
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
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvVendas2 = new System.Windows.Forms.DataGridView();
            this.gvVendas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvVendas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(189, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(399, 50);
            this.label12.TabIndex = 31;
            this.label12.Text = "Pesquisa de Venda";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvVendas2);
            this.groupBox1.Controls.Add(this.gvVendas);
            this.groupBox1.Location = new System.Drawing.Point(8, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 525);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // gvVendas2
            // 
            this.gvVendas2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvVendas2.BackgroundColor = System.Drawing.Color.White;
            this.gvVendas2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVendas2.Location = new System.Drawing.Point(26, 245);
            this.gvVendas2.Name = "gvVendas2";
            this.gvVendas2.Size = new System.Drawing.Size(781, 165);
            this.gvVendas2.TabIndex = 4;
            this.gvVendas2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvVendas2_CellContentClick);
            // 
            // gvVendas
            // 
            this.gvVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvVendas.BackgroundColor = System.Drawing.Color.White;
            this.gvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVendas.GridColor = System.Drawing.Color.White;
            this.gvVendas.Location = new System.Drawing.Point(26, 19);
            this.gvVendas.Name = "gvVendas";
            this.gvVendas.Size = new System.Drawing.Size(781, 150);
            this.gvVendas.TabIndex = 3;
            this.gvVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvVendas_CellContentClick);
            this.gvVendas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gvVendas_MouseClick);
            // 
            // Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 636);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Name = "Pesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvVendas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvVendas;
        private System.Windows.Forms.DataGridView gvVendas2;
    }
}