using System;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using NUnit.Framework;

namespace Sandbox
{ 
    [TestFixture]
    public class DateTimeTests
    {
        [Test]
        public void DateTimeTest()
        {
            var dateTime = new License(new DateTime(2014, 01, 01, 0, 0, 0)); 
            Assert.IsTrue(dateTime.HasExpired);
        }

        [Test]
        public void ConfigurationTest()
        {
            var dataProviderString = ConfigurationManager.AppSettings["provider"];
            var dp = DataProvider.None;
            if (Enum.IsDefined(typeof (DataProvider), dataProviderString))
                dp = (DataProvider) Enum.Parse(typeof (DataProvider), dataProviderString);
            else
                Console.WriteLine("Sorry, no provider exists!");

            var myCn = GetConnection(dp);

            if (myCn != null)
                Console.WriteLine("Your connection is a {0}!", myCn.GetType().Name);
            Console.ReadLine();
        }

        private static IDbConnection GetConnection(DataProvider dp)
        {
            IDbConnection conn = null;
            switch (dp)
            {
                case DataProvider.SqlServer:
                    conn = new SqlConnection();
                    break;
                case DataProvider.OleDb:
                    conn = new OleDbConnection();
                    break;
                case DataProvider.Odbc:
                    conn = new OdbcConnection();
                    break;
            }
            return conn;
        } 
    }
}
