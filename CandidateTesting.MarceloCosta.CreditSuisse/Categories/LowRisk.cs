using CandidateTesting.MarceloCosta.CreditSuisse.Categories.Interfaces;
using CandidateTesting.MarceloCosta.CreditSuisse.Trades.Interfaces;

namespace CandidateTesting.MarceloCosta.CreditSuisse.Categories
{
  public class LowRisk : ICategory
  {
    public int OrderExecution => 4;
    public string Name => "LOWRISK";
    public bool Active => true;

    public bool EvaluateRisk(ITrade trade)
    {
      return true;
    }

  }
}