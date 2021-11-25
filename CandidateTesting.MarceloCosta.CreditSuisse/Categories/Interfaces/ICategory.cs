using CandidateTesting.MarceloCosta.CreditSuisse.Trades.Interfaces;

namespace CandidateTesting.MarceloCosta.CreditSuisse.Categories.Interfaces
{
  public interface ICategory
  {
    int OrderExecution { get; }
    string Name { get; }
    public bool EvaluateRisk(ITrade trade);
    bool Active { get; }
  }
}