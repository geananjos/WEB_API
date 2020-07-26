namespace TesteBecomexV1.Models.Interfaces
{
    public interface ICabecaRobo
    {
        public int Rotacao { get; set; }
        public byte Inclinacao { get; set; }

        public byte Estado { get; set; }
    }
}