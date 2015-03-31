namespace Prototype.Classes
{
    // Concrete Prototype
    public class DVD : Item
    {
        // construtor
        public DVD(int id, string descricao, double preco)
            : base(id, descricao, preco)
        {
        }
        // clonar
        public override Item Clone()
        {
            return (Item)this.MemberwiseClone();
        }
    }
}
