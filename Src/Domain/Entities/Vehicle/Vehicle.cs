namespace XOKA.Domain.Entities.Vehicle
{
    public class _Vehicle
    {
        public System.Guid Vehicle_ID { get; set; }
        public System.Int64? Organization_ID { get; set; }
        public string Plate_No { get; set; }
        public int Horse_Power { get; set; }
        public string CO2 { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string Mile_Stamp { get; set; }
        public string Version { get; set; }
        public string Chassis_Number { get; set; }
        public double Purchase_Value { get; set; }
        public string Fixed_AssetID { get; set; }
        public string Is_Active { get; set; }
        public System.Guid? document_detail_id { get; set; }
    }
}
