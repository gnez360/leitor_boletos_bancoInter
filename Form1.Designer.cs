namespace Gestão_Boletos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCarregar = new System.Windows.Forms.Button();
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btcopiarnome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btCarregar
            // 
            this.btCarregar.Location = new System.Drawing.Point(39, 12);
            this.btCarregar.Name = "btCarregar";
            this.btCarregar.Size = new System.Drawing.Size(182, 49);
            this.btCarregar.TabIndex = 8;
            this.btCarregar.Text = "Carregar Pasta";
            this.btCarregar.UseVisualStyleBackColor = true;
            this.btCarregar.Click += new System.EventHandler(this.btCarregar_Click);
            // 
            // dgDados
            // 
            this.dgDados.AllowUserToAddRows = false;
            this.dgDados.AllowUserToDeleteRows = false;
            this.dgDados.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Numero,
            this.Data_Vencimento});
            this.dgDados.Location = new System.Drawing.Point(39, 92);
            this.dgDados.Name = "dgDados";
            this.dgDados.ReadOnly = true;
            this.dgDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dgDados.Size = new System.Drawing.Size(767, 346);
            this.dgDados.TabIndex = 9;
            this.dgDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDados_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Numero
            // 
            this.Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Data_Vencimento
            // 
            this.Data_Vencimento.HeaderText = "Data_Vencimento";
            this.Data_Vencimento.Name = "Data_Vencimento";
            this.Data_Vencimento.ReadOnly = true;
            this.Data_Vencimento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Data_Vencimento.Width = 200;
            // 
            // btcopiarnome
            // 
            this.btcopiarnome.Location = new System.Drawing.Point(614, 12);
            this.btcopiarnome.Name = "btcopiarnome";
            this.btcopiarnome.Size = new System.Drawing.Size(182, 49);
            this.btcopiarnome.TabIndex = 10;
            this.btcopiarnome.Text = "Copiar";
            this.btcopiarnome.UseVisualStyleBackColor = true;
            this.btcopiarnome.Click += new System.EventHandler(this.btcopiarnome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.btcopiarnome);
            this.Controls.Add(this.dgDados);
            this.Controls.Add(this.btCarregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gestão de Boletos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btCarregar;
        private System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.Button btcopiarnome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Vencimento;
    }
}

