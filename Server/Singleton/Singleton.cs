namespace Data.DataSingleton {
    using RepositoryInterface.TrainingType;
    using MongoDB.TrainingType;
    using Data.RepositoryInterface.TrainingSensation;
    using MongoDB.TrainingSensation;
    using Data.RepositoryInterface.Training;
    using Data.MongoDB.Training;
    using Data.RepositoryInterface.Objective;
    using Data.MongoDB.Objective;

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
        private static ITrainingSensationDelete _TrainingSensationDelete;

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

        public static ITrainingSensationDelete TrainingSensationDelete {
            get {
                if (_TrainingSensationDelete == null)
                    _TrainingSensationDelete = new TrainingSensationDelete();
                return _TrainingSensationDelete;
            }
        }
        #endregion
        #region Training
        private static ITrainingAdd _TrainingAdd;
        private static ITrainingSelect _TrainingSelect;
        private static ITrainingSelectAll _TrainingSelectAll;
        private static ITrainingUpdate _TrainingUpdate;
        private static ITrainingDelete _TrainingDelete;

        public static ITrainingAdd TrainingAdd {
            get {
                if (_TrainingAdd == null)
                    _TrainingAdd = new TrainingAdd();
                return _TrainingAdd;
            }
        }

        public static ITrainingSelect TrainingSelect {
            get {
                if (_TrainingSelect == null)
                    _TrainingSelect = new TrainingSelect();
                return _TrainingSelect;
            }
        }

        public static ITrainingSelectAll TrainingSelectAll {
            get {
                if (_TrainingSelectAll == null)
                    _TrainingSelectAll = new TrainingSelectAll();
                return _TrainingSelectAll;
            }
        }

        public static ITrainingUpdate TrainingUpdate {
            get {
                if (_TrainingUpdate == null)
                    _TrainingUpdate = new TrainingUpdate();
                return _TrainingUpdate;
            }
        }

        public static ITrainingDelete TrainingDelete {
            get {
                if (_TrainingDelete == null)
                    _TrainingDelete = new TrainingDelete();
                return _TrainingDelete;
            }
        }
        #endregion
        #region Objective
        private static IObjectiveAdd _ObjectiveAdd;
        private static IObjectiveSelect _ObjectiveSelect;
        private static IObjectiveSelectAll _ObjectiveSelectAll;
        private static IObjectiveUpdate _ObjectiveUpdate;
        private static IObjectiveUpdateStatus _ObjectiveUpdateStatus;
        private static IObjectiveDelete _ObjectiveDelete;

        public static IObjectiveAdd ObjectiveAdd {
            get {
                if (_ObjectiveAdd == null)
                    _ObjectiveAdd = new ObjectiveAdd();
                return _ObjectiveAdd;
            }
        }

        public static IObjectiveSelect ObjectiveSelect {
            get {
                if (_ObjectiveSelect == null)
                    _ObjectiveSelect = new ObjectiveSelect();
                return _ObjectiveSelect;
            }
        }

        public static IObjectiveSelectAll ObjectiveSelectAll {
            get {
                if (_ObjectiveSelectAll == null)
                    _ObjectiveSelectAll = new ObjectiveSelectAll();
                return _ObjectiveSelectAll;
            }
        }

        public static IObjectiveUpdate ObjectiveUpdate {
            get {
                if (_ObjectiveUpdate == null)
                    _ObjectiveUpdate = new ObjectiveUpdate();
                return _ObjectiveUpdate;
            }
        }

        public static IObjectiveUpdateStatus ObjectiveUpdateStatus {
            get {
                if (_ObjectiveUpdateStatus == null)
                    _ObjectiveUpdateStatus = new ObjectiveUpdateStatus();
                return _ObjectiveUpdateStatus;
            }
        }

        public static IObjectiveDelete ObjectiveDelete {
            get {
                if (_ObjectiveDelete == null)
                    _ObjectiveDelete = new ObjectiveDelete();
                return _ObjectiveDelete;
            }
        }
        #endregion
    }
}
