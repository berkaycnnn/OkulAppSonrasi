using DAL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        public bool OgretmenEkle(Ogretmen ogrt)
        {
            SqlParameter[] p = {
                             new SqlParameter("@Ad",ogrt.Ad),
                             new SqlParameter("@Soyad",ogrt.Soyad),
                             new SqlParameter("@TCkimlik",ogrt.TCkimlik)
                         };
            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Insert into tblOgretmenlerr values(@Ad, @Soyad, @TCkimlik)", p) > 0;
        }
    }
}