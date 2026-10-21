using Robust.Shared.Configuration;

namespace Content.Shared._DV.CCVars;

/// <summary>
/// DeltaV specific cvars.
/// </summary>
[CVarDefs]
// ReSharper disable once InconsistentNaming - Shush you
public sealed partial class DCCVars
{

    /// <summary>
    /// A string containing a list of newline-separated strings to be highlighted in the chat. Use this instead of Wizden's CVar.
    /// </summary>
    public static readonly CVarDef<string> ChatHighlights =
        CVarDef.Create("deltav.chat.highlights",
            "",
            CVar.CLIENTONLY | CVar.ARCHIVE,
            "A list of newline-separated strings to be highlighted in the chat.");

    /// <summary>
    /// An option to toggle the automatic filling of the highlights with the character's info, if available.
    /// </summary>
    [Obsolete("Use CCVar.ChatAutoFillHighlights instead.")]
    public static readonly CVarDef<bool> ChatAutoFillHighlights =
        CVarDef.Create("deltav.chat.auto_fill_highlights",
            false,
            CVar.CLIENTONLY | CVar.ARCHIVE,
            "Toggles automatically filling the highlights with the character's information.");

    /// <summary>
    /// The color in which the highlights will be displayed.
    /// </summary>
    [Obsolete("Use CCVar.ChatHighlightsColor instead.")]
    public static readonly CVarDef<string> ChatHighlightsColor =
        CVarDef.Create("deltav.chat.highlights_color",
            "#17FFC1FF",
            CVar.CLIENTONLY | CVar.ARCHIVE,
            "The color in which the highlights will be displayed.");


}
