using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CandidateTesting.MarceloCosta.CreditSuisse.Helpers
{
  public static class FileHelpers
  {
    public static async Task<List<string>> LoadLinesAsync(string pathFile)
    {
      var lines = await File.ReadAllLinesAsync(pathFile);

      if (!lines.Any())
        throw new ArgumentNullException();

      return lines.ToList();
    }

    public static void SaveToOutputFile(string outPath, string output)
    {
      using var streamWriter = new StreamWriter(outPath);
      streamWriter.Write(output);
    }
  }
}