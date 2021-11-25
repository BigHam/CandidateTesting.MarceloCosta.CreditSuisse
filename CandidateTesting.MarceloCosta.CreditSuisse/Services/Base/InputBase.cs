using CandidateTesting.MarceloCosta.CreditSuisse.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using CandidateTesting.MarceloCosta.CreditSuisse.Trades.Interfaces;

namespace CandidateTesting.MarceloCosta.CreditSuisse.Services.Base
{
  public abstract class InputBase
  {
    public async Task<List<ITrade>> LoadFileAsync(string pathFile) 
    {
      // Load Inputa Data
      var lines = await FileHelpers.LoadLinesAsync(pathFile);

      var referenceDate = DateTime.ParseExact(lines.First(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
      var TradeList = new List<ITrade>();

      foreach (var line in lines.Skip(2))
      {
        var trade = ParseInput(line);
        trade.ReferenceDate = referenceDate; 
        TradeList.Add(trade);
      }

      return TradeList;
    }

    public abstract ITrade ParseInput(string line);
  }
}