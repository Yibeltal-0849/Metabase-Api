



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblInstitution.proctblInstitutionInsert.proctblInstitutionInsertCommand
{

    /// @author  Shimels Alem  proc_tblInstitutionInsert stored procedure.


    public class proctblInstitutionInsertHandler : IRequestHandler<proctblInstitutionInsertCommand, IList<tblInstitution_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblInstitutionInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblInstitution_id>> Handle( proctblInstitutionInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblInstitution_id> result = await _procedureAdabter
                .Execute<tblInstitution_id>("[ProprtyData].proc_tblInstitutionInsert", request);
           

            return result;
        }
    }
}
 