using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Comands.CreateCateogry
{
    public class CreateCategoryCommand : IRequest<CreateCategoryCommandResponse>
    {
        public string Name { get; set; }
    }
}
