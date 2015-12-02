﻿using System;
using UamTTA.Model;
using UamTTA.Storage;

namespace UamTTA.Services
{
    public class BudgetService : IBudgetService
    {
        private readonly IBudgetFactory _factory;
        private readonly IRepository<Budget> _budgetRepository;
        private readonly IRepository<BudgetTemplate> _templateRepository;

        public BudgetService(IBudgetFactory factory, IRepository<Budget> budgetRepository, IRepository<BudgetTemplate> templateRepository)
        {
            _factory = factory;
            _budgetRepository = budgetRepository;
            _templateRepository = templateRepository;
        }

        public BudgetTemplate CreateBudgetTemplate(BudgetTemplate template)
        {
            return _templateRepository.Persist(template);
        }

        public BudgetTemplate UpdateBudgetTemplate(BudgetTemplate template)
        {
            return _templateRepository.Persist(template);
        }

        public Budget CreateBudgetFromTemplate(BudgetTemplate template, DateTime startDate)
        {
            Budget newBudget = _factory.CreateBudget(template, startDate);
            _budgetRepository.Persist(newBudget);
            return newBudget;
        }

        public Budget CreateBudgetFromTemplate(int templateId, DateTime startDate)
        {
            var template = _templateRepository.FindById(templateId);
            Budget newBudget = _factory.CreateBudget(template, startDate);
            _budgetRepository.Persist(newBudget);
            return newBudget;
        }

        public Budget GetBudgetById(int budgetId)
        {
            return _budgetRepository.FindById(budgetId);
        }

        public Budget UpdateBudget(Budget budget)
        {
            return _budgetRepository.Persist(budget);
        }
    }
}