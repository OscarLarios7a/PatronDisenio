namespace PatronDiseño.IU
{
    partial class FormClientesDTO
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
            this.dtgvClientes = new System.Windows.Forms.DataGridView();
            this.txtBuscarClientes = new System.Windows.Forms.TextBox();
            this.bntBuscarClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvClientes
            // 
            this.dtgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClientes.Location = new System.Drawing.Point(13, 67);
            this.dtgvClientes.Name = "dtgvClientes";
            this.dtgvClientes.Size = new System.Drawing.Size(985, 288);
            this.dtgvClientes.TabIndex = 0;
            // 
            // txtBuscarClientes
            // 
            this.txtBuscarClientes.Location = new System.Drawing.Point(13, 24);
            this.txtBuscarClientes.Name = "txtBuscarClientes";
            this.txtBuscarClientes.Size = new System.Drawing.Size(571, 20);
            this.txtBuscarClientes.TabIndex = 1;
            this.txtBuscarClientes.TextChanged += new System.EventHandler(this.txtBuscarClientes_TextChanged);
            // 
            // bntBuscarClientes
            // 
            this.bntBuscarClientes.Location = new System.Drawing.Point(625, 24);
            this.bntBuscarClientes.Name = "bntBuscarClientes";
            this.bntBuscarClientes.Size = new System.Drawing.Size(75, 23);
            this.bntBuscarClientes.TabIndex = 2;
            this.bntBuscarClientes.Text = "Buscar";
            this.bntBuscarClientes.UseVisualStyleBackColor = true;
            this.bntBuscarClientes.Click += new System.EventHandler(this.bntBuscarClientes_Click);
            // 
            // FormClientesDTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 367);
            this.Controls.Add(this.bntBuscarClientes);
            this.Controls.Add(this.txtBuscarClientes);
            this.Controls.Add(this.dtgvClientes);
            this.Name = "FormClientesDTO";
            this.Text = "FormClientesDTO";
            this.Load += new System.EventHandler(this.FormClientesDTO_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvClientes;
        private System.Windows.Forms.TextBox txtBuscarClientes;
        private System.Windows.Forms.Button bntBuscarClientes;
    }
}