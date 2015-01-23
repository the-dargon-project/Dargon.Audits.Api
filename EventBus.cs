namespace Dargon.Audits {
   public interface EventBus<T> {
      void Post(T obj);

      event EventBusHandler<T> EventPosted;
   }

   public delegate void EventBusHandler<T>(EventBus<T> sender, T e);
}
