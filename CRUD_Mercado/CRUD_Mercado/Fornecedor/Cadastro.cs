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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        SqlConnection sqlCo = null;
        private string strCon = "Password=dudinha321;Persist Security Info=True;User ID=66873;Initial Catalog=66873;Data Source=172.16.0.8";
        private string con = string.Empty;

        private void button1_Click(object sender, EventArgs e)
         {
             con = "insert into Douglas.FORNE(ID_EMPRESA,EMPRESA,CNPJ,ENDERECO,TELEFONE,UF,GENERO,CEP) values(" + txtID.Text + ",'" + txtEmpresa.Text + "'," + txtCnpj.Text + ",'" + txtEndereco.Text + "'," + txtTel.Text + ",'" + cmbUF.SelectedItem + "','" + cmbGenero.SelectedItem + "'," + txtCep.Text + ")";
             sqlCo = new SqlConnection(strCon);
             SqlCommand comando = new SqlCommand(con, sqlCo);

            try
            {
                sqlCo.Open();
                // abrir o banco

                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Efetuado");




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {

                sqlCo.Close();
                //Fechar o banco

            }

        }
    }
}
