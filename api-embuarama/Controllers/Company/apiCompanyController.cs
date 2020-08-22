using api_embuarama.Models.Company;
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
        public HttpResponseMessage Register(TB_EMPRESA company)
        {

            Empresa e = new Empresa();
            Services s = new Services();

            bool emailValido = false;
            bool cnpjValido = false;

            try
            {
                if (ModelState.IsValid)
                {
                    emailValido = e.FindCompanyByEmail(company.DS_EMAIL_EMPRESA);
                    cnpjValido = e.FindCompanyByCnpj(company.NR_CNPJ);

                    if (emailValido && cnpjValido)
                    {
                        company.DS_TOKEN_EMPRESA = s.GerarTokenEmpresa();
                        company = e.Create(company);
                        return Request.CreateResponse(HttpStatusCode.OK, new { valid = true, empresa = company });
                    }
                    else
                    {
                        string message = String.Empty;

                        if (!emailValido)
                            message = "Já existe uma empresa com esse e-mail cadastrado!";
                        if (!cnpjValido)
                            message += "Já existe uma empresa com esse CNPJ cadastrado!";

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