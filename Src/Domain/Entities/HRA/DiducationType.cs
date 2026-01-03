namespace XOKA.Domain.Entities.HRA
{
    public class DiducationType
    {
        public System.Guid? DiductionCode { get; set; }
        public string Name { get; set; }
        public int? Priority { get; set; }
        public bool? IS_Forever { get; set; }
        public bool? Is_Before_Tax { get; set; }
        public string? GL_Account { get; set; }
        public bool? Is_Active { get; set; }
    }
}
