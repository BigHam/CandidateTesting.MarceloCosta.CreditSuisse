using System.Threading.Tasks;

namespace CandidateTesting.MarceloCosta.CreditSuisse.Services.Interfaces
{
  public interface IProcessTrades
  {
    Task ExecuteAsync(string pathIn, string pathOut);
  }
}