using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dargon.Audits {
   public interface EventBus<T> {
      void Post(T obj);

      event EventBusHandler<T> EventPosted;
   }

   public delegate void EventBusHandler<T>(EventBus<T> sender, T e);
}
