namespace Dargon.Audits {
   public interface AuditEventBus : EventBus<AuditEvent> {
      void Post(AuditEventType eventType, string eventKey, string message, string data = null);
   }
}
