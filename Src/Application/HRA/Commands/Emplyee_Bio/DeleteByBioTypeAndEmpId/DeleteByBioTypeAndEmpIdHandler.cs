using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Emplyee_Bio.DeleteByBioTypeAndEmpId
{
    public class DeleteByBioTypeAndEmpIdHandler : IRequestHandler<DeleteByBioTypeAndEmpIdCommand, IList<EmplyeeBio_Emp_Bioid>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteByBioTypeAndEmpIdHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<EmplyeeBio_Emp_Bioid>> Handle(DeleteByBioTypeAndEmpIdCommand request, CancellationToken cancellationToken)
        {
           
          string Bio_Type = request.Bio_Type;
            string Employee_ID = request.Employee_ID;
            IList<EmplyeeBio_Emp_Bioid> result = await _procedureAdabter
                .Execute<EmplyeeBio_Emp_Bioid>("[HRA].[proc_Emplyee_BioDeleteByBioTypeAndEmpId]",
                (nameof(Bio_Type), Bio_Type), (nameof(Employee_ID), Employee_ID));

            return result;
        }
    }
}
