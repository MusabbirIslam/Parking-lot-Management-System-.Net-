using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Entity
{
    public class User
    {
        public string name;
        public string phoneNo;
        public string vehicleNo;
        public DateTime arrivalTime;
        public DateTime departingTime;
        public string parkingPlot;
        public int floor;
        public double stayingTIme;
        public double amount;
        public string Name { get { return name; } }
        public string Phone_NO { get { return phoneNo; } }
        public string Vehicle_NO { get { return vehicleNo; } }
        public DateTime Arrival_Time { get { return arrivalTime; } }
        public string Parking_Plot { get { return parkingPlot; } }
        public int Floor_ID { get { return floor; } }
        public DateTime Departing_TIme { get { return departingTime; } }
        public Double Staying_Duration { get { return stayingTIme; } }



        public User(string name, string phoneNo, string vehicleNo, DateTime arrivalTime, string parkingPlot,int floor)
        {
            this.name = name;
            this.phoneNo = phoneNo;
            this.vehicleNo = vehicleNo;
            this.arrivalTime = arrivalTime;
            this.parkingPlot = parkingPlot;
            this.floor = floor;
            this.departingTime = new DateTime() ;
            this.stayingTIme = 0;
            this.amount= 0;
        }

        public TimeSpan getStayinTime()
        {
            return departingTime.Subtract(arrivalTime);
        }
        public string getParkingPlot()
        {
            return parkingPlot;
        }

        public double getAmountToBePaid()
        {
            double mint= getStayinTime().TotalMinutes;
            //per 10 minutes 2 dollar
            double moneyAmount = (mint / 10) * 2;
            return moneyAmount;
        }
    }
}
