using System.ComponentModel;

namespace NewsApp
{
  partial class NewsEditForm
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
      this.textBoxTitle = new System.Windows.Forms.TextBox();
      this.textBoxContent = new System.Windows.Forms.TextBox();
      this.textBoxPress = new System.Windows.Forms.TextBox();
      this.textBoxRpt = new System.Windows.Forms.TextBox();
      this.buttonDelete = new System.Windows.Forms.Button();
      this.buttonUpdate = new System.Windows.Forms.Button();
      this.buttonInsert = new System.Windows.Forms.Button();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      this.textBoxTitle.Location = new System.Drawing.Point(12, 14);
      this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxTitle.Name = "textBoxTitle";
      this.textBoxTitle.ReadOnly = true;
      this.textBoxTitle.Size = new System.Drawing.Size(776, 23);
      this.textBoxTitle.TabIndex = 0;
      this.textBoxContent.Location = new System.Drawing.Point(12, 42);
      this.textBoxContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxContent.Multiline = true;
      this.textBoxContent.Name = "textBoxContent";
      this.textBoxContent.ReadOnly = true;
      this.textBoxContent.Size = new System.Drawing.Size(776, 482);
      this.textBoxContent.TabIndex = 1;
      this.textBoxPress.Location = new System.Drawing.Point(12, 529);
      this.textBoxPress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxPress.Name = "textBoxPress";
      this.textBoxPress.ReadOnly = true;
      this.textBoxPress.Size = new System.Drawing.Size(109, 23);
      this.textBoxPress.TabIndex = 2;
      this.textBoxRpt.Location = new System.Drawing.Point(127, 529);
      this.textBoxRpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxRpt.Name = "textBoxRpt";
      this.textBoxRpt.ReadOnly = true;
      this.textBoxRpt.Size = new System.Drawing.Size(109, 23);
      this.textBoxRpt.TabIndex = 3;
      this.buttonDelete.Location = new System.Drawing.Point(684, 529);
      this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonDelete.Name = "buttonDelete";
      this.buttonDelete.Size = new System.Drawing.Size(103, 22);
      this.buttonDelete.TabIndex = 4;
      this.buttonDelete.Text = "삭제";
      this.buttonDelete.UseVisualStyleBackColor = true;
      this.buttonDelete.Visible = false;
      this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
      this.buttonUpdate.Location = new System.Drawing.Point(575, 529);
      this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonUpdate.Name = "buttonUpdate";
      this.buttonUpdate.Size = new System.Drawing.Size(103, 22);
      this.buttonUpdate.TabIndex = 5;
      this.buttonUpdate.Text = "수정";
      this.buttonUpdate.UseVisualStyleBackColor = true;
      this.buttonUpdate.Visible = false;
      this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
      this.buttonInsert.Location = new System.Drawing.Point(466, 529);
      this.buttonInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonInsert.Name = "buttonInsert";
      this.buttonInsert.Size = new System.Drawing.Size(103, 22);
      this.buttonInsert.TabIndex = 6;
      this.buttonInsert.Text = "생성";
      this.buttonInsert.UseVisualStyleBackColor = true;
      this.buttonInsert.Visible = false;
      this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(242, 529);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(105, 23);
      this.comboBox1.TabIndex = 7;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 562);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.buttonInsert);
      this.Controls.Add(this.buttonUpdate);
      this.Controls.Add(this.buttonDelete);
      this.Controls.Add(this.textBoxRpt);
      this.Controls.Add(this.textBoxPress);
      this.Controls.Add(this.textBoxContent);
      this.Controls.Add(this.textBoxTitle);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "NewsEditForm";
      this.Text = "NewsEditForm";
      this.Load += new System.EventHandler(this.NewsEditForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.TextBox textBoxTitle;
    private System.Windows.Forms.TextBox textBoxContent;
    private System.Windows.Forms.TextBox textBoxPress;
    private System.Windows.Forms.TextBox textBoxRpt;
    private System.Windows.Forms.Button buttonInsert;
    private System.Windows.Forms.Button buttonUpdate;
    private System.Windows.Forms.Button buttonDelete;
    private System.Windows.Forms.ComboBox comboBox1;
  }
}