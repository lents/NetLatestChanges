using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopLevelPatternMatching
{
    internal class Example
    {
        public string GenerateNotification(object eventData)
        {
            if (eventData is OrderCompleted order)
            {
                if (order.Amount > 1000)
                {
                    return "VIP-клиент! Заказ завершен.";
                }
                else if (order.PaymentType == "CreditCard" && !order.IsInternational)
                {
                    return "Заказ оплачен картой (локальный).";
                }
                else
                {
                    return "Заказ завершен.";
                }
            }
            else if (eventData is SupportTicket ticket)
            {
                if (ticket.Priority == Priority.High && ticket.IsResolved)
                {
                    return "Срочный тикет закрыт!";
                }
                else if (ticket.Category == "Payment" && !ticket.IsResolved)
                {
                    return "Незакрытый платежный тикет!";
                }
                else
                {
                    return "Тикет обновлен.";
                }
            }
            else if (eventData == null)
            {
                return "Ошибка: пустое событие.";
            }
            return "Неизвестное событие.";
        }
        public string GenerateNotificationNew(object? eventData) => eventData switch
        {
            OrderCompleted { Amount: > 1000 } => "VIP-клиент! Заказ завершен.",
            OrderCompleted { PaymentType: "CreditCard", IsInternational: false }
                                                        => "Заказ оплачен картой (локальный).",
            OrderCompleted => "Заказ завершен.",

            SupportTicket { Priority: Priority.High, IsResolved: true }
                                                        => "Срочный тикет закрыт!",
            SupportTicket { Category: "Payment", IsResolved: false }
                                                        => "Незакрытый платежный тикет!",
            SupportTicket => "Тикет обновлен.",

            null => "Ошибка: пустое событие.",
            _ => "Неизвестное событие."
        };
    }
}

    
