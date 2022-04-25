using Nameless.Identity.Models;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Nameless.Identity.NHibernate.Mappings {

    public class UserClaimClassMapping : ClassMapping<UserClaim> {

        #region Public Constructors

        public UserClaimClassMapping() {

            Table("users_claims");

            Id(_ => _.ID, mapping => {
                mapping.Column("id");
                mapping.Type(NHibernateUtil.Guid);
                mapping.Access(Accessor.Field);
            });

            Property(_ => _.UserID, mapping => {
                mapping.Column("user_id");
                mapping.Type(NHibernateUtil.Guid);
            });

            Property(_ => _.Type, mapping => {
                mapping.Column("type");
                mapping.Length(255);
                mapping.NotNullable(true);
            });

            Property(_ => _.Value, mapping => {
                mapping.Column("value");
                mapping.Length(255);
                mapping.NotNullable(true);
            });
        }

        #endregion
    }
}
