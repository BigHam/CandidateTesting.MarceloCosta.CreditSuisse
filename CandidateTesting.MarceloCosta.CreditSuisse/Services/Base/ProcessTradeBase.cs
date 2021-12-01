using CandidateTesting.MarceloCosta.CreditSuisse.Categories.Interfaces;
using CandidateTesting.MarceloCosta.CreditSuisse.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using CandidateTesting.MarceloCosta.CreditSuisse.Trades.Interfaces;

namespace CandidateTesting.MarceloCosta.CreditSuisse.Services.Base
{
  public abstract class ProcessTradeBase : IProcessTrades
  {
    private readonly InputBase _inputBase;
    private readonly OutputBase _outputBase;
    private readonly List<ICategory> _categoryInstances;

    protected ProcessTradeBase(InputBase inputBase, OutputBase outputBase)
    {
      _inputBase = inputBase;
      _outputBase = outputBase;
      _categoryInstances = GetCategoryInstances();
    }

    public virtual List<ICategory> GetCategoryInstances()
    {
      var instancesCategory = Assembly.GetExecutingAssembly().GetTypes().Where(c =>
          c.GetInterfaces().Contains(typeof(ICategory)) &&
          c.GetConstructor(Type.EmptyTypes) != null)
        .Select(c => Activator.CreateInstance(c) as ICategory)
        .OrderBy(o => o?.OrderExecution).ToList();
      return instancesCategory;
    }


    private async Task<List<ITrade>> LoadProtifolioAsync(string pathFileInput)
    {
      return await _inputBase.LoadFileAsync(pathFileInput);
    }

    private async Task SaveProtifolioResult(List<string> outputList, string pathFileOutput)
    {
      await _outputBase.SaveFileAsync(outputList, pathFileOutput);
    }

    private string InteractWithCategories(ITrade trade)
    {
      foreach (var categoryInstance in _categoryInstances)
      {
        if (categoryInstance.EvaluateRisk(trade))
        {
          return categoryInstance.Name;
        }
      }
      return "NOTCATEGORIZED";
    }

    private List<string> InteractWithTrades(List<ITrade> portifolio)
    {
      return portifolio.Select(InteractWithCategories).ToList();
    }


    public async Task ExecuteAsync(string pathIn, string pathOut)
    {
      var portifolio = await LoadProtifolioAsync(pathIn);

      var outputList = InteractWithTrades(portifolio);

      await SaveProtifolioResult(outputList, pathOut);
    }
  }
}