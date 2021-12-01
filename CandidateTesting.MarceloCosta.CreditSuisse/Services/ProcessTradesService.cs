using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CandidateTesting.MarceloCosta.CreditSuisse.Categories.Interfaces;
using CandidateTesting.MarceloCosta.CreditSuisse.Services.Base;

namespace CandidateTesting.MarceloCosta.CreditSuisse.Services
{
  public class ProcessTradesService : ProcessTradeBase
  {
    public ProcessTradesService(InputBase inputBase, OutputBase outputBase) : base(inputBase, outputBase) 
    {
    }

    public override List<ICategory> GetCategoryInstances()
    {
      var instancesCategory = Assembly.GetExecutingAssembly().GetTypes().Where(c =>
          c.GetInterfaces().Contains(typeof(ICategory)) &&
          c.GetConstructor(Type.EmptyTypes) != null)
        .Select(c => Activator.CreateInstance(c) as ICategory)
        .OrderBy(o => o?.OrderExecution);
      return instancesCategory.ToList();
    }
  }
}