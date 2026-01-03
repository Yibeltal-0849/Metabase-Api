namespace XOKA.Domain.Entities.HRA
{
    public class proc_Transaction_Proporty_Assignment
    {
        public System.Guid Trasn_Id { get; set; }
        public byte[] Documents { get; set; }
        public System.DateTime? Period { get; set; }
        public System.DateTime? Created_Date { get; set; }
    }
}
