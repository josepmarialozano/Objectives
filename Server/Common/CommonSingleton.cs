namespace Util.Common {
    using Util.Common.Entities;

    public class CommonSingleton {
        private static CommonGeneric<Data.DataEntity.TrainingType, Controller.DtoEntity.TrainingType> _TrainingTypeCommon;
        private static CommonGeneric<Data.DataEntity.TrainingSensation, Controller.DtoEntity.TrainingSensation> _TrainingSensationCommon;

        public static CommonGeneric<Data.DataEntity.TrainingType, Controller.DtoEntity.TrainingType> TrainingTypeCommon {
            get {
                if (_TrainingTypeCommon == null)
                    _TrainingTypeCommon = new CommonGeneric<Data.DataEntity.TrainingType, Controller.DtoEntity.TrainingType>();
                return _TrainingTypeCommon;
            }
        }

        public static CommonGeneric<Data.DataEntity.TrainingSensation, Controller.DtoEntity.TrainingSensation> TrainingSensationCommon {
            get {
                if (_TrainingSensationCommon == null)
                    _TrainingSensationCommon = new CommonGeneric<Data.DataEntity.TrainingSensation, Controller.DtoEntity.TrainingSensation>();
                return _TrainingSensationCommon;
            }
        }


    }
}
