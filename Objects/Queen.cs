using System.Collections.Generic;
using System;

namespace QueenAttack.Objects
{
  public class Queen
  {
    private int _queenXinput;
    private int _queenYinput;

    public Queen(int queenX, int queenY)
    {
      _queenXinput = queenX;
      _queenYinput = queenY;
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
      int qYCoord = queen.GetQueenYinput();

      //vertical
      if (Xinput == qXCoord)
      {
        return true;
      }

      //horizontal
      else if (Yinput == qYCoord)
      {
          return true;
      }

      else if(Math.Abs(Yinput - qYCoord) == Math.Abs(Xinput - qXCoord))
      {
        return true;
      }

      else
      {
        return  false;
      }

    }
  }
}
