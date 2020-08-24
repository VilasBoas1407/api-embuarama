using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api_embuarama.DTO
{
    public class CompanyRegisterDTO
    {
        public int ID_EMPRESA { get; set; }
        public string DS_NOME_EMPRESA { get; set; }
        public string NR_CNPJ { get; set; }
        public string DS_NOME_RESPONSAVEL { get; set; }
        public string DS_EMAIL_EMPRESA { get; set; }
        public string DS_TOKEN_EMPRESA { get; set; }
        public string DS_LOGIN { get; set; }
        public string DS_SENHA { get; set; }
        public bool FL_EMPRESA { get; set;}
    }
}