﻿using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BismiSolutions.DesktopCore.Configuration
{
    public class WhiteDefaultLoggerFactory : ILoggerFactory
    {
        private readonly LoggerLevel defaultLevel;

        public WhiteDefaultLoggerFactory(LoggerLevel defaultLevel)
        {
            this.defaultLevel = defaultLevel;
        }

        public virtual ILogger Create(Type type)
        {
            return new WhiteDefaultLogger(type.FullName, defaultLevel);
        }

        public virtual ILogger Create(string name)
        {
            return new WhiteDefaultLogger(name, defaultLevel);
        }

        public virtual ILogger Create(Type type, LoggerLevel level)
        {
            return new WhiteDefaultLogger(type.FullName, level);
        }

        public virtual ILogger Create(string name, LoggerLevel level)
        {
            return new WhiteDefaultLogger(name, level);
        }
    }
}
