using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Application.Common.Interfaces;
using Common;
using Domain.Common;
using XOKA.Domain.Entities.view;
using XOKA.Domain.Entities.HRA;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
using XOKA.Domain.Entities.Finance;

namespace Persistence
{
    public class XOKADbContext : DbContext, IXOKADbContext
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;
        private IConfiguration Configuration;

        public XOKADbContext(DbContextOptions<XOKADbContext> options)
            : base(options)
        {
        }

        public XOKADbContext(
            DbContextOptions<XOKADbContext> options,
            ICurrentUserService currentUserService, IConfiguration _configuration,
            IDateTime dateTime)
            : base(options)
        {
            _currentUserService = currentUserService;
            _dateTime = dateTime;
            Configuration = _configuration;
        }

        #region Finance

        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll 
        //public virtual DbSet<Proc_Account_ProposeLoadByPrimaryKey> Proc_Account_ProposeLoadByPrimaryKey 
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll 
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll 
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll 
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll 
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll 
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll 
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll 
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll 
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll 
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll 
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll 
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll 
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll 
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll 
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll 
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll 
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll 
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll 

        #endregion

        // view
        public DbSet<View_for_GRR_item> View_for_GRR_item { get; set; }
        public DbSet<Purchase_Order_Voucher_ID_View> Purchase_Order_Voucher_ID_View { get; set; }
        public DbSet<ItemActivityPaymentTerm> ItemActivityPaymentTerm { get; set; }
        public DbSet<View_for_pur_new> View_for_pur_new { get; set; }
        public DbSet<View_fixed_dropdwn> View_fixed_dropdwn { get; set; }
        public DbSet<View_customerwithFamily> View_customerwithFamily { get; set; }
        public DbSet<View_bid_detail_Api> View_bid_detail_Api { get; set; }
        public DbSet<View_Training_Application_Fill_form> View_Training_Application_Fill_form { get; set; }
        public DbSet<View_Training_Applications> View_Training_Applications { get; set; }
        public DbSet<View_department> View_department { get; set; }
        public DbSet<View_renew_contrat_req> View_renew_contrat_req { get; set; }
        public DbSet<TeamMember> View_HRA_teammemebersApi { get; set; }
        public DbSet<View_ForCustomerID> View_ForCustomerID { get; set; }
        public DbSet<View_applicationrenew> View_applicationrenew { get; set; }
        public DbSet<View_CustomerForWhereWhereWork> View_CustomerForWhereWhereWork { get; set; }
        public DbSet<ViewBSCBudgetDetailGrid> ViewBSCBudgetDetailGrid { get; set; }
        public DbSet<View_RentContract> View_RentContract { get; set; }
        public DbSet<View_Training_app_aspuser> View_Training_app_aspuser { get; set; }
        public DbSet<View_propertyAssigmnetForPrint> View_propertyAssigmnetForPrint { get; set; }
        public DbSet<ViewBSCInnitiativePlanAssigmentGrid> ViewBSCInnitiativePlanAssigmentGrid { get; set; }
        public DbSet<ViewBSCKPIGoalMappingGrid> ViewBSCKPIGoalMappingGrid { get; set; }
        public DbSet<ViewFAFixedAssetGrid> ViewFAFixedAssetGrid { get; set; }
        public DbSet<ViewINVInventoryItemsGrid> ViewINVInventoryItemsGrid { get; set; }
        public DbSet<ViewINVItemAcitivityGrid> ViewINVItemAcitivityGrid { get; set; }
        public DbSet<ViewINVOnventoryItemsGrid> ViewINVOnventoryItemsGrid { get; set; }
        public DbSet<ViewAspNetUsersWorkInfoDetail> ViewAspNetUsersWorkInfoDetail { get; set; }
        public DbSet<View_SubCityPropertyData> View_SubCityPropertyData { get; set; }
        public DbSet<View_bank_reco_list> View_bank_reco_list { get; set; }
        public DbSet<View_Job_Application_Employee> View_Job_Application_Employee { get; set; }
        public DbSet<View_GetALLpropertyAssignment> View_GetALLpropertyAssignment { get; set; }
        public DbSet<View_NewHouseRentApplication> View_GetHouseRentApplicationDetail { get; set; }
        public DbSet<View_viewCustomerlistForPropertyAllocation> View_viewCustomerlistForPropertyAllocation { get; set; }
        public DbSet<ViewInnititativeAvalableForRequest> ViewInnititativeAvalableForRequest { get; set; }
        public DbSet<ViewBSCAnualStrategicPlanAssignment> ViewBSCAnualStrategicPlanAssignment { get; set; }
        public DbSet<ViewHRPlannedTrainings> ViewHRPlannedTrainings { get; set; }
        public DbSet<View_Organization_Code_Payroll_Transaction> View_Organization_Code_Payroll_Transaction { get; set; }

        public DbSet<viewsalseinfo> viewsalse { get; set; }
        public DbSet<View_forpay> View_forpay { get; set; }
        public DbSet<View_Parent_fixed_Asset> View_Parent_fixed_Asset { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.Created = _dateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = _currentUserService.UserId;
                        entry.Entity.LastModified = _dateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(XOKADbContext).Assembly);

            modelBuilder
            .Entity<ViewBSCBudgetDetailGrid>(eb =>
            {
                eb.HasNoKey();
                eb.ToView("View_BSC_Budget_Detail_Grid");
                eb.Property(v => v.Budget_DetailID).HasColumnName("Budget_DetailID");
                eb.Property(v => v.Budget_ID).HasColumnName("Budget_ID");
                eb.Property(v => v.Year).HasColumnName("Year");
                eb.Property(v => v.Budget_Type).HasColumnName("Budget_Type");
                eb.Property(v => v.Expenditure).HasColumnName("Expenditure");
                eb.Property(v => v.DIV_code_Name).HasColumnName("DIV_code_Name");
                eb.Property(v => v.Unit).HasColumnName("Unit");
                eb.Property(v => v.ParentBuget_Detail_ID).HasColumnName("ParentBuget_Detail_ID");
                eb.Property(v => v.Is_Approved).HasColumnName("Is_Approved");
                eb.Property(v => v.Budget_Ammount_Birr).HasColumnName("Budget_Ammount_Birr");
                eb.Property(v => v.ApplicationCode).HasColumnName("ApplicationCode");
                eb.Property(v => v.Application_NO).HasColumnName("Application_NO");
                eb.Property(v => v.Description).HasColumnName("Description");
                eb.Property(v => v.Innitiative_ID).HasColumnName("Innitiative_ID");
                eb.Property(v => v.Budget_Allocation_Type).HasColumnName("Budget_Allocation_Type");
            });
            modelBuilder
.Entity<Purchase_Order_Voucher_ID_View>(eb =>
{
eb.HasNoKey();
eb.ToView("Purchase_Order_Voucher_ID_View");
eb.Property(v => v.PO_ID).HasColumnName("PO_ID");
eb.Property(v => v.Bid_Award_ID).HasColumnName("Bid_Award_ID");
eb.Property(v => v.Purchase_Contract).HasColumnName("Purchase_Contract");

});
            modelBuilder
            .Entity<View_Training_Applications>(eb =>
            {
                eb.HasNoKey();
                eb.ToView("View_Training_Applications");
                eb.Property(v => v.Training_Planed_ID).HasColumnName("Training_Planed_ID");
                eb.Property(v => v.Employee_ID).HasColumnName("Employee_ID");
                eb.Property(v => v.First_Name).HasColumnName("First_Name");
                eb.Property(v => v.Last_Name).HasColumnName("Last_Name");
                eb.Property(v => v.Your_Application).HasColumnName("Your_Application");
                eb.Property(v => v.End_Date).HasColumnName("End_Date");
                eb.Property(v => v.Phone_Number).HasColumnName("Phone_Number");
                eb.Property(v => v.email).HasColumnName("email");
                eb.Property(v => v.IS_Submited).HasColumnName("IS_Submited");
                eb.Property(v => v.Training_Application_Status).HasColumnName("Training_Application_Status");
                eb.Property(v => v.Application_Evaluation_result).HasColumnName("Application_Evaluation_result");
                eb.Property(v => v.Insert_Job_title).HasColumnName("Insert_Job_title");
                eb.Property(v => v.Educational_Background).HasColumnName("Educational_Background");
                eb.Property(v => v.Department).HasColumnName("Department");
                eb.Property(v => v.english_description).HasColumnName("english_description");
                eb.Property(v => v.amharic_description).HasColumnName("amharic_description");
                eb.Property(v => v.department_name).HasColumnName("department_name");
                eb.Property(v => v.Application_No).HasColumnName("Application_No");
                eb.Property(v => v.Service_Name).HasColumnName("Service_Name");
                eb.Property(v => v.Application_Start_Date).HasColumnName("Application_Start_Date");
                eb.Property(v => v.Application_End_Date).HasColumnName("Application_End_Date");
                eb.Property(v => v.Training_Start_Date).HasColumnName("Training_Start_Date");
                eb.Property(v => v.Training_End_Date).HasColumnName("Training_End_Date");
                eb.Property(v => v.Start_Hour).HasColumnName("Start_Hour");
                eb.Property(v => v.End_Hour).HasColumnName("End_Hour");
                eb.Property(v => v.Training_Provider_ID).HasColumnName("Training_Provider_ID");
                eb.Property(v => v.Training_Provider_Name).HasColumnName("Training_Provider_Name");
                eb.Property(v => v.Location).HasColumnName("Location");
                eb.Property(v => v.RequrementOf_Tranee).HasColumnName("RequrementOf_Tranee");
                eb.Property(v => v.Training_Name).HasColumnName("Training_Name");
                eb.Property(v => v.Training_Hour).HasColumnName("Training_Hour");
                eb.Property(v => v.Description).HasColumnName("Description");
                eb.Property(v => v.Pass_Point).HasColumnName("Pass_Point");
                eb.Property(v => v.Training_ID).HasColumnName("Training_ID");
                eb.Property(v => v.Address).HasColumnName("Address");
                eb.Property(v => v.HomePhone).HasColumnName("HomePhone");
                eb.Property(v => v.WorkPhone).HasColumnName("WorkPhone");
                eb.Property(v => v.Country).HasColumnName("Country");
            });
            modelBuilder
.Entity<View_RentContract>(eb =>
{
    eb.HasNoKey();
    eb.ToView("View_RentContract_ForCheckActive");
    eb.Property(v => v.Rent_Contract_ID).HasColumnName("Rent_Contract_ID");
    eb.Property(v => v.Property_ID).HasColumnName("Property_ID");
    eb.Property(v => v.From_Organization_Code).HasColumnName("From_Organization_Code");
    eb.Property(v => v.Rent_Contract_Type).HasColumnName("Rent_Contract_Type");
    eb.Property(v => v.Service_Code).HasColumnName("Service_Code");
    eb.Property(v => v.Application_Code).HasColumnName("Application_Code");
    eb.Property(v => v.Application_NO).HasColumnName("Application_NO");
    eb.Property(v => v.To_Customer).HasColumnName("To_Customer");
    eb.Property(v => v.Currency).HasColumnName("Currency");
    eb.Property(v => v.Unit).HasColumnName("Unit");
    eb.Property(v => v.Price).HasColumnName("Price");
    eb.Property(v => v.Start_Date).HasColumnName("Start_Date");
    eb.Property(v => v.End_Date).HasColumnName("End_Date");
    eb.Property(v => v.Renew_Year).HasColumnName("Renew_Year");
    eb.Property(v => v.Renew_Contract_Document_Detail_ID).HasColumnName("Renew_Contract_Document_Detail_ID");
    eb.Property(v => v.Main_Contract_Document_Detail_ID).HasColumnName("Main_Contract_Document_Detail_ID");
    eb.Property(v => v.Parent_Contact).HasColumnName("Parent_Contact");
    eb.Property(v => v.Terminate).HasColumnName("Terminate");
    eb.Property(v => v.Terminate_Remark).HasColumnName("Terminate_Remark");
    eb.Property(v => v.Active).HasColumnName("Active");
    eb.Property(v => v.Active_Remark).HasColumnName("Active_Remark");
    eb.Property(v => v.Referance_Letter).HasColumnName("Referance_Letter");
    eb.Property(v => v.Document_ID).HasColumnName("Document_ID");
    eb.Property(v => v.Contract_NO).HasColumnName("Contract_NO");
    eb.Property(v => v.is_tember).HasColumnName("is_tember");

});
            modelBuilder
              .Entity<ItemActivityPaymentTerm>(eb =>
              {
                  eb.HasNoKey();  // Assuming this is a view and has no primary key
                  eb.ToView("View_payment_term_update2");  // Specify the view name in the database

                  // Define properties and map them to respective column names
                  eb.Property(v => v.PurchaseOrderNum).HasColumnName("Purchase_Order_Num");
                  eb.Property(v => v.PaymentTermID).HasColumnName("Payment_TermID");
                  eb.Property(v => v.Parent).HasColumnName("Parent");
                  eb.Property(v => v.PaymentTerm).HasColumnName("Payment_Term");
                  eb.Property(v => v.LkDetailCode).HasColumnName("lkdetail_code");
                  eb.Property(v => v.EnglishDescription).HasColumnName("english_description");
                  eb.Property(v => v.Declaration).HasColumnName("Declaration");
                  eb.Property(v => v.IsApproved).HasColumnName("Is_Approved");
                  eb.Property(v => v.ContractID).HasColumnName("ContractID");
                  eb.Property(v => v.Percent).HasColumnName("Percent");
                  eb.Property(v => v.TotalPercent).HasColumnName("Total_Percent");
                  eb.Property(v => v.Description).HasColumnName("Description");
                  eb.Property(v => v.IsPurchased).HasColumnName("is_Purchased");
                  eb.Property(v => v.VocherNo).HasColumnName("Vocher_NO");
                  eb.Property(v => v.payment_term).HasColumnName("Expr1");
              });

            modelBuilder
              .Entity<View_Parent_fixed_Asset>(eb =>
              {
                  eb.HasNoKey();  // Assuming this is a view and has no primary key
                  eb.ToView("View_Parent_fixed_Asset");  // Specify the view name in the database

                  // Define properties and map them to respective column names
                  eb.Property(v => v.lkdetail_code).HasColumnName("lkdetail_code");
                  eb.Property(v => v.lkmaster_master_code).HasColumnName("lkmaster_master_code");
                  eb.Property(v => v.english_description).HasColumnName("english_description");
                  eb.Property(v => v.amharic_description).HasColumnName("amharic_description");
                  eb.Property(v => v.tigrigna_description).HasColumnName("tigrigna_description");
                  eb.Property(v => v.oromiffa_description).HasColumnName("oromiffa_description");
                  eb.Property(v => v.Parent).HasColumnName("Parent");

              });
            modelBuilder
  .Entity<View_for_pur_new>(eb =>
  {
      eb.HasNoKey();  // Assuming this is a view and has no primary key
      eb.ToView("View_for_pur_new");  // Specify the view name in the database

      // Define properties and map them to respective column names
      eb.Property(v => v.PurchaseOrderNum).HasColumnName("Purchase_Order_Num");
      eb.Property(v => v.PaymentTermID).HasColumnName("Payment_TermID");
      eb.Property(v => v.Parent).HasColumnName("Parent");
      eb.Property(v => v.PaymentTerm).HasColumnName("Payment_Term");
      eb.Property(v => v.IsApproved).HasColumnName("Is_Approved");
      eb.Property(v => v.ContractID).HasColumnName("ContractID");
      eb.Property(v => v.Percent).HasColumnName("Percent");
      eb.Property(v => v.TotalPercent).HasColumnName("Total_Percent");
      eb.Property(v => v.Description).HasColumnName("Description");
      eb.Property(v => v.IsPurchased).HasColumnName("is_Purchased");
      eb.Property(v => v.VocherNo).HasColumnName("Vocher_NO");
      eb.Property(v => v.payment_term).HasColumnName("Expr1");
      eb.Property(v => v.declaration).HasColumnName("declaration");
  });



            modelBuilder
        .Entity<View_Training_app_aspuser>(eb =>
        {
            eb.HasNoKey();
            eb.ToView("View_Training_app_aspuser");
            eb.Property(v => v.application_number).HasColumnName("application_number");
            eb.Property(v => v.UserId).HasColumnName("UserId");
            eb.Property(v => v.Training_Planed_ID).HasColumnName("Training_Planed_ID");
            eb.Property(v => v.Employee_ID).HasColumnName("Employee_ID");


        });
            modelBuilder
.Entity<View_for_GRR_item>(eb =>
{
eb.HasNoKey();
eb.ToView("View_for_GRR_item");
eb.Property(v => v.Vocher_NO).HasColumnName("Vocher_NO");
eb.Property(v => v.Json_Data).HasColumnName("Json_Data");



});
            modelBuilder
.Entity<View_bid_detail_Api>(eb =>
{
eb.HasNoKey();
eb.ToView("View_bid_detail_Api_term");
eb.Property(v => v.Description).HasColumnName("Description");
eb.Property(v => v.Parent).HasColumnName("Parent");
eb.Property(v => v.is_Purchased).HasColumnName("is_Purchased");



});
            modelBuilder
            .Entity<View_ForCustomerID>(eb =>
            {
                eb.HasNoKey();
                eb.ToView("View_ForCustomerID");
                eb.Property(v => v.UserId).HasColumnName("UserId");
                eb.Property(v => v.UserName).HasColumnName("UserName");

            });
            modelBuilder
           .Entity<View_department>(eb =>
           {
               eb.HasNoKey();
               eb.ToView("View_department");
               eb.Property(v => v.department_code).HasColumnName("department_code");
               eb.Property(v => v.Code).HasColumnName("Code");
               eb.Property(v => v.department_name).HasColumnName("department_name");

           });
            modelBuilder
         .Entity<View_renew_contrat_req>(eb =>
         {
             eb.HasNoKey();
             eb.ToView("View_renew_contrat_req");
             eb.Property(v => v.userId).HasColumnName("userId");
             eb.Property(v => v.status).HasColumnName("status");

         });
            modelBuilder
         .Entity<TeamMember>(eb =>
         {
             eb.HasNoKey();
             eb.ToView("View_HRA_teammemebersApi");
             eb.Property(v => v.TeamLeaderEmployeeID).HasColumnName("TeamLeaderEmployeeID");
             eb.Property(v => v.TeamLeaderFullName).HasColumnName("TeamLeaderFullName");
             eb.Property(v => v.MemberEmployeeID).HasColumnName("MemberEmployeeID");
             eb.Property(v => v.MembersFullName).HasColumnName("MembersFullName");
             eb.Property(v => v.DepartmentName).HasColumnName("DepartmentName");


         });
            modelBuilder
.Entity<View_SubCityPropertyData>(eb =>
{
    eb.HasNoKey();
    eb.ToView("View_SubCityPropertyData");
    eb.Property(v => v.ID).HasColumnName("ID");
    eb.Property(v => v.Name).HasColumnName("Name");
    eb.Property(v => v.Parent).HasColumnName("Parent");
    eb.Property(v => v.Active).HasColumnName("Active");

});
 modelBuilder.Entity<View_bank_reco_list>(eb =>
{
    eb.HasNoKey();
    eb.ToView("View_bank_reco_list");
    eb.Property(v => v.Orderid).HasColumnName("Orderid");
    eb.Property(v => v.trans_initate_time).HasColumnName("trans_initate_time");
    eb.Property(v => v.top_short_code).HasColumnName("top_short_code");
    eb.Property(v => v.short_code).HasColumnName("short_code");
    eb.Property(v => v.biz_org_name).HasColumnName("biz_org_name");
    eb.Property(v => v.trans_status).HasColumnName("trans_status");
    eb.Property(v => v.debit_party_mnemonic).HasColumnName("debit_party_mnemonic");
    eb.Property(v => v.Amount).HasColumnName("Amount");
    eb.Property(v => v.BillReferenceNumber).HasColumnName("BillReferenceNumber");
    eb.Property(v => v.bank_name).HasColumnName("bank_name");
    eb.Property(v => v.Mobile_No).HasColumnName("Mobile_No");


});
            modelBuilder
.Entity<View_applicationrenew>(eb =>
{
    eb.HasNoKey();
    eb.ToView("View_applicationrenew");
    eb.Property(v => v.UserName).HasColumnName("UserName");
    eb.Property(v => v.application_code).HasColumnName("application_code");
    eb.Property(v => v.application_number).HasColumnName("application_number");
    eb.Property(v => v.Customer_ID).HasColumnName("Customer_ID");



});
            modelBuilder
.Entity<View_fixed_dropdwn>(eb =>
{
eb.HasNoKey();
eb.ToView("View_fixed_dropdwn");
eb.Property(v => v.lkdetail_code).HasColumnName("lkdetail_code");
eb.Property(v => v.lkmaster_master_code).HasColumnName("lkmaster_master_code");
eb.Property(v => v.english_description).HasColumnName("english_description");
eb.Property(v => v.Parent).HasColumnName("Parent");



});

            modelBuilder
.Entity<View_Job_Application_Employee>(eb =>
{
    eb.HasNoKey();
    eb.ToView("View_Job_Application_Employee");
    eb.Property(v => v.FName).HasColumnName("FName");
    eb.Property(v => v.LName).HasColumnName("LName");
    eb.Property(v => v.email).HasColumnName("email");
    eb.Property(v => v.Department_code).HasColumnName("Department_code");
    eb.Property(v => v.Structure_ID).HasColumnName("Structure_ID");
    eb.Property(v => v.department_name).HasColumnName("department_name");
    eb.Property(v => v.Job_Title).HasColumnName("Job_Title");
    eb.Property(v => v.IS_Active).HasColumnName("IS_Active");
    eb.Property(v => v.Address).HasColumnName("Address");
    eb.Property(v => v.Employee_Id).HasColumnName("Employee_Id");
    eb.Property(v => v.english_description).HasColumnName("english_description");
    eb.Property(v => v.Cell_Phone_Number).HasColumnName("Cell_Phone_Number");
    eb.Property(v => v.lkdetail_code).HasColumnName("lkdetail_code");


});
            modelBuilder
.Entity<View_forpay>(eb =>
{
    eb.HasNoKey();
    eb.ToView("View_forpay");
    eb.Property(v => v.UserName).HasColumnName("UserName");
    eb.Property(v => v.Document_No).HasColumnName("Document_No");
    eb.Property(v => v.Customer_ID).HasColumnName("Customer_ID");



});
            modelBuilder
            .Entity<ViewBSCInnitiativePlanAssigmentGrid>(eb =>
    {
        eb.HasNoKey();
        eb.ToView("View_BSC_Innitiative_Plan_Assigment_Grid");
        eb.Property(v => v.IPA_ID).HasColumnName("IPA_ID");
        eb.Property(v => v.Innitiative_ID).HasColumnName("Innitiative_ID");
        eb.Property(v => v.Assigned_Body).HasColumnName("Assigned_Body");
        eb.Property(v => v.Assigned_Body_Name).HasColumnName("Assigned_Body_Name");
        eb.Property(v => v.Responsible_Role).HasColumnName("Responsible_Role");
        eb.Property(v => v.Responsible_Role_Name).HasColumnName("Responsible_Role_Name");
        eb.Property(v => v.Is_Active).HasColumnName("Is_Active");
        eb.Property(v => v.ApplicationCode).HasColumnName("ApplicationCode");
        eb.Property(v => v.Application_NO).HasColumnName("Application_NO");
        eb.Property(v => v.Assigned_By).HasColumnName("Assigned_By");
        eb.Property(v => v.Assigned_By_name).HasColumnName("Assigned_By_name");
        eb.Property(v => v.Is_Owner).HasColumnName("Is_Owner");
        eb.Property(v => v.Type_Of_Innitiative).HasColumnName("Type_Of_Innitiative");
        eb.Property(v => v.Innitiative).HasColumnName("Innitiative");
        eb.Property(v => v.Description).HasColumnName("Description");
        eb.Property(v => v.Estimated_Cost_In_Birr).HasColumnName("Estimated_Cost_In_Birr");
        eb.Property(v => v.Value_In_Per).HasColumnName("Value_In_Per");
        eb.Property(v => v.Unit).HasColumnName("Unit");
        eb.Property(v => v.Duration_In_Days).HasColumnName("Duration_In_Days");
        eb.Property(v => v.Expected_Result).HasColumnName("Expected_Result");
        eb.Property(v => v.Required_Inputs).HasColumnName("Required_Inputs");
        eb.Property(v => v.Priority).HasColumnName("Priority");
        eb.Property(v => v.Estimated_Budget).HasColumnName("Estimated_Budget");
        eb.Property(v => v.Budget_Account).HasColumnName("Budget_Account");
        eb.Property(v => v.StartDate).HasColumnName("StartDate");
        eb.Property(v => v.EndDate).HasColumnName("EndDate");
        eb.Property(v => v.Parentinnitiative_ID).HasColumnName("ParentInnitiative_ID");
    });

            modelBuilder
            .Entity<ViewBSCKPIGoalMappingGrid>(eb =>
            {
                eb.HasNoKey();
                eb.ToView("View_BSC_KPI_Goal_Mapping_Grid");
                eb.Property(v => v.KPIMapping_ID).HasColumnName("KPIMapping_ID");
                eb.Property(v => v.Innitiative_ID).HasColumnName("Innitiative_ID");
                eb.Property(v => v.ASPA_ID).HasColumnName("ASPA_ID");
                eb.Property(v => v.Type_Of_Innitiative).HasColumnName("Type_Of_Innitiative");
                eb.Property(v => v.Innitiative).HasColumnName("Innitiative");
                eb.Property(v => v.BaseLine).HasColumnName("BaseLine");
                eb.Property(v => v.KPI_ID).HasColumnName("KPI_ID");
                eb.Property(v => v.Performance_Indicator).HasColumnName("Performance_Indicator");
                eb.Property(v => v.Target).HasColumnName("Target");
                eb.Property(v => v.MIN).HasColumnName("MIN");
                eb.Property(v => v.MAX).HasColumnName("MAX");
                eb.Property(v => v.Value).HasColumnName("Value");
                eb.Property(v => v.Weight).HasColumnName("Weight");
                eb.Property(v => v.Accomplished_Per).HasColumnName("Accomplished_Per");
                eb.Property(v => v.Varance).HasColumnName("Varance");
            });
            modelBuilder
    .Entity<View_Training_Application_Fill_form>(eb =>
    {
        eb.HasNoKey();
        eb.ToView("View_Training_Application_Fill_form");
        eb.Property(v => v.department_name).HasColumnName("department_name");
        eb.Property(v => v.department_code).HasColumnName("department_code");
        eb.Property(v => v.Cell_Phone_Number).HasColumnName("Cell_Phone_Number");
        eb.Property(v => v.Employee_Id).HasColumnName("Employee_Id");
        eb.Property(v => v.Job_Title).HasColumnName("Job_Title");
        eb.Property(v => v.E_Mail).HasColumnName("E_Mail");


    });
            modelBuilder
            .Entity<ViewFAFixedAssetGrid>(eb =>
            {
                eb.HasNoKey();
                eb.ToView("View_FA_Fixed_Asset_Grid");
                eb.Property(v => v.FIXED_Asset_No).HasColumnName("FIXED_Asset_No");
                eb.Property(v => v.FixedAsset_Trans_ID).HasColumnName("FixedAsset_Trans_ID");
                eb.Property(v => v.Name).HasColumnName("Name");
                eb.Property(v => v.Fixed_Asset_Posting_Group).HasColumnName("Fixed_Asset_Posting_Group");
                eb.Property(v => v.Asset_Status_Type).HasColumnName("Asset_Status_Type");
                eb.Property(v => v.Asset_Status_Type_Name).HasColumnName("Asset_Status_Type_Name");
                eb.Property(v => v.FA_Class_Code).HasColumnName("FA_Class_Code");
                eb.Property(v => v.FA_Class_Code_Name).HasColumnName("FA_Class_Code_Name");
                eb.Property(v => v.FA_Class_Sub_Code).HasColumnName("FA_Class_Sub_Code");
                eb.Property(v => v.FA_Class_Code_Sub_Code).HasColumnName("FA_Class_Code_Sub_Code");
                eb.Property(v => v.Factory_Number).HasColumnName("Factory_Number");
                eb.Property(v => v.Value).HasColumnName("Value");
                eb.Property(v => v.Purchased_Date).HasColumnName("Purchased_Date");
                eb.Property(v => v.Received_Date).HasColumnName("Received_Date");
                eb.Property(v => v.Commission_Date).HasColumnName("Commission_Date");
                eb.Property(v => v.Depreciation_Start_Date).HasColumnName("Depreciation_Start_Date");
                eb.Property(v => v.Record_No).HasColumnName("Record_No");
                eb.Property(v => v.Quantity).HasColumnName("Quantity");
                eb.Property(v => v.Unit).HasColumnName("Unit");
                eb.Property(v => v.Remark).HasColumnName("Remark");
            });

            modelBuilder
            .Entity<ViewINVInventoryItemsGrid>(eb =>
            {
                eb.HasNoKey();
                eb.ToView("View_INV_Inventory_Items_Grid");
                eb.Property(v => v.Inv_ID).HasColumnName("Inv_ID");
                eb.Property(v => v.Item_Name).HasColumnName("Item_Name");
                eb.Property(v => v.Description).HasColumnName("Description");
                eb.Property(v => v.Item_Class).HasColumnName("Item_Class");
                eb.Property(v => v.Price).HasColumnName("Price");
                eb.Property(v => v.Cost_Method).HasColumnName("Cost_Method");
                eb.Property(v => v.Cost_Name).HasColumnName("Cost_Name");
                eb.Property(v => v.Last_Unit_Cost).HasColumnName("Last_Unit_Cost");
                eb.Property(v => v.UPC_SKU).HasColumnName("UPC_SKU");
                eb.Property(v => v.PartNumber).HasColumnName("PartNumber");
                eb.Property(v => v.Stocking_Unit).HasColumnName("Stocking_Unit");
                eb.Property(v => v.Weight).HasColumnName("Weight");
                eb.Property(v => v.Shelf_No).HasColumnName("Shelf_No");
                eb.Property(v => v.Item_Tax_Type).HasColumnName("Item_Tax_Type");
                eb.Property(v => v.Minimum_Stock).HasColumnName("Minimum_Stock");
                eb.Property(v => v.Reorder_Quantity).HasColumnName("Reorder_Quantity");
                eb.Property(v => v.Referred_Vendor_id).HasColumnName("Referred_Vendor_id");
                eb.Property(v => v.Preferred_Vendor_Name).HasColumnName("Preferred_Vendor_Name");
                eb.Property(v => v.Gen_Pord_Posting_Group).HasColumnName("Gen_Pord_Posting_Group");
                eb.Property(v => v.Inventory_Posting_Group).HasColumnName("Inventory_Posting_Group");
                eb.Property(v => v.Picture).HasColumnName("Picture");
                eb.Property(v => v.Buyer_ID).HasColumnName("Buyer_ID");
                eb.Property(v => v.Buyer_Name).HasColumnName("Buyer_Name");
                eb.Property(v => v.Item_Category_code).HasColumnName("Item_Category_code");
            });

            modelBuilder
            .Entity<ViewINVItemAcitivityGrid>(eb =>
            {
                eb.HasNoKey();
                eb.ToView("View_INV_Item_Acitivity_Grid");
                eb.Property(v => v.Vocher_NO).HasColumnName("Vocher_NO");
                eb.Property(v => v.Application_Code).HasColumnName("Application_Code");
                eb.Property(v => v.Application_No).HasColumnName("Application_No");
                eb.Property(v => v.TypeOf_Activity).HasColumnName("TypeOf_Activity");
                eb.Property(v => v.TypeOf_Activity_name).HasColumnName("TypeOf_Activity_name");
                eb.Property(v => v.Vendor).HasColumnName("Vendor");
                eb.Property(v => v.Vendor_Name).HasColumnName("Vendor_Name");
                eb.Property(v => v.services_service_code).HasColumnName("services_service_code");
                eb.Property(v => v.Service_Name).HasColumnName("Service_Name");
                eb.Property(v => v.From_Organization).HasColumnName("From_Organization");
                eb.Property(v => v.From_Org_Nmae).HasColumnName("From_Org_Nmae");
                eb.Property(v => v.From_DIV).HasColumnName("From_DIV");
                eb.Property(v => v.From_DIV_Name).HasColumnName("From_DIV_Name");
                eb.Property(v => v.To_Organization).HasColumnName("To_Organization");
                eb.Property(v => v.To_Org_Name).HasColumnName("To_Org_Name");
                eb.Property(v => v.To_DIV).HasColumnName("To_DIV");
                eb.Property(v => v.To_DIV_Name).HasColumnName("To_DIV_Name");
                eb.Property(v => v.Request_Date).HasColumnName("Request_Date");
                eb.Property(v => v.Address).HasColumnName("Address");
                eb.Property(v => v.Requested_By).HasColumnName("Requested_By");
                eb.Property(v => v.Requested_By_Name).HasColumnName("Requested_By_Name");
                eb.Property(v => v.Purchase_Order_Num).HasColumnName("Purchase_Order_Num");
                eb.Property(v => v.Ref_Job_Application_No).HasColumnName("Ref_Job_Application_No");
                eb.Property(v => v.To_Be_Issued_To).HasColumnName("To_Be_Issued_To");
                eb.Property(v => v.Recived_By).HasColumnName("Recived_By");
                eb.Property(v => v.Recived_By_Name).HasColumnName("Recived_By_Name");
                eb.Property(v => v.From_Store).HasColumnName("From_Store");
                eb.Property(v => v.To_Store).HasColumnName("To_Store");
                eb.Property(v => v.Parent_No).HasColumnName("Parent_No");
                eb.Property(v => v.Remark).HasColumnName("Remark");
                eb.Property(v => v.Innitiative_ID).HasColumnName("Innitiative_ID");
            });

            modelBuilder
            .Entity<ViewINVOnventoryItemsGrid>(eb =>
            {
                eb.HasNoKey();
                eb.ToView("View_INV_Onventory_Items_Grid");
                eb.Property(v => v.Inv_ID).HasColumnName("Inv_ID");
                eb.Property(v => v.Item_Name).HasColumnName("Item_Name");
                eb.Property(v => v.Description).HasColumnName("Description");
                eb.Property(v => v.Item_Class).HasColumnName("Item_Class");
                eb.Property(v => v.Price).HasColumnName("Price");
                eb.Property(v => v.Cost_Method).HasColumnName("Cost_Method");
                eb.Property(v => v.Cost_Name).HasColumnName("Cost_Name");
                eb.Property(v => v.OrgCode).HasColumnName("OrgCode");
                eb.Property(v => v.Org_Name).HasColumnName("Org_Name");
                eb.Property(v => v.Last_Unit_Cost).HasColumnName("Last_Unit_Cost");
                eb.Property(v => v.UPC_SKU).HasColumnName("UPC_SKU");
                eb.Property(v => v.PartNumber).HasColumnName("PartNumber");
                eb.Property(v => v.Stocking_Unit).HasColumnName("Stocking_Unit");
                eb.Property(v => v.Weight).HasColumnName("Weight");
                eb.Property(v => v.Shelf_No).HasColumnName("Shelf_No");
                eb.Property(v => v.Item_Tax_Type).HasColumnName("Item_Tax_Type");
                eb.Property(v => v.Minimum_Stock).HasColumnName("Minimum_Stock");
                eb.Property(v => v.Reorder_Quantity).HasColumnName("Reorder_Quantity");
                eb.Property(v => v.Referred_Vendor_id).HasColumnName("Referred_Vendor_id");
                eb.Property(v => v.Preferred_Vendor_Name).HasColumnName("Preferred_Vendor_Name");
                eb.Property(v => v.Gen_Pord_Posting_Group).HasColumnName("Gen_Pord_Posting_Group");
                eb.Property(v => v.Inventory_Posting_Group).HasColumnName("Inventory_Posting_Group");
                eb.Property(v => v.Picture).HasColumnName("Picture");
                eb.Property(v => v.Buyer_ID).HasColumnName("Buyer_ID");
                eb.Property(v => v.Buyer_Name).HasColumnName("Buyer_Name");
                eb.Property(v => v.Item_Category_Code).HasColumnName("Item_Category_Code");
            });

            modelBuilder
            .Entity<ViewAspNetUsersWorkInfoDetail>(eb =>
            {
                eb.HasNoKey();
                eb.ToView("View_AspNetUsers_Work_InfoDetail");
                eb.Property(v => v.UserId).HasColumnName("UserId");
                eb.Property(v => v.UserName).HasColumnName("UserName");
                eb.Property(v => v.LoweredUserName).HasColumnName("LoweredUserName");
                eb.Property(v => v.MobileAlias).HasColumnName("MobileAlias");
                eb.Property(v => v.FirstName_en).HasColumnName("FirstName_en");
                eb.Property(v => v.LastName_en).HasColumnName("LastName_en");
                eb.Property(v => v.FirstName_Local).HasColumnName("FirstName_Local");
                eb.Property(v => v.LastName_Local).HasColumnName("LastName_Local");
                eb.Property(v => v.MiddleName_en).HasColumnName("MiddleName_en");
                eb.Property(v => v.MiddleName_Local).HasColumnName("MiddleName_Local");
                eb.Property(v => v.phone).HasColumnName("phone");
                eb.Property(v => v.Is_Employee).HasColumnName("Is_Employee");
                //eb.Property(v => v.Employee_Id).HasColumnName("Employee_Id");
                eb.Property(v => v.department_code).HasColumnName("department_code");
                eb.Property(v => v.Code).HasColumnName("Code");
                eb.Property(v => v.department_name).HasColumnName("department_name");
                eb.Property(v => v.organization_code).HasColumnName("organization_code");
                eb.Property(v => v.Registration_code).HasColumnName("Registration_code");
                eb.Property(v => v.name_en).HasColumnName("name_en");
                eb.Property(v => v.name_local).HasColumnName("name_local");
                eb.Property(v => v.IS_Active).HasColumnName("IS_Active");
                eb.Property(v => v.Active).HasColumnName("Active");
                //eb.Property(v => v.Structure_ID).HasColumnName("Structure_ID");
            });


            modelBuilder
            .Entity<ViewInnititativeAvalableForRequest>(eb =>
            {
                eb.HasNoKey();
                eb.ToView("View_Innititative_AvalableForRequest");
                eb.Property(v => v.Strategy_NO).HasColumnName("Strategy_NO");
                //eb.Property(v => v.Organization_code).HasColumnName("Organization_code");
                //eb.Property(v => v.Title).HasColumnName("Title");
                //eb.Property(v => v.Strategic_Theme).HasColumnName("Strategic_Theme");
                //eb.Property(v => v.Annual_Strategic_GoalID).HasColumnName("Annual_Strategic_GoalID");
                //eb.Property(v => v.Year).HasColumnName("Year");
                //eb.Property(v => v.Result_In_Per).HasColumnName("Result_In_Per");
                //eb.Property(v => v.ASGD_ID).HasColumnName("ASGD_ID");
                //eb.Property(v => v.Strategic_Goal).HasColumnName("Strategic_Goal");
                //eb.Property(v => v.Goal_Value_In_Per).HasColumnName("Goal_Value_In_Per");
                //eb.Property(v => v.Assigned_Body).HasColumnName("Assigned_Body");
                //eb.Property(v => v.department_name).HasColumnName("department_name");
                //eb.Property(v => v.Responsible_Role).HasColumnName("Responsible_Role");
                //eb.Property(v => v.RoleName).HasColumnName("RoleName");
                //eb.Property(v => v.Innitiative_ID).HasColumnName("Innitiative_ID");
                //eb.Property(v => v.Type_Of_Innitiative).HasColumnName("Type_Of_Innitiative");
                //eb.Property(v => v.Innitiative).HasColumnName("Innitiative");
                //eb.Property(v => v.Description).HasColumnName("Description");
                //eb.Property(v => v.Innitiative_Assigned_Body_Name).HasColumnName("Innitiative_Assigned_Body_Name");
                //eb.Property(v => v.Innitiative_Assigned_Body_Role_Name).HasColumnName("Innitiative_Assigned_Body_Role_Name");
                //eb.Property(v => v.Expr1).HasColumnName("Expr1");
                //eb.Property(v => v.Expr2).HasColumnName("Expr2");
                //eb.Property(v => v.Expr3).HasColumnName("Expr3");
                //eb.Property(v => v.Expr4).HasColumnName("Expr4");
                //eb.Property(v => v.Estimated_Cost_In_Birr).HasColumnName("Estimated_Cost_In_Birr");
                //eb.Property(v => v.Value_In_Per).HasColumnName("Value_In_Per");
                //eb.Property(v => v.Unit).HasColumnName("Unit");
                //eb.Property(v => v.Acctual).HasColumnName("Acctual");
                //eb.Property(v => v.Variance).HasColumnName("Variance");
                //eb.Property(v => v.Duration_In_Days).HasColumnName("Duration_In_Days");
                //eb.Property(v => v.Expected_Result).HasColumnName("Expected_Result");
                //eb.Property(v => v.Priority).HasColumnName("Priority");
                //eb.Property(v => v.Required_Inputs).HasColumnName("Required_Inputs");
                //eb.Property(v => v.Estimated_Budget).HasColumnName("Estimated_Budget");
                //eb.Property(v => v.StartDate).HasColumnName("StartDate");
                //eb.Property(v => v.EndDate).HasColumnName("EndDate");
                //eb.Property(v => v.ParentInnitiative_ID).HasColumnName("ParentInnitiative_ID");
            });

            modelBuilder
            .Entity<ViewBSCAnualStrategicPlanAssignment>(eb =>
            {

                eb.HasNoKey();
                eb.ToView("View_BSC_Anual_Strategic_Plan_Assignment");
                eb.Property(v => v.ASPA_ID).HasColumnName("ASPA_ID");
                eb.Property(v => v.ASGD_ID).HasColumnName("ASGD_ID");
                eb.Property(v => v.Annual_Strategic_GoalID).HasColumnName("Annual_Strategic_GoalID");
                eb.Property(v => v.Strategic_Goal).HasColumnName("Strategic_Goal");
                eb.Property(v => v.Goal_Value_In_Per).HasColumnName("Goal_Value_In_Per");
                eb.Property(v => v.Assigned_Body).HasColumnName("Assigned_Body");
                eb.Property(v => v.Assigned_Body_Name).HasColumnName("Assigned_Body_Name");
                eb.Property(v => v.Responsible_Role).HasColumnName("Responsible_Role");
                eb.Property(v => v.Responsible_Role_Name).HasColumnName("Responsible_Role_Name");
                eb.Property(v => v.Is_Active).HasColumnName("Is_Active");
                eb.Property(v => v.Assigned_By).HasColumnName("Assigned_By");
                eb.Property(v => v.Assigned_By_Name).HasColumnName("Assigned_By_Name");
                eb.Property(v => v.ApplicationCode).HasColumnName("ApplicationCode");
                eb.Property(v => v.Application_NO).HasColumnName("Application_NO");
                eb.Property(v => v.Goal_Description).HasColumnName("Goal_Description");
            });
            modelBuilder
           .Entity<ViewHRPlannedTrainings>(eb =>
           {

               eb.HasNoKey();
               eb.ToView("View_HR_Planned_Trainings");
               eb.Property(v => v.Training_Planed_ID).HasColumnName("Training_Planed_ID");
               eb.Property(v => v.Application_Code).HasColumnName("Application_Code");
               eb.Property(v => v.Application_No).HasColumnName("Application_No");
               eb.Property(v => v.Service_Code).HasColumnName("Service_Code");
               eb.Property(v => v.Service_Name).HasColumnName("Service_Name");
               eb.Property(v => v.Organization_code).HasColumnName("Organization_code");
               eb.Property(v => v.Training_ID).HasColumnName("Training_ID");
               eb.Property(v => v.Training_Name).HasColumnName("Training_Name");
               eb.Property(v => v.Application_Start_Date).HasColumnName("Application_Start_Date");
               eb.Property(v => v.Application_End_Date).HasColumnName("Application_End_Date");
               eb.Property(v => v.Training_Start_Date).HasColumnName("Training_Start_Date");
               eb.Property(v => v.Training_End_Date).HasColumnName("Training_End_Date");
               eb.Property(v => v.Start_Hour).HasColumnName("Start_Hour");
               eb.Property(v => v.End_Hour).HasColumnName("End_Hour");
               eb.Property(v => v.Training_Provider_ID).HasColumnName("Training_Provider_ID");
               eb.Property(v => v.Training_Provider_Name).HasColumnName("Training_Provider_Name");
               eb.Property(v => v.Location).HasColumnName("Location");
               eb.Property(v => v.RequrementOf_Tranee).HasColumnName("RequrementOf_Tranee");
               eb.Property(v => v.Certificate_ID).HasColumnName("Certificate_ID");
               eb.Property(v => v.Innitiative_ID).HasColumnName("Innitiative_ID");
           });
            modelBuilder
         .Entity<View_Organization_Code_Payroll_Transaction>(eb =>
         {

             eb.HasNoKey();
             eb.ToView("View_Organization_Code_Payroll_Transaction");
             eb.Property(v => v.organization_code).HasColumnName("organization_code");
             eb.Property(v => v.Payrole_Trans_Id).HasColumnName("Payrole_Trans_Id");

         });
            modelBuilder
            .Entity<viewsalseinfo>(eb =>
            {
                eb.HasNoKey();
                eb.ToView("viewsalse");
                eb.Property(v => v.No).HasColumnName("No");
                eb.Property(v => v.Org_ID).HasColumnName("Org_ID");
                eb.Property(v => v.Type).HasColumnName("Type");
                eb.Property(v => v.Customer_id).HasColumnName("Customer_id");
                eb.Property(v => v.Address).HasColumnName("Address");
                eb.Property(v => v.Order_Date).HasColumnName("Order_Date");
                eb.Property(v => v.Requested_Delivery_date).HasColumnName("Requested_Delivery_date");
                eb.Property(v => v.Doc_No).HasColumnName("Doc_No");
                eb.Property(v => v.Document_Date).HasColumnName("Document_Date");
                eb.Property(v => v.Customer_PO).HasColumnName("Customer_PO");
                eb.Property(v => v.Application_No).HasColumnName("Application_No");
                eb.Property(v => v.Application_Code).HasColumnName("Application_Code");
                eb.Property(v => v.Service_Name).HasColumnName("Service_Name");
                eb.Property(v => v.Parent_Application_Code).HasColumnName("Parent_Application_Code");
                eb.Property(v => v.Parent_Application_No).HasColumnName("Parent_Application_No");
                eb.Property(v => v.TIN).HasColumnName("TIN");
                eb.Property(v => v.User_id).HasColumnName("User_id");
                eb.Property(v => v.Is_Customer).HasColumnName("Is_Customer");
                eb.Property(v => v.Is_Vendor).HasColumnName("Is_Vendor");
                eb.Property(v => v.Vendor_ID).HasColumnName("Vendor_ID");
                eb.Property(v => v.Name).HasColumnName("Name");
                eb.Property(v => v.TAX_Bus_Posting_group).HasColumnName("TAX_Bus_Posting_group");
                eb.Property(v => v.Payment_Terms_Code).HasColumnName("Payment_Terms_Code");
                eb.Property(v => v.Amount).HasColumnName("Amount");
                eb.Property(v => v.Bal_Amount).HasColumnName("Bal_Amount");
            });
            modelBuilder
           .Entity<View_GetALLpropertyAssignment>(eb =>
           {
               eb.HasNoKey();
               eb.ToView("View_GetALLpropertyAssignment");
               eb.Property(v => v.Property_ID).HasColumnName("Property_ID");
               eb.Property(v => v.Customer_Code).HasColumnName("Customer_Code");
               eb.Property(v => v.Postion).HasColumnName("Postion");
               eb.Property(v => v.Orgnization_Name_Eng).HasColumnName("Orgnization_Name_Eng");
               eb.Property(v => v.Orgnization_Name_Am).HasColumnName("Orgnization_Name_Am");
               eb.Property(v => v.description_am).HasColumnName("description_am");
               eb.Property(v => v.description_en).HasColumnName("description_en");
               eb.Property(v => v.Application_Date).HasColumnName("Application_Date");
               eb.Property(v => v.Priority).HasColumnName("Priority");
               eb.Property(v => v.Rent_App_ID).HasColumnName("Rent_App_ID");
               eb.Property(v => v.Registration_code).HasColumnName("Registration_code");
               eb.Property(v => v.organization_code).HasColumnName("organization_code");
               eb.Property(v => v.House_No).HasColumnName("House_No");
               eb.Property(v => v.name_en).HasColumnName("name_en");
               eb.Property(v => v.name_am).HasColumnName("name_am");
               eb.Property(v => v.Description).HasColumnName("Description");
               eb.Property(v => v.Building_Size_M2).HasColumnName("Building_Size_M2");
               eb.Property(v => v.Parking_Area_M2).HasColumnName("Parking_Area_M2");
               eb.Property(v => v.Compound_Size_M2).HasColumnName("Compound_Size_M2");
               eb.Property(v => v.Location_of_Property).HasColumnName("Location_of_Property");
               eb.Property(v => v.Number_of_Lift).HasColumnName("Number_of_Lift");
               eb.Property(v => v.Estimated_Price).HasColumnName("Estimated_Price");

           });
            modelBuilder
 .Entity<View_NewHouseRentApplication>(eb =>
 {
     eb.HasNoKey();
     eb.ToView("View_GetHouseRentApplicationDetail");
     eb.Property(v => v.Property_ID).HasColumnName("Property_ID");
     eb.Property(v => v.Customer_Code).HasColumnName("Customer_Code");
     eb.Property(v => v.Postion).HasColumnName("Postion");
     eb.Property(v => v.Orgnization_Name_Eng).HasColumnName("Orgnization_Name_Eng");
     eb.Property(v => v.Orgnization_Name_Am).HasColumnName("Orgnization_Name_Am");
     eb.Property(v => v.description_am).HasColumnName("description_am");
     eb.Property(v => v.description_en).HasColumnName("description_en");
     eb.Property(v => v.Application_Date).HasColumnName("Application_Date");
     eb.Property(v => v.Priority).HasColumnName("Priority");
     eb.Property(v => v.Rent_App_ID).HasColumnName("Rent_App_ID");
     eb.Property(v => v.Registration_code).HasColumnName("Registration_code");
     eb.Property(v => v.organization_code).HasColumnName("organization_code");
     eb.Property(v => v.House_No).HasColumnName("House_No");
     eb.Property(v => v.name_en).HasColumnName("name_en");
     eb.Property(v => v.name_am).HasColumnName("name_am");
     eb.Property(v => v.Description).HasColumnName("Description");
     eb.Property(v => v.Building_Size_M2).HasColumnName("Building_Size_M2");
     eb.Property(v => v.Parking_Area_M2).HasColumnName("Parking_Area_M2");
     eb.Property(v => v.Compound_Size_M2).HasColumnName("Compound_Size_M2");
     eb.Property(v => v.Location_of_Property).HasColumnName("Location_of_Property");
     eb.Property(v => v.Number_of_Lift).HasColumnName("Number_of_Lift");
     eb.Property(v => v.Estimated_Price).HasColumnName("Estimated_Price");

 });
            modelBuilder
  .Entity<View_viewCustomerlistForPropertyAllocation>(eb =>
  {
      eb.HasNoKey();
      eb.ToView("View_viewCustomerlistForPropertyAllocation");
      eb.Property(v => v.name_am).HasColumnName("name_am");
      eb.Property(v => v.name_en).HasColumnName("name_en");
      eb.Property(v => v.CustomerCode).HasColumnName("CustomerCode");
      eb.Property(v => v.Customer_ID).HasColumnName("Customer_ID");
      eb.Property(v => v.Applicant_First_Name_AM).HasColumnName("Applicant_First_Name_AM");
      eb.Property(v => v.Applicant_First_Name_EN).HasColumnName("Applicant_First_Name_EN");
      eb.Property(v => v.Applicant_Last_Name_AM).HasColumnName("Applicant_Last_Name_AM");
      eb.Property(v => v.Applicant_Last_Name_EN).HasColumnName("Applicant_Last_Name_EN");
      eb.Property(v => v.Applicant_Middle_Name_AM).HasColumnName("Applicant_Middle_Name_AM");
      eb.Property(v => v.Applicant_Middle_Name_En).HasColumnName("Applicant_Middle_Name_En");
      eb.Property(v => v.Applicant_Mother_Name_AM).HasColumnName("Applicant_Mother_Name_AM");
      eb.Property(v => v.Applicant_Mother_Name_EN).HasColumnName("Applicant_Mother_Name_EN");
      eb.Property(v => v.TIN).HasColumnName("TIN");
      eb.Property(v => v.Gender).HasColumnName("Gender");
      eb.Property(v => v.SDP_ID).HasColumnName("SDP_ID");
      eb.Property(v => v.Wereda_ID).HasColumnName("Wereda_ID");
      eb.Property(v => v.Email).HasColumnName("Email");
      eb.Property(v => v.Mobile_No).HasColumnName("Mobile_No");
      eb.Property(v => v.Photo).HasColumnName("Photo");
      eb.Property(v => v.Home_Telephone).HasColumnName("Home_Telephone");
      eb.Property(v => v.House_No).HasColumnName("House_No");
      eb.Property(v => v.Address).HasColumnName("Address");
      eb.Property(v => v.Kebele).HasColumnName("Kebele");
      eb.Property(v => v.Nationality).HasColumnName("Nationality");
      eb.Property(v => v.Residence_Country).HasColumnName("Residence_Country");
      eb.Property(v => v.State_Region).HasColumnName("State_Region");
      eb.Property(v => v.City).HasColumnName("City");
      eb.Property(v => v.Passport_ID).HasColumnName("Passport_ID");
      eb.Property(v => v.Is_Active).HasColumnName("Is_Active");
      eb.Property(v => v.Is_Represented).HasColumnName("Is_Represented");
      eb.Property(v => v.Parent_Customer_ID).HasColumnName("Parent_Customer_ID");
      eb.Property(v => v.Is_them).HasColumnName("Is_them");
      eb.Property(v => v.Customer_Type_ID).HasColumnName("Customer_Type_ID");
      eb.Property(v => v.Is_Representative).HasColumnName("Is_Representative");
      eb.Property(v => v.Customer_Status).HasColumnName("Customer_Status");
      eb.Property(v => v.Created_By).HasColumnName("Created_By");
      eb.Property(v => v.Updated_By).HasColumnName("Updated_By");
      eb.Property(v => v.Deleted_By).HasColumnName("Deleted_By");
      eb.Property(v => v.Is_Deleted).HasColumnName("Is_Deleted");
      eb.Property(v => v.Created_Date).HasColumnName("Created_Date");
      eb.Property(v => v.Updated_Date).HasColumnName("Updated_Date");
      eb.Property(v => v.Deleted_Date).HasColumnName("Deleted_Date");
      eb.Property(v => v.Date_of_Birth).HasColumnName("Date_of_Birth");
      eb.Property(v => v.Tenant_Work_Condition).HasColumnName("Tenant_Work_Condition");
      eb.Property(v => v.Rent_payment_type_ID).HasColumnName("Rent_payment_type_ID");

  });

            modelBuilder
         .Entity<View_propertyAssigmnetForPrint>(eb =>
        {
            eb.HasNoKey();
            eb.ToView("View_propertyAssigmnetForPrint");
            eb.Property(v => v.Proporty_ID).HasColumnName("Proporty_ID");
            eb.Property(v => v.Property_Type).HasColumnName("Property_Type");
            eb.Property(v => v.Orgnization_Name_Am).HasColumnName("Orgnization_Name_Am");
            eb.Property(v => v.Orgnization_Name_Eng).HasColumnName("Orgnization_Name_Eng");
            eb.Property(v => v.full_name).HasColumnName("full_name");
            eb.Property(v => v.Trans_ID).HasColumnName("Trans_ID");


        });
            modelBuilder
        .Entity<View_customerwithFamily>(eb =>
        {
            eb.HasNoKey();
            eb.ToView("View_customerwithFamily");


            eb.Property(v => v.Family_ID).HasColumnName("Family_ID");
            eb.Property(v => v.RelationShip).HasColumnName("RelationShip");
            eb.Property(v => v.Member_Customer_ID).HasColumnName("Member_Customer_ID");
            eb.Property(v => v.Created_By).HasColumnName("Created_By");
            eb.Property(v => v.Customer_ID).HasColumnName("Customer_ID");
            eb.Property(v => v.Updated_By).HasColumnName("Updated_By");
            eb.Property(v => v.Deleted_By).HasColumnName("Deleted_By");
            eb.Property(v => v.Is_Deleted).HasColumnName("Is_Deleted");
            eb.Property(v => v.Created_Date).HasColumnName("Created_Date");
            eb.Property(v => v.Updated_Date).HasColumnName("Updated_Date");
            eb.Property(v => v.Deleted_Date).HasColumnName("Deleted_Date");
            eb.Property(v => v.CustomerCode).HasColumnName("CustomerCode");
            eb.Property(v => v.Applicant_First_Name_AM).HasColumnName("Applicant_First_Name_AM");
            eb.Property(v => v.Applicant_First_Name_EN).HasColumnName("Applicant_First_Name_EN");
            eb.Property(v => v.Applicant_Middle_Name_AM).HasColumnName("Applicant_Middle_Name_AM");
            eb.Property(v => v.Applicant_Middle_Name_En).HasColumnName("Applicant_Middle_Name_En");
            eb.Property(v => v.Applicant_Last_Name_AM).HasColumnName("Applicant_Last_Name_AM");
            eb.Property(v => v.Applicant_Last_Name_EN).HasColumnName("Applicant_Last_Name_En");
            eb.Property(v => v.Applicant_Mother_Name_AM).HasColumnName("Applicant_Mother_Name_AM");
            eb.Property(v => v.Applicant_Mother_Name_EN).HasColumnName("Applicant_Mother_Name_EN");
            eb.Property(v => v.TIN).HasColumnName("TIN");
            eb.Property(v => v.Gender).HasColumnName("Gender ");
            eb.Property(v => v.SDP_ID).HasColumnName("SDP_ID ");
            eb.Property(v => v.Wereda_ID).HasColumnName("Wereda_ID");
            eb.Property(v => v.Email).HasColumnName("Email  ");
            eb.Property(v => v.Mobile_No).HasColumnName("Mobile_No");
            eb.Property(v => v.Photo).HasColumnName("Photo  ");
            eb.Property(v => v.Home_Telephone).HasColumnName("Home_Telephone");
            eb.Property(v => v.House_No).HasColumnName("House_No ");
            eb.Property(v => v.Address).HasColumnName("Address");
            eb.Property(v => v.Kebele).HasColumnName("Kebele ");
            eb.Property(v => v.Residence_Country).HasColumnName("Residence_Country");
            eb.Property(v => v.Nationality).HasColumnName("Nationality");
            eb.Property(v => v.State_Region).HasColumnName("State_Region");
            eb.Property(v => v.City).HasColumnName("City");
            eb.Property(v => v.Passport_ID).HasColumnName("Passport_ID");
            eb.Property(v => v.Is_Active).HasColumnName("Is_Active");
            eb.Property(v => v.Is_Active).HasColumnName("Is_Active");
            eb.Property(v => v.Is_Represented).HasColumnName("Is_Represented");
            eb.Property(v => v.Parent_Customer_ID).HasColumnName("Parent_Customer_ID");
            eb.Property(v => v.Is_them).HasColumnName("Is_them");
            eb.Property(v => v.Customer_Type_ID).HasColumnName("Customer_Type_ID");
            eb.Property(v => v.Is_Representative).HasColumnName("Is_Representative");
            eb.Property(v => v.Customer_Status).HasColumnName("Customer_Status");
            eb.Property(v => v.Expr1).HasColumnName("Expr1");
            eb.Property(v => v.Expr2).HasColumnName("Expr2");
            eb.Property(v => v.Expr3).HasColumnName("Expr3");
            eb.Property(v => v.Expr4).HasColumnName("Expr4");
            eb.Property(v => v.Expr5).HasColumnName("Expr5");
            eb.Property(v => v.Expr6).HasColumnName("Expr6");
            eb.Property(v => v.Expr7).HasColumnName("Expr7");
            eb.Property(v => v.Date_of_Birth).HasColumnName("Date_of_Birth");
            eb.Property(v => v.Tenant_Work_Condition).HasColumnName("Tenant_Work_Condition");
            eb.Property(v => v.Rent_payment_type_ID).HasColumnName("Rent_payment_type_ID");
        });

            modelBuilder
.Entity<View_CustomerForWhereWhereWork>(eb =>
{
    eb.HasNoKey();
    eb.ToView("View_CustomerForWhereWhereWork");

    eb.Property(v => v.Applicant_First_Name_AM).HasColumnName("Applicant_First_Name_AM");
    eb.Property(v => v.Applicant_First_Name_EN).HasColumnName("Applicant_First_Name_EN");
    eb.Property(v => v.Applicant_Middle_Name_AM).HasColumnName("Applicant_Middle_Name_AM");
    eb.Property(v => v.Applicant_Middle_Name_En).HasColumnName("Applicant_Middle_Name_En");
    eb.Property(v => v.Applicant_Last_Name_AM).HasColumnName("Applicant_Last_Name_AM");
    eb.Property(v => v.Applicant_Last_Name_EN).HasColumnName("Applicant_Last_Name_En");
    eb.Property(v => v.Applicant_Mother_Name_AM).HasColumnName("Applicant_Mother_Name_AM");
    eb.Property(v => v.Applicant_Mother_Name_EN).HasColumnName("Applicant_Mother_Name_EN");
    eb.Property(v => v.TIN).HasColumnName("TIN");
    eb.Property(v => v.SDP_ID).HasColumnName("SDP_ID ");
    eb.Property(v => v.Wereda_ID).HasColumnName("Wereda_ID");
    eb.Property(v => v.Email).HasColumnName("Email  ");
    eb.Property(v => v.Mobile_No).HasColumnName("Mobile_No");
    eb.Property(v => v.Home_Telephone).HasColumnName("Home_Telephone");
    eb.Property(v => v.House_No).HasColumnName("House_No ");
    eb.Property(v => v.Address).HasColumnName("Address");
    eb.Property(v => v.Kebele).HasColumnName("Kebele ");
    eb.Property(v => v.Residence_Country).HasColumnName("Residence_Country");
    eb.Property(v => v.Nationality).HasColumnName("Nationality");
    eb.Property(v => v.State_Region).HasColumnName("State_Region");
    eb.Property(v => v.City).HasColumnName("City");
    eb.Property(v => v.Is_Active).HasColumnName("Is_Active");
    eb.Property(v => v.Is_Active).HasColumnName("Is_Active");
    eb.Property(v => v.Is_Represented).HasColumnName("Is_Represented");
    eb.Property(v => v.Parent_Customer_ID).HasColumnName("Parent_Customer_ID");
    eb.Property(v => v.Is_them).HasColumnName("Is_them");
    eb.Property(v => v.Customer_Type_ID).HasColumnName("Customer_Type_ID");
    eb.Property(v => v.Is_Representative).HasColumnName("Is_Representative");
    eb.Property(v => v.Customer_Status).HasColumnName("Customer_Status");
    eb.Property(v => v.Tenant_Work_Condition).HasColumnName("Tenant_Work_Condition");
    eb.Property(v => v.Rent_payment_type_ID).HasColumnName("Rent_payment_type_ID");
});
        }

        public async Task<List<TeamMember>> GetTeamMembersByLeaderIdAsync(string employeeId)
        {
            var result = new List<TeamMember>();

            using (var connection = new SqlConnection(this.Configuration.GetConnectionString("XOKADatabase")))
            {
                using (var command = new SqlCommand("GetTeamMembersByLeaderId", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add input parameter
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);

                    await connection.OpenAsync();

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var teamMember = new TeamMember
                            {
                                // Map the properties from the reader to your TeamMember object
                                TeamLeaderFullName = reader["teamleaderFullnme"].ToString(),
                                TeamLeaderEmployeeID = (string)reader["teamleader_employee_ID"].ToString(),
                                MemberEmployeeID = (string)reader["memberEmployee_ID"].ToString(),
                                MembersFullName = reader["memebersFullnme"].ToString(),
                                DepartmentName = reader["department_name"].ToString(),
                                valuejson = reader["valuejson"].ToString(),
                                name = reader["name"].ToString(),
                                grade = reader["grade"].ToString()
                            };

                            result.Add(teamMember);
                        }
                    }
                }
            }

            return result;
        }

        public async Task<List<TeamMemberdirecor>> GetTeamMembersByDirectorIdAsync(string directorId)
        {
            var result = new List<TeamMemberdirecor>();

            using (var connection = new SqlConnection(this.Configuration.GetConnectionString("XOKADatabase")))
            {
                using (var command = new SqlCommand("GetTeamMembersByDirectorId", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add input parameter
                    command.Parameters.AddWithValue("@DirectorId", directorId);

                    await connection.OpenAsync();

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var teamMember = new TeamMemberdirecor
                            {
                                ParentCode = reader["parent_code"].ToString(),
                                DirectorDepartment = reader["directordep"].ToString(),
                                Code = reader["Code"].ToString(),
                                Teams = reader["teams"].ToString(),
                                EmployeeId = reader["Employee_ID"].ToString(),
                                FullName = reader["fullname"].ToString(),
                                DirectorName = reader["directorName"].ToString(),
                                valuejson = reader["valuejson"].ToString(),
                                name = reader["name"].ToString(),
                                grade = reader["grade"].ToString()
                            };

                            result.Add(teamMember);
                        }
                    }
                }
            }

            return result;
        }


        public async Task<List<SP_Bank_reconciliation_pay>> SP_Bank_reconciliation_payasync(string Orderid)
        {
            var result = new List<SP_Bank_reconciliation_pay>();

            using (var connection = new SqlConnection(this.Configuration.GetConnectionString("XOKADatabase")))
            {
                using (var command = new SqlCommand("[dbo].[SP_Bank_reconciliation_pay]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add input parameter
                    command.Parameters.AddWithValue("@Orderid", Orderid);

                 
                    // Add output parameters
                    command.Parameters.Add(new SqlParameter("@ResultCode", SqlDbType.NVarChar, -1) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@ResultDesc", SqlDbType.NVarChar, -1) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@TransIDOutput", SqlDbType.NVarChar, -1) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@BillRefNumberOutput", SqlDbType.NVarChar, -1) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@UtilityName", SqlDbType.NVarChar, -1) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.NVarChar, -1) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@Amount", SqlDbType.NVarChar, -1) { Direction = ParameterDirection.Output });

                    await connection.OpenAsync();
                   
                    await command.ExecuteNonQueryAsync();

                    result.Add(new SP_Bank_reconciliation_pay
                    {
                        ResultCode = command.Parameters["@ResultCode"].Value.ToString(),
                        ResultDesc = command.Parameters["@ResultDesc"].Value.ToString(),
                        TransID = command.Parameters["@TransIDOutput"].Value.ToString(),
                        BillRefNumber = command.Parameters["@BillRefNumberOutput"].Value.ToString(),
                        UtilityName = command.Parameters["@UtilityName"].Value.ToString(),
                        CustomerName = command.Parameters["@CustomerName"].Value.ToString(),
                        Amount = command.Parameters["@Amount"].Value.ToString()
                    });
                }
            }

            return result;
        }


    }
}


