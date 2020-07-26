using TesteBecomexV1.Models.Interfaces;

namespace TesteBecomexV1.Models
{
    public class Robo : IRobo
    {
        public Robo()
        {
        }

        public Robo(ICabecaRobo cabeca, IBracoRobo bracoEsquerdo, IBracoRobo bracoDireito)
        {
            Cabeca = cabeca;
            BracoEsquerdo = bracoEsquerdo;
            BracoDireito = bracoDireito;

            //BracoEsquerdo.Cotovelo.Estado = (byte)EnumsRobo.Estados.EmRepouso;
            //BracoDireito.Cotovelo.Estado = (byte)EnumsRobo.Estados.EmRepouso;
        }

        //public BracoRobo Braco { get; set; }

        //public CabecaRobo Cabeca { get; set; }

        public ICabecaRobo Cabeca { get; set; }
        public IBracoRobo BracoEsquerdo { get; set; }
        public IBracoRobo BracoDireito { get; set; }
    }
}