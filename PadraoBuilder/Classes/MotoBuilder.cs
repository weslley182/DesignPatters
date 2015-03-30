﻿
namespace PadraoBuilder.Classes
{
    // Concrete Builder
    public class MotoBuilder : VeiculoBuilder
    {
        public MotoBuilder()
        {
            _veiculo = new Veiculo("Motocicleta");
        }
        public override void BuildMotor()
        {
            _veiculo["motor"] = "50c";
        }
        public override void BuildPortas()
        {
            _veiculo["portas"] = "0";
        }
        public override void BuildPneus()
        {
            _veiculo["pneus"] = "2";
        }
    }
}
