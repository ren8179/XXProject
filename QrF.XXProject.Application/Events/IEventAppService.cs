using Abp.Application.Services;
using Abp.Application.Services.Dto;
using QrF.XXProject.Events.Dto;
using System;
using System.Threading.Tasks;

namespace QrF.XXProject.Events
{
    public interface IEventAppService : IApplicationService
    {
        Task<ListResultOutput<EventListDto>> GetList(GetEventListInput input);

        Task<EventDetailOutput> GetDetail(EntityRequestInput<Guid> input);

        Task Create(CreateEventInput input);

        Task Cancel(EntityRequestInput<Guid> input);

        Task<EventRegisterOutput> Register(EntityRequestInput<Guid> input);

        Task CancelRegistration(EntityRequestInput<Guid> input);
    }
}
