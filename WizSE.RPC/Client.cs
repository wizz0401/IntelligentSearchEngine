using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
namespace WizSE.RPC
{
   public  class Client
    {

       private Dictionary<string, Conncetion> connections = new Dictionary<string, Conncetion>();
        public class Call 
        {
            private Guid id;
            private Packet mRequest;
            private Packet mResponse;
            private bool isDone;

            public Call(Packet request)
            {
                mRequest = request;
            
            }

            private void CallComplete()
            {
                isDone = true;
            }
            private void SetResponse()
            { 
            
            
            }

           
        
        }

        public class Conncetion:ITask
        {
            public string RemoteID { get; set; }

            private Dictionary<Guid, Call> calls = new Dictionary<Guid, Call>();


            private void SendRequest()
            {
                return;
            
            }

            private void ReceiveReponse()
            {
                return;
            }

            private void Touch()
            {
                return;
            }

            private void AddCall()
            {
                return; 
            }


            public override void Run()
            {
                try
                {
                    while (true)
                    {
                        ReceiveReponse();
                    }
                }
                catch (Exception ex)
                {
                    Stop();
                }
            }
        }
    }
}
