﻿using System;

namespace LogicSingleton {
    using Logics.Logic.TrainingType;
    using Logics.Logic.TrainingSensation;
    public class Singleton {
        private static TrainingTypeAdd _TrainingTypeAdd;
        private static TrainingTypeSelectAll _TrainingTypeSelectAll;
        private static TrainingTypeSelect _TrainingTypeSelect;
        private static TrainingTypeUpdate _TrainingTypeUpdate;
        private static TrainingTypeDelete _TrainingTypeDelete;

        private static TrainingSensationAdd _TrainingSensationAdd;
        private static TrainingSensationSelectAll _TrainingSensationSelectAll;
        private static TrainingSensationSelect _TrainingSensationSelect;
        private static TrainingSensationUpdate _TrainingSensationUpdate;
        private static TrainingSensationDelete _TrainingSensationDelete;

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
    }
}
