namespace Dargon.Audits {
   public static class Extensions {
      public static void Debug(this AuditEventBus bus, string eventKey, string message, string data) {
         bus.Post(AuditEventType.Debug, eventKey, message, data);
      }

      public static void Verbose(this AuditEventBus bus, string eventKey, string message, string data = null) {
         bus.Post(AuditEventType.Verbose, eventKey, message, data);
      }

      public static void Notice(this AuditEventBus bus, string eventKey, string message, string data = null) {
         bus.Post(AuditEventType.Notice, eventKey, message, data);
      }

      public static void Warning(this AuditEventBus bus, string eventKey, string message, string data = null) {
         bus.Post(AuditEventType.Warning, eventKey, message, data);
      }

      public static void Error(this AuditEventBus bus, string eventKey, string message, string data = null) {
         bus.Post(AuditEventType.Error, eventKey, message, data);
      }

      public static void Fatal(this AuditEventBus bus, string eventKey, string message, string data = null) {
         bus.Post(AuditEventType.Fatal, eventKey, message, data);
      }
   }
}
