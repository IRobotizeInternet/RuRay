# What is RuRay
* Control Facebook actions (Navigation, click, posting and everything else) through voice commands.
* Design to support with multiple languages of Facebook.
* Add custom macros to automate certain tasks through voice command.
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

  i. Facebook UI mapping (Pages, dialogs, popups, etc).                                                                                                    
  ii. API serives backend. 
  
 ### i. [Facebook UI mapping](https://github.com/IRobotizeInternet/RuRay/tree/master/RuRay/RuRay.BLL/App)
The entire facebook website (excluding some pages) have been mapped using [Meet Me In the Middle](https://github.com/IRobotizeInternet/Meet-me-In-the-Middle) methodology. Which means all the pages are broken down in to managable sections and then coded distributed in multiple classes in a more object oriented way. Mapping is done through UI text, since Facebook encrypt all possible DOM identifiers. So I decided to use UI text to identify each element while mapping the website.

Using UI text is bit tricky when identifying the elements when language changes on the Facebook. To overcome this problem, all the UI text on the website is converted into resource strings. This will help us to run our code with just adding equivalent resource string in different language, without needing to add/update code.

#### Notable things in UI mappings:
* Fluent API's for complex pages, ex: [Marketplace page - GridMarketPlace](https://github.com/IRobotizeInternet/RuRay/tree/master/RuRay/RuRay.BLL/App/LoggedIn/Pages/Marketplace/GridMarketPlace). This is bit complex, however, it is to enforce filtering and searching in marketplace page through object oriented approach.
* Bash scripts to get around with Selenium limitations ex: Creating chrome shortcut on desktop with automation support args, getting cursors location and sending keys, etc.
* Since most of the mapping is separated with action usage, changes in the Facebook UI will minimum effort to fix the broken mapping. 

### ii. [API serives backend](https://github.com/IRobotizeInternet/RuRay/tree/master/RuRay/RuRay.BLL/Services)
It listens to the api requrests from [RuRay.API](https://github.com/IRobotizeInternet/RuRay/tree/master/RuRay/RuRay.API) and uses the [Facebook UI mapping](https://github.com/IRobotizeInternet/RuRay/tree/master/RuRay/RuRay.BLL/App) to execute the actions, such as adding a new post, Display & Accessibility setting change or anything that user can do through Facebook UI.  

### [RuRay.API](https://github.com/IRobotizeInternet/RuRay/tree/master/RuRay/RuRay.API)
This contains consumable public apis that run code on the servier for each request. These servies are used by [RASA](www.rasa.com) when user request certain action in natural language. Swagger is used describing RESTful APIs ![image](https://user-images.githubusercontent.com/83523058/139604809-3b89a5f2-2e80-4ff7-bec7-3b8ad4cc7a82.png)

### [WindowGrid](https://github.com/IRobotizeInternet/RuRay/tree/master/WindowGrid) 
This is a windows desktop application which is helpful when user need to click on certain location of the screen, they can request to show/hide grid. The grid appear with indexes, where user can command to click on a given index. This can be tested in through API as shown below.

