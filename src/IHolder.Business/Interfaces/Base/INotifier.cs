using IHolder.Business.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Interfaces.Base
{
    public interface INotifier
    {
        bool HasNotification();
        IEnumerable<Notification> GetNotifications();
        void AddNotification(Notification notification);
    }
}
