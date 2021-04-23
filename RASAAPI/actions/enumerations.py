# If you add or remove keystrokes from here you 
# must update rasa enum KeyStrokes in the rasaapi project.

class KeyStrokes(object):
    BACKSPACE = 1
    BREAK = 2
    CAPS_LOCK = 3
    DELETE = 4
    DOWN_ARROW = 5
    END = 6
    ENTER = 7
    ESC = 8
    HELP = 9
    HOME = 10
    INSERT = 11
    LEFT_ARROW = 12
    NUM_LOCK = 13
    PAGE_DOWN = 14
    PAGE_UP = 15
    PRINT_SCREEN = 16
    RIGHT_ARROW = 17
    SCROLL_LOCK = 18
    TAB = 19
    UP_ARROW = 20
    F1 = 21
    F2 = 22
    F3 = 23
    F4 = 24
    F5 = 25
    F6 = 26
    F7 = 27
    F8 = 28
    F9 = 29
    F10 = 30
    F11 = 31
    F12 = 32
    F13 = 33
    F14 = 34
    F15 = 35
    F16 = 36
    Keypad_Add = 37
    Keypad_Subtract = 38
    Keypad_Multiply = 39
    Keypad_Divide = 40
    Key = 41
    SHIFT = 42
    CTRL = 43

def __str__(self):
        return '%s' % self.value