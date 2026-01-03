using System;

public class ItemActivityPaymentTerm
{
    public string? PurchaseOrderNum { get; set; }    // Inventory.Item_Activity.Purchase_Order_Num (nvarchar 800, nullable)
    public Guid? PaymentTermID { get; set; }         // dbo.Contract_PaymentTerm.Payment_TermID (uniqueidentifier, non-nullable)
    public string? Parent { get; set; }              // dbo.Contract_PaymentTerm.Parent (nvarchar 100, nullable)
    public string? PaymentTerm { get; set; }         // dbo.Contract_PaymentTerm.Payment_Term (nvarchar 100, non-nullable)
    public Guid? LkDetailCode { get; set; }          // dbo.lkdetail.lkdetail_code (uniqueidentifier, non-nullable)
    public string? EnglishDescription { get; set; }  // dbo.lkdetail.english_description (nvarchar 100, nullable)
    public string? Declaration { get; set; }         // dbo.Contract_PaymentTerm.Declaration (nvarchar 1000, nullable)
    public bool? IsApproved { get; set; }            // dbo.Contract_PaymentTerm.Is_Approved (bit, nullable)
    public string? ContractID { get; set; }          // dbo.Contract_PaymentTerm.ContractID (nvarchar 600, nullable)
    public double? Percent { get; set; }             // dbo.Contract_PaymentTerm.[Percent] (float, non-nullable)
    public double? TotalPercent { get; set; }        // dbo.Contract_PaymentTerm.Total_Percent (float, non-nullable)
    public string? Description { get; set; }         // dbo.Contract_PaymentTerm.Description (nchar 1000, nullable)
    public bool? IsPurchased { get; set; }           // dbo.Contract_PaymentTerm.is_Purchased (bit, nullable)
    public string? VocherNo { get; set; }            // MAX(Inventory.Item_Activity.Vocher_NO) (nvarchar 400, nullable)
    public string? payment_term { get; set; }
}
