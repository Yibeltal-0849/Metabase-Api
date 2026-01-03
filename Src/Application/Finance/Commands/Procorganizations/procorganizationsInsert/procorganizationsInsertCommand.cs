using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procorganizationsInsert.procorganizationsInsertCommand
{
    /// @author  Henok Solomon  proc_organizationsInsert stored procedure.

    #region proc_organizationsInsert  
    /// proc_organizationsInsert stored procedure.
    public class procorganizationsInsertCommand : IRequest<IList<procorganizations_organization_Code>>
    {
        public System.Guid? organization_Code { get; set; }
        public string registration_Code { get; set; }
        public System.Guid? organization_Type_Code { get; set; }
        public string name_En { get; set; }
        public string name_Local { get; set; }
        public string name_Am { get; set; }
        public string name_Or { get; set; }
        public string name_Tg { get; set; }
        public string description_Am { get; set; }
        public string description_En { get; set; }
        public string description_Or { get; set; }
        public string description_Tg { get; set; }
        public string email { get; set; }
        public string pOBox { get; set; }
        public string telephone { get; set; }
        public string fax { get; set; }
        public string physicalAddress { get; set; }
        public decimal? zoomLevel { get; set; }
        public byte[]? header { get; set; }
        public byte[]? footer { get; set; }
        public decimal? geo_Location_X { get; set; }
        public decimal? geo_Location_Y { get; set; }
        public string organization_Link { get; set; }
        public string organization_Help_Id { get; set; }
        public System.Guid? created_By { get; set; }
        public DateTime? created_Date { get; set; }
        public bool? is_Published { get; set; }
        public bool? is_Active { get; set; }
        public bool? is_ServiceOwner { get; set; }
        public System.Guid? ref_Languages_Lanaguage_Code { get; set; }
        public System.Guid? organizations_Organization_Code { get; set; }
        public bool? is_Synched { get; set; }
        public DateTime? date_Synched { get; set; }
        public string database_IP { get; set; }
        public string webServer_IP { get; set; }
        public string gISServerService_URL { get; set; }
        public string gISServerService_UserName { get; set; }
        public string gISServerService_Password { get; set; }
        public string tin { get; set; }
    }
    #endregion
}