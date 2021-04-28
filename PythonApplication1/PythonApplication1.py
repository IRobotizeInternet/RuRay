import pyautogui
from subprocess import Popen
from pywinauto import Desktop

Popen('calc.exe', shell=True)
dlg = Desktop(backend="uia").Calculator
dlg.wait('visible')
#
#pyautogui.hscroll(-30) 
pyautogui.vscroll(90)
#pyautogui.moveTo(100, 200, 0.5)
x, y = pyautogui.locateCenterOnScreen('Capture.PNG',  confidence=0.50)
pyautogui.click(x, y)