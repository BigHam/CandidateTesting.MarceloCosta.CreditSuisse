using CandidateTesting.MarceloCosta.CreditSuisse.Categories.Interfaces;
using CandidateTesting.MarceloCosta.CreditSuisse.Trades.Enums;
using CandidateTesting.MarceloCosta.CreditSuisse.Trades.Interfaces;

namespace CandidateTesting.MarceloCosta.CreditSuisse.Categories
{
  public class MediumRisk  : ICategory
  {
    public int OrderExecution => 3;
    public string Name => "MEDIUMRISK";
    public bool Active => true;

    public bool EvaluateRisk(ITrade trade)
    {
      return Active && trade.Value > 1000000 && trade.ClientSector == EnumClienteSector.Public;
    }
  }
}