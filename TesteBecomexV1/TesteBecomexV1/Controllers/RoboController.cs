using Microsoft.AspNetCore.Mvc;
using System;
using TesteBecomexV1.BU;
using TesteBecomexV1.Models;
using TesteBecomexV1.Models.Interfaces;

namespace TesteBecomexV1.Controllers
{
    [Route("v1/Robo")]
    [ApiController]
    public class RoboController : ControllerBase
    {
        #region Declaração de variáveis

        private readonly IRobo _robo;
        private readonly IRegrasRobo _regraRobo;

        public RoboController(IRobo robo, IRegrasRobo regraRobo)
        {
            _robo = robo;
            _regraRobo = regraRobo;
        }

        #endregion Declaração de variáveis

        #region Braço Esquerdo

        [HttpPost]
        [Route("/RepousarCotoveloEsquerdo")]
        public IActionResult RepousarCotoveloEsquerdo()
        {
            try
            {
                if (_regraRobo.PermitirRepousarBraco(_robo, 1))
                {
                    var movimento = (byte)EnumsRobo.Estados.EmRepouso;
                    _robo.BracoEsquerdo.Cotovelo.Estado = movimento;
                    return Ok("Cotovelo esquerdo em repouso!");
                }
                else
                {
                    return BadRequest("Movimento não permitido!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/ContrairLevementeCotoveloEsquerdo")]
        public IActionResult ContrairLevementeCotoveloEsquerdo()
        {
            try
            {
                if (_regraRobo.PermitirContrairLevementeCotovelo(_robo, 1))
                {
                    var movimento = (byte)EnumsRobo.Estados.LevementeContraido;
                    _robo.BracoEsquerdo.Cotovelo.Estado = movimento;
                    return Ok("Cotovelo esquerdo levemente contraído!");
                }
                else
                {
                    return BadRequest("Movimento não permitido!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/ContrairCotoveloEsquerdo")]
        public IActionResult ContrairCotoveloEsquerdo()
        {
            try
            {
                if (_regraRobo.PermitirContrairCotovelo(_robo, 1))
                {
                    var movimento = (byte)EnumsRobo.Estados.Contraido;
                    _robo.BracoEsquerdo.Cotovelo.Estado = movimento;
                    return Ok("Cotovelo esquerdo contraído!");
                }
                else
                {
                    return BadRequest("Movimento não permitido!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/ContrairFortementeCotoveloEsquerdo")]
        public IActionResult ContrairFortementeCotoveloEsquerdo()
        {
            try
            {
                if (_regraRobo.PermitirContrairFortementeCotovelo(_robo, 1))
                {
                    var movimento = (byte)EnumsRobo.Estados.FortementeContraido;
                    _robo.BracoEsquerdo.Cotovelo.Estado = movimento;
                    return Ok("Cotovelo esquerdo fortemente contraído!");
                }
                else
                {
                    return BadRequest("Movimento não permitido!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/RotacionarPulsoEsquerdo90GrausNegativos")]
        public IActionResult RotacionarPulsoEsquerdo90GrausNegativos()
        {
            try
            {
                if (_regraRobo.VericarBracoFortementeContraido(_robo, 1))
                {
                    _regraRobo.RotacionarPulsoRobo(_robo, -90, 1);
                    return Ok("Pulso rotacionado em -90º!");
                }
                else
                {
                    return BadRequest("Este movimento não pode ser realizado!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/RotacionarPulsoEsquerdo45GrausNegativos")]
        public IActionResult RotacionarPulsoEsquerdo45GrausNegativos()
        {
            try
            {
                if (_regraRobo.VericarBracoFortementeContraido(_robo, 1))
                {
                    _regraRobo.RotacionarPulsoRobo(_robo, -45, 1);
                    return Ok("Pulso rotacionado em -45º!");
                }
                else
                {
                    return BadRequest("Este movimento não pode ser realizado!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/RotacionarPulsoEsquerdo45Graus")]
        public IActionResult RotacionarPulsoEsquerdo45Graus()
        {
            try
            {
                if (_regraRobo.VericarBracoFortementeContraido(_robo, 1))
                {
                    _regraRobo.RotacionarPulsoRobo(_robo, 45, 1);
                    return Ok("Pulso rotacionado em 45º!");
                }
                else
                {
                    return BadRequest("Este movimento não pode ser realizado!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/RotacionarPulsoEsquerdo90Graus")]
        public IActionResult RotacionarPulsoEsquerdo90Graus()
        {
            try
            {
                if (_regraRobo.VericarBracoFortementeContraido(_robo, 1))
                {
                    _regraRobo.RotacionarPulsoRobo(_robo, 90, 1);
                    return Ok("Pulso rotacionado em 90º!");
                }
                else
                {
                    return BadRequest("Este movimento não pode ser realizado!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/RotacionarPulsoEsquerdo135Graus")]
        public IActionResult RotacionarPulsoEsquerdo135Graus()
        {
            try
            {
                if (_regraRobo.VericarBracoFortementeContraido(_robo, 1))
                {
                    _regraRobo.RotacionarPulsoRobo(_robo, 135, 1);
                    return Ok("Pulso rotacionado em 135º!");
                }
                else
                {
                    return BadRequest("Este movimento não pode ser realizado!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/RotacionarPulsoEsquerdo180Graus")]
        public IActionResult RotacionarPulsoEsquerdo180Graus()
        {
            try
            {
                if (_regraRobo.VericarBracoFortementeContraido(_robo, 1))
                {
                    _regraRobo.RotacionarPulsoRobo(_robo, 180, 1);
                    return Ok("Pulso rotacionado em 180º!");
                }
                else
                {
                    return BadRequest("Este movimento não pode ser realizado!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        #endregion Braço Esquerdo

        #region Braço direito

        [HttpPost]
        [Route("/RepousarCotoveloDireito")]
        public IActionResult RepousarCotoveloDireito()
        {
            try
            {
                if (_regraRobo.PermitirRepousarBraco(_robo, 2))
                {
                    var movimento = (byte)EnumsRobo.Estados.EmRepouso;
                    _robo.BracoDireito.Cotovelo.Estado = movimento;
                    return Ok("Cotovelo direito em repouso!");
                }
                else
                {
                    return BadRequest("Movimento não permitido!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/ContrairLevementeCotoveloDireito")]
        public IActionResult ContrairLevementeCotoveloDireito()
        {
            try
            {
                if (_regraRobo.PermitirContrairLevementeCotovelo(_robo, 2))
                {
                    var movimento = (byte)EnumsRobo.Estados.LevementeContraido;
                    _robo.BracoDireito.Cotovelo.Estado = movimento;
                    return Ok("Cotovelo direito levemente contraído!");
                }
                else
                {
                    return BadRequest("Movimento não permitido!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/ContrairCotoveloDireito")]
        public IActionResult ContrairCotoveloDireito()
        {
            try
            {
                if (_regraRobo.PermitirContrairCotovelo(_robo, 2))
                {
                    var movimento = (byte)EnumsRobo.Estados.Contraido;
                    _robo.BracoDireito.Cotovelo.Estado = movimento;
                    return Ok("Cotovelo direito contraído!");
                }
                else
                {
                    return BadRequest("Movimento não permitido!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/ContrairFortementeCotoveloDireito")]
        public IActionResult ContrairFortementeCotoveloDireito()
        {
            try
            {
                if (_regraRobo.PermitirContrairFortementeCotovelo(_robo, 2))
                {
                    var movimento = (byte)EnumsRobo.Estados.FortementeContraido;
                    _robo.BracoDireito.Cotovelo.Estado = movimento;
                    return Ok("Cotovelo direito fortemente contraído!");
                }
                else
                {
                    return BadRequest("Movimento não permitido!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/RotacionarPulsoDireito90GrausNegativos")]
        public IActionResult RotacionarPulsoDireito90GrausNegativos()
        {
            try
            {
                if (_regraRobo.VericarBracoFortementeContraido(_robo, 2))
                {
                    _regraRobo.RotacionarPulsoRobo(_robo, -90, 2);
                    return Ok("Pulso rotacionado em -90º!");
                }
                else
                {
                    return BadRequest("Este movimento não pode ser realizado!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/RotacionarPulsoDireito45GrausNegativos")]
        public IActionResult RotacionarPulsoDireito45GrausNegativos()
        {
            try
            {
                if (_regraRobo.VericarBracoFortementeContraido(_robo, 2))
                {
                    _regraRobo.RotacionarPulsoRobo(_robo, -45, 2);
                    return Ok("Pulso rotacionado em -45º!");
                }
                else
                {
                    return BadRequest("Este movimento não pode ser realizado!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/RotacionarPulsoDireito45Graus")]
        public IActionResult RotacionarPulsoDireito45Graus()
        {
            try
            {
                if (_regraRobo.VericarBracoFortementeContraido(_robo, 2))
                {
                    _regraRobo.RotacionarPulsoRobo(_robo, 45, 2);
                    return Ok("Pulso rotacionado em 45º!");
                }
                else
                {
                    return BadRequest("Este movimento não pode ser realizado!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/RotacionarPulsoDireito90Graus")]
        public IActionResult RotacionarPulsoDireito90Graus()
        {
            try
            {
                if (_regraRobo.VericarBracoFortementeContraido(_robo, 2))
                {
                    _regraRobo.RotacionarPulsoRobo(_robo, 90, 2);
                    return Ok("Pulso rotacionado em 90º!");
                }
                else
                {
                    return BadRequest("Este movimento não pode ser realizado!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/RotacionarPulsoDireito135Graus")]
        public IActionResult RotacionarPulsoDireito135Graus()
        {
            try
            {
                if (_regraRobo.VericarBracoFortementeContraido(_robo, 2))
                {
                    _regraRobo.RotacionarPulsoRobo(_robo, 135, 2);
                    return Ok("Pulso rotacionado em 135º!");
                }
                else
                {
                    return BadRequest("Este movimento não pode ser realizado!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/RotacionarPulsoDireito180Graus")]
        public IActionResult RotacionarPulsoDireito180Graus()
        {
            try
            {
                if (_regraRobo.VericarBracoFortementeContraido(_robo, 2))
                {
                    _regraRobo.RotacionarPulsoRobo(_robo, 180, 2);
                    return Ok("Pulso rotacionado em 180º!");
                }
                else
                {
                    return BadRequest("Este movimento não pode ser realizado!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        #endregion Braço direito

        #region Cabeça

        [HttpPost]
        [Route("/RotacionarCabeca90GrausNegativos")]
        public IActionResult RotacionarCabeca90GrausNegativos()
        {
            try
            {
                if (_regraRobo.PermitirRotacionarCabeca(_robo))
                {
                    _regraRobo.RotacionarCabecaRobo(_robo, -90);
                    return Ok("Cabeça rotacionada em -90º!");
                }
                else
                {
                    return BadRequest("Este movimento não pode ser realizado!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/RotacionarCabeca45GrausNegativos")]
        public IActionResult RotacionarCabeca45GrausNegativos()
        {
            try
            {
                if (_regraRobo.PermitirRotacionarCabeca(_robo))
                {
                    _regraRobo.RotacionarCabecaRobo(_robo, -45);
                    return Ok("Cabeça rotacionada em -45º!");
                }
                else
                {
                    return BadRequest("Este movimento não pode ser realizado!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/RepousarCabecaRobo")]
        public IActionResult RepousarCabecaRobo()
        {
            try
            {
                _regraRobo.RepousarCabecaRobo(_robo);
                return Ok("Cabeça do robo em repouso");
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/RotacionarCabeca45Graus")]
        public IActionResult RotacionarCabeca45Graus()
        {
            try
            {
                if (_regraRobo.PermitirRotacionarCabeca(_robo))
                {
                    _regraRobo.RotacionarCabecaRobo(_robo, 45);
                    return Ok("Cabeça rotacionada em 45º!");
                }
                else
                {
                    return BadRequest("Este movimento não pode ser realizado!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/RotacionarCabeca90Graus")]
        public IActionResult RotacionarCabeca90Graus()
        {
            try
            {
                if (_regraRobo.PermitirRotacionarCabeca(_robo))
                {
                    _regraRobo.RotacionarCabecaRobo(_robo, 90);
                    return Ok("Cabeça rotacionada em 90º!");
                }
                else
                {
                    return BadRequest("Este movimento não pode ser realizado!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/InclinarCabecaRoboParaCima")]
        public IActionResult InclinarCabecaRoboParaCima()
        {
            try
            {
                _regraRobo.InclinarCabeca(_robo, (byte)EnumsRobo.InclinacaoCabeca.ParaCima);
                return Ok("Cabeça inclinada para cima!");
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("/InclinarCabecaRoboParaBaixo")]
        public IActionResult InclinarCabecaRoboParaBaixo()
        {
            try
            {
                _regraRobo.InclinarCabeca(_robo, (byte)EnumsRobo.InclinacaoCabeca.ParaBaixo);
                return Ok("Cabeça inclinada para baixo!");
            }
            catch (Exception ex)
            {
                return BadRequest("Pane no sistema. Erro: " + ex.Message);
            }
        }

        #endregion Cabeça
    }
}