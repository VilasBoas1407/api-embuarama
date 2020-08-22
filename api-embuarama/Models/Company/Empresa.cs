using api_model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api_embuarama.Models.Company
{
    public class Empresa
    {
        DB_EMBUARAMAEntities db = new DB_EMBUARAMAEntities();

        public bool FindCompanyByID(string DS_TOKEN_EMPRESA)
        {
            bool ret = false;
            TB_EMPRESA Company = new TB_EMPRESA();

            try
            {
                Company = db.TB_EMPRESA
                    .Where(C => C.DS_TOKEN_EMPRESA == DS_TOKEN_EMPRESA)
                    .FirstOrDefault();

                if (Company != null)
                    ret = true;

                return ret;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}