// This is an example file.
// Actual implementation is private.

namespace YoutubeChatBotV2.Models
{
    public enum FilterType
    {
        BlacklistWords,    // Yasaklı kelimeler
        ExcessCaps,        // Aşırı büyük harf
        ExcessEmotes,      // Aşırı emoji
        Links,             // Linkler
        ExcessSymbols,     // Aşırı sembol
        Repetitions        // Tekrar eden mesajlar
    }

    public enum PunishmentType
    {
        Ignore,     // Yoksay (sadece logla)
        Warning,    // Uyarı mesajı gönder
        Timeout,    // Belirli süre sustur
        Ban         // Kalıcı ban
    }
}
