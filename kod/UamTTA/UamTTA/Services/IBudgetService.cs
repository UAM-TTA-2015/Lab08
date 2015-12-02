using System;
using UamTTA.Model;

namespace UamTTA.Services
{
    public interface IBudgetService
    {
        BudgetTemplate CreateBudgetTemplate(BudgetTemplate template);

        Budget CreateBudgetFromTemplate(BudgetTemplate template, DateTime startDate);

        Budget CreateBudgetFromTemplate(int templateId, DateTime startDate);

        Budget GetBudgetById(int budgetId);

        Budget UpdateBudget(Budget budget);
    }
}