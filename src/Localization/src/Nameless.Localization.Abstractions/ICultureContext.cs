using System.Globalization;

namespace Nameless.WebApplication.Localization {

    public interface ICultureContext {

        #region Methods

        CultureInfo GetCulture();

        #endregion
    }
}
