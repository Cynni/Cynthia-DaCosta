using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_30092015
{
  public partial class FrmYahtzee : Form
  {
    protected int aantalTeerlingen = 4;
    List<TeerlingController> teerlingen = new List<TeerlingController>();

    public FrmYahtzee()
    {
      InitializeComponent();
    }

    private void FrmYahtzee_Load(object sender, EventArgs e)
    {

      for (int teerlingnummer = 0; teerlingnummer < aantalTeerlingen; teerlingnummer++)
      {
        TeerlingController tijdelijkeTeerlingen = new TeerlingController();
        teerlingen.Add(tijdelijkeTeerlingen);
      }

      //teerlingen tonen
      for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; teerlingNummer++)
      {
        TeerlingView teerlingview = teerlingen[teerlingNummer].GetView();

        //breedte teerlingen ophalen en posititie berekenen (0 * breedte teerling, ... )
        int horizontalPosition = teerlingNummer * teerlingview.Width;
        teerlingview.Location = new System.Drawing.Point(horizontalPosition, 0);

        Controls.Add(teerlingview);
        teerlingen[teerlingNummer].Werp();
        teerlingen[teerlingNummer].UpdateUI();
      }

      #region Comments

      //TeerlingController teerling1 = new TeerlingController();
      //Controls.Add(teerling1.GetView()); //hetzelfde als hieronder > controls.add(new Teerlingview());

      //zelf toegevoegd > view toevoegen aan frm when start (rechtsstreeks)
      //Controls.Add(new TeerlingView());

      #endregion
    }

    private void btnWerpAll_Click(object sender, EventArgs e)
    {
      TeerlingModel.AantalWorpen++;
      //IS VAST OF NIET TOEVOEGEN
      if (TeerlingModel.AantalWorpen < 4)
      {
        for (int i = 0; i < teerlingen.Count; i++)
        {
          if (teerlingen[i].view.CheckColorLabel())
          {
            //return;
            teerlingen[i].UpdateUI();
          }
          else
          {
              teerlingen[i].Werp();
              teerlingen[i].UpdateUI();            
          }
       }
      }
      if(TeerlingModel.AantalWorpen == 3)
      {
        btnWerpAll.Enabled = false;
      }
    }

    private void btnCheat_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < teerlingen.Count; i++)
      {
        teerlingen[i].cheatButtonVisibility();
      }
    }

  }
}
