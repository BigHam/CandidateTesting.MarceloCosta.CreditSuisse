using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace CandidateTesting.MarceloCosta.CreditSuisse.Services.Base
{
  public abstract class OutputBase
  {
    public async Task SaveFileAsync(List<string> values, string pathFile)
    {
      await File.WriteAllLinesAsync(pathFile, values);
    }
  }
}