namespace Data.DataSingleton {
    using RepositoryInterface.TrainingType;
    using MongoDB.TrainingType;
    using Data.RepositoryInterface.TrainingSensation;
    using MongoDB.TrainingSensation;

    public class Singleton {
        #region TrainingType
        private static ITrainingTypeAdd _TrainingTypeAdd;
        private static ITrainingTypeUpdate _TrainingTypeUpdate;
        private static ITrainingTypeSelect _TrainingTypeSelect;
        private static ITrainingTypeSelectAll _TrainingTypeSelectAll;
        private static ITrainingTypeDelete _TrainingTypeDelete;

        public static ITrainingTypeAdd TrainingTypeAdd {
            get {
                if (_TrainingTypeAdd == null)
                    _TrainingTypeAdd = new TrainingTypeAdd();
                return _TrainingTypeAdd;
            }
        }

        public static ITrainingTypeUpdate TrainingTypeUpdate {
            get {
                if (_TrainingTypeUpdate == null)
                    _TrainingTypeUpdate = new TrainingTypeUpdate();
                return _TrainingTypeUpdate;
            }
        }

        public static ITrainingTypeSelect TrainingTypeSelect {
            get {
                if (_TrainingTypeSelect == null)
                    _TrainingTypeSelect = new TrainingTypeSelect();
                return _TrainingTypeSelect;
            }
        }

        public static ITrainingTypeSelectAll TrainingTypeSelectAll {
            get {
                if (_TrainingTypeSelectAll == null)
                    _TrainingTypeSelectAll = new TrainingTypeSelectAll();
                return _TrainingTypeSelectAll;
            }
        }

        public static ITrainingTypeDelete TrainingTypeDelete {
            get {
                if (_TrainingTypeDelete == null)
                    _TrainingTypeDelete = new TrainingTypeDelete();
                return _TrainingTypeDelete;
            }
        }
        #endregion
        #region TrainingSensation
        private static ITrainingSensationAdd _TrainingSensationAdd;
        private static ITrainingSensationSelect _TrainingSensationSelect;
        private static ITrainingSensationSelectAll _TrainingSensationSelectAll;
        private static ITrainingSensationUpdate _TrainingSensationUpdate;
        public static ITrainingSensationAdd TrainingSensationAdd {
            get {
                if (_TrainingSensationAdd == null)
                    _TrainingSensationAdd = new TrainingSensationAdd();
                return _TrainingSensationAdd;
            }
        }

        public static ITrainingSensationSelect TrainingSensationSelect {
            get {
                if (_TrainingSensationSelect == null)
                    _TrainingSensationSelect = new TrainingSensationSelect();
                return _TrainingSensationSelect;
            }
        }

        public static ITrainingSensationSelectAll TrainingSensationSelectAll {
            get {
                if (_TrainingSensationSelectAll == null)
                    _TrainingSensationSelectAll = new TrainingSensationSelectAll();
                return _TrainingSensationSelectAll;
            }
        }

        public static ITrainingSensationUpdate TrainingSensationUpdate {
            get {
                if (_TrainingSensationUpdate == null)
                    _TrainingSensationUpdate = new TrainingSensationUpdate();
                return _TrainingSensationUpdate;
            }
        }
        #endregion
    }
}
