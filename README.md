# What is RuRay
* Control Facebook actions (Navigation, click, posting and everything else) through voice commands.
* Design to support with multiple languages of Facebook.
* Add custom macros to automate certain task through voice command.
* All the services are designed in small managable micro services (Toolbox, Business Logic, Rest API, Automated text conversation using RASA, Voice to text using Google)

![RuRay](https://user-images.githubusercontent.com/83523058/126584597-1935350a-e52f-4cd0-b38d-7737083f0213.png)

# Core projects in solution:
1. RuRayToolbox
2. RuRay.BLL (Core)
3. RuRay.API
4. WindowGrid
5. RASAAPI
6. RobotizeTTSAndSTT

## 1. [RuRayToolbox](https://github.com/IRobotizeInternet/RuRay/tree/master/RuRayToolbox)
Toolbox contains all common components that can be found in any website such as textbox, label, radio button, dropdown, etc. Each component class comes with common functionality. For example consider dropdown, it provides scrolling up/down, click, getting or setting list item and more. All the components inherit from a base class called [BaseDOMObject.cs](https://github.com/IRobotizeInternet/RuRay/blob/master/RuRayToolbox/Controls/BaseDOMObject.cs).

The base class [BaseDOMObject.cs](https://github.com/IRobotizeInternet/RuRay/blob/master/RuRayToolbox/Controls/BaseDOMObject.cs) implements and/or override _OpenQA.Selenium.IWebElement interface_. It also contains core functionality of DOM object manipulation through Javascript. 

## 2. [RuRay.BLL (Core)](https://github.com/IRobotizeInternet/RuRay/tree/master/RuRay/RuRay.BLL)
Business logic layer contains two parts 

  I. Facebook UI mapping (Pages, dialogs, popups, etc). 
  II. API serives backend. 
  
 ### i. [Facebook UI mapping](https://github.com/IRobotizeInternet/RuRay/tree/master/RuRay/RuRay.BLL/App)
The entire facebook website (excluding some pages) have been mapped using [Meet Me In the Middle](https://github.com/IRobotizeInternet/Meet-me-In-the-Middle) methodology. Which means all the pages are broken down in to managable sections and then coded distributed in multiple classes in a more object oriented way. Mapping is done through UI text, since Facebook encrypt all possible DOM identifiers. So I decided to use UI text to identify each element while mapping the website.


Using UI text is bit tricky when identifying the elements when language changes on the Facebook. To overcome this problem, all the UI text on the website is converted into resource strings. This will help us to run our code with just adding equivalent resource string in different language, without needing to add/update code.

### i. [API serives backend](https://github.com/IRobotizeInternet/RuRay/tree/master/RuRay/RuRay.BLL/Services)
It listens to the api requrests from [RuRay.API](https://github.com/IRobotizeInternet/RuRay/tree/master/RuRay/RuRay.API) and uses the [Facebook UI mapping](https://github.com/IRobotizeInternet/RuRay/tree/master/RuRay/RuRay.BLL/App) to execute the actions, such as adding a new post, Display & Accessibility setting change or anything that user can do through Facebook UI.  
