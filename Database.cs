using System.Collections.Generic;

namespace Dargon.Audits {
   public interface Database {
      void Add(AuditEvent auditEvent);
      IList<AuditEvent> Get();
      IList<AuditEvent> Get(int index);
   }
}