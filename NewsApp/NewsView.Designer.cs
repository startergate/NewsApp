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
      this.btnNew.Name = "btnNew";
      this.btnNew.Size = new System.Drawing.Size(135, 32);
      this.btnNew.TabIndex = 1;
      this.btnNew.Text = "업로드";
      this.btnNew.UseVisualStyleBackColor = true;
      this.btnNew.Visible = false;
      this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
      // 
      // NewsView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 562);
      this.Controls.Add(this.btnNew);
      this.Controls.Add(this.dataGridView1);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "NewsView";
      this.Text = "NewsView";
      this.Load += new System.EventHandler(this.NewsView_Load);
      ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnNew;
  }
}