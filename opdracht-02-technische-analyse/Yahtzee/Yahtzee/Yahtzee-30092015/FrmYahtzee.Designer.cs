using System.Collections.Generic;

namespace Yahtzee_30092015
{
  partial class FrmYahtzee
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnWerpAll = new System.Windows.Forms.Button();
      this.btnCheat = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnWerpAll
      // 
      this.btnWerpAll.Location = new System.Drawing.Point(13, 226);
      this.btnWerpAll.Name = "btnWerpAll";
      this.btnWerpAll.Size = new System.Drawing.Size(75, 23);
      this.btnWerpAll.TabIndex = 0;
      this.btnWerpAll.Text = "Werp";
      this.btnWerpAll.UseVisualStyleBackColor = true;
      this.btnWerpAll.Click += new System.EventHandler(this.btnWerpAll_Click);
      // 
      // btnCheat
      // 
      this.btnCheat.Location = new System.Drawing.Point(922, 226);
      this.btnCheat.Name = "btnCheat";
      this.btnCheat.Size = new System.Drawing.Size(75, 23);
      this.btnCheat.TabIndex = 1;
      this.btnCheat.Text = "Cheat";
      this.btnCheat.UseVisualStyleBackColor = true;
      this.btnCheat.Click += new System.EventHandler(this.btnCheat_Click);
      // 
      // FrmYahtzee
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1009, 261);
      this.Controls.Add(this.btnCheat);
      this.Controls.Add(this.btnWerpAll);
      this.Name = "FrmYahtzee";
      this.Text = "Yahtzee";
      this.Load += new System.EventHandler(this.FrmYahtzee_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnWerpAll;
    private System.Windows.Forms.Button btnCheat;

  }
}

