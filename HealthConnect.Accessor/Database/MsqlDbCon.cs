using HealthConnect.Accessor.healthconnectdb;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

// Required for making use of methods to facilitate MySql operations

namespace HealthConnect.Accessors.Database
{
    class MsqlDbCon
    {
        private MySqlConnection conn;
        private string conString;

        public MsqlDbCon()
        {

             conString = "server=localhost;user id=itsadmin;password=DevPass;persistsecurityinfo=True;database=healthconnectdb";

            conn = new MySqlConnection(conString);
        }

        public bool openConnection()
        {
            try
            {
                conn.Open(); //open the connection

                Console.WriteLine(" Connection Status: " + conn.Ping());
                // Ping() returns true if connection has been successfully established
                return conn.Ping();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close(); //close the connection
            }
        }

        public List<Question> GetQuestionList()
        {
            using (var context = new healthconnectdbContext())
            {
                var questions = context.Question.ToList();
                return questions;
            }
        }
    }  
}