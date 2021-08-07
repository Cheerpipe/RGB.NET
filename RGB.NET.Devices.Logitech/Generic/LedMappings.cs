﻿using RGB.NET.Core;

namespace RGB.NET.Devices.Logitech
{
    /// <summary>
    /// Contains mappings for <see cref="LedId"/> to <see cref="LogitechDeviceCaps"/>.
    /// </summary>
    public static class LedMappings
    {
        /// <summary>
        /// Gets the mapping for per key devices.
        /// </summary>
        public static LedMapping<LogitechLedId> PerKey { get; } = new()
        {
            { LedId.Keyboard_Escape, LogitechLedId.ESC },
            { LedId.Keyboard_F1, LogitechLedId.F1 },
            { LedId.Keyboard_F2, LogitechLedId.F2},
            { LedId.Keyboard_F3, LogitechLedId.F3 },
            { LedId.Keyboard_F4, LogitechLedId.F4 },
            { LedId.Keyboard_F5, LogitechLedId.F5 },
            { LedId.Keyboard_F6, LogitechLedId.F6 },
            { LedId.Keyboard_F7, LogitechLedId.F7 },
            { LedId.Keyboard_F8, LogitechLedId.F8 },
            { LedId.Keyboard_F9, LogitechLedId.F9 },
            { LedId.Keyboard_F10, LogitechLedId.F10 },
            { LedId.Keyboard_F11, LogitechLedId.F11 },
            { LedId.Keyboard_F12, LogitechLedId.F12 },
            { LedId.Keyboard_PrintScreen, LogitechLedId.PRINT_SCREEN },
            { LedId.Keyboard_ScrollLock, LogitechLedId.SCROLL_LOCK },
            { LedId.Keyboard_PauseBreak, LogitechLedId.PAUSE_BREAK },

            { LedId.Keyboard_GraveAccentAndTilde, LogitechLedId.TILDE },
            { LedId.Keyboard_1, LogitechLedId.ONE },
            { LedId.Keyboard_2, LogitechLedId.TWO },
            { LedId.Keyboard_3, LogitechLedId.THREE },
            { LedId.Keyboard_4, LogitechLedId.FOUR },
            { LedId.Keyboard_5, LogitechLedId.FIVE },
            { LedId.Keyboard_6, LogitechLedId.SIX },
            { LedId.Keyboard_7, LogitechLedId.SEVEN },
            { LedId.Keyboard_8, LogitechLedId.EIGHT },
            { LedId.Keyboard_9, LogitechLedId.NINE },
            { LedId.Keyboard_0, LogitechLedId.ZERO },
            { LedId.Keyboard_MinusAndUnderscore, LogitechLedId.MINUS },
            { LedId.Keyboard_EqualsAndPlus, LogitechLedId.EQUALS },
            { LedId.Keyboard_Backspace, LogitechLedId.BACKSPACE },
            { LedId.Keyboard_Insert, LogitechLedId.INSERT },
            { LedId.Keyboard_Home, LogitechLedId.HOME },
            { LedId.Keyboard_PageUp, LogitechLedId.PAGE_UP },
            { LedId.Keyboard_NumLock, LogitechLedId.NUM_LOCK },
            { LedId.Keyboard_NumSlash, LogitechLedId.NUM_SLASH },
            { LedId.Keyboard_NumAsterisk, LogitechLedId.NUM_ASTERISK },
            { LedId.Keyboard_NumMinus, LogitechLedId.NUM_MINUS },

            { LedId.Keyboard_Tab, LogitechLedId.TAB },
            { LedId.Keyboard_Q, LogitechLedId.Q },
            { LedId.Keyboard_W, LogitechLedId.W },
            { LedId.Keyboard_E, LogitechLedId.E },
            { LedId.Keyboard_R, LogitechLedId.R },
            { LedId.Keyboard_T, LogitechLedId.T },
            { LedId.Keyboard_Y, LogitechLedId.Y },
            { LedId.Keyboard_U, LogitechLedId.U },
            { LedId.Keyboard_I, LogitechLedId.I },
            { LedId.Keyboard_O, LogitechLedId.O },
            { LedId.Keyboard_P, LogitechLedId.P },
            { LedId.Keyboard_BracketLeft, LogitechLedId.OPEN_BRACKET },
            { LedId.Keyboard_BracketRight, LogitechLedId.CLOSE_BRACKET },
            { LedId.Keyboard_Backslash, LogitechLedId.BACKSLASH },
            { LedId.Keyboard_Delete, LogitechLedId.KEYBOARD_DELETE },
            { LedId.Keyboard_End, LogitechLedId.END },
            { LedId.Keyboard_PageDown, LogitechLedId.PAGE_DOWN },
            { LedId.Keyboard_Num7, LogitechLedId.NUM_SEVEN },
            { LedId.Keyboard_Num8, LogitechLedId.NUM_EIGHT },
            { LedId.Keyboard_Num9, LogitechLedId.NUM_NINE },
            { LedId.Keyboard_NumPlus, LogitechLedId.NUM_PLUS },

            { LedId.Keyboard_CapsLock, LogitechLedId.CAPS_LOCK },
            { LedId.Keyboard_A, LogitechLedId.A },
            { LedId.Keyboard_S, LogitechLedId.S },
            { LedId.Keyboard_D, LogitechLedId.D },
            { LedId.Keyboard_F, LogitechLedId.F },
            { LedId.Keyboard_G, LogitechLedId.G },
            { LedId.Keyboard_H, LogitechLedId.H },
            { LedId.Keyboard_J, LogitechLedId.J },
            { LedId.Keyboard_K, LogitechLedId.K },
            { LedId.Keyboard_L, LogitechLedId.L },
            { LedId.Keyboard_SemicolonAndColon, LogitechLedId.SEMICOLON },
            { LedId.Keyboard_ApostropheAndDoubleQuote, LogitechLedId.APOSTROPHE },
            { LedId.Keyboard_NonUsTilde, LogitechLedId.ISO_TILDE },
            { LedId.Keyboard_Enter, LogitechLedId.ENTER },
            { LedId.Keyboard_Num4, LogitechLedId.NUM_FOUR },
            { LedId.Keyboard_Num5, LogitechLedId.NUM_FIVE },
            { LedId.Keyboard_Num6, LogitechLedId.NUM_SIX },

            { LedId.Keyboard_LeftShift, LogitechLedId.LEFT_SHIFT },
            { LedId.Keyboard_NonUsBackslash, LogitechLedId.ISO_BACKSLASH },
            { LedId.Keyboard_Z, LogitechLedId.Z },
            { LedId.Keyboard_X, LogitechLedId.X },
            { LedId.Keyboard_C, LogitechLedId.C },
            { LedId.Keyboard_V, LogitechLedId.V },
            { LedId.Keyboard_B, LogitechLedId.B },
            { LedId.Keyboard_N, LogitechLedId.N },
            { LedId.Keyboard_M, LogitechLedId.M },
            { LedId.Keyboard_CommaAndLessThan, LogitechLedId.COMMA },
            { LedId.Keyboard_PeriodAndBiggerThan, LogitechLedId.PERIOD },
            { LedId.Keyboard_SlashAndQuestionMark, LogitechLedId.FORWARD_SLASH },
            { LedId.Keyboard_RightShift, LogitechLedId.RIGHT_SHIFT },
            { LedId.Keyboard_ArrowUp, LogitechLedId.ARROW_UP },
            { LedId.Keyboard_Num1, LogitechLedId.NUM_ONE },
            { LedId.Keyboard_Num2, LogitechLedId.NUM_TWO },
            { LedId.Keyboard_Num3, LogitechLedId.NUM_THREE },
            { LedId.Keyboard_NumEnter, LogitechLedId.NUM_ENTER },

            { LedId.Keyboard_LeftCtrl, LogitechLedId.LEFT_CONTROL },
            { LedId.Keyboard_LeftGui, LogitechLedId.LEFT_WINDOWS },
            { LedId.Keyboard_LeftAlt, LogitechLedId.LEFT_ALT },
            { LedId.Keyboard_Space, LogitechLedId.SPACE },
            { LedId.Keyboard_RightAlt, LogitechLedId.RIGHT_ALT },
            { LedId.Keyboard_RightGui, LogitechLedId.RIGHT_WINDOWS },
            { LedId.Keyboard_Application, LogitechLedId.APPLICATION_SELECT },
            { LedId.Keyboard_RightCtrl, LogitechLedId.RIGHT_CONTROL },
            { LedId.Keyboard_ArrowLeft, LogitechLedId.ARROW_LEFT },
            { LedId.Keyboard_ArrowDown, LogitechLedId.ARROW_DOWN },
            { LedId.Keyboard_ArrowRight, LogitechLedId.ARROW_RIGHT },
            { LedId.Keyboard_Num0, LogitechLedId.NUM_ZERO },
            { LedId.Keyboard_NumPeriodAndDelete, LogitechLedId.NUM_PERIOD },

            { LedId.Keyboard_Programmable1, LogitechLedId.G_1 },
            { LedId.Keyboard_Programmable2, LogitechLedId.G_2 },
            { LedId.Keyboard_Programmable3, LogitechLedId.G_3 },
            { LedId.Keyboard_Programmable4, LogitechLedId.G_4 },
            { LedId.Keyboard_Programmable5, LogitechLedId.G_5 },
            { LedId.Keyboard_Programmable6, LogitechLedId.G_6 },
            { LedId.Keyboard_Programmable7, LogitechLedId.G_7 },
            { LedId.Keyboard_Programmable8, LogitechLedId.G_8 },
            { LedId.Keyboard_Programmable9, LogitechLedId.G_9 },
            { LedId.Logo, LogitechLedId.G_LOGO },
            { LedId.Keyboard_Custom1, LogitechLedId.G_BADGE },
        };

        /// <summary>
        /// Gets the mapping for per device devices.
        /// </summary>
        public static LedMapping<int> Device { get; } = new()
        {
            { LedId.Custom1, 0 }
        };

        /// <summary>
        /// Gets the mapping for per zone keyboards.
        /// </summary>
        public static LedMapping<int> ZoneKeyboard { get; } = new()
        {
            { LedId.Keyboard_Programmable1, 0 },
            { LedId.Keyboard_Programmable2, 1 },
            { LedId.Keyboard_Programmable3, 2 },
            { LedId.Keyboard_Programmable4, 3 },
            { LedId.Keyboard_Programmable5, 4 },
            { LedId.Keyboard_Programmable6, 5 },
            { LedId.Keyboard_Programmable7, 6 },
            { LedId.Keyboard_Programmable8, 7 },
            { LedId.Keyboard_Programmable9, 8 },
            { LedId.Keyboard_Programmable10, 9 },
            { LedId.Keyboard_Programmable11, 10 },
            { LedId.Keyboard_Programmable12, 11 },
            { LedId.Keyboard_Programmable13, 12 },
            { LedId.Keyboard_Programmable14, 13 },
            { LedId.Keyboard_Programmable15, 14 },
            { LedId.Keyboard_Programmable16, 15 },
            { LedId.Keyboard_Programmable17, 16 },
            { LedId.Keyboard_Programmable18, 17 },
            { LedId.Keyboard_Programmable19, 18 },
            { LedId.Keyboard_Programmable20, 19 },
            { LedId.Keyboard_Programmable21, 20 },
            { LedId.Keyboard_Programmable22, 21 },
            { LedId.Keyboard_Programmable23, 22 },
            { LedId.Keyboard_Programmable24, 23 },
            { LedId.Keyboard_Programmable25, 24 },
            { LedId.Keyboard_Programmable26, 25 },
            { LedId.Keyboard_Programmable27, 26 },
            { LedId.Keyboard_Programmable28, 27 },
            { LedId.Keyboard_Programmable29, 28 },
            { LedId.Keyboard_Programmable30, 29 },
            { LedId.Keyboard_Programmable31, 30 },
            { LedId.Keyboard_Programmable32, 31 },
        };

        /// <summary>
        /// Gets the mapping for per zone mice.
        /// </summary>
        public static LedMapping<int> ZoneMouse { get; } = new()
        {
            { LedId.Mouse1, 0 },
            { LedId.Mouse2, 1 },
            { LedId.Mouse3, 2 },
            { LedId.Mouse4, 3 },
            { LedId.Mouse5, 4 },
            { LedId.Mouse6, 5 },
            { LedId.Mouse7, 6 },
            { LedId.Mouse8, 7 },
            { LedId.Mouse9, 8 },
            { LedId.Mouse10, 9 },
            { LedId.Mouse11, 10 },
            { LedId.Mouse12, 11 },
            { LedId.Mouse13, 12 },
            { LedId.Mouse14, 13 },
            { LedId.Mouse15, 14 },
            { LedId.Mouse16, 15 },
            { LedId.Mouse17, 16 },
            { LedId.Mouse18, 17 },
            { LedId.Mouse19, 18 },
            { LedId.Mouse20, 19 },
            { LedId.Mouse21, 20 },
            { LedId.Mouse22, 21 },
            { LedId.Mouse23, 22 },
            { LedId.Mouse24, 23 },
            { LedId.Mouse25, 24 },
            { LedId.Mouse26, 25 },
            { LedId.Mouse27, 26 },
            { LedId.Mouse28, 27 },
            { LedId.Mouse29, 28 },
            { LedId.Mouse30, 29 },
            { LedId.Mouse31, 30 },
            { LedId.Mouse32, 31 },
        };

        /// <summary>
        /// Gets the mapping for per zone headsets.
        /// </summary>
        public static LedMapping<int> ZoneHeadset { get; } = new()
        {
            { LedId.Headset1, 0 },
            { LedId.Headset2, 1 },
            { LedId.Headset3, 2 },
            { LedId.Headset4, 3 },
            { LedId.Headset5, 4 },
            { LedId.Headset6, 5 },
            { LedId.Headset7, 6 },
            { LedId.Headset8, 7 },
            { LedId.Headset9, 8 },
            { LedId.Headset10, 9 },
            { LedId.Headset11, 10 },
            { LedId.Headset12, 11 },
            { LedId.Headset13, 12 },
            { LedId.Headset14, 13 },
            { LedId.Headset15, 14 },
            { LedId.Headset16, 15 },
            { LedId.Headset17, 16 },
            { LedId.Headset18, 17 },
            { LedId.Headset19, 18 },
            { LedId.Headset20, 19 },
            { LedId.Headset21, 20 },
            { LedId.Headset22, 21 },
            { LedId.Headset23, 22 },
            { LedId.Headset24, 23 },
            { LedId.Headset25, 24 },
            { LedId.Headset26, 25 },
            { LedId.Headset27, 26 },
            { LedId.Headset28, 27 },
            { LedId.Headset29, 28 },
            { LedId.Headset30, 29 },
            { LedId.Headset31, 30 },
            { LedId.Headset32, 31 },
        };

        /// <summary>
        /// Gets the mapping for per zone mousepads.
        /// </summary>
        public static LedMapping<int> ZoneMousepad { get; } = new()
        {
            { LedId.Mousepad1, 0 },
            { LedId.Mousepad2, 1 },
            { LedId.Mousepad3, 2 },
            { LedId.Mousepad4, 3 },
            { LedId.Mousepad5, 4 },
            { LedId.Mousepad6, 5 },
            { LedId.Mousepad7, 6 },
            { LedId.Mousepad8, 7 },
            { LedId.Mousepad9, 8 },
            { LedId.Mousepad10, 9 },
            { LedId.Mousepad11, 10 },
            { LedId.Mousepad12, 11 },
            { LedId.Mousepad13, 12 },
            { LedId.Mousepad14, 13 },
            { LedId.Mousepad15, 14 },
            { LedId.Mousepad16, 15 },
            { LedId.Mousepad17, 16 },
            { LedId.Mousepad18, 17 },
            { LedId.Mousepad19, 18 },
            { LedId.Mousepad20, 19 },
            { LedId.Mousepad21, 20 },
            { LedId.Mousepad22, 21 },
            { LedId.Mousepad23, 22 },
            { LedId.Mousepad24, 23 },
            { LedId.Mousepad25, 24 },
            { LedId.Mousepad26, 25 },
            { LedId.Mousepad27, 26 },
            { LedId.Mousepad28, 27 },
            { LedId.Mousepad29, 28 },
            { LedId.Mousepad30, 29 },
            { LedId.Mousepad31, 30 },
            { LedId.Mousepad32, 31 },
        };

        /// <summary>
        /// Gets the mapping for per zone speakers.
        /// </summary>
        public static LedMapping<int> ZoneSpeaker { get; } = new()
        {
            { LedId.Speaker1, 0 },
            { LedId.Speaker2, 1 },
            { LedId.Speaker3, 2 },
            { LedId.Speaker4, 3 },
            { LedId.Speaker5, 4 },
            { LedId.Speaker6, 5 },
            { LedId.Speaker7, 6 },
            { LedId.Speaker8, 7 },
            { LedId.Speaker9, 8 },
            { LedId.Speaker10, 9 },
            { LedId.Speaker11, 10 },
            { LedId.Speaker12, 11 },
            { LedId.Speaker13, 12 },
            { LedId.Speaker14, 13 },
            { LedId.Speaker15, 14 },
            { LedId.Speaker16, 15 },
            { LedId.Speaker17, 16 },
            { LedId.Speaker18, 17 },
            { LedId.Speaker19, 18 },
            { LedId.Speaker20, 19 },
            { LedId.Speaker21, 20 },
            { LedId.Speaker22, 21 },
            { LedId.Speaker23, 22 },
            { LedId.Speaker24, 23 },
            { LedId.Speaker25, 24 },
            { LedId.Speaker26, 25 },
            { LedId.Speaker27, 26 },
            { LedId.Speaker28, 27 },
            { LedId.Speaker29, 28 },
            { LedId.Speaker30, 29 },
            { LedId.Speaker31, 30 },
            { LedId.Speaker32, 31 },
        };
    }
}
