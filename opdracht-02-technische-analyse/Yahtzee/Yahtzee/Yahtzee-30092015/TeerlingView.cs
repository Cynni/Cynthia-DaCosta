using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_30092015
{
  public partial class TeerlingView : UserControl
  {
    private TeerlingController controller;
    private int aantalKerenGeworpen = 0;

    public TeerlingView(TeerlingController c)
    {
      InitializeComponent();
      controller = c;
    }

    public void UpdateUI()
    {
      lblTeerling.Text = controller.model.AantalOgen.ToString();
    }

    private void btnWerpTeeriling_Click(object sender, EventArgs e)
    {
      controller.Werp();
      aantalKerenGeworpen++;
      int nieuwAantalOgen = controller.model.AantalOgen;
      lblTeerling.Text = nieuwAantalOgen.ToString();
      if (aantalKerenGeworpen == 1)
      {
        btnWerpTeeriling.Visible = false;
      }   
    }

    private void TeerlingView_Load(object sender, EventArgs e)
    {
      btnWerpTeeriling.Visible = false;
    }

    public void cheatButtonVisibility()
    {
      btnWerpTeeriling.Visible = true;
    }

    public void ColorBackGroundLabel()
    {
      lblTeerling.BackColor = Color.Red; 
    }

    public bool CheckColorLabel()
    {
      if (lblTeerling.BackColor == Color.Red)
      {
        return true;
      }
      else { return false; }
    }

    private void lblTeerling_Click(object sender, EventArgs e)
    {
      ColorBackGroundLabel();
    }
  }

}
