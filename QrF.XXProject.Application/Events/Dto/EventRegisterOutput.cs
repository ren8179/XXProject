using Abp.Application.Services.Dto;

namespace QrF.XXProject.Events.Dto
{
    public class EventRegisterOutput : IOutputDto
    {
        public int RegistrationId { get; set; }
    }
}
