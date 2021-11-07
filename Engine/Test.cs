using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Test
    {
        public delegate void TestMessage(string message);

        public Test(TestMessage messageTest)
        {
            Send = messageTest;
        }

        public string Message { get; set; }
        public TestMessage Send { get; set; }

        public void AlertUser(TestMessage message)
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
