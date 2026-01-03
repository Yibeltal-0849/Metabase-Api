namespace XOKA.Domain.Entities.Finance
{
    public class CItemGeneral
    {
        public string UPCSKU { get; set; }
        public string Item_id { get; set; }
        public bool? Partnumber { get; set; }
        public bool? MultiPacks { get; set; }
        public long? ItemClass { get; set; }
        public string Parent_IPCSKU { get; set; }
    }
}
