// This is an example file.
// Actual implementation is private.

using System.Collections.Generic;
using YoutubeChatBotV2.Models;

namespace YoutubeChatBotV2.Services
{
    /// <summary>
    /// Filter JSON persist servisi
    /// </summary>
    public static class FilterService
    {
        // Load filters from JSON file
        public static FilterConfig Load() { /* ... */ }
        
        // Save filters to JSON file
        public static void Save(FilterConfig config) { /* ... */ }
        
        // Get specific filter by type
        public static FilterModel GetFilter(FilterConfig config, FilterType type) { /* ... */ }
        
        // Update a filter and save
        public static void UpdateFilter(FilterConfig config, FilterModel filter) { /* ... */ }
    }

    /// <summary>
    /// JSON root object
    /// </summary>
    public class FilterConfig
    {
        public string Version { get; set; }
        public List<FilterModel> Filters { get; set; }
    }
}
