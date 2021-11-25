using CandidateTesting.MarceloCosta.CreditSuisse.Categories.Interfaces;
using CandidateTesting.MarceloCosta.CreditSuisse.Trades.Interfaces;

namespace CandidateTesting.MarceloCosta.CreditSuisse.Categories
{
  public class Expired : ICategory
  {
    public int OrderExecution => 1;
    public string Name => "EXPIRED";
    public bool Active => true;

    public bool EvaluateRisk(ITrade trade)
    {
      return Active && trade.NextPaymentDate.Subtract(trade.ReferenceDate).Days < -30;
    }

  }
}