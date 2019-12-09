using BismiSolutions.DesktopCore.Bricks;
using BismiSolutions.DesktopCore.Interceptors;
using BismiSolutions.DesktopCore.UIItems;
using BismiSolutions.DesktopCore.UIItems.Actions;

namespace BismiSolutions.DesktopCore.Factory
{
    public static class UIItemProxyFactory
    {
        public static IUIItem Create(IUIItem item, ActionListener actionListener)
        {
            return (IUIItem) DynamicProxyGenerator.Instance.CreateProxy(item.GetType(), new CoreInterceptor(item, actionListener));
        }
    }
}