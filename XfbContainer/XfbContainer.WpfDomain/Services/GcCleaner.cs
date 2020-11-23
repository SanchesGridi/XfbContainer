using System;
using System.Runtime;

namespace XfbContainer.WpfDomain.Services
{
    public sealed class GcCleaner : ICleaner
    {
        public void ClearMemory()
        {
            GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
            GC.Collect();
        }
    }
}
