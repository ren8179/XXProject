using Abp.Domain.Services;
using QrF.XXProject.Users;
using System.Threading.Tasks;

namespace QrF.XXProject.Events
{
    public interface IEventRegistrationPolicy : IDomainService
    {
        /// <summary>
        /// Checks if given user can register to <see cref="@event"/> and throws exception if can not.
        /// </summary>
        Task CheckRegistrationAttemptAsync(Event @event, User user);
    }
}
