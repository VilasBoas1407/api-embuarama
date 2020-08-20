using api_model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api_embuarama.Models.User
{
    public class Usuario
    {
        DB_EMBUARAMAEntities db = new DB_EMBUARAMAEntities();

        public TB_USUARIO Validate(string ds_login, string ds_senha)
        {
            TB_USUARIO Usuario = new TB_USUARIO();
            try
            {
                Usuario = db.TB_USUARIO
                            .Where(x => x.DS_LOGIN == ds_login && x.DS_SENHA == ds_senha)
                            .FirstOrDefault();

                return Usuario;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Create(TB_USUARIO User)
        {
            try
            {
                db.TB_USUARIO.Attach(User);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}