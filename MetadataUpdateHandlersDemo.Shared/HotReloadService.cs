#if NET6_0_OR_GREATER && DEBUG
[assembly: System.Reflection.Metadata.MetadataUpdateHandlerAttribute(typeof(MetadataUpdateHandlersDemo.Shared.HotReloadService))]
namespace MetadataUpdateHandlersDemo.Shared
{
    public static class HotReloadService
    {
        public static event Action<Type[]?>? UpdateApplicationEvent;

        static HotReloadService()
        {
        }

        internal static void UpdateApplication(Type[] types)
        {
            if ((types != null && types.Length > 0 && types[0] != null))
            {
                UpdateApplicationEvent?.Invoke(types);

                //DispatchIfNecessary(() =>
                //{
                //    UpdateApplicationEvent?.Invoke(types);
                //});
            }
        }

        internal static void DispatchIfNecessary(Action action)
        {
            //if (!Application.Current.Dispatcher.CheckAccess())
            //    Application.Current.Dispatcher.Invoke(action);
            //else
            //    action.Invoke();
        }
    }
}
#endif