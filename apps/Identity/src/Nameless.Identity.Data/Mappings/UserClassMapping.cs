using Nameless.Identity.Models;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Nameless.Identity.NHibernate.Mappings {

    public class UserClassMapping : ClassMapping<User> {

        #region Public Constructors

        public UserClassMapping() {

            Table("users");

            Id(_ => _.ID, mapping => {
                mapping.Column("id");
                mapping.Type(NHibernateUtil.Guid);
                mapping.Access(Accessor.Field);
            });

            Property(_ => _.Username, mapping => {
                mapping.Column("username");
                mapping.Length(255);
                mapping.NotNullable(true);
            });

            Property(_ => _.FirstName, mapping => {
                mapping.Column("first_name");
                mapping.Length(255);
                mapping.NotNullable(true);
            });

            Property(_ => _.LastName, mapping => {
                mapping.Column("last_name");
                mapping.Length(255);
            });

            Property(_ => _.Email, mapping => {
                mapping.Column("email");
                mapping.Length(255);
                mapping.NotNullable(true);
            });

            Property(_ => _.EmailConfirmed, mapping => {
                mapping.Column("email_confirmed");
            });

            Property(_ => _.PhoneNumber, mapping => {
                mapping.Column("phone_number");
                mapping.Length(32);
            });

            Property(_ => _.PhoneNumberConfirmed, mapping => {
                mapping.Column("phone_number_confirmed");
            });

            Property(_ => _.AvatarUrl, mapping => {
                mapping.Column("avatar_url");
                mapping.Length(4000);
            });

            Property(_ => _.TwoFactorAuthEnabled, mapping => {
                mapping.Column("two_factor_auth_enabled");
            });

            Property(_ => _.LockoutEnd, mapping => {
                mapping.Column("lockout_end");
                mapping.NotNullable(false);
            });

            Property(_ => _.LockoutEnabled, mapping => {
                mapping.Column("lockout_enabled");
            });

            Property(_ => _.AccessFailureCounter, mapping => {
                mapping.Column("access_failure_counter");
            });

            Property(_ => _.PasswordHash, mapping => {
                mapping.Column("password_hash");
                mapping.Length(255);
            });

            Version(_ => _.ConcurrencyStamp, mapping => {
                mapping.Column("concurrency_stamp");
                mapping.Type(NHibernateUtil.DbTimestamp);
            });

            OptimisticLock(OptimisticLockMode.Version);
        }

        #endregion
    }
}
