using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Alert
            {
        public delegate void AlertMessage(string message);

        public Alert(AlertMessage messageTest)
        {
            Send = messageTest;
        }

        public string Message { get; set; }
        public AlertMessage Send { get; set; }

        public void AlertUser(AlertMessage message)
        {
            message(Message);
        }

        public void SetMessage(string message)
        {
            Message = message;
            AlertUser(Send);
        }
    }
}
