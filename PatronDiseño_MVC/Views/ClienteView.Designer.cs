namespace PatronDiseño_MVC.Views
{
    partial class ClienteView
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
            this.dtgvClienteView = new System.Windows.Forms.DataGridView();
            this.txtBuscarClientesView = new System.Windows.Forms.TextBox();
            this.btnBuscarView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClienteView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvClienteView
            // 
            this.dtgvClienteView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvClienteView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvClienteView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvClienteView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClienteView.Location = new System.Drawing.Point(12, 60);
            this.dtgvClienteView.Name = "dtgvClienteView";
            this.dtgvClienteView.Size = new System.Drawing.Size(888, 347);
            this.dtgvClienteView.TabIndex = 0;
            // 
            // txtBuscarClientesView
            // 
            this.txtBuscarClientesView.Location = new System.Drawing.Point(12, 23);
            this.txtBuscarClientesView.Name = "txtBuscarClientesView";
            this.txtBuscarClientesView.Size = new System.Drawing.Size(482, 20);
            this.txtBuscarClientesView.TabIndex = 1;
            // 
            // btnBuscarView
            // 
            this.btnBuscarView.Location = new System.Drawing.Point(528, 23);
            this.btnBuscarView.Name = "btnBuscarView";
            this.btnBuscarView.Size = new System.Drawing.Size(96, 23);
            this.btnBuscarView.TabIndex = 2;
            this.btnBuscarView.Text = "Buscar Cliente";
            this.btnBuscarView.UseVisualStyleBackColor = true;
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 419);
            this.Controls.Add(this.btnBuscarView);
            this.Controls.Add(this.txtBuscarClientesView);
            this.Controls.Add(this.dtgvClienteView);
            this.Name = "ClienteView";
            this.Text = "Vista Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClienteView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtgvClienteView;
        public System.Windows.Forms.TextBox txtBuscarClientesView;
        public System.Windows.Forms.Button btnBuscarView;
    }
}