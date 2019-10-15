using Data.DataSingleton;
using System;
using Util.Common;

namespace Logics.Logic.Training {
    public class TrainingAdd {
        public Guid ExecuteAdd(Controller.DtoEntity.Training training) {
            try {
                string[] fieldsToCheck = {"TrainingMonth", "TrainingYear", "StartingHour","StartingMinute", "TrainingHour","TrainingMinute", "TrainingSecond", "Speed" };
                if (string.IsNullOrEmpty(training.Name))
                    throw new Exception("Add Training, Name shouldn't be empty");
                Type trainingObjectType = training.GetType();
                foreach (var item in fieldsToCheck) {
                    if((int)(trainingObjectType.GetProperty(item).GetValue(training))>0)
                        throw new Exception(String.Format("Add Training, {0} shouldn't be empty",item));
                }
                Data.DataEntity.Training trainingResult = Singleton.TrainingAdd.Add(CommonSingleton.TrainingCommon.ToDataEntity(training));
                return trainingResult.Id;
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
