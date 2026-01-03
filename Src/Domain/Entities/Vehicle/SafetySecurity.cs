namespace XOKA.Domain.Entities.Vehicle
{
    public class SafetySecurity
    {
        public System.Guid Safety_SecurityID { get; set; }
        public System.Guid? Vehicle_DispatchID { get; set; }
        public string Location { get; set; }
        public string Reported_By { get; set; }
        public string Location_X { get; set; }
        public string Location_Y { get; set; }
    }
}
