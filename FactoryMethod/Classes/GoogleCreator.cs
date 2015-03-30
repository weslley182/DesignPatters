
namespace FactoryMethod.Classes
{
    // Concrete Creator
    public class GoogleCreator : Creator
    {
        public override Autenticacao CreateInstance()
        {
            return new AutenticacaoGoogle();
        }
    }
}
