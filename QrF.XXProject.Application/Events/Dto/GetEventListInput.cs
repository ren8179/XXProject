using Abp.Application.Services.Dto;

namespace QrF.XXProject.Events.Dto
{
    public class GetEventListInput : IInputDto
    {
        public bool IncludeCanceledEvents { get; set; }
    }
}
