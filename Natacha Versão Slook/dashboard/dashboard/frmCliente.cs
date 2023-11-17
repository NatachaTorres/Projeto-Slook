using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dashboard
{
    public partial class frmCliente : MaterialForm
    {
        string stringConexao = "" + "Data Source=FAC0539709W10-1;Initial Catalog=t14_projeto_slook;User ID=sa;Password=123456";


        private void TestarConexao()
        {
            SqlConnection conn = new SqlConnection(stringConexao);

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.ToString());
                Application.Exit();
            }

        }


        public frmCliente()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange700, TextShade.WHITE);

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btolimpar_Click(object sender, EventArgs e)
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

        private void btoalterar_Click(object sender, EventArgs e)
        {
            string cpf = txtcpf.Text;
            cpf = cpf.Replace(",", ".");

            string sql = "update cliente set " +
                "nome_cliente='" + txtnome.Text + "'," +
                "nasc_cliente='" + txtnascimento.Text + "'," +
                "cpf_cliente='" + cpf + "'," +
                "numero_cliente=" + txtnumero.Text + "," +
                "logradouro_cliente='" + txtlogradouro.Text + "'," +
                "cep_cliente='" + txtcep.Text + "'," +
                "bairro_cliente='" + txtbairro.Text + "'," +
                "cidade_cliente='" + txtcidade.Text + "'," +
                "comp_cliente='" + txtcomplemento.Text + "'," +
                "uf_cliente='" + cbouf.Text + "'," +
                "telefone1_cliente='" + txttelefone1.Text + "'," +
                "telefone2_cliente='" + txttelefone2.Text + "'," +
                "email_cliente='" + txtemail.Text + "'," +
                "obs_cliente='" + txtobs.Text + "'," +
                "status_cliente='" + cbostatus.SelectedIndex + "'" +
                "where id_cliente = " + txtid.Text;



            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandType = System.Data.CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Dados alterados com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro, não foi possivel alterar os dados");
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
            string cpf = txtcpf.Text;
            cpf = cpf.Replace(",", ".");

            string sql = "set dateformat dmy insert into cliente (nome_cliente, nasc_cliente, cpf_cliente, numero_cliente," +
                "logradouro_cliente, cep_cliente, bairro_cliente, cidade_cliente," +
                "comp_cliente, uf_cliente, telefone1_cliente, telefone2_cliente, email_cliente," +
                "obs_cliente, status_cliente)" +

                "values" +

                "('" + txtnome.Text + "','" + txtnascimento.Text + "','" + cpf + "'," +
                "" + txtnumero.Text + "," +
                "'" + txtlogradouro.Text + "','" + txtcep.Text + "','" + txtbairro.Text + "'," +
                "'" + txtcidade.Text + "','" + txtcomplemento.Text + "','" + cbouf.Text + "'," +
                "'" + txttelefone1.Text + "','" + txttelefone2.Text + "'," +
                "'" + txtemail.Text + "','" + txtobs.Text + "','" + cbostatus.Text + "')" +
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

        private void frmCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();

            teste2 frm = new teste2();
            frm.Show();

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            TestarConexao();

        }
    }
}
