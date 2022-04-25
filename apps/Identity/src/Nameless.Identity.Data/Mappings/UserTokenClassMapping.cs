using Nameless.Identity.Models;
using NHibernate;
using NHibernate.Mapping.ByCode.Conformist;

namespace Nameless.Identity.NHibernate.Mappings {

    public class UserTokenClassMapping : ClassMapping<UserToken> {

        #region Public Constructors

        public UserTokenClassMapping() {

            Table("users_tokens");

            Property(_ => _.UserID, mapping => {
                mapping.Column("user_id");
                mapping.Type(NHibernateUtil.Guid);
            });

            Property(_ => _.LoginProvider, mapping => {
                mapping.Column("login_provider");
                mapping.Length(255);
                mapping.NotNullable(true);
            });

            Property(_ => _.Name, mapping => {
                mapping.Column("name");
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
