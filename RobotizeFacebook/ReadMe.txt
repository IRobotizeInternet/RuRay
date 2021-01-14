// Customized text message to all the friends {New year, festivals etc.}

Configuring Google Chrome
To ensure that automated web application testing in Google Chrome runs properly, please set command shown below.

Close chrome browser if opened, and terminate all running Chrome-related background processes.
Right-click the Chrome icon on the desktop, and click Properties.
On the Shortcut tab in the Google Chrome Properties window, edit the contents of the Target text box. 
Append a white space to the existing command, followed by the following flags: 
–remote-debugging-port=9222 –no-first-run –disable-web-security –allow-file-access-from-file –enable-views-textfield –force-renderer-accessibility.

The resultant command line string should look something like the following:

"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe" --remote-debugging-port=9222 --no-first-run --disable-web-security --allow-file-access-from-file --enable-views-textfield --force-renderer-accessibility