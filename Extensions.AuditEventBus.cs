using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dargon.Audits.Api {
   public static class Extensions {
      public static void Debug(this AuditEventBus bus, string eventKey, string message, string data) {
         bus.Event(AuditEventType.Debug, eventKey, message, data);
      }

      public static void Verbose(this AuditEventBus bus, string eventKey, string message, string data = null) {
         bus.Event(AuditEventType.Verbose, eventKey, message, data);
      }

      public static void Notice(this AuditEventBus bus, string eventKey, string message, string data = null) {
         bus.Event(AuditEventType.Notice, eventKey, message, data);
      }

      public static void Warning(this AuditEventBus bus, string eventKey, string message, string data = null) {
         bus.Event(AuditEventType.Warning, eventKey, message, data);
      }

      public static void Error(this AuditEventBus bus, string eventKey, string message, string data = null) {
         bus.Event(AuditEventType.Error, eventKey, message, data);
      }

      public static void Fatal(this AuditEventBus bus, string eventKey, string message, string data = null) {
         bus.Event(AuditEventType.Fatal, eventKey, message, data);
      }
   }
}
