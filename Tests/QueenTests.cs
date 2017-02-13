using Xunit;
using QueenAttack.Objects;
using System;
using System.Collections.Generic;

namespace QueenAttack
{
  public class QueenAttackTest
  {
    [Fact]
    public void QueenAttackResult_returnTrue_true()
    {
      Queen testResult = new Queen(4,6);
      Assert.Equal(true, testResult.CanAttack(testResult,4,2));
    }
  }
}
