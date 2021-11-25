using CandidateTesting.MarceloCosta.CreditSuisse.Services.Base;
using System;
using System.Globalization;
using CandidateTesting.MarceloCosta.CreditSuisse.Trades.Enums;
using CandidateTesting.MarceloCosta.CreditSuisse.Trades.Interfaces;

namespace CandidateTesting.MarceloCosta.CreditSuisse.Services
{
  public class FileInputService<TTrade> : InputBase where TTrade : ITrade, new()
  {
    public override ITrade ParseInput(string line)
    {
      // business rule for loading the input file
      // Just change here to change loading behavior
      var fields = line.Split(" ");
      return new TTrade
      {
        Value = double.Parse(fields[0]),
        ClientSector = (EnumClienteSector)Enum.Parse(typeof(EnumClienteSector), fields[1], true),
        NextPaymentDate = DateTime.ParseExact(fields[2], "MM/dd/yyyy", CultureInfo.InvariantCulture)
      };
    }
  }
}