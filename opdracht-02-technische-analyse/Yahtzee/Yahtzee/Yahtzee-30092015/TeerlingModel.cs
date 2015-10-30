using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_30092015
{
  public class TeerlingModel
  {
    private int aantalOgen;
    private static int aantalWorpen;

    #region Properties

    public int AantalOgen 
    { 
      get { return aantalOgen; }
      
      set { aantalOgen = value; }
    }

    public static int AantalWorpen
    {
      get { return aantalWorpen; }
      set { aantalWorpen = value; }
    }

    #endregion

  }
}
