using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NewsApp
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }
    
    private MySqlConnection conn;
    private MySqlDataAdapter adapter;
    private DataSet dataSet;

    private void MainForm_Load(object sender, EventArgs e)
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
      
      comboBox1.SelectedIndex = 0;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // TODO: DB 연결해서 회원가입 / 로그인
      switch (comboBox1.SelectedIndex)
      {
        case 0:
          string sqlSelect = "SELECT * FROM users WHERE userid = @id";
          
          adapter.SelectCommand = new MySqlCommand(sqlSelect, conn);
          adapter.SelectCommand.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));

          if (adapter.Fill(dataSet) > 0)
          {
            Session sess = new Session()
            {
              Id = (int) dataSet.Tables["Table"].Rows[0]["userid"],
              Name = (string) dataSet.Tables["Table"].Rows[0]["name"]
            };
            var tickets = new NewsView(sess) {Location = this.Location, StartPosition = this.StartPosition};

            tickets.Show();
            this.Hide();
          }
          break;
        case 1:
          string sqlInsert = "INSERT INTO users (name) VALUES (@name)";

          adapter.InsertCommand = new MySqlCommand(sqlInsert, conn);
          adapter.InsertCommand.Parameters.AddWithValue("@name", textBox1.Text);

          if (adapter.InsertCommand.ExecuteNonQuery() > 0)
          {
            Session sess = new Session()
            {
              Id = (int) adapter.InsertCommand.LastInsertedId,
              Name = textBox1.Text
            };
            var tickets = new NewsView(sess) {Location = this.Location, StartPosition = this.StartPosition};

            MessageBox.Show(sess.Name + "님의 아이디는 " + sess.Id + " 입니다.", "가입 완료!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tickets.Show();
            this.Hide();
          }
          break;
        default:
          MessageBox.Show("TF you doing here nigga, identify yourself, who tf are you");
          break;
      }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (comboBox1.SelectedIndex)
      {
        case 0:
          label2.Text = "아이디";
          button1.Text = "로그인";
          break;
        case 1:
          label2.Text = "이름";
          button1.Text = "회원가입";
          break;
        default:
          MessageBox.Show("STOP RIGHT THERE, CRIMINAL SCUM!");
          break;
      }
    }

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
  }
}