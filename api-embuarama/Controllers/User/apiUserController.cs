using api_embuarama.Models.User;
using api_embuarama.Utils;
using api_model;
using System;
using System.Collections.Generic;
using System.Linq;
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
                ds_senha = serv.CriptografarSenha(ds_senha);
                usuario = u.Validate(ds_login, ds_senha);
                if(usuario != null)
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { valid = true, message = "Bem vindo!", userData = usuario });
                else
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { valid = true, message = "Login ou senha inválidos!" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { valid = true, message = "Erro:" + ex });
            }
        }

        [HttpPost]
        [Route("v1/api/user")]
        public HttpResponseMessage Register(TB_USUARIO User)
        {

            Usuario u = new Usuario();

            try
            {
                if (ModelState.IsValid)
                {
                    User.DS_SENHA = serv.CriptografarSenha(User.DS_SENHA);
                    u.Create(User);
                    return Request.CreateResponse(HttpStatusCode.OK, new { valid = true, message = "Usuário cadastro com sucesso!" });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { valid = false, message = "Ocorreu um ao realizar o seu cadastro! Os seguintes campos são obrigatórios" });
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { valid = true, message = "Erro:" + ex });
            }
        }
    }
}
