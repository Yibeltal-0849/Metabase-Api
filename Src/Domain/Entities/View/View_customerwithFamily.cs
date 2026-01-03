using System;

namespace XOKA.Domain.Entities.view
{
    public  class View_customerwithFamily
    {
        public System.Guid Family_ID { get; set; }
        public string Customer_ID { get; set; }
        public Nullable<int> RelationShip { get; set; }
        public Nullable<System.Guid> Member_Customer_ID { get; set; }
        public Nullable<System.Guid> Created_By { get; set; }
        public Nullable<System.Guid> Updated_By { get; set; }
        public Nullable<System.Guid> Deleted_By { get; set; }
        public Nullable<bool> Is_Deleted { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public Nullable<System.DateTime> Updated_Date { get; set; }
        public Nullable<System.DateTime> Deleted_Date { get; set; }
        public string CustomerCode { get; set; }
        public string Applicant_First_Name_AM { get; set; }
        public string Applicant_First_Name_EN { get; set; }
        public string Applicant_Middle_Name_AM { get; set; }
        public string Applicant_Middle_Name_En { get; set; }
        public string Applicant_Last_Name_AM { get; set; }
        public string Applicant_Last_Name_EN { get; set; }
        public string Applicant_Mother_Name_AM { get; set; }
        public string Applicant_Mother_Name_EN { get; set; }
        public string TIN { get; set; }
        public string Gender { get; set; }
        public Nullable<System.Guid> SDP_ID { get; set; }
        public Nullable<int> Wereda_ID { get; set; }
        public string Email { get; set; }
        public string Mobile_No { get; set; }
        public byte[] Photo { get; set; }
        public string Home_Telephone { get; set; }
        public string House_No { get; set; }
        public string Address { get; set; }
        public string Kebele { get; set; }
        public string Residence_Country { get; set; }
        public string Nationality { get; set; }
        public string State_Region { get; set; }
        public string City { get; set; }
        public string Passport_ID { get; set; }
        public bool Is_Active { get; set; }
        public bool Is_Represented { get; set; }
        public Nullable<System.Guid> Parent_Customer_ID { get; set; }
        public bool Is_them { get; set; }
        public Nullable<int> Customer_Type_ID { get; set; }
        public bool Is_Representative { get; set; }
        public Nullable<int> Customer_Status { get; set; }
        public Nullable<System.Guid> Expr1 { get; set; }
        public Nullable<System.Guid> Expr2 { get; set; }
        public Nullable<System.Guid> Expr3 { get; set; }
        public Nullable<bool> Expr4 { get; set; }
        public Nullable<System.DateTime> Expr5 { get; set; }
        public Nullable<System.DateTime> Expr6 { get; set; }
        public Nullable<System.DateTime> Expr7 { get; set; }
        public Nullable<System.DateTime> Date_of_Birth { get; set; }
        public string Tenant_Work_Condition { get; set; }
        public Nullable<System.Guid> Rent_payment_type_ID { get; set; }
    }
}
