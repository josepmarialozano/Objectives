namespace Logics.Logic.TrainingSensation {
    using Data.DataSingleton;
    using System;
    using Util.Common;

    public class TrainingSensationUpdate {
        public Controller.DtoEntity.TrainingSensation ExecuteUpdate(Controller.DtoEntity.TrainingSensation trainingSensation) {
            try {
                if (Singleton.TrainingSensationSelect.Select(trainingSensation.Id) == null)
                    throw new Exception("Training Sensation Update. TrainingType doesn't exist.");
                return CommonSingleton.TrainingSensationCommon.ToDtoEntity(Singleton.TrainingSensationUpdate.Update(CommonSingleton.TrainingSensationCommon.ToDataEntity(trainingSensation)));
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
