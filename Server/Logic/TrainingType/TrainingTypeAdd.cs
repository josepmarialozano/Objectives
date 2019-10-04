namespace Logics.Logic.TrainingType {
    using System;
    using Data.DataSingleton;
    using Util.Common;

    public class TrainingTypeAdd {
        public Guid ExecuteAdd(Controller.DtoEntity.TrainingType trainingType) {
            try {
                if (string.IsNullOrEmpty(trainingType.Name))
                    throw new Exception("Add TrainingType, Name shouldn't be empty");
                Data.DataEntity.TrainingType trainingTypeResult = Singleton.TrainingTypeAdd.Add(CommonSingleton.TrainingTypeCommon.ToDataEntity(trainingType));
                return trainingTypeResult.Id;
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
