namespace XOKA.Domain.Entities.Finance
{
    public class CEmployeePayInfo
    {
        public long id { get; set; }
        public string orgcode { get; set; }
        public string Employee_Id { get; set; }
        public string Pay_Type { get; set; }
        public bool? UseDefault { get; set; }
        public string Pay_Frequency { get; set; }
        public string GL_Account { get; set; }
        public decimal? Salary_Hour_Pay { get; set; }
    }
}
