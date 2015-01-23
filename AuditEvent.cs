namespace Dargon.Audits {
   public class AuditEvent {
      private AuditEventType eventType;
      private string eventKey;
      private string eventMessage;
      private string eventData;

      public AuditEvent() { }

      public AuditEvent(AuditEventType eventType, string eventKey, string eventMessage, string eventData) {
         this.eventType = eventType;
         this.eventKey = eventKey;
         this.eventMessage = eventMessage;
         this.eventData = eventData;
      }

      public virtual AuditEventType EventType { get { return eventType; } set { eventType = value; } }
      public virtual string EventKey { get { return eventKey; } set { eventKey = value; } }
      public virtual string EventMessage { get { return eventMessage; } set { eventMessage = value; } }
      public virtual string EventData { get { return eventData; } set { eventData = value; } }
   }
}
