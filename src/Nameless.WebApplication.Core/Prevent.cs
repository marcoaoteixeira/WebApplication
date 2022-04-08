using System.Diagnostics;

namespace Nameless.WebApplication {

    public static class Prevent {

        #region Public Static Methods

        [DebuggerStepThrough]
        public static void ParameterNull(object? parameterValue, string parameterName) {
            EnsureParameterName(parameterName);

            if (parameterValue == null) {
                throw new ArgumentNullException(parameterName);
            }
        }

        [DebuggerStepThrough]
        public static void ParameterNullOrWhiteSpace(string parameterValue, string parameterName) {
            EnsureParameterName(parameterName);

            if (string.IsNullOrWhiteSpace(parameterValue)) {
                throw new ArgumentNullException("Parameter cannot be null, empty or white spaces.", parameterName);
            }
        }

        #endregion

        #region Private Static Methods

        private static void EnsureParameterName(string parameterName) {
            if (string.IsNullOrWhiteSpace(parameterName)) {
                throw new ArgumentException("Parameter cannot be null, empty or white spaces.", nameof(parameterName));
            }
        }

        #endregion
    }
}
