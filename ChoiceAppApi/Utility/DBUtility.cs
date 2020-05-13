using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ChoiceAppApi.Data;
using ChoiceAppApi.Model;

namespace ChoiceAppApi.Utility
{
    public class DBUtility
    {
        
        private const string ConnectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PageDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        #region GET ALL

        private const string GET_PAGES = "SELECT * FROM PageData";

        public static PageData[] GetPagesFromDatabase()
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

                PageData[] pageArray = PageList.ToArray();

                return pageArray;

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
            pageData.ButtonData = GetButtonData(pageData.PageID);
            return pageData;

        }

        protected static ButtonData[] GetButtonData(int pageID)
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

                ButtonData[] buttonArray = ButtonList.ToArray();

                return buttonArray;

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

        #endregion

        #region PostArray

        public static void PostArrayToDB(PageData[] pageDataArray)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    using (SqlCommand command = conn.CreateCommand())
                    {
                        int x = 7;
                        int y = 8;
                        int z = 9;
                        int t = 10;
                        int r = 11;
                        int e = 12;
                        int iterationNo = 6;

                        foreach (PageData page in pageDataArray)
                        {
                            command.CommandText = "Insert into PageData values (" +
                                                  $"@Para{x}, @Para{y}, @Para{z}, @Para{t}, @Para{r}, @Para{e})";
                            command.Parameters.AddWithValue($"@Para{x}", page.PageID);
                            command.Parameters.AddWithValue($"@Para{y}", page.PageTitle);
                            command.Parameters.AddWithValue($"@Para{z}", page.PageDescription);
                            command.Parameters.AddWithValue($"@Para{t}", page.Ending);
                            command.Parameters.AddWithValue($"@Para{r}", page.Result);
                            command.Parameters.AddWithValue($"@Para{e}", page.Victory);
                            command.ExecuteNonQuery();

                            foreach (ButtonData button in page.ButtonData)
                            {
                                command.CommandText = "Insert into ButtonData values (" +
                                                      $"@Param{x}, @Param{y}, @Param{z}, @Param{t})";
                                command.Parameters.AddWithValue($"@Param{x}", button.ButtonID);
                                command.Parameters.AddWithValue($"@Param{y}", button.ButtonDescription);
                                command.Parameters.AddWithValue($"@Param{z}", button.ButtonDestinationPage);
                                command.Parameters.AddWithValue($"@Param{t}", page.PageID);
                                command.ExecuteNonQuery();

                                x += iterationNo;
                                y += iterationNo;
                                z += iterationNo;
                                t += iterationNo;

                            }

                            r += iterationNo;
                            e += iterationNo;

                        }

                    }
                }
            }
        }


        #endregion

    }
}
