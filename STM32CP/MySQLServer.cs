using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace STM32CP
{
    public class MySQLServer
    {
        public MySQLServer()
        {
        }
        public static List<Arcticle> article = new List<Arcticle> { };

        public static string server = "Server=m4xwe11o.ddns.net;" +
                    "Database=STM32KBtestDB;" +
                    "Port=3306;" +
                    "User ID=stm32kb;" +
                    "Password=;";

        protected internal static void GetArticles(){
            try{
                new I18N.West.CP1250();

                MySqlConnection sqlconn = new MySqlConnection(server);
                sqlconn.Open();

                DataSet articles = new DataSet();
                string queryString = "SELECT * FROM Arcticles";

                Console.WriteLine("Sending query");
                MySqlDataAdapter adapter = new MySqlDataAdapter(queryString, sqlconn);
                adapter.Fill(articles, "Articles");
                Console.WriteLine("Result received");
                if(article.Count == 0){
                    Console.WriteLine("ADDING article");
                    foreach (DataRow row in articles.Tables["Articles"].Rows){
                        Console.WriteLine("ID " + row[0].ToString() + " " + "Title " + row[1].ToString() + " " + "Description " + row[2].ToString());
                        article.Add(new Arcticle(row[1].ToString(), row[2].ToString(), row[3].ToString()));
                    }
                }else{
                    Console.WriteLine("NO NEW articles");
                }
                Console.WriteLine(article.Count.ToString());
                sqlconn.Close();
            }
            catch (Exception ex){
                Console.WriteLine("ERROR");
                Console.WriteLine(ex.Message);
            }
        }

        protected internal static void GetUser(string username)
        {
            try
            {
                new I18N.West.CP1250();

                MySqlConnection sqlconn = new MySqlConnection(server);
                sqlconn.Open();

                DataSet user = new DataSet();
                string queryString = "SELECT * FROM Arcticles where username like "+ username;

                Console.WriteLine("Sending query");
                MySqlDataAdapter adapter = new MySqlDataAdapter(queryString, sqlconn);
                Console.WriteLine("Result received");

                Console.WriteLine("ADDING article");
                foreach (DataRow row in user.Tables["Articles"].Rows)
                {
                    if (row[1].ToString() == username)
                    {
                        Console.WriteLine("USER FOUND");
                    }
                    else
                    {
                        Console.WriteLine("USER NOT FOUND");
                    }
                }
                Console.WriteLine(article.Count.ToString());

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(ex.Message);
            }
        }

        protected internal static void SetRegistration(string firstname, string lastname, string city, string street, string email, string password)
        {
            try
            {
                new I18N.West.CP1250();

                MySqlConnection sqlconn = new MySqlConnection(server);
                sqlconn.Open();

                DataSet user = new DataSet();
                string queryString = "";

                Console.WriteLine("Sending query");
                MySqlDataAdapter adapter = new MySqlDataAdapter(queryString, sqlconn);
                Console.WriteLine("Result received");

                //Implement Code

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
