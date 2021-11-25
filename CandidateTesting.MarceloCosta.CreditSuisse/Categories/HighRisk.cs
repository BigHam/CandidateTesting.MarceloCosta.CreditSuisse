using CandidateTesting.MarceloCosta.CreditSuisse.Categories.Interfaces;
using CandidateTesting.MarceloCosta.CreditSuisse.Trades.Enums;
using CandidateTesting.MarceloCosta.CreditSuisse.Trades.Interfaces;

namespace CandidateTesting.MarceloCosta.CreditSuisse.Categories
{
  public class HighRisk : ICategory
  {
    public int OrderExecution => 2;
    public string Name => "HIGHRISK";
    public bool Active => true;

    public bool EvaluateRisk(ITrade trade)
    {
      return Active && trade.Value > 1000000 && trade.ClientSector == EnumClienteSector.Private;
    }
  }
}