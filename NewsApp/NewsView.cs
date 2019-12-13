using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NewsApp
{
  public partial class NewsView : Form
  {
    private Session sess;
    
    public NewsView(Session sess)
    {
      InitializeComponent();
      this.sess = sess;
    }
    
    private MySqlConnection conn;
    private MySqlDataAdapter adapter;
    private DataSet dataSet;
    
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      base.OnFormClosing(e);
      
      if (MessageBox.Show("진짜로 종료하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        Application.Exit();
        return;
      }
      else
      {
        e.Cancel = true;
      }
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      var newsEditForm = new NewsEditForm(sess) {Location = this.Location, StartPosition = this.StartPosition};
      newsEditForm.ShowDialog();
    }

    private void NewsView_Load(object sender, EventArgs e)
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
      
      loadDataGridAll();
    }

    private void loadDataGridAll()
    {
      string sql = "SELECT * FROM news_with_press_reporter ORDER BY newsid DESC LIMIT 50";

      adapter.SelectCommand = new MySqlCommand(sql, conn);

      if (adapter.Fill(dataSet) > 0)
      {
        dataGridView1.DataSource = dataSet.Tables["Table"];
        dataGridView1.Columns["newsid"].Visible = false;
        dataGridView1.Columns["pressid"].Visible = false;
        dataGridView1.Columns["rptid"].Visible = false;
      }
    }
  }
}