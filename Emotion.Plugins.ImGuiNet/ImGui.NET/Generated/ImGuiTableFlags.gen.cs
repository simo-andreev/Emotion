#region Using

using System;

#endregion

namespace ImGuiNET
{
    [Flags]
    public enum ImGuiTableFlags
    {
        None = 0,
        Resizable = 1,
        Reorderable = 2,
        Hideable = 4,
        Sortable = 8,
        NoSavedSettings = 16,
        ContextMenuInBody = 32,
        RowBg = 64,
        BordersInnerH = 128,
        BordersOuterH = 256,
        BordersInnerV = 512,
        BordersOuterV = 1024,
        BordersH = 384,
        BordersV = 1536,
        BordersInner = 640,
        BordersOuter = 1280,
        Borders = 1920,
        NoBordersInBody = 2048,
        NoBordersInBodyUntilResize = 4096,
        SizingFixedFit = 8192,
        SizingFixedSame = 16384,
        SizingStretchProp = 24576,
        SizingStretchSame = 32768,
        NoHostExtendX = 65536,
        NoHostExtendY = 131072,
        NoKeepColumnsVisible = 262144,
        PreciseWidths = 524288,
        NoClip = 1048576,
        PadOuterX = 2097152,
        NoPadOuterX = 4194304,
        NoPadInnerX = 8388608,
        ScrollX = 16777216,
        ScrollY = 33554432,
        SortMulti = 67108864,
        SortTristate = 134217728,
        SizingMask = 57344,
    }
}