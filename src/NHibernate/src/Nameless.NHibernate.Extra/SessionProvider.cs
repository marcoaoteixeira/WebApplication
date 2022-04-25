using NHibernate;

namespace Nameless.NHibernate {

    public sealed class SessionProvider : ISessionProvider {

        #region Private Read-Only Fields

        private readonly IConfigurationBuilder _configurationBuilder;

        #endregion

        #region Private Fields

        private ISessionFactory? _sessionFactory;
        private bool _disposed;

        #endregion

        #region Public Constructors

        public SessionProvider(IConfigurationBuilder configurationBuilder) {
            Prevent.ParameterNull(configurationBuilder, nameof(configurationBuilder));

            _configurationBuilder = configurationBuilder;
        }

        #endregion

        #region Destructor

        ~SessionProvider() {
            Dispose(disposing: false);
        }

        #endregion

        #region Private Methods

        private void Dispose(bool disposing) {
            if (_disposed) { return; }
            if (disposing) {
                if (_sessionFactory != null) {
                    _sessionFactory.Dispose();
                    _sessionFactory = null;
                }
            }

            _disposed = true;
        }

        #endregion

        #region ISessionProvider Members

        public ISession GetSession(NHibernateOptions? options = null) {
            if (_sessionFactory == null) {
                var config = _configurationBuilder.Build(options ?? new());
                _sessionFactory = config.BuildSessionFactory();
            }

            return _sessionFactory.OpenSession();
        }

        #endregion

        #region IDisposable Members

        public void Dispose() {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
