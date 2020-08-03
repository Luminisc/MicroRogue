using System;
using MicroRogue.Core.Input;

namespace MicroRogue.Console
{
    public static class InputMapper
    {
        public static VirtualKey ToVirtualKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    return VirtualKey.DPadUp;
                case ConsoleKey.DownArrow:
                    return VirtualKey.DPadDown;
                case ConsoleKey.LeftArrow:
                    return VirtualKey.DPadLeft;
                case ConsoleKey.RightArrow:
                    return VirtualKey.DPadRight;
                default:
                    return VirtualKey.Unknown;
            }
        }
    }
}
