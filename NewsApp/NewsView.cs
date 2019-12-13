using System;
using System.Windows.Forms;

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

  }
}