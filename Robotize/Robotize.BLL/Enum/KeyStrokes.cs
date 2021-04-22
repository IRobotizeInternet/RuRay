using System.ComponentModel;

namespace Robotize.BLL.Contracts
{
// If you add or remove keystrokes from here you 
// must update enum in the Robotize.BLL.Contracts KeyStrokes
    public enum KeyStrokes
    {
        [Description("{BACKSPACE},")] BACKSPACE = 1,
        [Description("{BREAK}")] BREAK = 2,
        [Description("{CAPSLOCK}")] CAPS_LOCK = 3,
        [Description("{DELETE}")] DELETE = 4,
        [Description("{DOWN}")] DOWN_ARROW = 5,
        [Description("{END}")] END = 6,
        [Description("{ENTER}")] ENTER = 7,
        [Description("{ESC}")] ESC = 8,
        [Description("{HELP}")] HELP = 9,
        [Description("{HOME}")] HOME = 10,
        [Description("{INSERT}")] INSERT = 11,
        [Description("{LEFT}")] LEFT_ARROW = 12,
        [Description("{NUMLOCK}")] NUM_LOCK = 13,
        [Description("{PGDN}")] PAGE_DOWN = 14,
        [Description("{PGUP}")] PAGE_UP = 15,
        [Description("{PRTSC}")] PRINT_SCREEN = 16,
        [Description("{RIGHT}")] RIGHT_ARROW = 17,
        [Description("{SCROLLLOCK}")] SCROLL_LOCK = 18,
        [Description("{TAB}")] TAB = 19,
        [Description("{UP}")] UP_ARROW = 20,
        [Description("{F1}")] F1 = 21,
        [Description("{F2}")] F2 = 22,
        [Description("{F3}")] F3 = 23,
        [Description("{F4}")] F4 = 24,
        [Description("{F5}")] F5 = 25,
        [Description("{F6}")] F6 = 26,
        [Description("{F7}")] F7 = 27,
        [Description("{F8}")] F8 = 28,
        [Description("{F9}")] F9 = 29,
        [Description("{F10}")] F10 = 30,
        [Description("{F11}")] F11 = 31,
        [Description("{F12}")] F12 = 32,
        [Description("{F13}")] F13 = 33,
        [Description("{F14}")] F14 = 34,
        [Description("{F15}")] F15 = 35,
        [Description("{F16}")] F16 = 36,
        [Description("{ADD}")] Keypad_Add = 37,
        [Description("{SUBTRACT}")] Keypad_Subtract = 38,
        [Description("{MULTIPLY}")] Keypad_Multiply = 39,
        [Description("{DIVIDE}")] Keypad_Divide = 40,
        [Description("Code")] Key = 41,
        [Description("+")] SHIFT = 42,
        [Description("^")] CTRL = 43
    }
}
