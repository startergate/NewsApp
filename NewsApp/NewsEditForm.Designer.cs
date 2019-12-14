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
      this.SuspendLayout();
      // 
      // textBoxTitle
      // 
      this.textBoxTitle.Location = new System.Drawing.Point(12, 14);
      this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxTitle.Name = "textBoxTitle";
      this.textBoxTitle.ReadOnly = true;
      this.textBoxTitle.Size = new System.Drawing.Size(776, 23);
      this.textBoxTitle.TabIndex = 0;
      // 
      // textBoxContent
      // 
      this.textBoxContent.Location = new System.Drawing.Point(12, 42);
      this.textBoxContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxContent.Multiline = true;
      this.textBoxContent.Name = "textBoxContent";
      this.textBoxContent.ReadOnly = true;
      this.textBoxContent.Size = new System.Drawing.Size(776, 482);
      this.textBoxContent.TabIndex = 1;
      // 
      // textBoxPress
      // 
      this.textBoxPress.Location = new System.Drawing.Point(12, 529);
      this.textBoxPress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxPress.Name = "textBoxPress";
      this.textBoxPress.ReadOnly = true;
      this.textBoxPress.Size = new System.Drawing.Size(109, 23);
      this.textBoxPress.TabIndex = 2;
      // 
      // textBoxRpt
      // 
      this.textBoxRpt.Location = new System.Drawing.Point(127, 529);
      this.textBoxRpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxRpt.Name = "textBoxRpt";
      this.textBoxRpt.ReadOnly = true;
      this.textBoxRpt.Size = new System.Drawing.Size(109, 23);
      this.textBoxRpt.TabIndex = 3;
      // 
      // NewsEditForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 562);
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
  }
}