namespace XOKA.Domain.Entities.Finance
{
    public class CTurmsAndCreditVendor
    {
        public long Id { get; set; }
        public string Org_id { get; set; }
        public bool? COD { get; set; }
        public bool? Prepaid { get; set; }
        public bool? DueinNumberofDays { get; set; }
        public bool? DueonDayofnextMonth { get; set; }
        public bool? Dueatendofmonth { get; set; }
        public int? DueontheNextMonth { get; set; }
        public int? NetDueinday { get; set; }
        public int? Discountindays { get; set; }
        public int? DiscountPercent { get; set; }
        public decimal? CreaditLimit { get; set; }
        public long? CreaditStatus { get; set; }
        public string GLSalesAccount { get; set; }
        public string DiscountGLAccount { get; set; }
    }
}
