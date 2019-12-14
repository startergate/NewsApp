using System.Windows.Forms;

namespace NewsApp
{
  public struct News
  {
    public string title;
    public string content;
    public int newsid;
    public int pressid;
    public int rptid;
    public string press_name;
    public string rpt_name;
    public string section;

    public News(DataGridViewRow row)
    {
      newsid = (int) row.Cells["newsid"].Value;
      title = (string) row.Cells["title"].Value;
      content = (string) row.Cells["content"].Value;
      pressid = (int) row.Cells["pressid"].Value;
      rptid = (int) row.Cells["rptid"].Value;
      press_name = (string) row.Cells["press_name"].Value;
      rpt_name = (string) row.Cells["rpt_name"].Value;
      section = (string) row.Cells["section"].Value;
    }
  }
}