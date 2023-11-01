using System.Data;
using System.Data.SqlClient;

namespace frmvendedor
{
    public partial class frmVendedor : Form
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
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void btosair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btolimpar_Click(object sender, EventArgs e)
        {
            txtbairro.Text = "";
            txtcep.Text = "";
            txtcidade.Text = "";
            txtcomplemento.Text = "";
            txtcpf.Text = "";
            txtemail.Text = "";
            txtnascimento.Text = "";
            txtlogradouro.Text = "";
            txtnome.Text = "";
            txtnumero.Text = "0";
            txttelefone1.Text = "";
            txttelefone2.Text = "";
            txtuf.Text = "";
            cbostatus.SelectedIndex = -1;

            txtbairroloja.Text = "";
            txtceploja.Text = "";
            txtcidadeloja.Text = "";
            txtcomplementoloja.Text = "";
            txtcnpjloja.Text = "";
            txtdataloja.Text = "";
            txtemailloja.Text = "";
            txtidloja.Text = "";
            txtnascimentoloja.Text = "";
            txtlogradouroloja.Text = "";
            txtnomeloja.Text = "";
            txtnumeroloja.Text = "0";
            txttelefone1loja.Text = "";
            txttelefone2loja.Text = "";
            txtufloja.Text = "";
            cbostatusloja.SelectedIndex = -1;
            txtobs.Text = "";
            txtnome.Focus();
        }

        private void btocadastrar_Click(object sender, EventArgs e)
        {
            
            string sql = //"insert into usuario (nome_usuario,login_usuario,senha_usuario,obs_usuario)" +
            //    "values" +
            //    "('" + txtNome.Text + "','" + txtLogin.Text + "','" + txtSenha.Text + "','" + txtObs.Text + "') select SCOPE_IDENTITY()";

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
                   
                    txtidloja.Text = leitura[0].ToString();

                    btoprequisar.PerformClick();
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