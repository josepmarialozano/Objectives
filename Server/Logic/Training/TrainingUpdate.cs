using Data.DataSingleton;
using System;
using Util.Common;

namespace Logics.Logic.Training {
    public class TrainingUpdate {
        public Controller.DtoEntity.Training ExecuteUpdate(Controller.DtoEntity.Training training) {
            try {
                if (Singleton.TrainingSelect.Select(training.Id) == null)
                    throw new Exception("Training Update. Training doesn't exist.");
                return CommonSingleton.TrainingCommon.ToDtoEntity(Singleton.TrainingUpdate.Update(CommonSingleton.TrainingCommon.ToDataEntity(training)));
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
