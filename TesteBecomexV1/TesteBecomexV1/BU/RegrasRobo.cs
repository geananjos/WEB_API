using TesteBecomexV1.Models;
using TesteBecomexV1.Models.Interfaces;

namespace TesteBecomexV1.BU
{
    public class RegrasRobo : IRegrasRobo
    {
        /// <summary>
        /// Método responsável por inclinar a cabeça do robo. Esta inclinacao pode ser para cima ou para baixo.
        /// </summary>
        /// <param name="_robo">Objeto robo que receberá o movimento</param>
        /// <param name="direcaoInclinacao">Direção da inclinacao. recebe um número que representa a direção. Ver EnumsRobo</param>
        public void InclinarCabeca(IRobo _robo, byte direcaoInclinacao)
        {
            _robo.Cabeca.Inclinacao = 0;
            _robo.Cabeca.Inclinacao = direcaoInclinacao;
        }

        /// <summary>
        /// Método responsável por verificar se o robo pode realizar movimento de contração do cotovelo
        /// </summary>
        /// <param name="_robo">Ojeto robo que será verificado o estado atual do braço</param>
        /// <param name="ladoBraco">Parâmetro para identificar qual dos braços (esquerdo ou direito) está sendo verificado.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Método responsável por verificar se o robo pode realizar movimento de contração forte do cotovelo
        /// </summary>
        /// <param name="_robo">Ojeto robo que será verificado o estado atual do braço</param>
        /// <param name="ladoBraco">Parâmetro para identificar qual dos braços (esquerdo ou direito) está sendo verificado.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Método responsável por verificar se o robo pode realizar movimento de contração leve do cotovelo
        /// </summary>
        /// <param name="_robo">Ojeto robo que será verificado o estado atual do braço</param>
        /// <param name="ladoBraco">Parâmetro para identificar qual dos braços (esquerdo ou direito) está sendo verificado.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Método responsável por verificar se o robo pode repousar os braços
        /// </summary>
        /// <param name="_robo">Ojeto robo que será verificado o estado atual do braço</param>
        /// <param name="ladoBraco">Parâmetro para identificar qual dos braços (esquerdo ou direito) está sendo verificado.</param>
        /// <returns>Retorno booleano com base na permissão do movimento.</returns>
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

        /// <summary>
        /// Método responsável por verificar se o robo pode realizar movimento de rotação da cabeça.
        /// O movimento só é permitido se a cabeça não estiver inclinada para baixo
        /// </summary>
        /// <param name="_robo">Ojeto robo, utilizado para ver a inclinacao atual de sua cabeça.</param>
        /// <returns>Retorno booleano com base na permissao do movimento</returns>
        public bool PermitirRotacionarCabeca(IRobo _robo)
        {
            var resultado = false;

            //Permitir rotacao se a cabeça não estiver inclinada para baixo.
            if (!(_robo.Cabeca.Inclinacao == (byte)EnumsRobo.InclinacaoCabeca.ParaBaixo))
                resultado = true;

            return resultado;
        }

        /// <summary>
        /// Método responsável por colocar a cabeça do robô em repouso.
        /// </summary>
        /// <param name="_robo"></param>
        public void RepousarCabecaRobo(IRobo _robo)
        {
            _robo.Cabeca.Estado = (byte)EnumsRobo.EstadoCabeca.EmRepouso;
        }

        /// <summary>
        /// Método responsável por realizar rotação da cabeça do robô, com base no grau de rotação designado.
        /// </summary>
        /// <param name="_robo">Objeto robo para configurar o grau de rotação na cabeça</param>
        /// <param name="grauRotacao">Grau de rotação que a cabeça do robô deverá rotacionar</param>
        public void RotacionarCabecaRobo(IRobo _robo, int grauRotacao)
        {
            _robo.Cabeca.Rotacao = 0;
            _robo.Cabeca.Rotacao = grauRotacao;
        }

        /// <summary>
        /// Método responsável por rotacionar os pulsos do robo.
        /// O robô fará o movimento com base no grau de rotação e braço que está fazendo o movimento.
        /// </summary>
        /// <param name="_robo">Objeto robô que irá rotacionar.</param>
        /// <param name="grauRotacao">Valor do grau de rotação que o robô deve rotacionar.</param>
        /// <param name="ladoBraco">Identificador de qual braço está realizando o movimento (esquerdo ou direito)</param>
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

        /// <summary>
        /// Método para verificar se o braço está fortemente contraído. Utilizado para bloquear rotação dos pulsos caso não esteja neste estado.
        /// </summary>
        /// <param name="_robo">Objeto robô utilizado para verificar o estado dos braços.</param>
        /// <param name="ladoBraco">Identificador de qual braço está sendo verficado (esquerdo ou direito).</param>
        /// <returns></returns>
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