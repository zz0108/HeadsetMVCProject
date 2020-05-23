using Dapper;
using Headset.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Headset.Repository
{
    public class Test
    {
        #region 建構式
        public static string connString;
        public SqlConnection conn;
        public Test()
        {
            if (string.IsNullOrEmpty(connString))
            {
                connString = ConfigurationManager.ConnectionStrings["HeadsetModels"].ConnectionString;
            }
            if (conn == null)
            {
                conn = new SqlConnection(connString);
            }
        }
        #endregion

        public List<TestViewModel> getPorduct()
        {
            List<TestViewModel> getTopTravel;
            using (conn = new SqlConnection(connString))
            {
                string sql = @"select p.Product_Id,p.Color1,p.Picture1 from dbo.Product_Table p";
                getTopTravel = conn.Query<TestViewModel>(sql).ToList();
            }
            return getTopTravel;
        }
    }
}