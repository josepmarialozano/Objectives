namespace Util.Common.Entities {
    using System;
    using System.Collections.Generic;

    public class CommonGeneric<DataEntity, ControllerEntity> where DataEntity : new() where ControllerEntity : new() {
        public DataEntity ToDataEntity(ControllerEntity controllerEntity) {
            DataEntity dataEntity = new DataEntity();
            Type controllerType = controllerEntity.GetType();
            Type dataType = dataEntity.GetType();
            foreach (var item in controllerType.GetProperties()) {
                dataType.GetProperty(item.Name).SetValue(dataEntity, controllerType.GetProperty(item.Name).GetValue(controllerEntity));
            };
            return dataEntity;
        }

        public ControllerEntity ToDtoEntity(DataEntity dataEntity) {
            ControllerEntity controllerEntity = new ControllerEntity();
            Type dataType = dataEntity.GetType();
            Type controllerType = controllerEntity.GetType();
            foreach (var item in dataType.GetProperties()) {
                controllerType.GetProperty(item.Name).SetValue(controllerEntity, dataType.GetProperty(item.Name).GetValue(dataEntity));
            };
            return controllerEntity;
        }

        public List<ControllerEntity> ToDtoEntityList(List<DataEntity> dataEntityList) {
            return dataEntityList.ConvertAll(item => ToDtoEntity(item));
        }
    }
}
