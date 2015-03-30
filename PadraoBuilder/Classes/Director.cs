
namespace PadraoBuilder.Classes
{
    public class Director
    {
        public void Construct(VeiculoBuilder builder)
        {
            builder.BuildMotor();
            builder.BuildPortas();
            builder.BuildPneus();
        }
    }
}
