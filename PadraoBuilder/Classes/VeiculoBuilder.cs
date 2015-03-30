﻿
namespace PadraoBuilder.Classes
{
    // Builder (Abstrato)
    public abstract class VeiculoBuilder
    {
        protected Veiculo _veiculo;
        public Veiculo Veiculo
        {
            get { return _veiculo; }
        }
        // processo de construção (abstrato)
        public abstract void BuildMotor();
        public abstract void BuildPortas();
        public abstract void BuildPneus();
    }
}
