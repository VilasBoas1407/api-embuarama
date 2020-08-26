using api_embuarama.Models.Company;
using api_embuarama.Models.User;
using api_embuarama.Utils;
using api_model;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api_embuarama.Controllers.User
{
    public class apiUserController : ApiController
    {
        Services serv = new Services();

        [HttpGet]
        [Route("v1/api/user")]
        public HttpResponseMessage Login(string ds_login, string ds_senha)
        {

            Usuario u = new Usuario();
            TB_USUARIO usuario = new TB_USUARIO();

            try
            {
                if (ModelState.IsValid)
                {

                    ds_senha = serv.CriptografarSenha(ds_senha);
                    usuario = u.Validate(ds_login, ds_senha);
                    if (usuario != null)
                        return Request.CreateResponse(HttpStatusCode.OK, new { valid = true, message = "Bem vindo!", userData = usuario });
                    else
                        return Request.CreateResponse(HttpStatusCode.OK, new { valid = false, message = "Login ou senha inválidos!" });
                }
                return Request.CreateResponse(HttpStatusCode.OK, new { valid = false, message = "Login ou senha inválidos!" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { valid = false, message = "Erro:" + ex });
            }
        }

        [HttpPost]
        [Route("v1/api/user/register")]
        public HttpResponseMessage Register(TB_USUARIO User)
        {

            Usuario u = new Usuario();
            Empresa e = new Empresa();

            TB_EMPRESA Company = new TB_EMPRESA();

            string errorMessage = String.Empty;

            try
            {
                if (ModelState.IsValid)
                {
                    Company = e.FindCompanyByID(User.DS_TOKEN_EMPRESA);
                    bool EmailValido = u.FindUserByEmail(User.DS_EMAIL);
                    bool LoginValido = u.FindUserByLogin(User.DS_LOGIN);

                    if (Company != null && EmailValido && LoginValido)
                    {
                        User.DS_SENHA = serv.CriptografarSenha(User.DS_SENHA);
                        User.ID_EMPRESA = Company.ID_EMPRESA;

                        u.Create(User);
                        return Request.CreateResponse(HttpStatusCode.OK, new { valid = true, message = "Usuário cadastrado com sucesso!" });
                    }
                    else
                    {
                        if (Company == null)
                            errorMessage = "O token empresa digitado não corresponde a nenhuma empresa na nossa base de dados!;";
                        if (!EmailValido)
                            errorMessage += "O e-mail digitado já está cadastrado na nossa base da dados!;";
                        if (!LoginValido)
                            errorMessage += "O login digitado já está cadastrado na nossa base da dados!";

                        return Request.CreateResponse(HttpStatusCode.OK, new { valid = false, message = errorMessage });

                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { valid = false, message = "Ocorreu um ao realizar o seu cadastro! Os seguintes campos são obrigatórios" });
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { valid = true, message = "Erro:" + ex });
            }
        }

        [HttpGet]
        [Route("v1/api/user/recovery")]
        public string RecoveryPassword()
        {
            Mail m = new Mail();
            string from = "";
            string to = "";
            m.EnviarEmail(from, to, "", "", "teste", "body");

            return "OK";
        }
    }
}
