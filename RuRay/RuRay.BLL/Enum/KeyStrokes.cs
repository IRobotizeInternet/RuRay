using System.ComponentModel;

namespace RuRay.BLL.Contracts
{
    // If you add or remove keystrokes from here you 
    // must update enum in the RuRay.BLL.Contracts KeyStrokes
    public enum KeyStrokes
    {
        /// <summary>
        /// Defines the BACKSPACE.
        /// </summary>
        [Description("{BACKSPACE},")] BACKSPACE = 1,

        /// <summary>
        /// Defines the BREAK.
        /// </summary>
        [Description("{BREAK}")] BREAK = 2,

        /// <summary>
        /// Defines the CAPS_LOCK.
        /// </summary>
        [Description("{CAPSLOCK}")] CAPS_LOCK = 3,

        /// <summary>
        /// Defines the DELETE.
        /// </summary>
        [Description("{DELETE}")] DELETE = 4,

        /// <summary>
        /// Defines the DOWN_ARROW.
        /// </summary>
        [Description("{DOWN}")] DOWN_ARROW = 5,

        /// <summary>
        /// Defines the END.
        /// </summary>
        [Description("{END}")] END = 6,

        /// <summary>
        /// Defines the ENTER.
        /// </summary>
        [Description("{ENTER}")] ENTER = 7,

        /// <summary>
        /// Defines the ESC.
        /// </summary>
        [Description("{ESC}")] ESC = 8,

        /// <summary>
        /// Defines the HELP.
        /// </summary>
        [Description("{HELP}")] HELP = 9,

        /// <summary>
        /// Defines the HOME.
        /// </summary>
        [Description("{HOME}")] HOME = 10,

        /// <summary>
        /// Defines the INSERT.
        /// </summary>
        [Description("{INSERT}")] INSERT = 11,

        /// <summary>
        /// Defines the LEFT_ARROW.
        /// </summary>
        [Description("{LEFT}")] LEFT_ARROW = 12,

        /// <summary>
        /// Defines the NUM_LOCK.
        /// </summary>
        [Description("{NUMLOCK}")] NUM_LOCK = 13,

        /// <summary>
        /// Defines the PAGE_DOWN.
        /// </summary>
        [Description("{PGDN}")] PAGE_DOWN = 14,

        /// <summary>
        /// Defines the PAGE_UP.
        /// </summary>
        [Description("{PGUP}")] PAGE_UP = 15,

        /// <summary>
        /// Defines the PRINT_SCREEN.
        /// </summary>
        [Description("{PRTSC}")] PRINT_SCREEN = 16,

        /// <summary>
        /// Defines the RIGHT_ARROW.
        /// </summary>
        [Description("{RIGHT}")] RIGHT_ARROW = 17,

        /// <summary>
        /// Defines the SCROLL_LOCK.
        /// </summary>
        [Description("{SCROLLLOCK}")] SCROLL_LOCK = 18,

        /// <summary>
        /// Defines the TAB.
        /// </summary>
        [Description("{TAB}")] TAB = 19,

        /// <summary>
        /// Defines the UP_ARROW.
        /// </summary>
        [Description("{UP}")] UP_ARROW = 20,

        /// <summary>
        /// Defines the F1.
        /// </summary>
        [Description("{F1}")] F1 = 21,

        /// <summary>
        /// Defines the F2.
        /// </summary>
        [Description("{F2}")] F2 = 22,

        /// <summary>
        /// Defines the F3.
        /// </summary>
        [Description("{F3}")] F3 = 23,

        /// <summary>
        /// Defines the F4.
        /// </summary>
        [Description("{F4}")] F4 = 24,

        /// <summary>
        /// Defines the F5.
        /// </summary>
        [Description("{F5}")] F5 = 25,

        /// <summary>
        /// Defines the F6.
        /// </summary>
        [Description("{F6}")] F6 = 26,

        /// <summary>
        /// Defines the F7.
        /// </summary>
        [Description("{F7}")] F7 = 27,

        /// <summary>
        /// Defines the F8.
        /// </summary>
        [Description("{F8}")] F8 = 28,

        /// <summary>
        /// Defines the F9.
        /// </summary>
        [Description("{F9}")] F9 = 29,

        /// <summary>
        /// Defines the F10.
        /// </summary>
        [Description("{F10}")] F10 = 30,

        /// <summary>
        /// Defines the F11.
        /// </summary>
        [Description("{F11}")] F11 = 31,

        /// <summary>
        /// Defines the F12.
        /// </summary>
        [Description("{F12}")] F12 = 32,

        /// <summary>
        /// Defines the F13.
        /// </summary>
        [Description("{F13}")] F13 = 33,

        /// <summary>
        /// Defines the F14.
        /// </summary>
        [Description("{F14}")] F14 = 34,

        /// <summary>
        /// Defines the F15.
        /// </summary>
        [Description("{F15}")] F15 = 35,

        /// <summary>
        /// Defines the F16.
        /// </summary>
        [Description("{F16}")] F16 = 36,

        /// <summary>
        /// Defines the Keypad_Add.
        /// </summary>
        [Description("{ADD}")] Keypad_Add = 37,

        /// <summary>
        /// Defines the Keypad_Subtract.
        /// </summary>
        [Description("{SUBTRACT}")] Keypad_Subtract = 38,

        /// <summary>
        /// Defines the Keypad_Multiply.
        /// </summary>
        [Description("{MULTIPLY}")] Keypad_Multiply = 39,

        /// <summary>
        /// Defines the Keypad_Divide.
        /// </summary>
        [Description("{DIVIDE}")] Keypad_Divide = 40,

        /// <summary>
        /// Defines the Key.
        /// </summary>
        [Description("Code")] Key = 41,

        /// <summary>
        /// Defines the SHIFT.
        /// </summary>
        [Description("+")] SHIFT = 42,

        /// <summary>
        /// Defines the CTRL.
        /// </summary>
        [Description("^")] CTRL = 43
    }
}
