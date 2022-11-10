using System;
namespace SocketIO.Unity.Extensions
{
    internal static class DisposableExtensions
    {
        public static void TryDispose(this IDisposable disposable)
        {
            disposable?.Dispose();
        }
    }
}
