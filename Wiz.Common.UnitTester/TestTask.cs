using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Wiz.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
namespace Wiz.Common.UnitTester
{
    public class MyTestTask : ITask
    {
        public override void Run()
        {
            while (true)
            {
                try
                {
                    string msg = "test";
                    byte[] bytes = Encoding.UTF8.GetBytes(msg);
                    using (FileStream fs = new FileStream("D:\\Projects\\SearchEnginee\\fs.txt"
                        , FileMode.Append))
                    {

                        fs.Write(bytes, 0, bytes.Length);
                    }

                    Thread.Sleep(100);

                }
                catch (Exception ex)
                {
                    return;

                }
            }
        }
    }

    [TestClass()]
  public class TestTask
    {



        [TestMethod]
        public void RunTest()
        {
            var task = new MyTestTask();
            task.Start();
            Thread.Sleep(10000);
        
        }

        private void Run()
        {
            while (true)
            {
                try
                {
                    string msg = "test";
                    byte[] bytes = Encoding.UTF8.GetBytes(msg);
                    using (FileStream fs = new FileStream("D:\\Projects\\SearchEnginee\\fs.txt", FileMode.Append))
                    {

                        fs.Write(bytes, 0, bytes.Length);
                    }

                    Thread.Sleep(100);

                }
                catch (Exception ex)
                {
                    return;

                }
            }      
        
        }

    }
}
