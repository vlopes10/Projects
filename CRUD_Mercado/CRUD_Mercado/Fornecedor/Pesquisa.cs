using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CRUD_Mercado.Fornecedor
{
    public partial class Pesquisa : Form
    {
        public Pesquisa()
        {
            InitializeComponent();
            ListaFornecedor();
        }
        SqlConnection sqlCo = null;
        private string strCon = "Password=dudinha321;Persist Security Info=True;User ID=66873;Initial Catalog=66873;Data Source=172.16.0.8";
        private string strSql = string.Empty;
        SqlConnection con = new SqlConnection("Password=dudinha321;Persist Security Info=True;User ID=66873;Initial Catalog=66873;Data Source=172.16.0.8");

        public void ListaFornecedor()
        {
            Pesquisa_For p = new Pesquisa_For();
            gvForne.DataSource = p.ListaFornecedor();
   
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaFornecedor();
           
        }

        private void gvForne_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void gvForne_MouseClick(object sender, MouseEventArgs e)
        {
            if (gvForne.Rows.Count > 0)
            {
                txtEmpresa.Text = gvForne.SelectedRows[0].Cells["EMPRESA"].Value.ToString();
                txtCnpj.Text = gvForne.SelectedRows[0].Cells["CNPJ"].Value.ToString();
                txtCod.Text = gvForne.SelectedRows[0].Cells["CODIGO"].Value.ToString();
                txtEnde.Text = gvForne.SelectedRows[0].Cells["ENDERECO"].Value.ToString();
                txtTel.Text = gvForne.SelectedRows[0].Cells["TELEFONE"].Value.ToString();
                txtUf.Text = gvForne.SelectedRows[0].Cells["UF"].Value.ToString();
                txtGenero.Text = gvForne.SelectedRows[0].Cells["GENERO"].Value.ToString();
                txtCep.Text = gvForne.SelectedRows[0].Cells["CEP"].Value.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
             SqlCommand comm = new SqlCommand("delete from Douglas.FORNE where ID_EMPRESA=" + txtCod.Text, con);

            con.Open();
            comm.ExecuteNonQuery();
            


            con.Close();
            MessageBox.Show("EXCLUIDO COM SUCESSO");

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ListaFornecedor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand comm;
           // strCon = "update Douglas.FORNE set EMPRESA='"+ txtEmpresa.Text+"', CNPJ="+txtCnpj.Text+", GENERO="+txtGenero.Text+", ENDERECO='"+ txtEnde.Text+"',TELEFONE="+txtTel.Text+",UF='"+txtUf.Text+"', CEP="+txtCep.Text+" where ID_EMPRESA="+txtCod.Text;
            comm = new SqlCommand("update Douglas.FORNE set EMPRESA='" + txtEmpresa.Text + "', CNPJ=" + txtCnpj.Text + ", GENERO='" + txtGenero.Text + "', ENDERECO='" + txtEnde.Text + "',TELEFONE=" + txtTel.Text + ",UF='" + txtUf.Text + "', CEP=" + txtCep.Text + " where ID_EMPRESA=" + txtCod.Text, con);

            con.Open();
            comm.ExecuteNonQuery();

            con.Close();

            MessageBox.Show(" ALTERADO COM SUCESSO");
       
        }
    }
    }

