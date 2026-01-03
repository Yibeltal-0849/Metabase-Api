namespace XOKA.Domain.Entities.view
{
    public class View_NewHouseRentApplication
    {
     public  string? Property_ID               {set; get;}
     public  System.Guid? Customer_Code             {set; get;}
     public System.Guid? Postion                   {set; get;}
     public  string? Orgnization_Name_Eng      {set; get;}
     public  string? Orgnization_Name_Am       {set; get;}
     public  string? description_am            {set; get;}
     public  string? description_en            {set; get;}
     public System.Guid? Application_Date          {set; get;}
     public  int? Priority                  {set; get;}
     public System.Guid Rent_App_ID               {set; get;}
     public  string? Registration_code         {set; get;}
     public System.Guid? organization_code         {set; get;}
     public  string? House_No                  {set; get;}
     public  string? name_en                   {set; get;}
     public  string? name_am                   {set; get;}
     public  string? Description               {set; get;}
     public  double? Building_Size_M2          {set; get;}
     public  double? Parking_Area_M2           {set; get;}
     public  double? Compound_Size_M2          {set; get;}
     public  string? Location_of_Property      {set; get;}
     public  int? Number_of_Lift            {set; get;}
     public decimal? Estimated_Price           {set; get;}
    }
}
