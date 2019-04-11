using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking.Data;
using Parking.Entity;
namespace Parking.Core
{
    public class AdminService
    {
        private DatabaseConnection db;
        public AdminService()
        {
            db = new DatabaseConnection();
        }

        public void createNewFloor(int row,int column)
        {
            int maximumPlot = (row * column) -row-1;
            db.createNewFloor(row,column, maximumPlot);
        }

        public List<Floor> getFloors()
        {
            return db.getAllFloors();
        }

        public List<User> getFAllUser()
        {
            return db.getAllUser(); 
        }
        public List<User> getCurrentUser()
        {
            return db.getCurrentUser(); 
        }
    }
}
