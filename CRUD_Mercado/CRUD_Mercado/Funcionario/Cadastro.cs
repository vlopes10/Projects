﻿using System;
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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        SqlConnection sqlCo = null;
        private string strCon = "Password=dudinha321;Persist Security Info=True;User ID=66873;Initial Catalog=66873;Data Source=172.16.0.8";
        private string con = string.Empty;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = "insert into Douglas.FUNCIO(ID_FUN,NOME,CARGO,IDADE,ENDERECO,EMAIL,CPF,TELEFONE,UF,CEP,CIDADE) values(" + txtID.Text + ",'" + txtNome.Text + "','" + txtCargo.Text + "'," + txtIdade.Text + ",'" + txtEndereco.Text + "','" + txtEmail.Text + "'," + txtCpf.Text + "," + txtTel.Text + ",'" + cmbUF.SelectedItem + "'," + txtCep.Text + ",'" + txtCidade.Text + "')";

       sqlCo = new SqlConnection(strCon);
       SqlCommand comando = new SqlCommand(con, sqlCo);

       try
       {
           sqlCo.Open();
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
       
       }
        
        
        }

           
    }
}
