namespace Nameless.Identity.Models {

    public class User {

        #region Private Read-Only Fields

        private readonly Guid _id;

        #endregion

        #region Public Virtual Properties

        public virtual Guid ID => _id;
        public virtual string? Username { get; set; }
        public virtual string? FirstName { get; set; }
        public virtual string? LastName { get; set; }
        public virtual string? Email { get; set; }
        public virtual bool EmailConfirmed { get; set; }
        public virtual string? PhoneNumber { get; set; }
        public virtual bool PhoneNumberConfirmed { get; set; }
        public virtual string? AvatarUrl { get; set; }
        public virtual bool TwoFactorAuthEnabled { get; set; }
        public virtual DateTimeOffset? LockoutEnd { get; set; }
        public virtual bool LockoutEnabled { get; set; }
        public virtual int AccessFailureCounter { get; set; }
        public virtual string? PasswordHash { get; set; }
        public virtual string? ConcurrencyStamp { get; set; }

        #endregion

        #region Public Constructors

        public User() {
            _id = Guid.NewGuid();
        }

        #endregion

        #region Public Virtual Methods

        public virtual bool Equals(User? obj) => obj != null && obj.ID == ID;

        #endregion

        #region Public Override Methods

        public override bool Equals(object? obj) => Equals(obj as User);

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