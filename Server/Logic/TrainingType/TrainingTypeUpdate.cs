namespace Logics.Logic.TrainingType {
    using Data.DataSingleton;
    using System;
    using Util.Common;
    public class TrainingTypeUpdate {
        public Controller.DtoEntity.TrainingType ExecuteUpdate(Controller.DtoEntity.TrainingType trainingType) {
            try {
                if (Singleton.TrainingTypeSelect.Select(trainingType.Id) == null)
                    throw new Exception("Training Type Update. TrainingType doesn't exist.");
                return CommonSingleton.TrainingTypeCommon.ToDtoEntity(Singleton.TrainingTypeUpdate.Update(CommonSingleton.TrainingTypeCommon.ToDataEntity(trainingType)));
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
