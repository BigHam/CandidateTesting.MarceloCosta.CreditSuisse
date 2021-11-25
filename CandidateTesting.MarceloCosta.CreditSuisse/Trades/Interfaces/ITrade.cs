using CandidateTesting.MarceloCosta.CreditSuisse.Trades.Enums;
using System;

namespace CandidateTesting.MarceloCosta.CreditSuisse.Trades.Interfaces
{
  public interface ITrade
  {
    DateTime ReferenceDate { get; internal set; }
    double Value { get; internal set; } //indicates the transaction amount in dollars
    EnumClienteSector ClientSector { get; internal set; } //indicates the client´s sector which can be "Public" or "Private"
    DateTime NextPaymentDate { get; internal set; } //indicates when the next payment from the client to the bank is expected
  }
}