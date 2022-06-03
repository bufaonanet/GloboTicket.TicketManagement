using GloboTicket.TicketManagement.Domain;

namespace GloboTicket.TicketManagement.Application.Contracts.Persistence
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {

    }
}
