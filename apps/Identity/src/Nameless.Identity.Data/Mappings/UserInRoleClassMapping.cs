using Nameless.Identity.Models;
using NHibernate;
using NHibernate.Mapping.ByCode.Conformist;

namespace Nameless.Identity.NHibernate.Mappings {

    public class UserInRoleClassMapping : ClassMapping<UserInRole> {

        #region Public Constructors

        public UserInRoleClassMapping() {

            Table("users_roles");

            Property(_ => _.UserID, mapping => {
                mapping.Column("user_id");
                mapping.Type(NHibernateUtil.Guid);
            });

            Property(_ => _.RoleID, mapping => {
                mapping.Column("role_id");
                mapping.Type(NHibernateUtil.Guid);
            });
        }

        #endregion
    }
}
