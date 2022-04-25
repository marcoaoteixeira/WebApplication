namespace Nameless.Identity.Models {

    public class Role {

        #region Private Read-Only Fields

        private readonly Guid _id;

        #endregion

        #region Public Virtual Properties

        public virtual Guid ID => _id;
        public virtual string? Name { get; set; }
        public virtual string? ConcurrencyStamp { get; set; }

        #endregion

        #region Public Constructors

        public Role() {
            _id = Guid.NewGuid();
        }

        #endregion

        #region Public Virtual Methods

        public virtual bool Equals(Role? obj) => obj != null && obj.ID == ID;

        #endregion

        #region Public Override Methods

        public override bool Equals(object? obj) => Equals(obj as Role);

        public override int GetHashCode() {
            var hash = 13;
            unchecked {
                hash += ID.GetHashCode() * 7;
            }
            return hash;
        }

        #endregion
    }
}
