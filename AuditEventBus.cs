using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dargon.Audits.Api {
   public interface AuditEventBus : EventBus<AuditEvent> {
      void Post(AuditEventType eventType, string eventKey, string message, string data = null);
   }
}
