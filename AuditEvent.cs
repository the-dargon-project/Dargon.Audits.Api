using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dargon.Audits.Api {
   public class AuditEvent {
      private readonly AuditEventType eventType;
      private readonly string eventKey;
      private readonly string eventMessage;
      private readonly string eventData;

      public AuditEvent(AuditEventType eventType, string eventKey, string eventMessage, string eventData) {
         this.eventType = eventType;
         this.eventKey = eventKey;
         this.eventMessage = eventMessage;
         this.eventData = eventData;
      }

      public AuditEventType EventType { get { return eventType; } }
      public string EventKey { get { return eventKey; } }
      public string EventMessage { get { return eventMessage; } }
      public string EventData { get { return eventData; } }
   }
}
