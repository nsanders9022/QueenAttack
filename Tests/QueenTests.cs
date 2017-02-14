using Xunit;
using QueenAttack.Objects;
using System;
using System.Collections.Generic;

namespace QueenAttack
{
  public class QueenAttackTest
  {
    [Fact]
    public void QueenAttackResult_Vertical_true()
    {
      Queen testResult = new Queen(4,6);
      Assert.Equal(true, testResult.CanAttack(testResult,4,2));
    }

    [Fact]
    public void QueenAttackResult_Horizontall_true()
    {
      Queen testResult = new Queen(2,2);
      Assert.Equal(true, testResult.CanAttack(testResult,4,2));
    }

    [Fact]
    public void QueenAttackResult_Diagonal_true()
    {
      Queen testResult = new Queen(5,3);
      Assert.Equal(true, testResult.CanAttack(testResult,4,2));
    }
  }
}
