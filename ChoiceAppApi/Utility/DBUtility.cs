using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ChoiceAppApi.Model;

namespace ChoiceAppApi.Utility
{
    public class DBUtility
    {
        
        private const string ConnectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PageDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private const string GET_PAGES = "SELECT * FROM PageData";
        

        public static List<PageData> GetPagesFromDatabase()
        {
            List<PageData> PageList = new List<PageData>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(GET_PAGES, conn))
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PageData pageData = NextPageData(reader);
                        PageList.Add(pageData);
                    }
                    reader.Close();
                }

                return PageList;

            }
        }

        protected static PageData NextPageData(SqlDataReader reader)
        {
            //PageData pageData = new PageData(0,"","",false,false,false, new ButtonData[]
            //{
            //    (new ButtonData(0,"",0)), 
            //    (new ButtonData(1, "", 0)),
            //    (new ButtonData(2,"",0))
            //});
            PageData pageData = new PageData();
            pageData.PageID = reader.GetInt32(0);
            pageData.PageTitle = reader.GetString(1);
            pageData.PageDescription = reader.GetString(2);
            pageData.Ending = reader.GetBoolean(3);
            pageData.Result = reader.GetBoolean(4);
            pageData.Victory = reader.GetBoolean(5);
            //pageData.ButtonData = GetButtonData(pageData.PageID);
            return pageData;

        }

        protected static List<ButtonData> GetButtonData(int pageID)
        {
            List<ButtonData> ButtonList = new List<ButtonData>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                
                using (SqlCommand command = new SqlCommand($"SELECT * FROM ButtonData WHERE ButtonData.PageData = {pageID}", conn))
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ButtonData buttonData = NextButtonData(reader);
                        ButtonList.Add(buttonData);
                        
                    }
                    reader.Close();
                }

                return ButtonList;

            }

        }

        protected static ButtonData NextButtonData(SqlDataReader reader)
        {
            ButtonData buttonData = new ButtonData();
            buttonData.ButtonID = reader.GetInt32(1);
            buttonData.ButtonDescription = reader.GetString(2);
            buttonData.ButtonDestinationPage = reader.GetInt32(3);
            return buttonData;

        }

    }
}
