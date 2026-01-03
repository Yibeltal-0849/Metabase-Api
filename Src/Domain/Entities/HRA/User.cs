
namespace XOKA.Domain.Entities.HRA
{
    public class User
    {
        public string? EnrollNumber { get; set; }
        public string? Name { get; set; }
        public int Privilege { get; set; }
        public bool Enabled { get; set; }
        public int? MachineID { get; set; }
        public string? cEmpId { get; set; }
    }
}
