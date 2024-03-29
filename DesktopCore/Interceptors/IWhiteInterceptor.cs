﻿

using Castle.DynamicProxy;

namespace BismiSolutions.DesktopCore.Interceptors
{
    public interface IWhiteInterceptor
    {
        void PreProcess(IInvocation invocation, CoreInterceptContext context);
        void PostProcess(IInvocation invocation, CoreInterceptContext context);
    }
}
