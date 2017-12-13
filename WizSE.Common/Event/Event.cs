using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizSE.Common.Event
{
   public  interface  Event<enum>
    {
       string GetType();

       string GetName();
    }
}
