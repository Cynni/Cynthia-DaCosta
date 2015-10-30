using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_30092015
{
  public class TeerlingController
  {
    //view aanspreken > manier module communiceren > niet rechtsstreeks aanspreken zoals in frm code behind

    //Member die de view opvangt
    public TeerlingView view;
    public TeerlingModel model;
    static Random random = new Random();

    #region CTR

   public TeerlingController()
    {
      view = new TeerlingView( this );
      model = new TeerlingModel();
    }

    #endregion

    #region Methods

    public TeerlingView GetView()
    {
      return view;
    }

    public void UpdateUI()
    {
      view.UpdateUI();
    }

    public void cheatButtonVisibility()
    {
      view.cheatButtonVisibility();
    }

    public void ColorBackGroundLabel()
    {
      view.ColorBackGroundLabel();
    
    }

    public void CheckColorLabel()
    {
      view.CheckColorLabel();
    }

    public void Werp()
    {
      //vraagt aan model om aantal ogen te updaten
      //Console.WriteLine("Presenter spreekt controller aan"); //output 
      
      //getal berekenen tussen 1-6
      int aantalOgen = random.Next(1, 7); //1-6

      #region Comment
      //Console.WriteLine(aantalOgen);
      //MessageBox.Show("aantal ogen: " + aantalOgen);
      #endregion

      //Het model updaten
      model.AantalOgen = aantalOgen;
    }

    #endregion

  }
}