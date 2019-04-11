using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking.Entity;
using Parking.Data;
namespace Parking.Core
{
    public class UserService
    {
        private DatabaseConnection db;
        public UserService()
        {
            db = new DatabaseConnection();
        }
   
        public void getUser(string vehicleNo,string phoneNo)
        {

        }

        public Floor checkFreeSpace()
        {
            return db.getParkingFloor();
        }

        public List<string> getFloorsBookedSpace(int floorId)
        {
            return db.getBookedSpace(floorId);
        }

        public Boolean bookeParkngSpace(User u,int floorId)
        {
            db.bookeSpaceAndStoreUserData(u,floorId);
            return true;
        }

        public User unbookCarAndUpdateUserData(string vehicleNo,string phoneNo)
        {
            return db.unBookParkingandUpdateUser(vehicleNo, phoneNo);
        }
        public void printReciept(User user)
        {
            Reciept reciept = new Reciept(user);
            reciept.print();
        }

    }
}
