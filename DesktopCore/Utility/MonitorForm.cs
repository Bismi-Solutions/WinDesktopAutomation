using System.Drawing;
using System.Windows.Forms;

namespace BismiSolutions.DesktopCore.Utility
{
    public class MonitorForm : Form
    {
        public MonitorForm()
        {
            Size = new Size(1, 1);
        }

        protected override bool ProcessKeyMessage(ref Message m)
        {
            return base.ProcessKeyMessage(ref m);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MonitorForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "MonitorForm";
            this.Load += new System.EventHandler(this.MonitorForm_Load);
            this.ResumeLayout(false);

        }

        private void MonitorForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}