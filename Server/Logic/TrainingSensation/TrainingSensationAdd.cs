namespace Logics.Logic.TrainingSensation {
    using Data.DataSingleton;
    using System;
    using Util.Common;

    public class TrainingSensationAdd {
        public Guid ExecuteAdd(Controller.DtoEntity.TrainingSensation trainingSensation) {
            try {
                if (string.IsNullOrEmpty(trainingSensation.Name))
                    throw new Exception("Add TrainingSensation, Name shouldn't be empty");
                Data.DataEntity.TrainingSensation trainingSensationResult = Singleton.TrainingSensationAdd.Add(CommonSingleton.TrainingSensationCommon.ToDataEntity(trainingSensation));
                return trainingSensationResult.Id;
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
