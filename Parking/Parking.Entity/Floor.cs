using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Entity
{
    public class Floor
    {
        public int id;
        public int column;
        public int row;
        public int maximum_capasity;
        public int booked_floor;

        public int ID { get { return id; } }
        public int Column { get { return column; } }
        public int Row { get { return row; } }
        public int Capasity { get { return maximum_capasity; } }
        public int Booked { get { return booked_floor; } }

        public Floor(int id,int column,int row)
        {
            this.id= id;
            this.column= column;
            this.row= row;
            this.maximum_capasity = 0;
            this.booked_floor = 0;
        }

    }
}
