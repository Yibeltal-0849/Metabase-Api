namespace XOKA.Domain.Entities.view
{
    public class View_viewCustomerlistForPropertyAllocation
    {
      public string? name_am { set; get; }
      public string? name_en                 {set; get;}
      public System.Guid Customer_ID             {set; get;}
      public string? CustomerCode            {set; get;}
      public string? Applicant_First_Name_AM {set; get;}
      public string? Applicant_First_Name_EN {set; get;}
      public string? Applicant_Middle_Name_AM{set; get;}
      public string? Applicant_Middle_Name_En{set; get;}
      public string? Applicant_Last_Name_AM  {set; get;}
      public string? Applicant_Last_Name_EN  {set; get;}
      public string? Applicant_Mother_Name_AM{set; get;}
      public string? Applicant_Mother_Name_EN {set; get;}
      public string? TIN                     {set; get;}
      public string? Gender                  {set; get;}
      public System.Guid? SDP_ID                  {set; get;}
      public int? Wereda_ID               {set; get;}
      public string? Email                   {set; get;}
      public string? Mobile_No               {set; get;}
      public byte[]? Photo                   {set; get;}
      public string? Home_Telephone          {set; get;}
      public string? House_No                {set; get;}
      public string? Address                 {set; get;}
      public string? Kebele                  {set; get;}
      public string? Nationality             {set; get;}
      public string? Residence_Country       {set; get;}
      public string? State_Region            {set; get;}
      public string? City                    {set; get;}
      public string? Passport_ID             {set; get;}
      public bool? Is_Active               {set; get;}
      public bool? Is_Represented          {set; get;}
      public System.Guid? Parent_Customer_ID      {set; get;}
      public bool? Is_them                 {set; get;}
      public int? Customer_Type_ID        {set; get;}
      public bool? Is_Representative       {set; get;}
      public int? Customer_Status         {set; get;}
      public System.Guid?  Created_By              {set; get;}
      public System.Guid? Updated_By              {set; get;}
      public System.Guid? Deleted_By              {set; get;}
      public bool? Is_Deleted              {set; get;}
      public System.DateTime? Created_Date            {set; get;}
      public System.DateTime? Updated_Date            {set; get;}
      public System.DateTime? Deleted_Date            {set; get;}
      public System.DateTime? Date_of_Birth           {set; get;}
      public string? Tenant_Work_Condition   {set; get;}
      public System.Guid? Rent_payment_type_ID    {set; get;}
    }
}
