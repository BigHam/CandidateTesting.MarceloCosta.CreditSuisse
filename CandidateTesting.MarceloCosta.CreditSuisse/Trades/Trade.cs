using CandidateTesting.MarceloCosta.CreditSuisse.Trades.Enums;
using CandidateTesting.MarceloCosta.CreditSuisse.Trades.Interfaces;
using System;

namespace CandidateTesting.MarceloCosta.CreditSuisse.Trades
{
  public class Trade : ITrade
  {
    DateTime ITrade.ReferenceDate { get; set; }
    double ITrade.Value { get; set; }
    EnumClienteSector ITrade.ClientSector { get; set; }
    DateTime ITrade.NextPaymentDate { get; set; }
  }
}