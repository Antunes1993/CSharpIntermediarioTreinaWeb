using EstudoSQL.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoSQL
{
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            EstoqueDAO produtoDAO = new EstoqueDAO();
            DataTable dataTable = produtoDAO.GetProdutos();
            dgvEstoque.DataSource = dataTable;
            dgvEstoque.Refresh();

            //DataSet ds = produtoDAO.GetProdutos();
            //dgvEstoque.DataSource = ds.Tables["Produtos"];
            //dgvEstoque.Refresh();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int id = (int)dgvEstoque.CurrentRow.Cells[0].Value;
            EstoqueDAO produtoDao = new EstoqueDAO();
            produtoDao.ExcluirProdutos(id);
            CarregarDataGridView();
        }
        private void CarregarDataGridView()
        {
            EstoqueDAO produtoDAO = new EstoqueDAO();
            DataTable dataTable = produtoDAO.GetProdutos();
            dgvEstoque.DataSource = dataTable;
            dgvEstoque.Refresh();
        }
    }
}
