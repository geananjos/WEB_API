using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteBecomexV1.Models
{
    public class EnumsRobo
    {
        public enum Estados
        {
            EmRepouso  = 1,
            LevementeContraido = 2,
            Contraido = 3,
            FortementeContraido = 4
        }

        public enum InclinacaoCabeca
        {
            ParaCima = 1,
            EmRepouso = 2,
            ParaBaixo = 3
        }

        public enum EstadoCabeca
        {
            EmRepouso = 1
        }
    }
}
