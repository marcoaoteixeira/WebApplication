using Nameless.Identity.Models;
using NHibernate;
using NHibernate.Mapping.ByCode.Conformist;

namespace Nameless.Identity.NHibernate.Mappings {

    public class UserLoginClassMapping : ClassMapping<UserLogin> {

        #region Public Constructors

        public UserLoginClassMapping() {

            Table("users_logins");

            Property(_ => _.UserID, mapping => {
                mapping.Column("user_id");
                mapping.Type(NHibernateUtil.Guid);
            });

            Property(_ => _.LoginProvider, mapping => {
                mapping.Column("login_provider");
                mapping.Length(255);
                mapping.NotNullable(true);
            });

            Property(_ => _.ProviderKey, mapping => {
                mapping.Column("provider_key");
                mapping.Length(255);
                mapping.NotNullable(true);
            });

            Property(_ => _.DisplayName, mapping => {
                mapping.Column("display_name");
                mapping.Length(255);
                mapping.NotNullable(true);
            });
        }

        #endregion
    }
}
