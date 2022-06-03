using GloboTicket.TicketManagement.Application.Responses;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Comands.CreateCateogry
{
    public class CreateCategoryCommandResponse : BaseResponse
    {
        public CreateCategoryDto Category { get; set; }

        public CreateCategoryCommandResponse() : base()
        {

        }
    }
}
