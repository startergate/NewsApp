using System.Windows.Forms;

namespace NewsApp
{
  public partial class NewsEditForm : Form
  {
    private Session sess;
    
    public NewsEditForm(Session sess)
    {
      InitializeComponent();

      this.sess = sess;
    }
  }
}