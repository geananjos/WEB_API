using System.Security.Permissions;
using TesteBecomexV1.Models.Interfaces;

namespace TesteBecomexV1.Models
{
    public class CabecaRobo : ICabecaRobo
    {
        public int Rotacao { get; set; }
        public byte Inclinacao { get; set; }
        public byte Estado { get; set; }
    }
}