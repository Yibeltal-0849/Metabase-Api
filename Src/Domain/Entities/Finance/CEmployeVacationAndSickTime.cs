namespace XOKA.Domain.Entities.Finance
{
    public class CEmployeVacationAndSickTime
    {
        public long id { get; set; }
        public string Employee_Id { get; set; }
        public bool? UseDefault { get; set; }
        public long? EmplyeeGetHours { get; set; }
        public bool? Receives_at_Begining { get; set; }
        public long? MaxVacationOrSick_Time { get; set; }
    }
}
