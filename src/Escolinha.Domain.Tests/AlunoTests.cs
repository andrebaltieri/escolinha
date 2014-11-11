using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Escolinha.Domain.Tests
{
    [TestClass]
    public class Dado_um_novo_aluno
    {
        [TestMethod]
        [TestCategory("Novo Aluno")]
        [ExpectedException(typeof(Exception))]
        public void O_nome_deve_conter_mais_que_tres_caracteres()
        {
            var aluno = new Aluno("12", "andrebaltieri@hotmail.com", "andrebaltieri", "andrebaltieri");
        }

        [TestMethod]
        [TestCategory("Novo Aluno")]
        [ExpectedException(typeof(Exception))]
        public void O_email_deve_ser_valido()
        {
            var aluno = new Aluno("André Baltieri", "andre", "andrebaltieri", "andrebaltieri");
        }

        [TestMethod]
        [TestCategory("Novo Aluno")]
        public void O_usuario_deve_ser_valido() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Novo Aluno")]
        public void A_senha_deve_ser_valida() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Novo Aluno")]
        public void Dada_uma_data_de_nascimento_a_mesma_deve_ser_atribuida() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Novo Aluno")]
        public void Deve_estar_inativo() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Novo Aluno")]
        public void Deve_estar_desmarcada_a_opcao_de_alterar_senha() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Novo Aluno")]
        public void A_lista_de_aulas_deve_ser_inicializada()
        {
            var aluno = new Aluno("André Baltieri", "andrebaltieri@hotmail.com", "andrebaltieri", "1234567");
            Assert.AreNotEqual(aluno.Aulas, null);
        }

        [TestMethod]
        [TestCategory("Novo Aluno")]
        public void O_aluno_deve_ser_instanciado()
        {
            var aluno = new Aluno("André Baltieri", "andrebaltieri@hotmail.com", "andrebaltieri", "1234567");
            Assert.AreNotEqual(null, aluno);
        }
    }

    [TestClass]
    public class Ao_alterar_as_informacoes
    {
        [TestMethod]
        [TestCategory("Ao alterar as informações")]
        public void O_nome_deve_conter_mais_que_tres_caracteres() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Ao alterar as informações")]
        public void O_email_deve_ser_valido() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Ao alterar as informações")]
        public void Dada_uma_data_de_nascimento_a_mesma_deve_ser_atribuida() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Ao alterar as informações")]
        public void O_usuario_deve_estar_ativo() { Assert.Fail(); }
    }

    [TestClass]
    public class Ao_alterar_a_senha
    {
        [TestMethod]
        [TestCategory("Ao alterar a senha")]
        public void A_senha_atual_deve_ser_valida() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Ao alterar a senha")]
        public void A_nova_senha_deve_ser_valida() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Ao alterar a senha")]
        public void A_nova_senha_deve_ser_diferente_da_senha_atual() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Ao alterar a senha")]
        public void As_senhas_devem_coincidir() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Ao alterar a senha")]
        public void O_usuario_deve_estar_ativo() { Assert.Fail(); }
    }

    [TestClass]
    public class Ao_recuperar_a_senha
    {
        [TestMethod]
        [TestCategory("Ao recuperar senha")]
        public void O_usuario_deve_ser_valido() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Ao recuperar senha")]
        public void O_usuario_deve_estar_ativo() { Assert.Fail(); }
    }

    [TestClass]
    public class Ao_se_autenticar
    {
        [TestMethod]
        [TestCategory("Ao autenticar")]
        public void O_usuario_deve_estar_ativo() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Ao autenticar")]
        public void O_usuario_deve_ser_valido() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Ao autenticar")]
        public void A_senha_deve_ser_valida() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Ao autenticar")]
        public void O_usuario_deve_se_autenticar() { Assert.Fail(); }
    }

    [TestClass]
    public class Ao_ativar
    {
        [TestMethod]
        [TestCategory("Ao ativar")]
        public void O_usuario_deve_ser_ativado() { Assert.Fail(); }
    }

    [TestClass]
    public class Ao_inativar
    {
        [TestMethod]
        [TestCategory("Ao inativar")]
        public void O_usuario_deve_ser_inativado() { Assert.Fail(); }
    }

    [TestClass]
    public class Ao_marcar_para_alterar_a_senha
    {
        [TestMethod]
        [TestCategory("Ao marcar para alterar senha")]
        public void O_usuario_deve_estar_ativo() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Ao marcar para alterar senha")]
        public void O_usuario_deve_ser_marcado_para_alterar_a_senha() { Assert.Fail(); }
    }

    [TestClass]
    public class Ao_desmarcar_para_alterar_a_senha
    {
        [TestMethod]
        [TestCategory("Ao desmarcar para alterar senha")]
        public void O_usuario_deve_estar_ativo() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Ao desmarcar para alterar senha")]
        public void O_usuario_deve_ser_desmarcado_para_alterar_a_senha() { Assert.Fail(); }
    }
}
