using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace quanlyquancafeWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public Service1()
        {
            getConnection();
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlConnectionStringBuilder builder;

        void getConnection()
        {
            
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thang\OneDrive\Desktop\cafe\quanlyquancafe\quanlyquancafe\coffe.mdf;Integrated Security=True");
            cmd = conn.CreateCommand();
        }

        public List<coffee> getInfo()
        {
            try
            {
                List<coffee> list = new List<coffee>();
                cmd.CommandText = "SELECT * FROM tbl_coffe";
                cmd.CommandType = System.Data.CommandType.Text;

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    coffee c = new coffee()
                    {
                        id = Convert.ToInt32(reader["Id"]),
                        name = reader["name"].ToString(),
                        price = Convert.ToDecimal(reader["price"]),
                        tinhTrang = reader["tinhTrang"].ToString(),
                        numberOrder = Convert.ToInt32(reader["numberOrder"])
                    };
                    list.Add(c);
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
           finally
            {
                if (conn!=null)
                {
                    conn.Close();
                }
            }

        }

        public List<coffee> findCoffee(int a)
        {
            List<coffee> list = new List<coffee>();
            
            try
            {
                cmd.CommandText = " SELECT * FROM tbl_coffe WHERE id = @id";
                cmd.Parameters.AddWithValue("id", a);
                cmd.CommandType= System.Data.CommandType.Text;
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    coffee coffees = new coffee()
                    {
                        id = Convert.ToInt32(reader["Id"]),
                        name = reader["name"].ToString(),
                        price = Convert.ToDecimal(reader["price"]),
                        tinhTrang = reader["tinhTrang"].ToString(),
                        numberOrder = Convert.ToInt32(reader["numberOrder"])
                    };
                    list.Add(coffees);
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn!=null)
                {
                    conn.Close();
                }
            }
        }

        public int datMon(coffee c)
        {
            try
            {
                cmd.CommandText = "UPDATE tbl_coffe SET numberOrder = @order WHERE id = @id";
                cmd.Parameters.AddWithValue("id", c.id);
                cmd.Parameters.AddWithValue("order", c.numberOrder+1);
                cmd.CommandType = System.Data.CommandType.Text;
                conn.Open();                
               
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally 
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public List<coffee> Daban()
        {
            List<coffee> list = new List<coffee>();
            try
            {
                cmd.CommandText = " SELECT * FROM tbl_coffe WHERE numberOrder >0";               
                cmd.CommandType = System.Data.CommandType.Text;
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    coffee coffees = new coffee()
                    {
                        id = Convert.ToInt32(reader["Id"]),
                        name = reader["name"].ToString(),
                        price = Convert.ToDecimal(reader["price"]),
                        tinhTrang = reader["tinhTrang"].ToString(),
                        numberOrder = Convert.ToInt32(reader["numberOrder"])
                    };
                    list.Add(coffees);
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public List<coffee> conlai()
        {
            List<coffee> list = new List<coffee>();
            try
            {
                cmd.CommandText = " SELECT * FROM tbl_coffe WHERE numberOrder = 0";
                cmd.CommandType = System.Data.CommandType.Text;
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    coffee coffees = new coffee()
                    {
                        id = Convert.ToInt32(reader["Id"]),
                        name = reader["name"].ToString(),
                        price = Convert.ToDecimal(reader["price"]),
                        tinhTrang = reader["tinhTrang"].ToString(),
                        numberOrder = Convert.ToInt32(reader["numberOrder"])
                    };
                    list.Add(coffees);
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public decimal doanhthu()
        {
            List<coffee> list = new List<coffee>();
            try
            {
                cmd.CommandText = " SELECT * FROM tbl_coffe WHERE numberOrder >0";
                cmd.CommandType = System.Data.CommandType.Text;
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                decimal doanhthu = 0;
                while (reader.Read())
                {
                    coffee coffees = new coffee()
                    {
                       price = Convert.ToDecimal(reader["price"]),
                       
                        numberOrder = Convert.ToInt32(reader["numberOrder"])
                    };
                   doanhthu += coffees.numberOrder*coffees.price;
                }
               return doanhthu;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
