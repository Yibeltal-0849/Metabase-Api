using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Inventory.Quiries.StoreItemActivityType.GetStoreItemActivityTypeLoadAll;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.StoreItemActivityType.GetStoreItemActivityTypeByTaskIDAndOrgCode
                                                              
{
    public class GetStoreItemActivityTypeQueryHandlerTaskIDAndOrgCode : IRequestHandler<GetStoreItemActivityTypeByTaskIAndOrgCode, GetStoreItemActivityTypeLoadAllListVm_Branch>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetStoreItemActivityTypeQueryHandlerTaskIDAndOrgCode(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetStoreItemActivityTypeLoadAllListVm_Branch> Handle(GetStoreItemActivityTypeByTaskIAndOrgCode request, CancellationToken cancellationToken)
        {

            IList<Store_Item_Activity_Type_Group_Branch> StoreItemActivityTypes = await _procedureAdabter
               .Execute<Store_Item_Activity_Type_Group_Branch>("[Inventory].[proc_Store_Item_Activity_TypeLoadByGroup_Branch_and_Visable_For_Task_ID]", request);
            GetStoreItemActivityTypeLoadAllListVm_Branch vm = new GetStoreItemActivityTypeLoadAllListVm_Branch
            {
                StoreItemActivityTypes = _mapper.Map<IList<Store_Item_Activity_Type_Group_Branch>, IList<GetStoreItemActivityTypeLoadGroupBranchAllVm>>(StoreItemActivityTypes)
            };

            return vm;
        }
    }
}
