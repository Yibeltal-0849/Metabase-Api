using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procorganizationsInsert.procorganizationsInsertCommand
{
    /// @author  Henok Solomon  proc_organizationsInsert stored procedure.

    public class procorganizationsInsertHandler : IRequestHandler<procorganizationsInsertCommand, IList<procorganizations_organization_Code>>
    {
        private readonly IMapper _mapper;
        private readonly IProcedureAdabter _procedureAdabter;
        private readonly ILogger<procorganizationsInsertHandler> _logger;

        public procorganizationsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter, ILogger<procorganizationsInsertHandler> logger)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
            _logger = logger;
        }

        public async Task<IList<procorganizations_organization_Code>> Handle(procorganizationsInsertCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Received request: {@request}", request);

            // Explicitly define parameters as tuples to avoid AsDictionary conversion
            var paramsArray = new[]
            {
                ("organization_code", (object)(request.organization_Code ?? null)),
                ("Registration_code", request.registration_Code),
                ("organization_Type_code", request.organization_Type_Code ?? (object)null),
                ("name_en", request.name_En),
                ("name_local", request.name_Local),
                ("name_am", request.name_Am),
                ("name_or", request.name_Or),
                ("name_tg", request.name_Tg),
                ("description_am", request.description_Am),
                ("description_en", request.description_En),
                ("description_or", request.description_Or),
                ("description_tg", request.description_Tg),
                ("email", request.email),
                ("POBox", request.pOBox),
                ("Telephone", request.telephone),
                ("Fax", request.fax),
                ("PhysicalAddress", request.physicalAddress),
                ("ZoomLevel", request.zoomLevel ?? (object)null),
                ("header", request.header ?? new byte[0]), 
                ("footer", request.footer ?? new byte[0]), 
                ("geo_location_X", request.geo_Location_X ?? (object)null),
                ("geo_location_Y", request.geo_Location_Y ?? (object)null),
                ("tin", request.tin),
                ("organization_link", request.organization_Link),
                ("organization_help_id", request.organization_Help_Id),
                ("created_by", request.created_By ?? (object)null),
                ("created_date", request.created_Date ?? (object)null),
                ("is_published", request.is_Published ?? (object)null),
                ("is_active", request.is_Active ?? (object)null),
                ("is_serviceOwner", request.is_ServiceOwner ?? (object)null),
                ("ref_languages_lanaguage_code", request.ref_Languages_Lanaguage_Code ?? (object)null),
                ("organizations_organization_code", request.organizations_Organization_Code ?? (object)null),
                ("is_synched", request.is_Synched ?? (object)null),
                ("date_synched", request.date_Synched ?? (object)null),
                ("Database_IP", request.database_IP),
                ("WebServer_IP", request.webServer_IP),
                ("GISServerService_URL", request.gISServerService_URL),
                ("GISServerService_UserName", request.gISServerService_UserName),
                ("GISServerService_Password", request.gISServerService_Password)
            };

            // Log the parameters before passing to adapter
            _logger.LogInformation("Parameters before adapter: {@paramsArray}", paramsArray);

            IList<procorganizations_organization_Code> result;
            try
            {
                result = await _procedureAdabter
                    .Execute<procorganizations_organization_Code>("[dbo].proc_organizationsInsert", paramsArray);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error executing stored procedure [dbo].proc_organizationsInsert, Inner Exception: {InnerException}", ex.InnerException?.ToString() ?? "None");
                throw; // Re-throw to be caught by the controller
            }

            _logger.LogInformation("Execution result: {@result}", result);

            return result;
        }
    }
}