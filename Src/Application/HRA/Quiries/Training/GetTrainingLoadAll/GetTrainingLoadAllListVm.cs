using System;
using System.Collections.Generic;
using System.Text;

namespace Application.HRA.Quiries.Training.GetTrainingLoadAll
{
    /// @author  Shimels Alem  proc_TrainingLoadAll stored procedure.

    public class GetTrainingLoadAllListVm
    {
        public IList<GetTrainingLoadAllVm> Trainings { get; set; }
    }
}
