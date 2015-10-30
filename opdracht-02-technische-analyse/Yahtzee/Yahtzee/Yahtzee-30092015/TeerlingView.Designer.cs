namespace Yahtzee_30092015
{
  partial class TeerlingView
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnWerpTeeriling = new System.Windows.Forms.Button();
      this.lblTeerling = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnWerpTeeriling
      // 
      this.btnWerpTeeriling.Location = new System.Drawing.Point(37, 118);
      this.btnWerpTeeriling.Name = "btnWerpTeeriling";
      this.btnWerpTeeriling.Size = new System.Drawing.Size(75, 23);
      this.btnWerpTeeriling.TabIndex = 0;
      this.btnWerpTeeriling.Text = "Werp";
      this.btnWerpTeeriling.UseVisualStyleBackColor = true;
      this.btnWerpTeeriling.Click += new System.EventHandler(this.btnWerpTeeriling_Click);
      // 
      // lblTeerling
      // 
      this.lblTeerling.Location = new System.Drawing.Point(8, 5);
      this.lblTeerling.Name = "lblTeerling";
      this.lblTeerling.Size = new System.Drawing.Size(133, 110);
      this.lblTeerling.TabIndex = 1;
      this.lblTeerling.Text = "label1";
      this.lblTeerling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblTeerling.Click += new System.EventHandler(this.lblTeerling_Click);
      // 
      // TeerlingView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lblTeerling);
      this.Controls.Add(this.btnWerpTeeriling);
      this.Name = "TeerlingView";
      this.Load += new System.EventHandler(this.TeerlingView_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnWerpTeeriling;
    private System.Windows.Forms.Label lblTeerling;
  }
}
