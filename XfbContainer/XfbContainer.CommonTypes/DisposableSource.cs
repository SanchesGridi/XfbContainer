using System;
using XfbContainer.CommonTypes.Extensions;

namespace XfbContainer.CommonTypes
{
    public class DisposableSource : IDisposable
    {
        private readonly Action _dispose;

        public DisposableSource(Action dispose)
        {
            _dispose = dispose.VerifyReferenceAndSet(nameof(dispose), nameof(DisposableSource), "Exception in \"constructor\" method");
        }

        public void Dispose()
        {
            _dispose.Invoke();
        }
    }
}
