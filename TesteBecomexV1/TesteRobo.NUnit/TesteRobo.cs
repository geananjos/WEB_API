using NUnit.Framework;
using TesteBecomexV1.BU;
using TesteBecomexV1.Models;

namespace TesteRobo.NUnit
{
    [TestFixture]
    public class TesteRobo
    {
        #region Pass Tests Braços

        [Test]
        [Category("Teste Braços")]
        public void TesteVericarBracoFortementeContraidoEsquerdo()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            RegrasRobo regrasRobo = new RegrasRobo();

            robo.BracoEsquerdo.Cotovelo.Estado = (byte)EnumsRobo.Estados.FortementeContraido;

            //Act
            bool resultado = regrasRobo.VericarBracoFortementeContraido(robo, (byte)EnumsRobo.LadoBraco.Esquerdo);

            //Assert
            Assert.IsTrue(resultado);
        }

        [Test]
        [Category("Teste Braços")]
        public void TesteVericarBracoFortementeContraidoDireito()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            RegrasRobo regrasRobo = new RegrasRobo();

            robo.BracoDireito.Cotovelo.Estado = (byte)EnumsRobo.Estados.FortementeContraido;

            //Act
            bool resultado = regrasRobo.VericarBracoFortementeContraido(robo, (byte)EnumsRobo.LadoBraco.Direito);

            //Assert
            Assert.IsTrue(resultado);
        }

        [Test]
        [Category("Teste Braços")]
        public void TestePermitirRepousarBracoEsquerdo()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            RegrasRobo regrasRobo = new RegrasRobo();

            robo.BracoEsquerdo.Cotovelo.Estado = (byte)EnumsRobo.Estados.LevementeContraido;

            //Act
            bool resultado = regrasRobo.PermitirRepousarBraco(robo, (byte)EnumsRobo.LadoBraco.Esquerdo);

            //Assert
            Assert.IsTrue(resultado);
        }

        [Test]
        [Category("Teste Braços")]
        public void TestePermitirRepousarBracoDireito()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            RegrasRobo regrasRobo = new RegrasRobo();

            robo.BracoDireito.Cotovelo.Estado = (byte)EnumsRobo.Estados.LevementeContraido;

            //Act
            bool resultado = regrasRobo.PermitirRepousarBraco(robo, (byte)EnumsRobo.LadoBraco.Direito);

            //Assert
            Assert.IsTrue(resultado);
        }

        [Test]
        [Category("Teste Braços")]
        public void TestePermitirContrairLevementeCotoveloEsquerdo()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            RegrasRobo regrasRobo = new RegrasRobo();

            robo.BracoEsquerdo.Cotovelo.Estado = (byte)EnumsRobo.Estados.Contraido;

            //Act
            bool resultado = regrasRobo.PermitirContrairLevementeCotovelo(robo, (byte)EnumsRobo.LadoBraco.Esquerdo);

            //Assert
            Assert.IsTrue(resultado);
        }

        [Test]
        [Category("Teste Braços")]
        public void TestePermitirContrairLevementeCotoveloDireito()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            RegrasRobo regrasRobo = new RegrasRobo();

            robo.BracoEsquerdo.Cotovelo.Estado = (byte)EnumsRobo.Estados.Contraido;

            //Act
            bool resultado = regrasRobo.PermitirContrairLevementeCotovelo(robo, (byte)EnumsRobo.LadoBraco.Direito);

            //Assert
            Assert.IsTrue(resultado);
        }

        [Test]
        [Category("Teste Braços")]
        public void TestePermitirContrairCotoveloEsquerdo()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            RegrasRobo regrasRobo = new RegrasRobo();

            robo.BracoEsquerdo.Cotovelo.Estado = (byte)EnumsRobo.Estados.LevementeContraido;

            //Act
            bool resultado = regrasRobo.PermitirContrairCotovelo(robo, (byte)EnumsRobo.LadoBraco.Esquerdo);

            //Assert
            Assert.IsTrue(resultado);
        }

        [Test]
        [Category("Teste Braços")]
        public void TestePermitirContrairCotoveloDireito()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            RegrasRobo regrasRobo = new RegrasRobo();

            robo.BracoDireito.Cotovelo.Estado = (byte)EnumsRobo.Estados.LevementeContraido;

            //Act
            bool resultado = regrasRobo.PermitirContrairCotovelo(robo, (byte)EnumsRobo.LadoBraco.Direito);

            //Assert
            Assert.IsTrue(resultado);
        }

        [Test]
        [Category("Teste Braços")]
        public void TestePermitirContrairFortementeCotoveloEsquerdo()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            RegrasRobo regrasRobo = new RegrasRobo();

            robo.BracoEsquerdo.Cotovelo.Estado = (byte)EnumsRobo.Estados.Contraido;

            //Act
            bool resultado = regrasRobo.PermitirContrairFortementeCotovelo(robo, (byte)EnumsRobo.LadoBraco.Esquerdo);

            //Assert
            Assert.IsTrue(resultado);
        }

        [Test]
        [Category("Teste Braços")]
        public void TestePermitirContrairFortementeCotoveloDireito()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            RegrasRobo regrasRobo = new RegrasRobo();

            robo.BracoDireito.Cotovelo.Estado = (byte)EnumsRobo.Estados.Contraido;

            //Act
            bool resultado = regrasRobo.PermitirContrairFortementeCotovelo(robo, (byte)EnumsRobo.LadoBraco.Direito);

            //Assert
            Assert.IsTrue(resultado);
        }

        #endregion Pass Tests Braços

        #region Fail Tests Braços

        [Test]
        [Category("Teste Braços")]
        public void TesteFalhaVericarBracoFortementeContraidoEsquerdo()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            RegrasRobo regrasRobo = new RegrasRobo();

            robo.BracoEsquerdo.Cotovelo.Estado = (byte)EnumsRobo.Estados.Contraido;

            //Act
            bool resultado = regrasRobo.VericarBracoFortementeContraido(robo, (byte)EnumsRobo.LadoBraco.Esquerdo);

            //Assert
            Assert.IsFalse(resultado);
        }

        [Test]
        [Category("Teste Braços")]
        public void TesteFalhaVericarBracoFortementeContraidoDireito()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            RegrasRobo regrasRobo = new RegrasRobo();

            robo.BracoDireito.Cotovelo.Estado = (byte)EnumsRobo.Estados.Contraido;

            //Act
            bool resultado = regrasRobo.VericarBracoFortementeContraido(robo, (byte)EnumsRobo.LadoBraco.Direito);

            //Assert
            Assert.IsFalse(resultado);
        }

        [Test]
        [Category("Teste Braços")]
        public void TesteFalhaPermitirRepousarBracoEsquerdo()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            RegrasRobo regrasRobo = new RegrasRobo();

            robo.BracoEsquerdo.Cotovelo.Estado = (byte)EnumsRobo.Estados.Contraido;

            //Act
            bool resultado = regrasRobo.PermitirRepousarBraco(robo, (byte)EnumsRobo.LadoBraco.Esquerdo);

            //Assert
            Assert.IsFalse(resultado);
        }

        [Test]
        [Category("Teste Braços")]
        public void TesteFalhaPermitirRepousarBracoDireito()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            RegrasRobo regrasRobo = new RegrasRobo();

            robo.BracoDireito.Cotovelo.Estado = (byte)EnumsRobo.Estados.Contraido;

            //Act
            bool resultado = regrasRobo.PermitirRepousarBraco(robo, (byte)EnumsRobo.LadoBraco.Direito);

            //Assert
            Assert.IsFalse(resultado);
        }

        [Test]
        [Category("Teste Braços")]
        public void TesteFalhaPermitirContrairLevementeCotoveloEsquerdo()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            RegrasRobo regrasRobo = new RegrasRobo();

            robo.BracoEsquerdo.Cotovelo.Estado = (byte)EnumsRobo.Estados.FortementeContraido;

            //Act
            bool resultado = regrasRobo.PermitirContrairLevementeCotovelo(robo, (byte)EnumsRobo.LadoBraco.Esquerdo);

            //Assert
            Assert.IsFalse(resultado);
        }

        [Test]
        [Category("Teste Braços")]
        public void TesteFalhaPermitirContrairLevementeCotoveloDireito()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            RegrasRobo regrasRobo = new RegrasRobo();

            robo.BracoDireito.Cotovelo.Estado = (byte)EnumsRobo.Estados.FortementeContraido;

            //Act
            bool resultado = regrasRobo.PermitirContrairLevementeCotovelo(robo, (byte)EnumsRobo.LadoBraco.Direito);

            //Assert
            Assert.IsFalse(resultado);
        }

        [Test]
        [Category("Teste Braços")]
        public void TesteFalhaPermitirContrairCotoveloEsquerdo()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            RegrasRobo regrasRobo = new RegrasRobo();

            robo.BracoEsquerdo.Cotovelo.Estado = (byte)EnumsRobo.Estados.Contraido;

            //Act
            bool resultado = regrasRobo.PermitirContrairCotovelo(robo, (byte)EnumsRobo.LadoBraco.Esquerdo);

            //Assert
            Assert.IsFalse(resultado);
        }

        [Test]
        [Category("Teste Braços")]
        public void TesteFalhaPermitirContrairCotoveloDireito()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            RegrasRobo regrasRobo = new RegrasRobo();

            robo.BracoDireito.Cotovelo.Estado = (byte)EnumsRobo.Estados.Contraido;

            //Act
            bool resultado = regrasRobo.PermitirContrairCotovelo(robo, (byte)EnumsRobo.LadoBraco.Direito);

            //Assert
            Assert.IsFalse(resultado);
        }

        [Test]
        [Category("Teste Braços")]
        public void TesteFalhaPermitirContrairFortementeCotoveloEsquerdo()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            RegrasRobo regrasRobo = new RegrasRobo();

            robo.BracoEsquerdo.Cotovelo.Estado = (byte)EnumsRobo.Estados.FortementeContraido;

            //Act
            bool resultado = regrasRobo.PermitirContrairFortementeCotovelo(robo, (byte)EnumsRobo.LadoBraco.Esquerdo);

            //Assert
            Assert.IsFalse(resultado);
        }

        [Test]
        [Category("Teste Braços")]
        public void TesteFalhaPermitirContrairFortementeCotoveloDireito()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            RegrasRobo regrasRobo = new RegrasRobo();

            robo.BracoDireito.Cotovelo.Estado = (byte)EnumsRobo.Estados.FortementeContraido;

            //Act
            bool resultado = regrasRobo.PermitirContrairFortementeCotovelo(robo, (byte)EnumsRobo.LadoBraco.Direito);

            //Assert
            Assert.IsFalse(resultado);
        }

        #endregion Fail Tests Braços

        #region Pass Test Cabeça

        [Test]
        [Category("Teste Cabeça")]
        public void TestePermitirRotacionarCabeca()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            robo.Cabeca.Inclinacao = (byte)EnumsRobo.InclinacaoCabeca.ParaCima;

            RegrasRobo regrasRobo = new RegrasRobo();

            //Act
            bool resultado = regrasRobo.PermitirRotacionarCabeca(robo);

            //Assert
            Assert.IsTrue(resultado);
        }

        #endregion Pass Test Cabeça

        #region Fail Test Cabeça

        [Test]
        [Category("Teste Cabeça")]
        public void TesteFalhaPermitirRotacionarCabeca()
        {
            //Arrange
            Robo robo = new Robo(new CabecaRobo(),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()),
                        new BracoRobo(new CotoveloRobo(), new PulsoRobo()));

            robo.Cabeca.Inclinacao = (byte)EnumsRobo.InclinacaoCabeca.ParaBaixo;

            RegrasRobo regrasRobo = new RegrasRobo();

            //Act
            bool resultado = regrasRobo.PermitirRotacionarCabeca(robo);

            //Assert
            Assert.IsFalse(resultado);
        }

        #endregion Fail Test Cabeça
    }
}