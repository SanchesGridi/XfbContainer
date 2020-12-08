using System;
using System.Threading.Tasks;

namespace XfbContainer.CommonTypes.Extensions
{
    public static class TaskExtensions
    {
        public static async void CtorAwait(this Task @this, Action<Exception> @catch = null, bool @continue = false)
        {
            try
            {
                await @this.ConfigureAwait(continueOnCapturedContext: @continue);
            }
            catch (Exception ex)
            {
                @catch?.Invoke(ex);
            }
        }
    }
}
