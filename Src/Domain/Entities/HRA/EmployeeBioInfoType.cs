namespace XOKA.Domain.Entities.HRA
{
    public class EmployeeBioInfoType
    {
        public string Bio_Type_ID { get; set; }
        public string Name { get; set; }
        public string Json_Meta_Data { get; set; }
        public System.Guid? Visable_For_Task { get; set; }
        public bool? IsActive { get; set; }
    }
}
