using NiliBlazorAppWithAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiliBlazorAppWithAuthentication.Shared
{
    public class MedicationDragEventState
    {
        public Medication MedicationBeingDragged { get; set; }

        public event EventHandler DragStartEventHandler;
        public void ReRenderEventInvoke(EventArgs e)
        {
            EventHandler handler = DragStartEventHandler;
            handler?.Invoke(this, e);
        }
    }
}
