using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblElectricTransDstrDetail.proctblElectricTransDstrDetailDelete.proctblElectricTransDstrDetailDeleteCommand
{

    /// @author  Shimels Alem  proc_tblElectric_Trans_Dstr_DetailDelete stored procedure.


    public class proctblElectricTransDstrDetailDeleteHandler : IRequestHandler<proctblElectricTransDstrDetailDeleteCommand, IList<tblElectricTransDstrDetail_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblElectricTransDstrDetailDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblElectricTransDstrDetail_id>> Handle( proctblElectricTransDstrDetailDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblElectricTransDstrDetail_id> result = await _procedureAdabter
                .Execute<tblElectricTransDstrDetail_id>("[ProprtyData].proc_tblElectric_Trans_Dstr_DetailDelete", request);
           

            return result;
        }
    }
}
  