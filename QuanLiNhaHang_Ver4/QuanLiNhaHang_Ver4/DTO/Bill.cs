using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang_Ver4.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];

            var dataCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
                
            this.Status = (int)row["status"];
        }
        private DateTime? dateCheckOutTemp;
        public DateTime? DateCheckOutTemp
        {
            get { return dateCheckOutTemp; }
            set { dateCheckOutTemp = value; }
        }
        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        private DateTime? dateCheckOut;
        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }
        private DateTime? dateCheckIn;
        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
