using Nameless.Identity.Models;

namespace Nameless.Identity {

    public interface IUserManager {

        #region Public Properties

        IQueryable<User> Query { get; }

        #endregion

        #region Methods

        Task<User> CreateAsync(string username, string firstName, string email, CancellationToken cancellationToken = default);

        Task DeleteAsync(string username, CancellationToken cancellationToken = default);

        Task<User> GetAsync(string username, CancellationToken token = default);

        Task<IList<UserClaim>> GetUserClaimsAsync(string username, CancellationToken token = default);

        Task<IList<UserLogin>> GetUserLoginsAsync(string username, CancellationToken token = default);

        Task<IList<UserToken>> GetUserTokensAsync(string username, CancellationToken token = default);

        Task SetPasswordAsync(string username, string password, CancellationToken cancellationToken = default);

        Task ConfirmEmailAsync(string username, bool confirm = true, CancellationToken cancellationToken = default);

        Task ConfirmPhoneNumberAsync(string username, bool confirm = true, CancellationToken cancellationToken = default);

        Task SetAvatarUrlAsync(string username, string avatarUrl, CancellationToken cancellationToken = default);

        Task SetTwoFactorAuthAsync(string username, bool enable = true, CancellationToken cancellationToken = default);

        Task SetLockoutEndAsync(string username, DateTimeOffset lockoutEnd, CancellationToken cancellationToken = default);

        Task SetLockoutAsync(string username, bool enable = true, CancellationToken cancellationToken = default);

        Task IncrementAccessFailureCounterAsync(string username, CancellationToken cancellationToken = default);

        Task ResetAccessFailureCounterAsync(string username, CancellationToken cancellationToken = default);

        #endregion
    }
}
