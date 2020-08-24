using api_embuarama.DTO;
using api_embuarama.Models.Company;
using api_embuarama.Models.User;
using api_embuarama.Utils;
using api_model;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api_embuarama.Controllers.Company
{
    public class apiCompanyController : ApiController
    {
        [HttpPost]
        [Route("v1/api/company/register")]
        public HttpResponseMessage Register(CompanyRegisterDTO company)
        {

            Empresa e = new Empresa();
            Usuario u = new Usuario();
            Services s = new Services();

            TB_USUARIO Usuario = new TB_USUARIO();
            TB_EMPRESA Empresa = new TB_EMPRESA();


            bool emailValido = false;
            bool emailValidoLogin = false;
            bool cnpjValido = false;
            bool loginValido = false;

            try
            {
                if (ModelState.IsValid)
                {
                    //Preenchendo dados para criar a empresa

                    Empresa.DS_NOME_RESPONSAVEL = company.DS_NOME_RESPONSAVEL;
                    Empresa.DS_NOME_EMPRESA = company.DS_NOME_EMPRESA;
                    Empresa.DS_EMAIL_EMPRESA = company.DS_EMAIL_EMPRESA;
                    Empresa.NR_CNPJ = company.NR_CNPJ;

                    //Preenchendo dados para criar usuário da empresa
                    Usuario.FL_EMPRESA = company.FL_EMPRESA;
                    Usuario.FL_ADMINISTRADOR = false;
                    Usuario.DS_SENHA = s.CriptografarSenha(company.DS_SENHA);
                    Usuario.DS_NOME = company.DS_NOME_EMPRESA;
                    Usuario.DS_LOGIN = company.DS_LOGIN;
                    Usuario.DS_FUNCAO = "Administrador";
                    Usuario.DS_EMAIL = company.DS_EMAIL_EMPRESA;
                    Usuario.NR_DDD = 31;
                    Usuario.NR_TELEFONE = 998702381;
                   
                    emailValido = e.FindCompanyByEmail(company.DS_EMAIL_EMPRESA);
                    emailValidoLogin = u.FindUserByLogin(Usuario.DS_EMAIL);
                    cnpjValido = e.FindCompanyByCnpj(company.NR_CNPJ);
                    loginValido = u.FindUserByLogin(Usuario.DS_LOGIN);

                    if (emailValido && cnpjValido && emailValidoLogin && loginValido)
                    {
                        Empresa.DS_TOKEN_EMPRESA = s.GerarTokenEmpresa();
                        Empresa = e.Create(Empresa);

                        Usuario.DS_TOKEN_EMPRESA = Empresa.DS_TOKEN_EMPRESA;
                        Usuario.ID_EMPRESA = Empresa.ID_EMPRESA;
                        u.Create(Usuario);

                        return Request.CreateResponse(HttpStatusCode.OK, new { valid = true, empresa = Empresa });
                    }
                    else
                    {
                        string message = String.Empty;

                        if (!emailValido)
                            message = "Já existe uma empresa com esse e-mail cadastrado!";
                        if (!cnpjValido)
                            message += "Já existe uma empresa com esse CNPJ cadastrado!";
                        if (!emailValidoLogin)
                            message += "Já existe um usuário com esse e-mail cadastrado!";
                        if (!loginValido)
                            message += "Já existe uma usuário com esse login cadastrado!";

                        return Request.CreateResponse(HttpStatusCode.OK, new { valid = false, message=message });
                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { valid = true, message = "Campos faltando!" });
                }
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { valid = false, message = "Erro:" + ex });
            }

        }
    }
}