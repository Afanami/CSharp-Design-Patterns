using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Design_Patterns.src.OopsPrinciples.Coupling
{
    public interface INotificationService
    {
        void SendNotification(string message);
    }
}
