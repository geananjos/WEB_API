using TesteBecomexV1.Models.Interfaces;

namespace TesteBecomexV1.Models
{
    public class BracoRobo : IBracoRobo
    {
        public BracoRobo(ICotoveloRobo cotovelo, IPulsoRobo pulso)
        {
            Cotovelo = cotovelo;
            Pulso = pulso;
        }
        public ICotoveloRobo Cotovelo { get; set; }
        public IPulsoRobo Pulso { get; set; }
    }
}