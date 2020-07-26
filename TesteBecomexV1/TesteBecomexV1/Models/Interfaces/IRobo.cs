namespace TesteBecomexV1.Models.Interfaces
{
    public interface IRobo
    {
        public IBracoRobo BracoEsquerdo { get; set; }
        public IBracoRobo BracoDireito { get; set; }
        public ICabecaRobo Cabeca { get; set; }

        //public BracoRobo Braco { get; set; }
        //public CabecaRobo Cabeca { get; set; }

        //void BracoEsquerdoEmRepouso(Robo robo, byte movimento);
        //void BracoEsquerdoEmRepouso(byte movimento);
    }
}