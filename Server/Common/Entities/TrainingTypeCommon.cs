using System.Collections.Generic;

namespace Util.Common.Entities {
    public class TrainingTypeCommon {
        public Data.DataEntity.TrainingType ToDataEntity(Controller.DtoEntity.TrainingType trainingType) {
            return new Data.DataEntity.TrainingType {
                Id = trainingType.Id,
                Name = trainingType.Name
            };
        }

        public Controller.DtoEntity.TrainingType ToDtoEntity(Data.DataEntity.TrainingType trainingType) {
            return new Controller.DtoEntity.TrainingType {
                Id = trainingType.Id,
                Name = trainingType.Name
            };
        }

        public List<Controller.DtoEntity.TrainingType> ToDtoEntityList(List<Data.DataEntity.TrainingType> trainingTypeList) {
            return trainingTypeList.ConvertAll(item => ToDtoEntity(item));
        }
    }
}
