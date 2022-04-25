using NHibernate.Mapping.ByCode;

namespace Nameless.NHibernate {

    /// <summary>
    /// Default implementation of <see cref="ExplicitlyDeclaredModel" />.
    /// </summary>
    public sealed class ModelInspector : ExplicitlyDeclaredModel {

        #region Private Read-Only Fields

        private readonly Type[] _entityBaseTypes;

        #endregion

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="ModelInspector" />
        /// </summary>
        public ModelInspector(Type[] entityBaseTypes) {
            Prevent.ParameterNull(entityBaseTypes, nameof(entityBaseTypes));

            _entityBaseTypes = entityBaseTypes!;
        }

        #endregion

        #region Public Override Methods

        /// <inheritdoc />
        public override bool IsEntity(Type type) {
            return _entityBaseTypes.Any(_ => _.IsAssignableFrom(type));
        }

        #endregion
    }
}
