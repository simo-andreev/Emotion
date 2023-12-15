#region Using

using System;

#endregion

namespace ImGuiNET
{
    [Flags]
    public enum ImGuiComboFlags
    {
        None = 0,
        PopupAlignLeft = 1,
        HeightSmall = 2,
        HeightRegular = 4,
        HeightLarge = 8,
        HeightLargest = 16,
        NoArrowButton = 32,
        NoPreview = 64,
        HeightMask = 30,
    }
}