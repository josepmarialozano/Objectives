namespace LogicSingleton {
    using Logics.Logic.TrainingType;
    using Logics.Logic.TrainingSensation;
    using Logics.Logic.Training;
    using Logics.Logic.Objective;

    public class Singleton {
        #region TrainingType
        private static TrainingTypeAdd _TrainingTypeAdd;
        private static TrainingTypeSelectAll _TrainingTypeSelectAll;
        private static TrainingTypeSelect _TrainingTypeSelect;
        private static TrainingTypeUpdate _TrainingTypeUpdate;
        private static TrainingTypeDelete _TrainingTypeDelete;
        public static TrainingTypeAdd TrainingTypeAdd {
            get {
                if (_TrainingTypeAdd == null)
                    _TrainingTypeAdd = new TrainingTypeAdd();
                return _TrainingTypeAdd;
            }
        }

        public static TrainingTypeSelectAll TrainingTypeSelectAll {
            get {
                if (_TrainingTypeSelectAll == null)
                    _TrainingTypeSelectAll = new TrainingTypeSelectAll();
                return _TrainingTypeSelectAll;
            }
        }

        public static TrainingTypeSelect TrainingTypeSelect {
            get {
                if (_TrainingTypeSelect == null)
                    _TrainingTypeSelect = new TrainingTypeSelect();
                return _TrainingTypeSelect;
            }
        }

        public static TrainingTypeUpdate TrainingTypeUpdate {
            get {
                if (_TrainingTypeUpdate == null)
                    _TrainingTypeUpdate = new TrainingTypeUpdate();
                return _TrainingTypeUpdate;
            }
        }

        public static TrainingTypeDelete TrainingTypeDelete {
            get {
                if (_TrainingTypeDelete == null)
                    _TrainingTypeDelete = new TrainingTypeDelete();
                return _TrainingTypeDelete;
            }
        }
        #endregion

        #region TrainingSensation
        private static TrainingSensationAdd _TrainingSensationAdd;
        private static TrainingSensationSelectAll _TrainingSensationSelectAll;
        private static TrainingSensationSelect _TrainingSensationSelect;
        private static TrainingSensationUpdate _TrainingSensationUpdate;
        private static TrainingSensationDelete _TrainingSensationDelete;

        public static TrainingSensationAdd TrainingSensationAdd {
            get {
                if (_TrainingSensationAdd == null)
                    _TrainingSensationAdd = new TrainingSensationAdd();
                return _TrainingSensationAdd;
            }
        }

        public static TrainingSensationSelectAll TrainingSensationSelectAll {
            get {
                if (_TrainingSensationSelectAll == null)
                    _TrainingSensationSelectAll = new TrainingSensationSelectAll();
                return _TrainingSensationSelectAll;
            }
        }

        public static TrainingSensationSelect TrainingSensationSelect {
            get {
                if (_TrainingSensationSelect == null)
                    _TrainingSensationSelect = new TrainingSensationSelect();
                return _TrainingSensationSelect;
            }
        }

        public static TrainingSensationUpdate TrainingSensationUpdate {
            get {
                if (_TrainingSensationUpdate == null)
                    _TrainingSensationUpdate = new TrainingSensationUpdate();
                return _TrainingSensationUpdate;
            }
        }

        public static TrainingSensationDelete TrainingSensationDelete {
            get {
                if (_TrainingSensationDelete == null)
                    _TrainingSensationDelete = new TrainingSensationDelete();
                return _TrainingSensationDelete;
            }
        }
        #endregion

        #region Training
        private static TrainingAdd _TrainingAdd;
        private static TrainingSelectAll _TrainingSelectAll;
        private static TrainingSelect _TrainingSelect;
        private static TrainingUpdate _TrainingUpdate;
        private static TrainingDelete _TrainingDelete;

        public static TrainingAdd TrainingAdd {
            get {
                if (_TrainingAdd == null)
                    _TrainingAdd = new TrainingAdd();
                return _TrainingAdd;
            }
        }

        public static TrainingSelectAll TrainingSelectAll {
            get {
                if (_TrainingSelectAll == null)
                    _TrainingSelectAll = new TrainingSelectAll();
                return _TrainingSelectAll;
            }
        }

        public static TrainingSelect TrainingSelect {
            get {
                if (_TrainingSelect == null)
                    _TrainingSelect = new TrainingSelect();
                return _TrainingSelect;
            }
        }

        public static TrainingUpdate TrainingUpdate {
            get {
                if (_TrainingUpdate == null)
                    _TrainingUpdate = new TrainingUpdate();
                return _TrainingUpdate;
            }
        }

        public static TrainingDelete TrainingDelete {
            get {
                if (_TrainingDelete == null)
                    _TrainingDelete = new TrainingDelete();
                return _TrainingDelete;
            }
        }
        #endregion

        #region Objective
        private static ObjectiveAdd _ObjectiveAdd;
        private static ObjectiveSelectAll _ObjectiveSelectAll;
        private static ObjectiveSelect _ObjectiveSelect;
        private static ObjectiveUpdate _ObjectiveUpdate;
        private static ObjectiveUpdateStatus _ObjectiveUpdateStatus;
        private static ObjectiveDelete _ObjectiveDelete;

        public static ObjectiveAdd ObjectiveAdd {
            get {
                if (_ObjectiveAdd == null)
                    _ObjectiveAdd = new ObjectiveAdd();
                return _ObjectiveAdd;
            }
        }

        public static ObjectiveSelectAll ObjectiveSelectAll {
            get {
                if (_ObjectiveSelectAll == null)
                    _ObjectiveSelectAll = new ObjectiveSelectAll();
                return _ObjectiveSelectAll;
            }
        }

        public static ObjectiveSelect ObjectiveSelect {
            get {
                if (_ObjectiveSelect == null)
                    _ObjectiveSelect = new ObjectiveSelect();
                return _ObjectiveSelect;
            }
        }

        public static ObjectiveUpdate ObjectiveUpdate {
            get {
                if (_ObjectiveUpdate == null)
                    _ObjectiveUpdate = new ObjectiveUpdate();
                return _ObjectiveUpdate;
            }
        }

        public static ObjectiveUpdateStatus ObjectiveUpdateStatus {
            get {
                if (_ObjectiveUpdateStatus == null)
                    _ObjectiveUpdateStatus = new ObjectiveUpdateStatus();
                return _ObjectiveUpdateStatus;
            }
        }

        public static ObjectiveDelete ObjectiveDelete {
            get {
                if (_ObjectiveDelete == null)
                    _ObjectiveDelete = new ObjectiveDelete();
                return _ObjectiveDelete;
            }
        }
        #endregion
    }
}
