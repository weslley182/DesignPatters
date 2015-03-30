
namespace FactoryMethod.Classes
{
    // Concrete Creator
    public class FacebookCreator : Creator
    {
        public override Autenticacao CreateInstance()
        {
            return new AutenticacaoFacebook();
        }
    }
}
