namespace EstudoXML
{
    partial class frmGerenciamentoEstoque
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
            this.lblText1 = new System.Windows.Forms.Label();
            this.lbxProdutos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText1.ForeColor = System.Drawing.Color.Yellow;
            this.lblText1.Location = new System.Drawing.Point(19, 9);
            this.lblText1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(66, 24);
            this.lblText1.TabIndex = 0;
            this.lblText1.Text = "label1";
            // 
            // lbxProdutos
            // 
            this.lbxProdutos.FormattingEnabled = true;
            this.lbxProdutos.ItemHeight = 16;
            this.lbxProdutos.Location = new System.Drawing.Point(23, 64);
            this.lbxProdutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxProdutos.Name = "lbxProdutos";
            this.lbxProdutos.Size = new System.Drawing.Size(684, 276);
            this.lbxProdutos.TabIndex = 1;
            // 
            // frmGerenciamentoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(732, 364);
            this.Controls.Add(this.lbxProdutos);
            this.Controls.Add(this.lblText1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGerenciamentoEstoque";
            this.Text = "Gerenciamento de Estoque";
            this.Load += new System.EventHandler(this.FrmGerenciamentoEstoque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.ListBox lbxProdutos;
    }
}