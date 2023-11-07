﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace slooknatacha
{
    public partial class frmCliente : Form
    {
        string stringConexao = "" + "Data Source=FAC0539709W10-1;Initial Catalog=t14_projeto_slook;User ID=sa;Password=123456";

        public frmCliente()
        {
            InitializeComponent();
        }

        private void btosair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btolimpar_Click(object sender, EventArgs e)
        {
            txtid.Text = "";

        }
        private void txtsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btolimpar_Click_1(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtdata.Text = "";
            txtnome.Text = "";
            txtlogradouro.Text = "";
            txtcidade.Text = "";
            txtnumero.Text = "";
            txtcep.Text = "";
            txtcomplemento.Text = "";
            txtcpf.Text = "";
            txtbairro.Text = "";
            cbostatus.SelectedIndex = -1;
            txttelefone1.Text = "";
            txttelefone2.Text = "";
            txtemail.Text = "";
            cbouf.Text = "";
            txtobs.Text = "";
            txtnascimento.Text = "";            
            txtnome.Focus();
        }

        private void btoexcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from cliente where id_cliente = " + txtid.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandType = System.Data.CommandType.Text;
            conn.Open();

            try
            {
                int I = cmd.ExecuteNonQuery();

                if (I == 1)
                {
                    MessageBox.Show("Dado excluido com sucesso");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void btocadastrar_Click(object sender, EventArgs e)
        {
            string sql = "insert into cliente (nome_cliente, nasc_cliente, cpf_cliente, numero_cliente," +
                "logradouro_cliente, cep_cliente, bairro_cliente, cidade_cliente," +
                "comp_cliente, uf_cliente, telefone1_cliente, telefone2_cliente, email_cliente," +
                "obs_cliente, status_cliente)" +

                "values" +

                "('"+txtnome.Text+"','"+txtnascimento.Text+"','"+txtcpf.Text+"',"+
                ""+txtnumero.Text+","+
                "'"+txtlogradouro.Text+"','"+txtcep.Text+"','"+txtbairro.Text+"',"+
                "'"+txtcidade.Text+"','"+txtcomplemento.Text+"','"+cbouf.Text+"',"+
                "'"+txttelefone1.Text+"','"+txttelefone2.Text+"',"+
                "'"+txtemail.Text+"','"+txtobs.Text+ "','" + cbostatus.Text + "')" +
                "select SCOPE_IDENTITY()";



            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader leitura;

            conn.Open();

            try
            {

                leitura = cmd.ExecuteReader();

                if (leitura.Read())
                {
                    btolimpar.PerformClick();

                    MessageBox.Show("Castro realizado com sucesso código gerado");

                    txtid.Text = leitura[0].ToString();

                    btopesquisar.PerformClick();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void btopesquisar_Click(object sender, EventArgs e)
        {
            string sql = "select * from cliente where id_cliente=" + txtid.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader leitura;
            conn.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {

                    //cbostatusloja.Text = leitura[27].ToString();

                    txtid.Text = leitura[0].ToString();
                    txtnome.Text = leitura[1].ToString();
                    txtnascimento.Text = leitura[2].ToString();
                    txtdata.Text = leitura[3].ToString();
                    txtcpf.Text = leitura[4].ToString();
                    txtnumero.Text = leitura[5].ToString();
                    txtlogradouro.Text = leitura[6].ToString();
                    txtcep.Text = leitura[7].ToString();
                    txtbairro.Text = leitura[8].ToString();
                    txtcidade.Text = leitura[9].ToString();
                    txtcomplemento.Text = leitura[10].ToString();
                    cbouf.Text = leitura[11].ToString();
                    txttelefone1.Text = leitura[12].ToString();
                    txttelefone2.Text = leitura[13].ToString();
                    txtemail.Text = leitura[14].ToString();
                    txtobs.Text = leitura[15].ToString();
                    cbostatus.Text = leitura[16].ToString();


                }
                else
                {
                    MessageBox.Show("Código não encontrado");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro, " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }

       
}
