using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Quiries.Account_Type.GetCAccountTypeLoadAll
{
    public class GetCAccountTypeLoadAllQueryHandler : IRequestHandler<GetCAccountTypeLoadAllQuery, GetCAccountTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetCAccountTypeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCAccountTypeLoadAllListVm> Handle(GetCAccountTypeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Proc_C_Account_Type> accountTypes = await _procedureAdabter
               .Execute<Proc_C_Account_Type>("[BSC].[proc_c_Account_TypeLoadAll]");
            GetCAccountTypeLoadAllListVm vm = new GetCAccountTypeLoadAllListVm
            {
                AccountTypes = _mapper.Map<IList<Proc_C_Account_Type>, IList<GetCAccountTypeLoadAllVm>>(accountTypes)
            };

            return vm;
        }
    }
}
