namespace DtoEntity {
    using System;

    public class BaseEntity {
        private Guid _Id;
        public Guid Id {
            get {
                if (_Id == null) _Id = Guid.NewGuid();
                return _Id;
            }
            set {
                _Id = value;
            }
        }
        public string Name { get; set; }
    }
}
