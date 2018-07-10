using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD_Mercado.Funcionario
{
    public partial class Pesquisa : Form
    {
        public Pesquisa()
        {
            InitializeComponent();
            ListaFun();
        }

        SqlConnection sqlCo = null;
        private string strCon = "Password=dudinha321;Persist Security Info=True;User ID=66873;Initial Catalog=66873;Data Source=172.16.0.8";
        private string strSql = string.Empty;
        SqlConnection con = new SqlConnection("Password=dudinha321;Persist Security Info=True;User ID=66873;Initial Catalog=66873;Data Source=172.16.0.8");


        public void ListaFun()
        {
            Pesquisa_Fun p = new Pesquisa_Fun();
            gvFun.DataSource = p.ListaFun();


        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            if (gvFun.Rows.Count > 0)
            {
                txtCargo.Text = gvFun.SelectedRows[0].Cells["CARGO"].Value.ToString();
                txtemail.Text = gvFun.SelectedRows[0].Cells["EMAIL"].Value.ToString();
                txtID.Text = gvFun.SelectedRows[0].Cells["CODIGO"].Value.ToString();
                txtIdade.Text = gvFun.SelectedRows[0].Cells["IDADE"].Value.ToString();
                txtEndereco.Text = gvFun.SelectedRows[0].Cells["ENDERECO"].Value.ToString();
                txtNome.Text = gvFun.SelectedRows[0].Cells["NOME"].Value.ToString();
                txtcpf.Text = gvFun.SelectedRows[0].Cells["CPF"].Value.ToString();
                txtTelefone.Text = gvFun.SelectedRows[0].Cells["TELEFONE"].Value.ToString();
                txtUF.Text = gvFun.SelectedRows[0].Cells["UF"].Value.ToString();
                txtCep.Text = gvFun.SelectedRows[0].Cells["CEP"].Value.ToString();
                txtCidade.Text = gvFun.SelectedRows[0].Cells["CIDADE"].Value.ToString();


            }
          
        }

        public void Excluir() {

            SqlCommand comm = new SqlCommand("delete from Douglas.FUNCIO where ID_FUN=" + txtID.Text, con);

            con.Open();
            comm.ExecuteNonQuery();



            con.Close();
            MessageBox.Show("EXCLUIDO COM SUCESSO");

        
        
        
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ListaFun();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ListaFun();
        }

        private void button2_Click(object sender, EventArgs e)
        {

          
            SqlCommand comm;
           comm = new SqlCommand("update Douglas.FUNCIO set CARGO='" + txtCargo.Text + "', NOME='" + txtNome.Text + "', IDADE=" + txtIdade.Text + ", ENDERECO='" + txtEndereco.Text + "',EMAIL='" + txtemail.Text +"', CPF=" + txtcpf.Text + ", TELEFONE=" + txtTelefone.Text + ", UF='"+txtUF.Text+"', CEP="+txtCep.Text+", CIDADE='"+txtCidade.Text+"' where ID_FUN=" + txtID.Text, con);

            con.Open();
            comm.ExecuteNonQuery();

            con.Close();

            MessageBox.Show(" ALTERADO COM SUCESSO");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
