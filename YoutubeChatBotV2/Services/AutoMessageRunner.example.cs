// This is an example file.
// Actual implementation is private.

using System;
using System.Collections.Generic;
using YoutubeChatBotV2.Models;

namespace YoutubeChatBotV2.Services
{
    /// <summary>
    /// Otomatik mesaj zamanlayıcı
    /// </summary>
    public class AutoMessageRunner : IDisposable
    {
        /// <summary>
        /// Tüm otomatik mesaj timerlarını başlatır
        /// </summary>
        public void Start(List<AutoMessageModel> messages, Action<string> sendMessage)
        {
            // Her mesaj için System.Timers.Timer oluşturur
            // Interval sürede sendMessage callback'ini çağırır
        }

        /// <summary>
        /// Tüm timerları durdurur
        /// </summary>
        public void Stop()
        {
            // Timer'ları durdur ve dispose et
        }

        public void Dispose()
        {
            Stop();
        }
    }
}
