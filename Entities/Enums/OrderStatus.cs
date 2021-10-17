using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment,
        Processign,
        Shipped,
        Delivered
    }
}
