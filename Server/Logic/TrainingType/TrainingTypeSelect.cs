namespace Logics.Logic.TrainingType {
    using System;
    using Data.DataSingleton;
    using Util.Common;
    public class TrainingTypeSelect {
        public Controller.DtoEntity.TrainingType ExecuteSelect(Guid trainingTypeId) {
            try {
                return CommonSingleton.TrainingTypeCommon.ToDtoEntity(Singleton.TrainingTypeSelect.Select(trainingTypeId));
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
