using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using InternetShop.DAL;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace InternetShop.SiteApp.Commands.OrderCreateNotification
{
    public class EmailNotify : INotificationHandler<OrderCreated>
    {
        private readonly IUnitOfWork _uow;
        public EmailNotify(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public Task Handle(OrderCreated notification, CancellationToken cancellationToken)
        {
            var orderParts = _uow.GetGenericRepository<Order>()
                .Where(x => x.OrderId == notification.OrderId)
                .Include(x => x.Product)
                .Include(x => x.OrderDetail).ToList();
            var sb = new StringBuilder();
            var details = orderParts.FirstOrDefault()?.OrderDetail;
            sb.AppendLine($"Уведомляю вас о создании заказа в {details.OrderDate.ToString("T")}\nДетали:");
            sb.AppendLine(
                $"Имя клиента {details.CustomerName}\nНомер телефона: {details.PhoneNumber}\nАдрес и комментарии от клиента: {details.AdressAndComment}");
            sb.AppendLine("Заказчиком выбраны следующие товары:");
            double sum = 0;
            foreach (var part in orderParts)
            {
                sb.AppendLine($"{part.Product.Name}");
                sum += part.Product.Price;
            }

            sb.AppendLine($"Общая сумма заказа составляет {sum} сом.");
            return Task.CompletedTask;
        }
    }
}