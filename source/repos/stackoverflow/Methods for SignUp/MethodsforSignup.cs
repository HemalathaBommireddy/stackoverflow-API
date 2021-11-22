using DataBaseConnection;
using DataBaseConnection.Exceptions;
using LoginViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Methods_for_SignUp
{     
    public class SignUpDetails: ISignUpClass
    { 
          private SqlConnection _connection;
             private SqlCommand _command;

        public  SignUpDetails ()
        {
                _connection = new SqlConnection(ConnectionBwDataBaseandAPI.ConnectionString);
        }
        public bool InsertUserDetailsIntoSignUpForm(UserDetailsRegister _UserDetailsRegister)
        {
                   bool isSuccess = false;
               try
               {
                   using (_command = new SqlCommand($"INSERT INTO RegisterTable (UserName,EmailId,Password,ConformPassword) VALUES ('{_UserDetailsRegister.EmailId}','{_UserDetailsRegister.Password}','{_UserDetailsRegister.ConformPassword}',{_UserDetailsRegister.UserName}')", _connection))
                   {
                     
                    if (_connection.State == System.Data.ConnectionState.Closed)
                    _connection.Open();

                       _command.ExecuteNonQuery();

                        isSuccess = true;
                   }
               }
               catch (Exception ex)
               {
                   throw new UserException(ex.Message, ex);
               }
               finally
               {
                  if (_connection.State == System.Data.ConnectionState.Open)
                     _connection.Close();
               }

                  return isSuccess;

           
            
            


        }


         public IEnumerable<UserDetailsRegister> UserLogin( string _EmailId, string _Password, IEnumerable<UserDetailsRegister> _UserDetailsRegister)
         {


                 List<UserDetailsRegister> _UserDetailsRigister = new List<UserDetailsRegister>();

             try
             {
                 using (_command = new SqlCommand("SELECT * FROM RegisterTable where  EmailId='" + _EmailId + "' Password='" + _Password + "'", _connection))
                 {
                     if (_connection.State == System.Data.ConnectionState.Closed)
                    _connection.Open();

                      SqlDataReader reader = _command.ExecuteReader();

                     while (reader?.Read() ?? false)
                    _UserDetailsRigister.Add(new UserDetailsRegister() {  EmailId = reader.GetString(0), Password = reader.GetString(1) });
                 }
             }
             catch (Exception ex)
             {
                  throw new UserExceptions(ex.Message, ex);
             }
             finally
             {
                if (_connection.State == System.Data.ConnectionState.Open)
                _connection.Close();
             }

            
            return _UserDetailsRegister;
         }

        
    }
}
   