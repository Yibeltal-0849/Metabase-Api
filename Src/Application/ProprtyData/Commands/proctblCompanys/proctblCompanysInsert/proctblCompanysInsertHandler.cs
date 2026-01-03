



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblCompanys.proctblCompanysInsert.proctblCompanysInsertCommand
{

    /// @author  Shimels Alem  proc_tblCompanysInsert stored procedure.


    public class proctblCompanysInsertHandler : IRequestHandler<proctblCompanysInsertCommand, IList<tblCompanys_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblCompanysInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblCompanys_id>> Handle( proctblCompanysInsertCommand request, CancellationToken cancellationToken)
        {

            long? id = request.id;
            string Name = request.Name;
            long? Region = request.Region;
            bool? IsLocal = request.IsLocal;
            string Operating_Area = request.Operating_Area;
            decimal? Capital = request.Capital;
            string Mistion = request.Mistion;
            string vistion = request.vistion;
            string Objective = request.Objective;
            byte[]? LastUpdated = request.LastUpdated;
            string More_info = request.More_info;
            long OrgType = request.OrgType;
            IList<tblCompanys_id> result = await _procedureAdabter
                    .Execute<tblCompanys_id>("[ProprtyData].proc_tblCompanysInsert",
                    (nameof(id), id),
                    (nameof(Name), Name),
                    (nameof(Region), Region),
                    (nameof(IsLocal), IsLocal),
                    (nameof(Operating_Area), Operating_Area),
                    (nameof(Capital), Capital),
                    (nameof(Mistion), Mistion),
                    (nameof(vistion), vistion),
                    (nameof(Objective), Objective),
                    (nameof(LastUpdated), LastUpdated)
                    );
           

            return result;
        }
    }
}
 