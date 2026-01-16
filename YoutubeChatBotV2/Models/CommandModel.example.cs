// This is an example file.
// Actual implementation is private.

namespace YoutubeChatBotV2.Models
{
    /// <summary>
    /// Chat komutu modeli
    /// </summary>
    public class CommandModel
    {
        public string Prefix { get; set; }    // Örn: "!"
        public string Command { get; set; }   // Örn: "discord"
        public string Response { get; set; }  // Örn: "Discord: discord.gg/xxx"
    }
}
