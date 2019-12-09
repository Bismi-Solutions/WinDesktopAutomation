﻿

using BismiSolutions.DesktopCore.Configuration;
using System.Diagnostics;
using System.Windows.Automation;

namespace BismiSolutions.DesktopCore.UIItems.Actions
{
    public class ProcessActionListener : ActionListener
    {
        private readonly Process process;

        public ProcessActionListener(AutomationElement automationElement)
        {
            int processId = automationElement.Current.ProcessId;
            process = Process.GetProcessById(processId);
        }

        public virtual void ActionPerforming(UIItem uiItem) { }

        public virtual void ActionPerformed(Action action)
        {
            process.WaitForInputIdle(CoreAppXmlConfiguration.Instance.BusyTimeout);
        }
    }
}
