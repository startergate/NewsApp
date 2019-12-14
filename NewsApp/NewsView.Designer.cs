using System.ComponentModel;

namespace NewsApp
{
  partial class NewsView
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }

      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.btnNew = new System.Windows.Forms.Button();
      this.textBoxTitle = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
      this.label4 = new System.Windows.Forms.Label();
      this.comboBoxPress = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.textBoxRpt = new System.Windows.Forms.TextBox();
      this.comboBoxSec = new System.Windows.Forms.ComboBox();
      this.label6 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
      this.dataGridView1.Location = new System.Drawing.Point(11, 8);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(636, 548);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellDoubleClick +=
        new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
      // 
      // btnNew
      // 
      this.btnNew.Location = new System.Drawing.Point(653, 8);
      this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnNew.Name = "btnNew";
      this.btnNew.Size = new System.Drawing.Size(135, 32);
      this.btnNew.TabIndex = 1;
      this.btnNew.Text = "업로드";
      this.btnNew.UseVisualStyleBackColor = true;
      this.btnNew.Visible = false;
      this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
      // 
      // textBoxTitle
      // 
      this.textBoxTitle.Location = new System.Drawing.Point(653, 232);
      this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxTitle.Name = "textBoxTitle";
      this.textBoxTitle.Size = new System.Drawing.Size(135, 23);
      this.textBoxTitle.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(653, 209);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(86, 20);
      this.label1.TabIndex = 3;
      this.label1.Text = "제목";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // dateTimePickerFrom
      // 
      this.dateTimePickerFrom.Location = new System.Drawing.Point(653, 437);
      this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dateTimePickerFrom.Name = "dateTimePickerFrom";
      this.dateTimePickerFrom.Size = new System.Drawing.Size(135, 23);
      this.dateTimePickerFrom.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(653, 414);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(86, 20);
      this.label2.TabIndex = 5;
      this.label2.Text = "이 시점부터";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(653, 464);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(86, 20);
      this.label3.TabIndex = 7;
      this.label3.Text = "이 시점까지";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // dateTimePickerTo
      // 
      this.dateTimePickerTo.Location = new System.Drawing.Point(653, 488);
      this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dateTimePickerTo.Name = "dateTimePickerTo";
      this.dateTimePickerTo.Size = new System.Drawing.Size(135, 23);
      this.dateTimePickerTo.TabIndex = 6;
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(653, 262);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(86, 20);
      this.label4.TabIndex = 8;
      this.label4.Text = "언론사";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // comboBoxPress
      // 
      this.comboBoxPress.FormattingEnabled = true;
      this.comboBoxPress.Location = new System.Drawing.Point(653, 285);
      this.comboBoxPress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.comboBoxPress.Name = "comboBoxPress";
      this.comboBoxPress.Size = new System.Drawing.Size(135, 23);
      this.comboBoxPress.TabIndex = 9;
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(653, 314);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(86, 20);
      this.label5.TabIndex = 11;
      this.label5.Text = "기자";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // textBoxRpt
      // 
      this.textBoxRpt.Location = new System.Drawing.Point(653, 337);
      this.textBoxRpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxRpt.Name = "textBoxRpt";
      this.textBoxRpt.Size = new System.Drawing.Size(135, 23);
      this.textBoxRpt.TabIndex = 10;
      // 
      // comboBoxSec
      // 
      this.comboBoxSec.FormattingEnabled = true;
      this.comboBoxSec.Location = new System.Drawing.Point(653, 388);
      this.comboBoxSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.comboBoxSec.Name = "comboBoxSec";
      this.comboBoxSec.Size = new System.Drawing.Size(135, 23);
      this.comboBoxSec.TabIndex = 13;
      // 
      // label6
      // 
      this.label6.Location = new System.Drawing.Point(653, 365);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(86, 20);
      this.label6.TabIndex = 12;
      this.label6.Text = "섹션";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(653, 524);
      this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(68, 32);
      this.button1.TabIndex = 14;
      this.button1.Text = "조회";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(727, 524);
      this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(61, 32);
      this.button2.TabIndex = 15;
      this.button2.Text = "리셋";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // NewsView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 562);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.comboBoxSec);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.textBoxRpt);
      this.Controls.Add(this.comboBoxPress);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.dateTimePickerTo);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.dateTimePickerFrom);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxTitle);
      this.Controls.Add(this.btnNew);
      this.Controls.Add(this.dataGridView1);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "NewsView";
      this.Text = "NewsView";
      this.Load += new System.EventHandler(this.NewsView_Load);
      ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnNew;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxTitle;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
    private System.Windows.Forms.DateTimePicker dateTimePickerTo;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ComboBox comboBoxSec;
    private System.Windows.Forms.ComboBox comboBoxPress;
    private System.Windows.Forms.TextBox textBoxRpt;
  }
}