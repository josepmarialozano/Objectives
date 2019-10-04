using System;

namespace LogicSingleton {
    using Logics.Logic.TrainingType;
    public class Singleton {
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

    }
}
