using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Jahresprojekt_Eugene
{
    public class sqlclass
    {
        static SqlConnection conn = new SqlConnection("server= (localdb)\\MSSQLLocalDB; Integrated Security = true;");
        static SqlCommand cmd = new SqlCommand("", conn);
        static public string owner;
        static public string NewOwner;
        static public int money, price;
        static Random rng = new Random();
        public static void createDatabase()
        {
            try
            {
                conn.Open();
                cmd.CommandText = "SELECT Count(*) FROM sys.databases WHERE name='cardbase'";
                bool exist = cmd.ExecuteScalar().ToString().Equals("0") ? false : true;
                conn.Close();
                if (!exist)//checks if database exist
                {
                    conn.Open();
                    cmd.CommandText = "CREATE DATABASE cardbase";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    conn.ConnectionString += " database = cardbase;";                   
                    conn.Close();
                    createTable();
                    createCards();
                }
                else
                {
                    conn.ConnectionString += " database = cardbase;"; //set the connection to the right database
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        public static void createTable()
        {
            try
            {
                conn.Open();
                cmd.CommandText = "CREATE TABLE cardtbl(Id INT NOT NULL PRIMARY KEY IDENTITY, Name VARCHAR(50), Rarity VARCHAR(50), quality VARCHAR(50), type VARCHAR(50), price INT NOT NULL, owner INT default NULL)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE TABLE usertbl(Id INT NOT NULL PRIMARY KEY IDENTITY, Username NVARCHAR(100), Password NVARCHAR(100), Money INT default '1000')";
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch(Exception ex) { ex.ToString(); }
        }
        public static void createCards()
        {
            try
            {
                //create fix cards
                #region bronze
                conn.Open();
                cmd.CommandText = "insert into cardtbl(Name, Rarity, quality, type, price, owner) values ('Karte 1', 'Gewöhnlich', 'Sehr schlecht', 'Typ a', '50', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into cardtbl(Name, Rarity, quality, type, price, owner) values ('Karte 2', 'Gewöhnlich', 'Schlecht', 'Typ a', '70', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into cardtbl(Name, Rarity, quality, type, price, owner) values ('Karte 3', 'Gewöhnlich', 'Schlecht', 'Typ a', '100', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into cardtbl(Name, Rarity, quality, type, price, owner) values ('Karte 4', 'Gewöhnlich', 'Sehr gut', 'Typ c', '125', '0');";
                cmd.ExecuteNonQuery();
                #endregion
                #region Iron
                cmd.CommandText = "insert into cardtbl(Name, Rarity, quality, type, price, owner) values ('Karte 5', 'Selten', 'Schlecht', 'Typ a', '200', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into cardtbl(Name, Rarity, quality, type, price, owner) values ('Karte 6', 'Selten', 'Normal', 'Typ b', '300', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into cardtbl(Name, Rarity, quality, type, price, owner) values ('Karte 7', 'Selten', 'Gut', 'Typ b', '500', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into cardtbl(Name, Rarity, quality, type, price, owner) values ('Karte 8', 'Selten', 'Sehr gut', 'Typ c', '600', '0');";
                cmd.ExecuteNonQuery();
                #endregion
                #region Platin
                cmd.CommandText = "insert into cardtbl(Name, Rarity, quality, type, price, owner) values ('Karte 9', 'Episch', 'Gut', 'Typ b', '600', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into cardtbl(Name, Rarity, quality, type, price, owner) values ('Karte 10', 'Legendär', 'Gut', 'Typ c', '1000', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into cardtbl(Name, Rarity, quality, type, price, owner) values ('Karte 11', 'Legendär', 'Sehr gut', 'Typ b', '1200', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into cardtbl(Name, Rarity, quality, type, price, owner) values ('Karte 12', 'Legendär', 'Sehr gut', 'Typ c', '2000', '0');";
                cmd.ExecuteNonQuery();
                #endregion
                #region Diamand
                cmd.CommandText = "insert into cardtbl(Name, Rarity, quality, type, price, owner) values ('Karte 14', 'Legendär', 'Gut', 'Typ c', '1000', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into cardtbl(Name, Rarity, quality, type, price, owner) values ('Karte 15', 'Legendär', 'Sehr gut', 'Typ b', '1200', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into cardtbl(Name, Rarity, quality, type, price, owner) values ('Karte 16', 'Legendär', 'Sehr gut', 'Typ c', '2000', '0');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into cardtbl(Name, Rarity, quality, type, price, owner) values ('Besondere Karte', 'Mystisch', 'Hervorragend', 'Typ c', '12000', '0');";
                cmd.ExecuteNonQuery();
                conn.Close();
                #endregion
            }
            catch (Exception ex) { ex.ToString(); }
        }
        public static void addNewCard(string name, string rarity, string quality, string type, string price)
        {
            conn.Open();
            cmd.CommandText = "INSERT INTO cardtbl VALUES(" + "'" + name + "'" + ", " + "'" + rarity + "'" + ", " + "'" + quality + "'" + ", " + "'" + type + "'" + ", " + price + ", " + 0 + ")"; //create the card like the user whants to
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void showAll(DataTable dt)
        {
            try
            {             
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM cardtbl", conn); //shows all the cards
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch (Exception ex) { ex.ToString(); }
        }
        public static void AddUser(string username, string password)
        {
            string salt = BCrypt.GenerateSalt();
            string hashpassword = BCrypt.HashPassword(password, salt); //hashes the password 

            try
            {
                conn.Close();
                conn.Open();
                cmd.CommandText = "insert into usertbl(Username, Password) values ('" + username + "', '" + hashpassword + "');"; //add a new user
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static bool CheckUser(string username)
        {
            bool userExist = false;
            try
            {
                conn.Close();
                conn.Open();
                cmd.CommandText = "select * from usertbl where Username = '" + username + "';"; //check if the user already exist
                SqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
                if(reader.Equals(null))
                    userExist = false;
                else
                    userExist= true;
                return userExist;

            }catch(Exception ex) 
            { 
                MessageBox.Show(ex.ToString());
                return userExist;
            }
        }
        public static bool getPassword(string username, string password)
        {
            try
            {
                conn.Close();
                conn.Open();
                cmd.CommandText = "select Password from usertbl where Username = '" + username + "';"; //get the right passoword
                if (BCrypt.CheckPassword(password, cmd.ExecuteScalar().ToString()))
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public static void buyCard(string name, string id) 
        {
            try
            {
                conn.Close();
                conn.Open();
                cmd.CommandText = "select id from usertbl where Username = '" + name + "';"; //select id from the user that whants to buy the card
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    owner = reader[0].ToString();
                }
                conn.Close();
                conn.Open();
                cmd.CommandText = "update cardtbl set owner ='"+owner+"' where id = '"+id+"';"; //user get the card to his account
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        public static void checkMoney(string name, string id) //doesnt work 100%(-money) 
        {
            try 
            {
                conn.Close();
                conn.Open();
                cmd.CommandText = "select Money from usertbl where Username = '" + name + "';";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    money = reader.GetInt32(0);
                }
                conn.Close();
                conn.Open();
                cmd.CommandText = "select price from cardtbl where id = '" + id + "';";
                SqlDataReader readerr = cmd.ExecuteReader();
                while (readerr.Read())
                {
                    price = readerr.GetInt32(0);
                }
                conn.Close();
                conn.Open();
                if(money >= price)
                {
                    buyCard(name, id);
                    //cmd.CommandText = "update usertbl set Money=(" + money + "-"+price+") where Username = '" + name + "';"
                    //cmd.CommandText = "update usertbl set Money-= "+price+" where Username = '" + name + "';";
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Nicht genug geld"); 
                }
                conn.Close();
            }
            catch(Exception ex) { ex.ToString(); }
        }
        public static void showInv(DataTable dt, string name)
        {
            try
            {
                conn.Open();
                cmd.CommandText = "select id from usertbl where Username = '" + name + "';";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    owner = reader[0].ToString();
                }
                conn.Close();
                conn.Open();
                //MessageBox.Show(owner); TEST
                cmd.CommandText = "select * from cardtbl where owner = " + owner + ";";
                //cmd.CommandText = "select * from cardtbl where owner = 1;"; TEST
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);    
                conn.Close();
            }
            catch (Exception ex) { ex.ToString(); }
        }
        public static void sellCard(string name, string id)
        {
            try
            {
                conn.Open();
                cmd.CommandText = "update cardtbl set owner = '0' where id = '" + id + "';"; 
                cmd.ExecuteNonQuery();
                conn.Close();
            }catch(Exception ex) { ex.ToString(); } 

        }
        #region Packs
        //packs not with money
        public static void BronzePack(string name) 
        {
            try
            {
                int card = rng.Next(1, 4); //choose a random card
                conn.Close();
                conn.Open();
                cmd.CommandText = "select id from usertbl where Username = '" + name + "';";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    owner = reader[0].ToString();
                }
                conn.Close();
                conn.Open();
                cmd.CommandText = "update cardtbl set owner ='" + owner + "' where id = '" + card + "';";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Du hast Karte " + card + " bekommen!");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }       
        }
        public static void IronPack(string name) 
        {
            try
            {
                int card = rng.Next(5, 8);
                conn.Close();
                conn.Open();
                cmd.CommandText = "select id from usertbl where Username = '" + name + "';";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    owner = reader[0].ToString();
                }
                conn.Close();
                conn.Open();
                cmd.CommandText = "update cardtbl set owner ='" + owner + "' where id = '" + card + "';";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Du hast Karte " + card + " bekommen!");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        public static void PlatinPack(string name) 
        {
            try
            {
                int card = rng.Next(9, 12);
                conn.Close();
                conn.Open();
                cmd.CommandText = "select id from usertbl where Username = '" + name + "';";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    owner = reader[0].ToString();
                }
                conn.Close();
                conn.Open();
                cmd.CommandText = "update cardtbl set owner ='" + owner + "' where id = '" + card + "';";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Du hast Karte " + card + " bekommen!");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        public static void DiamandPack(string name) 
        {
            try
            {
                int card = rng.Next(13, 16);
                conn.Close();
                conn.Open();
                cmd.CommandText = "select id from usertbl where Username = '" + name + "';";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    owner = reader[0].ToString();
                }
                conn.Close();
                conn.Open();
                cmd.CommandText = "update cardtbl set owner ='" + owner + "' where id = '" + card + "';";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Du hast Karte " + card + " bekommen!");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        #endregion
    }
}

