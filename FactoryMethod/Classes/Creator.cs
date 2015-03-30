
namespace FactoryMethod.Classes
{
    // Creator - define o Factory Method abstrato
    public abstract class Creator
    {
        public abstract Autenticacao CreateInstance();
    }
}
