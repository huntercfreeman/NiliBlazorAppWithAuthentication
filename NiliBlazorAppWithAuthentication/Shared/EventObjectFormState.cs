using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiliBlazorAppWithAuthentication.Shared
{
    public class EventObjectFormState
    {
        public double XCoordinate { get; set; }
        public double YCoordinate { get; set; }
        public bool IsDisplayed { get; set; }


        public event EventHandler ReRenderEventHandler;
        public void ReRenderEventInvoke(EventArgs e)
        {
            EventHandler handler = ReRenderEventHandler;
            handler?.Invoke(this, e);
        }
    }
}
