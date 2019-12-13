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
      this.dataGridView1.Size = new System.Drawing.Size(777, 548);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellDoubleClick +=
        new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
      // 
      // NewsView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 562);
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
  }
}