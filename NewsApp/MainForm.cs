using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsApp
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      comboBox1.SelectedIndex = 0;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // TODO: DB 연결해서 회원가입 / 로그인
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
  }
}