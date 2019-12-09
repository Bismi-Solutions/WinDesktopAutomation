using Castle.Core.Logging;
using Castle.DynamicProxy;
using BismiSolutions.DesktopCore.Bricks;
using BismiSolutions.DesktopCore.Configuration;
using BismiSolutions.DesktopCore.UIItems.Actions;
using System;
using BismiSolutions.DesktopCore.UIItems;

namespace BismiSolutions.DesktopCore.Interceptors
{
    public class CoreInterceptor : IInterceptor
    {
        private readonly CoreInterceptContext coreInterceptContext;
        private readonly ILogger logger = CoreAppXmlConfiguration.Instance.LoggerFactory.Create(typeof(CoreInterceptor));

        public CoreInterceptor(IUIItem uiItem, ActionListener actionListener)
        {
            coreInterceptContext = new CoreInterceptContext(uiItem, actionListener);
        }

        public virtual void Intercept(IInvocation invocation)
        {
            coreInterceptContext.VerifyUIItem();
            try
            {
                CoreAppXmlConfiguration.Instance.Interceptors.Process(invocation, coreInterceptContext);
            }
            catch (Exception)
            {
                logger.Error(DynamicProxyInterceptors.ToString(invocation));
                throw;
            }
        }

        public virtual CoreInterceptContext Context
        {
            get { return coreInterceptContext; }
        }
    }
}
