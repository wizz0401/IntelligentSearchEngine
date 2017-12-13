using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizSE.Common.StateMachine
{
  public   interface  Event
    {
      string GetType();

      string GetName();
    }
}
