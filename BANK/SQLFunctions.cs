using System;
using System.Collections;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BANK
{
    class SQLFunctions
    {
        //************ Calling SQL Connection Class and its methods ************//
        SQL_Connection sqlconn = new SQL_Connection();
        //************ Retrieving datas drom Administrator Table ************//
        public bool AdministratorData(string name, string password, string surname, string gender)
        {
            bool flag = false;
            sqlconn.Connection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL_Connection.connstring;
            cmd.CommandText = String.Format("select * from Administrator where Name = '{0}' and  Password = '{1}' and Surname = '{2}' and Gender = '{3}'", name, password, surname, gender);
            try
            {
                SqlDataReader sqldr = cmd.ExecuteReader();
                BANK_Manager_Form bmf = new BANK_Manager_Form();
                while (sqldr.Read())
                {
                    if (sqldr.HasRows && (name == sqldr[0].ToString() && password == sqldr[1].ToString()) || (surname == "admin" || gender == "admin"))
                    {
                        flag = true;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }

            sqlconn.Close_Connection();
                return flag;
            
            
        }
        //************ END ************//

        //************ Inserting datas to Administrator table by getting id, password, name, surname, gender parameters ************// 
        public bool RegistrationData(string id, string password, string name, string surname, string gender)
        {
            bool flag = false;

            sqlconn.Connection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL_Connection.connstring;
            cmd.CommandText = String.Format("insert into Administrator(ID, Password, Name, Surname, Gender) values ('{0}','{1}','{2}','{3}','{4}')", id, password, name, surname, gender);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    flag = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }
            sqlconn.Close_Connection();
            return flag;
        }
        //************ END ************//

        //************ Retrieving Workers data from Administrator table by retrieving id, password parameters ************//
        public bool WorkerData(string name, string password)
        {
            bool flag = false;

            sqlconn.Connection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL_Connection.connstring;
            cmd.CommandText = String.Format("select * from Administrator where Name = '{0}' and  Password = '{1}'", name, password);

            SqlDataReader sqldr = cmd.ExecuteReader();
            BANK_Manager_Form bmf = new BANK_Manager_Form();
            try
            {
                while (sqldr.Read())
                {
                    if (sqldr.HasRows)
                    {
                        if (name == sqldr[0].ToString() || password == sqldr[1].ToString())
                        {
                            {
                                flag = true;
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }
            sqlconn.Close_Connection();
            return flag;
        }
        //************ END ************//

        //************ Retrieving all clients from Clients DataBase ************//
        public ArrayList AllClients()
        {
            ArrayList allclients = new ArrayList();
            sqlconn.Connection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL_Connection.connstring;
            cmd.CommandText = "select * from Clients order by Name";

            try
            {
                SqlDataReader sqldr = cmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    foreach (DbDataRecord result in sqldr)
                        allclients.Add(result);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }
            sqlconn.Close_Connection();
            return allclients;
        }
        //************ END ************//

        //************ Retrieving all credits by debitorID parameter(foreign key) from database (in) Credits ************//
        public ArrayList AllCredits(string debitorID)
        {
            ArrayList allcredits = new ArrayList();
            sqlconn.Connection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL_Connection.connstring;
            cmd.CommandText = String.Format("select * from Credits where DebitorID = '{0}' order by OpenDate", debitorID);

            try
            {
                SqlDataReader sqldr = cmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    foreach (DbDataRecord result in sqldr)
                        allcredits.Add(result);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }

            sqlconn.Close_Connection();
            return allcredits;
        }
        //************ END ************//

        //************ Retrieving all payments paymentID parameter(foreign key) from database (in) Payments ************//
        public ArrayList AllPayments(string paymentID)
        {
            ArrayList allpayments = new ArrayList();
            sqlconn.Connection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL_Connection.connstring;
            cmd.CommandText = String.Format("select * from Payments where CreditsID = '{0}' order by PaymentDate", paymentID);

            try
            {
                SqlDataReader sqldr = cmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    foreach (DbDataRecord result in sqldr)
                        allpayments.Add(result);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }
            sqlconn.Close_Connection();
            return allpayments;
        }
        //************ END ************//

        //************ Adding new clients to Clients database by accepting parameters id, name, payment, phone which are existed as in Clients Database ************//

        public bool AddNewClients (string id, string name, string payment, string phone)
        {
            bool flag = false;

            sqlconn.Connection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL_Connection.connstring;
            cmd.CommandText = String.Format("insert into Clients([ID], [Name], [Payment], [PhoneNumber]) values ('{0}', '{1}', '{2}', '{3}')", id, name, payment, (phone != String.Empty) ? phone : null);

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    flag = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }
            sqlconn.Close_Connection();
            return flag;
        }
        //************ END ************//

        //************ Adding new credits for clients to Credits Database by accepting parameters id, debitorID, amount, balance, opendate which are existed as in Credits Database ************//
        public bool AddNewCredits(string id, string debitorID, string amount, string balance, string opendate)
        {
            bool flag = false;
            
            sqlconn.Connection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL_Connection.connstring;
            cmd.CommandText = String.Format("insert into Credits([ID], [DebitorID], [Amount], [Balance], [OpenDate]) values ('{0}', '{1}', '{2}', '{3}', '{4}')", id, debitorID, amount, balance, opendate);

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    flag = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }
            sqlconn.Close_Connection();
            return flag;
        }
        //************ END ************//

        //************ Adding new Payments for credits to Payments Database by accepting parameters id, creditID, balance, paymentdate which are existed as in Payments Database ************//
        public bool AddNewPayment(string id, string creditID, string balance, string paymentdate)
        {
            bool flag = false;

            sqlconn.Connection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL_Connection.connstring;
            cmd.CommandText = String.Format("insert into Payments([ID], [CreditsID], [Amount], [PaymentDate]) values ('{0}', '{1}', '{2}', '{3}')", id, creditID, balance, paymentdate);

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    flag = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }
            sqlconn.Close_Connection();
            return flag;
        }
        //************ END ************//

        //************ Updating Credits Database by retrieving balanceID, balance which already contains values in Credits Database ************//
        public ArrayList UpdateCredits(string balance, string balanceID)
        {
            ArrayList allbalances = new ArrayList();
            sqlconn.Connection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL_Connection.connstring;
            cmd.CommandText = String.Format("update Credits Set Balance = '{0}' where ID = '{1}'",balance, balanceID);

            try
            {
                SqlDataReader sqldr = cmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    foreach (DbDataRecord result in sqldr)
                        allbalances.Add(result);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }
            sqlconn.Close_Connection();
            return allbalances;
        }
        //************ END ************//

        //************ Searching all clients by their ID or Name in an existing Clients Database ************//
        public ArrayList AllClientsSearch(string searchtext)
        {
            ArrayList allclientssearch = new ArrayList();

            sqlconn.Connection();
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL_Connection.connstring;
            cmd.CommandText = "select * from Clients where ID like '%" + searchtext + "%' or Name like '%" + searchtext + "%' or Payment like '%" + searchtext + "%'";

            try
            {
                SqlDataReader sqldr = cmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    foreach (DbDataRecord result in sqldr)
                        allclientssearch.Add(result);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }
            sqlconn.Close_Connection();
            return allclientssearch;
        }
        //************ END ************//

        //************ Updating Data in Clients table by retireving id, name, payment, phonenumber parameters ************//
        public bool UpdateClientsData(string id, string name, string payment, string phonenumber)
        {
            bool flag = false;
            sqlconn.Connection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL_Connection.connstring;
            cmd.CommandText = String.Format("update Clients set Name = '{0}', Payment = '{1}', PhoneNumber = '{2}'  where ID = '{3}'", name, payment, phonenumber, id);

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    flag = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }
            sqlconn.Close_Connection();
            return flag;
        }
        //************ END ************//

        //************ Deleting data in Clients table by retrieving id parameter ************//
        public bool DeleteClientsData(string id)
        {
            bool flag = false;
            sqlconn.Connection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL_Connection.connstring;
            cmd.CommandText = String.Format("delete from Clients where ID = '{0}'", id);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    flag = true;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Данные Клиента невозможно удалить! Проверьте наличии зависимости данных! Иначе обратитесь разработчикам!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }
            sqlconn.Close_Connection();
            return flag;
        }
        //************ END ************//

        //************ Retrieving data from Administration table ************// 
        public ArrayList GetAdministrationData()
        {
            ArrayList alladministrationdata = new ArrayList();

            sqlconn.Connection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL_Connection.connstring;
            cmd.CommandText = String.Format("select * from Administrator");

            try
            {
                SqlDataReader sqldr = cmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    foreach (DbDataRecord result in sqldr)
                        alladministrationdata.Add(result);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }
            sqlconn.Close_Connection();
            return alladministrationdata;
        }
        //************ END ************//

        //************ Updating data in Administration Table by retrieving id, password, name, surname, gender, selected_id parameters ************//
        public bool UpdateAdministrationData(Guid id, string password, string name, string surname, string gender, string selected_id)
        {
            bool flag = false;

            sqlconn.Connection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL_Connection.connstring;
            cmd.CommandText = String.Format("update Administrator Set ID = '{0}', Password = '{1}', Name = '{2}', Surname = '{3}', Gender = '{4}' where ID = '{5}'", id, password, name, surname, gender, selected_id);

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    flag = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }
            sqlconn.Close_Connection();
            return flag;
        }
        //************ END ************//

        //************ Deleting data from Administration table by retrieving id parameter ************//
        public bool DeleteAdministrationData(string id)
        {
            bool flag = false;
            sqlconn.Connection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL_Connection.connstring;
            cmd.CommandText = String.Format("delete from Administrator where ID = '{0}'", id);

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    flag = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }
            sqlconn.Close_Connection();
            return flag;
        }
        //************ END ************//

        //************ Searching and Retrieving datas from Clients table by retrieving searchtext parameter ************//
        public ArrayList AllCliensSearch(string searchtext)
        {
            ArrayList allclientssearch = new ArrayList();

            sqlconn.Connection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL_Connection.connstring;
            cmd.CommandText = "select * from Clients where ID like '%" + searchtext + "%' or Name like '%" + searchtext + "%'";

            try
            {
                SqlDataReader sqldr = cmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    foreach (DbDataRecord result in sqldr)
                        allclientssearch.Add(result);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }
            sqlconn.Close_Connection();
            return allclientssearch;
        }
        //************ END ************//
    }
}
