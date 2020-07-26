using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteBecomexV1.Models.Interfaces
{
    public interface IBracoRobo
    {
        public ICotoveloRobo Cotovelo { get; set; }
        public IPulsoRobo Pulso { get; set; }
    }
}
