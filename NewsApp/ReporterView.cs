using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NewsApp
{
  public partial class ReporterView : Form
  {
    public ReporterView()
    {
      InitializeComponent();
    }
    
    private MySqlConnection conn;
    private MySqlDataAdapter adapter;
    private DataSet dataSet;

    private void ReporterView_Load(object sender, EventArgs e)
    {
      string connStr = "server=db.donote.co;port=3306;database=news;uid=news;pwd=1111";
      conn = new MySqlConnection(connStr);
      adapter = new MySqlDataAdapter();
      dataSet = new DataSet();
      
      try
      {
        conn.Open();
        if (conn.State != ConnectionState.Open)
        {
          MessageBox.Show("Warning! Can't Connect to the Database.");
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      
      const string sql = "SELECT * FROM reporters_with_presses";

      adapter.SelectCommand = new MySqlCommand(sql, conn);

      if (adapter.Fill(dataSet) > 0)
      {
        dataSet.Clear();
        adapter.Fill(dataSet);
        dataGridView1.DataSource = dataSet.Tables["Table"].DefaultView.ToTable(true);
      }
    }
  }
}