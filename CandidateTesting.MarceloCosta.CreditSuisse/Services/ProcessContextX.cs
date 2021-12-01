using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CandidateTesting.MarceloCosta.CreditSuisse.Categories;
using CandidateTesting.MarceloCosta.CreditSuisse.Categories.Interfaces;
using CandidateTesting.MarceloCosta.CreditSuisse.Services.Base;

namespace CandidateTesting.MarceloCosta.CreditSuisse.Services
{
  public class ProcessContextX : ProcessTradeBase
  {
    public ProcessContextX(InputBase inputBase, OutputBase outputBase) 
      : base(inputBase, outputBase)
    {
    }

    public override List<ICategory> GetCategoryInstances()
    {
      var lista = new List<ICategory>()
      {
        new LowRisk(),
        new HighRisk(),
        new Expired(),
        new MediumRisk()
      };
      return lista;
    }
  }
}