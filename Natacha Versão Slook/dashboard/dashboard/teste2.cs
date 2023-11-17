using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard
{
    public partial class teste2 : MaterialForm
    {
        string stringConexao = "" + "Data Source=FAC0539709W10-1;Initial Catalog=t14_projeto_slook;User ID=sa;Password=123456";


        public teste2()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange700, TextShade.WHITE);

        }


        private void teste2_Load(object sender, EventArgs e)
        {
            carregarDataGridcliente();
        }

        private void carregarDataGridcliente()
        {
            string sql = "select id_cliente as 'ID', nome_cliente as 'Nome', " +
            "email_cliente as 'Login', telefone1_cliente as 'Contato', data_cliente as 'Data', status_cliente as 'Status' from cliente " +
            "where nome_cliente like '%" + txtNomedePesquisa.Text + "%'";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();

            conn.Open();

            try
            {
                ad.Fill(ds);

                dgcliente.DataSource = ds.Tables[0];
                dgcliente.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgcliente.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);


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

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmCliente frm = new frmCliente();
            frm.Show();
            
        }

        private void dgcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {            
            carregarDataGridcliente();
        }
    }
}
