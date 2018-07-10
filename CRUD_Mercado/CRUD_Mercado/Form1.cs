using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CRUD_Mercado.Fornecedor;

namespace CRUD_Mercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cADASTROToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cadastro chama = new Cadastro();
            chama.ShowDialog();
        }

        private void cONSULTAToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            Fornecedor.Pesquisa chama = new Fornecedor.Pesquisa();
            chama.ShowDialog();
        }

        private void aLTERAÇÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedor.Pesquisa chama = new Fornecedor.Pesquisa();
            chama.ShowDialog();
        }

        private void eXCLUSÃOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fornecedor.Pesquisa chama = new Fornecedor.Pesquisa();
            chama.ShowDialog();
        }

        private void cADASTROToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Funcionario.Cadastro chama = new Funcionario.Cadastro();  // chamar formulario de cadastro cliente
            chama.ShowDialog();
        }

        private void cONSULTAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Funcionario.Pesquisa chama = new Funcionario.Pesquisa();        // chamar formulário de pesquisa 
            chama.ShowDialog();
        }

        private void eXCLUSÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionario.Pesquisa chama = new Funcionario.Pesquisa();
            chama.ShowDialog();
        }

        private void aLTERAÇÃOToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Funcionario.Pesquisa chama = new Funcionario.Pesquisa();
            chama.ShowDialog();
        }

        private void cADASTROToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            Produto.Cadastro chama = new Produto.Cadastro();
            chama.ShowDialog();

        }

        private void cONSULTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto.Pesquisa chama = new Produto.Pesquisa();
            chama.ShowDialog();
        }

        private void aLTERAÇÃOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Produto.Pesquisa chama = new Produto.Pesquisa();
            chama.ShowDialog();
        }

        private void eXCLUSÃOToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Produto.Pesquisa chama = new Produto.Pesquisa();
            chama.ShowDialog();
        }

        private void pESQUISAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendas.Pesquisa chama = new Vendas.Pesquisa();
            chama.ShowDialog();
        }

        private void cADASTROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendas.realizacao_venda chama = new Vendas.realizacao_venda();
            chama.ShowDialog();
        }

        private void fUNCIONARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
