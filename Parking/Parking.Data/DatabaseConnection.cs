using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parking.Entity;
namespace Parking.Data
{
    public class DatabaseConnection
    {
        SqlConnection connector;
        SqlCommand command;
        SqlDataReader reader;
        

        public DatabaseConnection()
        {
            connector = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\study\Parking\Parking.Data\ParkinfDatabase.mdf;Integrated Security=True");
        }

        private Boolean executeQuarry(string quary)
        {
            Boolean result = false;
            try
            {
                command = new SqlCommand(quary, connector);
                connector.Open();
                result= Convert.ToBoolean(command.ExecuteNonQuery());
                connector.Close();
            }
            catch (Exception e) { MessageBox.Show("Error in executeQuarry\n" + quary + e.ToString()); }

            return result;
        }

        public Floor getParkingFloor()
        {
            string quary = "select Top 1 * from ParkingFloors where totalParkingPlot>bookedParkingPlot";
            Floor flr = null;
            try
            {
                connector.Open();
                command = new SqlCommand(quary, connector);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read() == true)
                    {
                        int id = (int)reader["id"];
                        int column = (int)reader["FloorColumn"];
                        int row = (int)reader["FloorRow"];
                        flr = new Floor(id,column,row);
                    }
                }
                connector.Close();
                reader.Close();
            }
            catch (Exception e) { MessageBox.Show("Error in Database getParkingFloor \n" + e.ToString()); }
            return flr;
        }

        public  List<string> getBookedSpace(int floorId)
        {
            string quary = "select  * from BookedSpace where id="+ floorId + "";
            List<string> listOfBookedSpace = new List<string>();
            try
            {
                connector.Open();
                command = new SqlCommand(quary, connector);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read() == true)
                    {
                        string position = (string)reader["position"];
                        listOfBookedSpace.Add(position);
                    }
                }
                connector.Close();
                reader.Close();
            }
            catch (Exception e) { MessageBox.Show("Error in Database getBookedSpace \n" + e.ToString()); }
            return listOfBookedSpace;
        }

        public Boolean bookeSpaceAndStoreUserData(User newUser,int floorId)
        {
            string query = "INSERT INTO BookedSpace (id, position) VALUES(" + floorId + ", '" + newUser.getParkingPlot() + "' ); ";

            string query2 = "INSERT INTO UserTable (name ,phoneNo,vehicleNO,arrivalTime,parkingPlot,floor) VALUES('" + newUser.name
                + "','" +newUser.phoneNo+ "','"+newUser.vehicleNo+"','"+newUser.arrivalTime+"','"+newUser.parkingPlot+"',"+ floorId + " ) ";
            string query3 = "UPDATE ParkingFloors SET bookedParkingPlot = bookedParkingPlot+1 WHERE id=" + floorId + " ;";
            executeQuarry(query3);
            executeQuarry(query);
            return executeQuarry(query2);
        }

        public User unBookParkingandUpdateUser(string vehicleNo, string phoneNo)
        {
            string quary1 = "select * from UserTable where vehicleNO='" + vehicleNo + "' and  phoneNo='" + phoneNo + "' and departingTime IS NULL ;";
            User oldUser=null;
            try
            {
                connector.Open();
                command = new SqlCommand(quary1, connector);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read() == true)
                    {
                        string name = (string)reader["name"];
                        DateTime arrivalTime = (DateTime)reader["arrivalTime"];
                        string parkingPlot = (string)reader["parkingPlot"];
                        int floor=(int)reader["floor"];
                        oldUser = new User(name, phoneNo, vehicleNo, arrivalTime, parkingPlot, floor);
                    }
                }
                connector.Close();
                reader.Close();
            }
            catch (Exception e) { MessageBox.Show("Error in Database unBookParkingandUpdateUser \n" + e.ToString()); }

            if(oldUser!=null)
            {
                oldUser.departingTime = DateTime.Now;
                updateUserDepartingTimeAndCheckIfFLoorFull(oldUser);
            }

            return oldUser;
        }

        private void updateUserDepartingTimeAndCheckIfFLoorFull(User oldUser)
        {
            // quary for setting departing time nad staying time
            string query = "UPDATE UserTable SET departingTIme ='"+DateTime.Now+ "',amount="+ oldUser.getAmountToBePaid()+ " , stayingTIme=" + oldUser.getStayinTime().TotalMinutes+ " WHERE vehicleNO='" + oldUser.vehicleNo + "' and departingTime IS NULL ;"; ;
            executeQuarry(query);

            //decrementing booked parking plot counter
            string query1 = "UPDATE ParkingFloors SET bookedParkingPlot = bookedParkingPlot-1 WHERE id="+oldUser.floor+" ;";
            executeQuarry(query1);

            // deleting parking plot from booked space
            string query2 = "DELETE FROM BookedSpace WHERE id="+oldUser.floor+" and position='"+oldUser.parkingPlot+"' ;";
            executeQuarry(query2);
        }


        public void createNewFloor(int row, int column, int maximumPlace)
        {
            string query = "INSERT INTO ParkingFloors (FloorColumn, FloorRow,totalParkingPlot ) VALUES(" + column + "," + row + ","+maximumPlace+" ); ";
            executeQuarry(query);
        }

        public List<Floor> getAllFloors()
        {
            List<Floor> allFloors=new List<Floor>();
            string quary = "select * from ParkingFloors";
            try
            {
                connector.Open();
                command = new SqlCommand(quary, connector);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read() == true)
                    {
                        int row= (int)reader["FloorRow"];
                        int column = (int)reader["FloorColumn"];
                        int booked = (int)reader["bookedParkingPlot"];
                        int maximum = (int)reader["totalParkingPlot"];
                        int id = (int)reader["Id"];
                        Floor floor = new Floor(id, column, row);
                        floor.maximum_capasity = maximum;
                        floor.booked_floor = booked;
                        allFloors.Add(floor);
                    }
                }
                connector.Close();
                reader.Close();
            }
            catch (Exception e) { MessageBox.Show("Error in Database get Plane \n" + e.ToString()); }
            return allFloors;
        }

        public List<User> getAllUser()
        {
            List<User> allUser = new List<User>();
            string quary = "select * from UserTable where departingTime IS NOT NULL and stayingTIme  IS NOT NULL";
            try
            {
                connector.Open();
                command = new SqlCommand(quary, connector);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read() == true)
                    {
                        string name = (string)reader["name"];
                        string phoneNo = (string)reader["phoneNo"];
                        string vehicleNo = (string)reader["vehicleNo"];
                        DateTime arrivalTime = (DateTime)reader["arrivalTime"];
                        DateTime departingTime = (DateTime)reader["departingTime"];
                        string parkingPlot = (string)reader["parkingPlot"];
                        double stayingTime = (double)reader["stayingTime"];
                        int floor = (int)reader["floor"];

                        User user = new User(name, phoneNo, vehicleNo, arrivalTime, parkingPlot, floor);
                        user.departingTime = departingTime;
                        user.stayingTIme = stayingTime;
                        allUser.Add(user);
                    }
                }
                connector.Close();
                reader.Close();
            }
            catch (Exception e) { MessageBox.Show("Error in Database get Plane \n" + e.ToString()); }
            return allUser;
        }

        public List<User> getCurrentUser()
        {
            List<User> allUser = new List<User>();
            string quary = "select * from UserTable where departingTime IS NULL and stayingTIme  IS NULL";
            try
            {
                connector.Open();
                command = new SqlCommand(quary, connector);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read() == true)
                    {
                        string name = (string)reader["name"];
                        string phoneNo = (string)reader["phoneNo"];
                        string vehicleNo = (string)reader["vehicleNo"];
                        DateTime arrivalTime = (DateTime)reader["arrivalTime"];
                        string parkingPlot = (string)reader["parkingPlot"];
                        int floor = (int)reader["floor"];

                        User user = new User(name, phoneNo, vehicleNo, arrivalTime, parkingPlot, floor);
                        allUser.Add(user);
                    }
                }
                connector.Close();
                reader.Close();
            }
            catch (Exception e) { MessageBox.Show("Error in Database get Plane \n" + e.ToString()); }
            return allUser;
        }
    }

}
