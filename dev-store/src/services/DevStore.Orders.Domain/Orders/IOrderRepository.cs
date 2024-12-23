using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using DevStore.Core.Data;

namespace DevStore.Orders.Domain.Orders
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<Order> GetById(Guid id);
        Task<IEnumerable<Order>> GetCustomersById(Guid customerId);
        void Add(Order order);
        void Update(Order order);

        DbConnection GetConnection();


        /* Order Item */
        Task<OrderItem> GetItemById(Guid id);
        Task<OrderItem> GetItemByOrder(Guid orderId, Guid productId);
    }
}