namespace Logics.Logic.Training {
    using Data.DataSingleton;
    using System;
    using Util.Common;

    public class TrainingSelect {
        public Controller.DtoEntity.Training ExecuteSelect(Guid trainingId) {
            try {
                return CommonSingleton.TrainingCommon.ToDtoEntity(Singleton.TrainingSelect.Select(trainingId));
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
