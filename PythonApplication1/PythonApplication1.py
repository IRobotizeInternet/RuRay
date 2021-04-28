import pyautogui

#
#pyautogui.hscroll(-30) 
pyautogui.vscroll(90)
#pyautogui.moveTo(100, 200, 0.5)
prompt(text='', title='' , default='')
while True:
    x, y = pyautogui.locateCenterOnScreen('Capture.PNG',  confidence=0.40)
    
    pyautogui.click(x, y)
    alert(text='', title='', button='OK')