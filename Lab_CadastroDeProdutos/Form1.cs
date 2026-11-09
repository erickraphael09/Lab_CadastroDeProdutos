using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_CadastroDeProdutos
{
    public partial class Form1 : Form
    { 
       private int codigoAtual = 1;

        public Form1()
        {
            InitializeComponent();

            txtCodigo.Text = codigoAtual.ToString("D6");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CalcularMargem()
        {
            decimal custo = numCusto.Value;
            decimal venda = numVenda.Value;

            decimal margem = venda - custo;

            txtMargem.Text = margem.ToString("N2");
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {


        }

        private void nudCusto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudVenda_ValueChanged(object sender, EventArgs e)
        {
            CalcularMargem();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbFornecedor.SelectedIndex = -1;
            txtDescricao.Clear();

            numCusto.Value = 0;
            numVenda.Value = 0;
            nudEstoque.Value = 0;
            nudEstoqueMinimo.Value = 0;

            txtMargem.Clear();

            chkProdutoAtivo.Checked = true;
            dtpCadastro.Value = DateTime.Now;

            txtNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            codigoAtual++;

            txtCodigo.Text = codigoAtual.ToString("D6");

            txtNome.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbFornecedor.SelectedIndex = -1;
            txtDescricao.Clear();

            numCusto.Value = 0;
            numVenda.Value = 0;
            nudEstoque.Value = 0;
            nudEstoqueMinimo.Value = 0;

            CalcularMargem();

            chkProdutoAtivo.Checked = true;
            dtpCadastro.Value = DateTime.Now;

            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Digite o nome do produto!");
                txtNome.Focus();
                return;
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma categoria!");
                return;
            }

            if (cmbFornecedor.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um fornecedor!");
                return;
            }

            MessageBox.Show("Produto cadastrado com sucesso!");
            txtNome.Clear();

            cmbCategoria.SelectedIndex = -1;
            cmbFornecedor.SelectedIndex = -1;

            numCusto.Value = 0;
            numVenda.Value = 0;

            txtNome.Focus();

            if (cmbFornecedor.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um fornecedor!");
                return;
            }
            if (numCusto.Value <= 0)
            {
                MessageBox.Show("O custo deve ser maior que zero!");
                numCusto.Focus();
                return;
            }

            if (numVenda.Value <= 0)
            {
                MessageBox.Show("O preço de venda deve ser maior que zero!");
                numVenda.Focus();
                return;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Nenhum produto para excluir!");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir este produto?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                MessageBox.Show("Produto excluído com sucesso!");

                btnLimpar_Click(sender, e);
            }
        }
    }
}
