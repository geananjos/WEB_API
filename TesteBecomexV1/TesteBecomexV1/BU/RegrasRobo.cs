using TesteBecomexV1.Models;
using TesteBecomexV1.Models.Interfaces;

namespace TesteBecomexV1.BU
{
    public class RegrasRobo : IRegrasRobo
    {
        public void InclinarCabeca(IRobo _robo, byte direcaoInclinacao)
        {
            _robo.Cabeca.Inclinacao = 0;
            _robo.Cabeca.Inclinacao = direcaoInclinacao;
        }

        public bool PermitirContrairCotovelo(IRobo _robo, byte ladoBraco)
        {
            var resultado = false;

            byte estadoRobo = 0;
            if (ladoBraco == 1)
                estadoRobo = _robo.BracoEsquerdo.Cotovelo.Estado;

            if (ladoBraco == 2)
                estadoRobo = _robo.BracoDireito.Cotovelo.Estado;

            if ((estadoRobo == (byte)EnumsRobo.Estados.LevementeContraido) || (estadoRobo == (byte)EnumsRobo.Estados.FortementeContraido))
                resultado = true;

            return resultado;
        }

        public bool PermitirContrairFortementeCotovelo(IRobo _robo, byte ladoBraco)
        {
            var resultado = false;

            byte estadoRobo = 0;
            if (ladoBraco == 1)
                estadoRobo = _robo.BracoEsquerdo.Cotovelo.Estado;

            if (ladoBraco == 2)
                estadoRobo = _robo.BracoDireito.Cotovelo.Estado;

            if (estadoRobo == (byte)EnumsRobo.Estados.Contraido)
                resultado = true;

            return resultado;
        }

        public bool PermitirContrairLevementeCotovelo(IRobo _robo, byte ladoBraco)
        {
            var resultado = false;

            byte estadoRobo = 0;
            if (ladoBraco == 1)
                estadoRobo = _robo.BracoEsquerdo.Cotovelo.Estado;

            if (ladoBraco == 2)
                estadoRobo = _robo.BracoDireito.Cotovelo.Estado;

            if ((estadoRobo == (byte)EnumsRobo.Estados.EmRepouso) || (estadoRobo == (byte)EnumsRobo.Estados.Contraido))
                resultado = true;

            return resultado;
        }

        public bool PermitirRepousarBraco(IRobo _robo, byte ladoBraco)
        {
            var resultado = false;
            switch (ladoBraco)
            {
                case 1:
                    {
                        if (_robo.BracoEsquerdo.Cotovelo.Estado == (byte)EnumsRobo.Estados.LevementeContraido)
                            resultado = true;
                        else
                            resultado = false;
                        break;
                    }
                case 2:
                    {
                        if (_robo.BracoDireito.Cotovelo.Estado == (byte)EnumsRobo.Estados.LevementeContraido)
                            resultado = true;
                        else
                            resultado = false;
                        break;
                    }
            }
            return resultado;
        }

        public bool PermitirRotacionarCabeca(IRobo _robo)
        {
            var resultado = false;

            if (!(_robo.Cabeca.Inclinacao == (byte)EnumsRobo.InclinacaoCabeca.ParaBaixo))
                resultado = true;

            return resultado;
        }

        public void RepousarCabecaRobo(IRobo _robo)
        {
            _robo.Cabeca.Estado = (byte)EnumsRobo.EstadoCabeca.EmRepouso;
        }

        public void RotacionarCabecaRobo(IRobo _robo, int grauRotacao)
        {
            _robo.Cabeca.Rotacao = 0;
            _robo.Cabeca.Rotacao = grauRotacao;
        }

        public void RotacionarPulsoRobo(IRobo _robo, int grauRotacao, byte ladoBraco)
        {
            _robo.BracoEsquerdo.Pulso.Rotacao = 0;
            _robo.BracoDireito.Pulso.Rotacao = 0;

            switch (ladoBraco)
            {
                case 1:
                    {
                        _robo.BracoEsquerdo.Pulso.Rotacao = grauRotacao;
                        break;
                    }
                case 2:
                    {
                        _robo.BracoDireito.Pulso.Rotacao = grauRotacao;
                        break;
                    }
            }
        }

        public bool VericarBracoFortementeContraido(IRobo _robo, byte ladoBraco)
        {
            var resultado = false;

            switch (ladoBraco)
            {
                case 1:
                    {
                        if (_robo.BracoEsquerdo.Cotovelo.Estado == (byte)EnumsRobo.Estados.FortementeContraido)
                            resultado = true;
                        break;
                    }
                case 2:
                    {
                        if (_robo.BracoDireito.Cotovelo.Estado == (byte)EnumsRobo.Estados.FortementeContraido)
                            resultado = true;
                        break;
                    }
            }
            return resultado;
        }
    }
}