// Customized text message to all the friends {New year, festivals etc.}

**Configuring Google Chrome
To ensure that automated web application testing in Google Chrome runs properly, please set command shown below.**

* Close all chrome browsers if any opened, and terminate all running Chrome-related background processes from task manager.
* [This is not automatically done through bash script] Right-click the Chrome icon on the desktop, and click Properties.
On the Shortcut tab in the Google Chrome Properties window, edit the contents of the Target text box. 
Append a white space to the existing command, followed by the following flags: 
–remote-debugging-port=9222 –no-first-run –disable-web-security –allow-file-access-from-file –enable-views-textfield –force-renderer-accessibility.

* The resultant command line string should look something like the following:

"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe" --remote-debugging-port=9222 --no-first-run --disable-web-security --allow-file-access-from-file --enable-views-textfield --force-renderer-accessibility

**----
Goals
----**
* To be able to create automated actions quickly by using appropriate abstraction layers.
* The framework should have meaningful logging and reporting structure.
* Should be easily maintainable and extendable.
* Should be simple enough for testers to write automated tests.
* A retry mechanism to rerun action - this is especially useful for WebDriver UI actions.

***----
Known issue
----***
* [Fixed]~~Often chorme driver does not connect/Dont click/click on incorrect element even after refersing the page.~~
* Must close all the google chrome browser before running the RuRay (Sometime existing browser cause new browser to be opened with unknown port
that will eventually throw up (https://stackoverflow.com/questions/56356452/selenium-chromedriver-the-http-request-to-the-remote-webdriver-server-for-url)
Unhandled exception. System.IO.FileLoadException: Could not load file or assembly 'Microsoft.Extensions.DependencyModel, Version=2.1.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'. The located assembly's manifest definition does not match the assembly reference. (0x80131040) [TO FIX: Clean and rebuild the solution]
* [Very important] Run RuRay.API.exe through executable from bin folder when running the entire application. 


--
Read text from element collection
document.getElementsByClassName("card--frame card--back disabled").forEach(function(element, index){ console.log(element.innerText);});

----
Avoiding bot detecting:
This may not necessary if we actually contact the owner of the website and get permission to serve our purpose;
I found this article which could be helpful when we are building the scritp
 https://stackoverflow.com/questions/33225947/can-a-website-detect-when-you-are-using-selenium-with-chromedriver
 "The bot detection scripts usually look anything containing word "selenium" / "webdriver" in any of the variables (on window object), and also document variables called $cdc_ and $wdc_. Of course, all of this depends on which browser you are on. All the different browsers expose different things."
