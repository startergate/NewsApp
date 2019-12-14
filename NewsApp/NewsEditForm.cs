using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NewsApp
{
  public partial class NewsEditForm : Form
  {
    private Session sess;
    private News news;
    
    private MySqlConnection conn;
    private MySqlDataAdapter adapter;
    private DataSet dataSet;
    
    public NewsEditForm(Session sess)
    {
      InitializeComponent();

      this.sess = sess;
      news = new News();
    }
    
    public NewsEditForm(Session sess, News news)
    {
      InitializeComponent();

      this.sess = sess;
      this.news = news;

      textBoxTitle.Text = news.title;
      textBoxContent.Text = news.content;
      textBoxPress.Text = news.press_name;
      textBoxRpt.Text = news.rpt_name;
      
      if (news.rptid == sess.Id)
      {
        textBoxTitle.ReadOnly = false;
        textBoxContent.ReadOnly = false;
        textBoxPress.ReadOnly = false;
        textBoxRpt.ReadOnly = false;

        buttonUpdate.Visible = true;
        buttonDelete.Visible = true;
      }
    }

    private void NewsEditForm_Load(object sender, EventArgs e)
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
      
      const string sql = "SELECT * FROM sections";

      adapter.SelectCommand = new MySqlCommand(sql, conn);

      if (adapter.Fill(dataSet) > 0)
      {
        foreach (DataRow row in dataSet.Tables["Table"].Rows)
        {
          comboBox1.Items.Add((string) row["name"]);
        }
      }

      comboBox1.SelectedIndex = 0;

      if (news.section != "")
      {
        MessageBox.Show(news.section);
        comboBox1.SelectedItem = news.section;
      }
    }

    private void buttonInsert_Click(object sender, EventArgs e)
    {
      throw new System.NotImplementedException();
    }

    private void buttonUpdate_Click(object sender, EventArgs e)
    {
      throw new System.NotImplementedException();
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
      throw new System.NotImplementedException();
    }
  }
}