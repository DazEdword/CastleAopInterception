using Castle.Core;
using Castle.MicroKernel;
using Castle.MicroKernel.ModelBuilder;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using NUnit.Framework;
using SimpleCalculator;
using SimpleLogger;
using System.Linq;

namespace AopUnitTests
{
    [TestFixture]
    public class HandleSelectorTests
    {
        [Test]
        public void DemoTests()
        {
            using (var container = new WindsorContainer())
            {
                // Real Calculator registration
                container.Kernel.ComponentModelBuilder.AddContributor(new IContributeToCalculatorFakeConstruction());

                container.Register(Component.For<ILogger>().ImplementedBy<Logger>());
                container.Register(Component.For<ICalculator>().ImplementedBy<Calculator>().Named("Calculator"));

                var actual = container.Resolve<ICalculator>();

                Assert.AreEqual(1000, actual.Add(0, 0));
            }
        }
    }


    public class IContributeToCalculatorFakeConstruction : IContributeComponentModelConstruction
    {
        public void ProcessModel(IKernel kernel, ComponentModel model)
        {
            if (model.Services.Contains(typeof(ICalculator)))
            {
                model.Implementation = typeof(CalculatorFake);
            }
        }
    }

}