using System.Data.SqlClient;

namespace POCOnDBConnectApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MONO-HYD-LAP-90\\SQLEXPRESS;database=MonoceptDB;integrated security = SSPI";

            SqlCommand cmd = new SqlCommand("select * from student", con);
            con.Open();
            SqlDataReader DR = cmd.ExecuteReader(); 

            BindingSource source = new BindingSource();
            source.DataSource = DR;

            dataGridView1.DataSource = source;
            con.Close();
        }
    }
}