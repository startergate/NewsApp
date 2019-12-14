﻿using System;
using System.Collections.Generic;
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

      if (sess.PressId != 0)
      {
        btnNew.Visible = true;
        btnReporter.Visible = true;
      }
    }
    
    private MySqlConnection conn;
    private MySqlDataAdapter adapter;
    private DataSet dataSet;

    private DateTime dtTo;
    private DateTime dtFrom;
    
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      base.OnFormClosing(e);
      
      Application.Exit();
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      var newsEditForm = new NewsEditForm(sess, new News(dataGridView1.SelectedRows[0])) {Location = this.Location, StartPosition = this.StartPosition};
      newsEditForm.ShowDialog();

      if (sess.PressId != 0)
      {
        loadDataGridAll();
      }
    }

    private void NewsView_Load(object sender, EventArgs e)
    {
      dtFrom = dateTimePickerFrom.Value;
      dtTo = dateTimePickerTo.Value;
      
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

      DataSet dsTemp = new DataSet();
      
      var sql = "SELECT * FROM sections";
      
      adapter.SelectCommand = new MySqlCommand(sql, conn);
      
      if (adapter.Fill(dsTemp) > 0)
      {
        foreach (DataRow row in dsTemp.Tables["Table"].Rows)
        {
          comboBoxSec.Items.Add((string) row["name"]);
        }
      }
      
      dsTemp.Clear();
      
      sql = "SELECT * FROM presses";
      
      adapter.SelectCommand = new MySqlCommand(sql, conn);
      
      if (adapter.Fill(dsTemp) > 0)
      {
        foreach (DataRow row in dsTemp.Tables["Table"].Rows)
        {
          comboBoxPress.Items.Add((string) row["name"]);
        }
      }
    }

    private void loadDataGridAll()
    {
      const string sql = "SELECT * FROM sections_with_news ORDER BY created_at DESC LIMIT 50";

      adapter.SelectCommand = new MySqlCommand(sql, conn);

      if (adapter.Fill(dataSet) > 0)
      {
        dataSet.Clear();
        adapter.Fill(dataSet);
        dataGridView1.DataSource = dataSet.Tables["Table"].DefaultView.ToTable(true);
        dataGridView1.Columns["newsid"].Visible = false;
        dataGridView1.Columns["pressid"].Visible = false;
        dataGridView1.Columns["rptid"].Visible = false;
      }
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
      var newsEditForm = new NewsEditForm(sess) {Location = this.Location, StartPosition = this.StartPosition};
      newsEditForm.ShowDialog();
      
      loadDataGridAll();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      textBoxTitle.Text = "";
      textBoxRpt.Text = "";
      comboBoxPress.SelectedItem = null;
      comboBoxSec.SelectedItem = null;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var sql = "SELECT * FROM sections_with_news";

      List<string> conditions = new List<string>();

      if (textBoxTitle.Text != "")
      {
        conditions.Add("title LIKE \"%" + textBoxTitle.Text + "%\"");
      }

      if (textBoxRpt.Text != "")
      {
        conditions.Add("rpt_name = \"" + textBoxRpt.Text + "\"");
      }

      if (comboBoxPress.SelectedIndex != -1)
      {
        conditions.Add("press_name = \"" + comboBoxPress.SelectedItem + "\"");
      }
      
      if (comboBoxSec.SelectedIndex != -1)
      {
        conditions.Add("section = \"" + comboBoxSec.SelectedItem + "\"");
      }

      if (dateTimePickerFrom.Value < dtFrom)
      {
        conditions.Add("created_at >= \"" + dateTimePickerFrom.Value + "\"");
      }

      if (dateTimePickerTo.Value < dtTo)
      {
        conditions.Add("created_at <= \"" + dateTimePickerTo.Value + "\"");
      }
      
      var condition = (conditions.ToArray().Length > 0 ? " WHERE " : "") + String.Join(" AND ", conditions.ToArray());

      MessageBox.Show(condition);

      condition += " ORDER BY created_at DESC LIMIT 50";
      
      adapter.SelectCommand = new MySqlCommand(sql + condition, conn);
      
      if (adapter.Fill(dataSet) > 0)
      {
        dataSet.Clear();
        adapter.Fill(dataSet);
        dataGridView1.DataSource = dataSet.Tables["Table"].DefaultView.ToTable(true);
      }
      else
      {
        MessageBox.Show("검색된 데이터가 없습니다.");
      }
    }
  }
}