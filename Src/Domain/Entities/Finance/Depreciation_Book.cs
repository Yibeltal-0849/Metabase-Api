using System;

namespace XOKA.Domain.Entities.Finance
{
    public class Depreciation_Book
    {
        public int Year { get; set; }
        public string Fixed_Assets_No { get; set; }
        public Nullable<System.Guid> Method { get; set; }
        public Nullable<System.DateTime> Dep_Start_Date { get; set; }
        public Nullable<System.DateTime> Dep_End_Date { get; set; }
        public Nullable<double> Dep_Per { get; set; }
        public Nullable<double> Dep_Amount { get; set; }
        public Nullable<double> Calculated_Book_Value { get; set; }
        public bool Is_IFRS { get; set; }
        public Nullable<int> Number_Of_Dep_Year { get; set; }
        public Nullable<bool> FA_Post { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public byte[] Update_date { get; set; }
        public Nullable<System.Guid> UpdateBy { get; set; }
        public string Remark { get; set; }
    }
}
