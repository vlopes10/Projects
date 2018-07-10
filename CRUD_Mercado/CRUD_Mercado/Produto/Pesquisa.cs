using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD_Mercado.Produto
{
    public partial class Pesquisa : Form
    {
        public Pesquisa()
        {
            InitializeComponent();
            ListaProduto();
        }
        SqlConnection sqlCo = null;
        private string strCon = "Password=dudinha321;Persist Security Info=True;User ID=66873;Initial Catalog=66873;Data Source=172.16.0.8";
        private string strSql = string.Empty;
        SqlConnection con = new SqlConnection("Password=dudinha321;Persist Security Info=True;User ID=66873;Initial Catalog=66873;Data Source=172.16.0.8");
      
        public void ListaProduto()
        {
            Pesquisa_Produto p = new Pesquisa_Produto();
            gvProduto.DataSource = p.ListaProduto();


        }
        public void Excluir()
        {

            SqlCommand comm = new SqlCommand("delete from Douglas.PRODUTO where ID_PRODUTO=" + txtID.Text, con);

            con.Open();
            comm.ExecuteNonQuery();



            con.Close();
            MessageBox.Show("EXCLUIDO COM SUCESSO");





        }
        private void gvProduto_MouseClick(object sender, MouseEventArgs e)
        {

            if (gvProduto.Rows.Count > 0)
            {
                txtMarca.Text = gvProduto.SelectedRows[0].Cells["MARCA"].Value.ToString();
                txtID.Text = gvProduto.SelectedRows[0].Cells["CODIGO"].Value.ToString();
                txtPreco.Text = gvProduto.SelectedRows[0].Cells["PRECO"].Value.ToString();
                txtQDD.Text = gvProduto.SelectedRows[0].Cells["QDD"].Value.ToString();
                txtNome.Text = gvProduto.SelectedRows[0].Cells["NOME"].Value.ToString();
                txtGenero.Text = gvProduto.SelectedRows[0].Cells["GENERO"].Value.ToString();
                txtValidade.Text = gvProduto.SelectedRows[0].Cells["VALIDADE"].Value.ToString();
                txtDataE.Text = gvProduto.SelectedRows[0].Cells["DATAE"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaProduto();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ListaProduto();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        //    strSql = "update Douglas.PRODUTO set MARCA='"+txtMarca.Text+"', PRECO="+txtPreco.Text+", QDD="+txtQDD.Text+", NOME='"+txtNome.Text+"',GENERO='"+txtGenero.Text+"',VALIDADE="+txtValidade.Text+", DATA_en="+txtDataE.Text+" where ID_PRODUTO="+txtID.Text;
            SqlCommand comm;
            comm = new SqlCommand("update Douglas.PRODUTO set MARCA='" + txtMarca.Text + "', PRECO=" + txtPreco.Text + ", QDD=" + txtQDD.Text + ", NOME='" + txtNome.Text + "',GENERO='" + txtGenero.Text + "',VALIDADE=" + txtValidade.Text + ", DATA_en=" + txtDataE.Text + " where ID_PRODUTO=" + txtID.Text, con);

            con.Open();
            comm.ExecuteNonQuery();

            con.Close();

            MessageBox.Show(" ALTERADO COM SUCESSO");
        }

        private void gvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
