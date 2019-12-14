using System;
using System.Windows.Forms;

namespace NewsApp
{
  public partial class NewsEditForm : Form
  {
    private Session sess;
    private News news;
    
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

      MessageBox.Show(news.rptid + " " + sess.Id);
      
      if (news.rptid == sess.Id)
      {
        textBoxTitle.ReadOnly = false;
        textBoxContent.ReadOnly = false;
        textBoxPress.ReadOnly = false;
        textBoxRpt.ReadOnly = false;
        
        
      }
    }

    private void NewsEditForm_Load(object sender, EventArgs e)
    {
      
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