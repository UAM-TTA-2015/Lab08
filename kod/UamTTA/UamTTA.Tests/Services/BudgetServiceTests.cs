using FakeItEasy;
using NUnit.Framework;
using UamTTA.Model;
using UamTTA.Services;
using UamTTA.Storage;

namespace UamTTA.Tests.Services
{
    [TestFixture]
    public partial class BudgetServiceTests
    {
        [SetUp]
        public void SetUp()
        {
            _budgetFactory = A.Fake<IBudgetFactory>();
            _repository = A.Fake<IRepository<Budget>>();
            _templateRepository = A.Fake<IRepository<BudgetTemplate>>();

            _sut = new BudgetService(_budgetFactory, _repository, _templateRepository);
        }

        private BudgetService _sut;
        private IBudgetFactory _budgetFactory;
        private IRepository<Budget> _repository;
        private IRepository<BudgetTemplate> _templateRepository;
    }
}