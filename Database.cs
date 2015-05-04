using System.Collections.Generic;

namespace Dargon.Audits {
   public interface Database {
      void Add(AuditEvent auditEvent);
   }
}
