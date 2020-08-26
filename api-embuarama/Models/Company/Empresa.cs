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

        public TB_EMPRESA FindCompanyByID(string DS_TOKEN_EMPRESA)
        {
            TB_EMPRESA Company = new TB_EMPRESA();

            try
            {
                Company = db.TB_EMPRESA
                    .Where(C => C.DS_TOKEN_EMPRESA == DS_TOKEN_EMPRESA)
                    .FirstOrDefault();

                return Company;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool FindCompanyByEmail(string DS_EMAIL_EMPRESA)
        {
            bool ret = true;
            TB_EMPRESA Company = new TB_EMPRESA();

            try
            {
                Company = db.TB_EMPRESA
                    .Where(C => C.DS_EMAIL_EMPRESA == DS_EMAIL_EMPRESA)
                    .FirstOrDefault();

                if (Company != null)
                    ret = false;

                return ret;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool FindCompanyByCnpj(string NR_CNPJ)
        {
            bool ret = true;
            TB_EMPRESA Company = new TB_EMPRESA();

            try
            {
                Company = db.TB_EMPRESA
                    .Where(C => C.NR_CNPJ == NR_CNPJ)
                    .FirstOrDefault();

                if (Company != null)
                    ret = false;

                return ret;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public TB_EMPRESA Create(TB_EMPRESA Company)
        {
            TB_EMPRESA Empresa = new TB_EMPRESA();

            try
            {
                Empresa =  db.TB_EMPRESA.Add(Company);
                db.SaveChanges();

                return Empresa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}