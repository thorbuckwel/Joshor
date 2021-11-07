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
        public delegate void AlertMessageWrite(string message);

        public Alert(AlertMessage messageTest, AlertMessageWrite messageWrite)
        {
            Send = messageTest;
            SendWrite = messageWrite;
        }

        public string Message { get; set; }
        public AlertMessage Send { get; set; }
        public AlertMessageWrite SendWrite { get; set; }

        public void AlertUser(AlertMessage message)
        {
            message(Message);
        }

        public void AlertUserWrite(AlertMessageWrite message)
        {
            message(Message);
        }

        public void SetMessage(string message)
        {
            Message = message;
            AlertUser(Send);
        }

        public void SetMessageWrite(string message)
        {
            Message = message;
            AlertUserWrite(SendWrite);
        }
    }
}
