using TesteBecomexV1.Models.Interfaces;

namespace TesteBecomexV1.BU
{
    public interface IRegrasRobo
    {
        bool VericarBracoFortementeContraido(IRobo _robo, byte ladoBraco);

        void RotacionarPulsoRobo(IRobo _robo, int grauRotacao, byte ladoBraco);

        bool PermitirRepousarBraco(IRobo _robo, byte ladoBraco);

        bool PermitirContrairLevementeCotovelo(IRobo _robo, byte ladoBraco);

        bool PermitirContrairCotovelo(IRobo _robo, byte ladoBraco);

        bool PermitirContrairFortementeCotovelo(IRobo _robo, byte ladoBraco);

        void RotacionarCabecaRobo(IRobo _robo, int grauRotacao);

        bool PermitirRotacionarCabeca(IRobo _robo);

        void RepousarCabecaRobo(IRobo _robo);

        void InclinarCabeca(IRobo _robo, byte direcaoInclinacao);
    }
}