using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EstudoXML
{
    public partial class frmGerenciamentoEstoque : Form
    {
        public frmGerenciamentoEstoque()
        {
            InitializeComponent();
        }

        private void FrmGerenciamentoEstoque_Load(object sender, EventArgs e)
        {
            lblText1.Text = CarregarTitulo();
            CriarProdutos();
            CarregarProdutos();
        }
        private string CarregarTitulo()
        {
            XmlDocument documentoXml = new XmlDocument();
            documentoXml.Load(@"C:\Users\feoxp7\Desktop\SCRIPTS\TreinaWeb\CSharpIntermediario\EstudoXML\GerenciamentoEstoque.xml");
            XmlNode noTitulo = documentoXml.SelectSingleNode("//nomeMercado");
            return noTitulo.InnerText;
        }
        private void CarregarProdutos()
        {
            XmlDocument documentoXml = new XmlDocument();
            documentoXml.Load(@"C:\Users\feoxp7\Desktop\SCRIPTS\TreinaWeb\CSharpIntermediario\EstudoXML\GerenciamentoEstoque.xml");
            XmlNodeList produtos = documentoXml.SelectNodes("//produto");
            foreach (XmlNode item in produtos)
            {
                string representacaoProduto = "";
                string id = item.Attributes["id"].Value;
                string nome = item.Attributes["nome"].Value;
                string marca = item.Attributes["marca"].Value;
                string tipo = item.Attributes["tipo"].Value;
                string preco = item.Attributes["preco"].Value;
                string quantidade = item.Attributes["quantidadeEstoque"].Value;

                representacaoProduto = "(" + id + ")" + " Nome:" + nome + " Preço (R$):" + preco + " Marca: " + marca +  " Tipo:" + tipo + " Estoque:" + quantidade;
                lbxProdutos.Items.Add(representacaoProduto); 
            }
        }
        private void CriarProdutos()
        {
            XmlDocument documentoXml = new XmlDocument();
            documentoXml.Load(@"C:\Users\feoxp7\Desktop\SCRIPTS\TreinaWeb\CSharpIntermediario\EstudoXML\GerenciamentoEstoque.xml");
            XmlAttribute atributoId = documentoXml.CreateAttribute("id");
            XmlAttribute atributoNome = documentoXml.CreateAttribute("nome");
            XmlAttribute atributoMarca = documentoXml.CreateAttribute("marca");
            XmlAttribute atributoTipo = documentoXml.CreateAttribute("tipo");
            XmlAttribute atributoPreco = documentoXml.CreateAttribute("preco");
            XmlAttribute atributoQuantidade = documentoXml.CreateAttribute("quantidadeEstoque");

            atributoId.Value = "010";
            atributoNome.Value = "Creatina";
            atributoMarca.Value = "Integral Médica";
            atributoTipo.Value = "Cápsulas";
            atributoPreco.Value = "60,00";
            atributoQuantidade.Value = "13";

            XmlNode novoProduto = documentoXml.CreateElement("produto");
            novoProduto.Attributes.Append(atributoId);
            novoProduto.Attributes.Append(atributoNome);
            novoProduto.Attributes.Append(atributoMarca);
            novoProduto.Attributes.Append(atributoTipo);
            novoProduto.Attributes.Append(atributoPreco);
            novoProduto.Attributes.Append(atributoQuantidade);

            XmlNode produtos = documentoXml.SelectSingleNode("//produtos");
            produtos.AppendChild(novoProduto);
            documentoXml.Save(@"C:\Users\feoxp7\Desktop\SCRIPTS\TreinaWeb\CSharpIntermediario\EstudoXML\GerenciamentoEstoque.xml"); //Salva as alterações no arquivo.
            
        }
    }
}
