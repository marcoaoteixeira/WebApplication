using Nameless.Identity.Models;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Nameless.Identity.NHibernate.Mappings {

    public class RoleClassMapping : ClassMapping<Role> {

        #region Public Constructors

        public RoleClassMapping() {

            Table("roles");

            Id(_ => _.ID, mapping => {
                mapping.Column("id");
                mapping.Type(NHibernateUtil.Guid);
                mapping.Access(Accessor.Field);
            });

            Property(_ => _.Name, mapping => {
                mapping.Column("name");
                mapping.Length(255);
                mapping.NotNullable(true);
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
