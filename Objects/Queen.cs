using System.Collections.Generic;
using System;

namespace QueenAttack.Objects
{
  public class Queen
  {
    private int _queenXinput;
    private int _queenYinput;

    public void Queen(int queenXinput, int queenYinput)
    {
      _queenXinput = queenXinput;
      _queenYinput = queenYinput;
    }

    public int GetQueenXinput()
    {
      return _queenXinput;
    }

    public int GetQueenYinput()
    {
      return _queenYinput;
    }

    public void SetQueenXinput(int queenx)
    {
      _queenXinput = queenx;
    }

    public void SetQueenYinput(int queeny)
    {
      _queenYinput = queeny;
    }

    public bool CanAttack(Queen queen, int Xinput, int Yinput)
    {
      int qXCoord = queen.GetQueenXinput();

      //vertical
      if (Xinput == qXCoord)
      {
        return true;
      }
      return false;
    }
  }
}
