using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiPPZaliczenie.model;

namespace MiPPZaliczenie.services
{
    class MessageService
    {
        private static MessageService instance;

        public static MessageService getInstance()
        {
            return instance ?? (instance = new MessageService());
        }

        public delegate void MessageSentEventHandler(Message message);

        public event MessageSentEventHandler messageSent;

        public void sendMessage(Message message)
        {
            messageSent(message);
        }
    }
}
