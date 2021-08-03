
namespace Dif.Controller
{
    public interface IDiController
    {
        void Register<TContract, TImplementation>() where TContract : class where TImplementation : class;

        void Register<TContract>(object instance) where TContract : class;

        TContract Resolve<TContract>() where TContract : class;
    }
}
