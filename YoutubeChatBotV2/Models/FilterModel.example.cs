// This is an example file.
// Actual implementation is private.

using System.Collections.Generic;

namespace YoutubeChatBotV2.Models
{
    /// <summary>
    /// Moderasyon filter modeli
    /// </summary>
    public class FilterModel
    {
        // Temel Bilgiler
        public FilterType Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }

        // Durum
        public bool IsEnabled { get; set; }

        // Ceza Ayarları
        public PunishmentType Punishment { get; set; }
        public int TimeoutDuration { get; set; }
        public string WarningMessage { get; set; }

        // Filter'a Özel Ayarlar
        public FilterSettings Settings { get; set; }
    }

    /// <summary>
    /// Filter ayarları
    /// </summary>
    public class FilterSettings
    {
        public List<string> Blacklist { get; set; }
        public List<string> Whitelist { get; set; }
        public int Threshold { get; set; }
        public int MinLength { get; set; }
        public bool CaseSensitive { get; set; }
        public bool PartialMatch { get; set; }
        public bool AllowYouTubeLinks { get; set; }
        public int RepeatCount { get; set; }
        public int TimeWindow { get; set; }
    }
}
