using System;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Comands.CreateCateogry
{
    public class CreateCategoryDto
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
    }
}