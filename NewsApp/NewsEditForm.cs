using System;
using System.Data;
using System.Security.AccessControl;
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
    private MySqlDataAdapter adapter2;
    private DataSet dataSet;
    
    public NewsEditForm(Session sess)
    {
      InitializeComponent();

      this.sess = sess;
      news = new News();

      if (sess.Id != 0)
      {
        textBoxTitle.ReadOnly = false;
        textBoxContent.ReadOnly = false;
        textBoxPress.Text = sess.PressId.ToString();
        textBoxRpt.Text = sess.Id.ToString();

        buttonInsert.Visible = true;
      }
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

        buttonUpdate.Visible = true;
        buttonDelete.Visible = true;
      }
    }

    private void NewsEditForm_Load(object sender, EventArgs e)
    {
      string connStr = "server=db.donote.co;port=3306;database=news;uid=news;pwd=1111";
      conn = new MySqlConnection(connStr);
      adapter = new MySqlDataAdapter();
      adapter2 = new MySqlDataAdapter();
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
        comboBox1.SelectedItem = news.section;
      }
    }

    private void buttonInsert_Click(object sender, EventArgs e)
    {
      var sqlInsert1 =
        "INSERT INTO news (title, content, pressid, rptid, created_at) VALUES (@title, @content, @pressid, @rptid, NOW())";
      
      adapter.InsertCommand = new MySqlCommand(sqlInsert1, conn);
      adapter.InsertCommand.Parameters.AddWithValue("@title", textBoxTitle.Text);
      adapter.InsertCommand.Parameters.AddWithValue("@content", textBoxContent.Text);
      adapter.InsertCommand.Parameters.AddWithValue("@pressid", int.Parse(textBoxPress.Text));
      adapter.InsertCommand.Parameters.AddWithValue("@rptid", int.Parse(textBoxRpt.Text));

      
      if (adapter.InsertCommand.ExecuteNonQuery() > 0)
      {
        sqlInsert1 = "INSERT INTO sections_has_news (sections_secid, news_newsid) VALUES (@secid, @newsid)";
              
        adapter2.InsertCommand = new MySqlCommand(sqlInsert1, conn);
        adapter2.InsertCommand.Parameters.AddWithValue("@secid", comboBox1.SelectedIndex + 1);
        adapter2.InsertCommand.Parameters.AddWithValue("@newsid", adapter.InsertCommand.LastInsertedId);

        adapter2.InsertCommand.ExecuteNonQuery();
        
        MessageBox.Show("기사를 업로드했습니다.");
        Close();
      }
      else 
      {
        MessageBox.Show("에러 발생. 기사를 업로드 할 수 없습니다.");
      }
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