namespace Tests;

using System.Text;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Parse_The_StringDate_Parameter_And_Return_The_Year_As_A_String(){
      Printer printer = new Printer();
      Assert.Equal("2022", printer.Print("5/5/2022"));
    }
}