# What is RuRay
* Control Facebook actions (Navigation, click, posting and everything else) through voice commands.
* Design to support with multiple languages of Facebook.
* Add custom macros to automate certain tasks through voice command.
* All the services are designed in small managable micro services (Toolbox, Business Logic, Rest API, Automated text conversation using RASA, Voice to text using Google)

![RuRay](https://user-images.githubusercontent.com/83523058/126584597-1935350a-e52f-4cd0-b38d-7737083f0213.png)

# How it works. 
* Listen to the users request through microphone and convert it to text using google apis.
* The converted text then fed into Rasa to understand the meaning and call appropriate api.
* Once request is received through api, it will make a call to api server with the users request.
* At the server the request is executed using Selenium, JavaScript, bash, c#, etc.

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

## 3. [RuRay.API](https://github.com/IRobotizeInternet/RuRay/tree/master/RuRay/RuRay.API)
This contains consumable public apis that run code on the servier for each request. These servies are used by [RASA](www.rasa.com) when user request certain action in natural language. Swagger is used to describe all RESTful APIs to access mapping and executing actions.

Lets call few apis from one browser and see live changes into another. There aren't many apis added to the services; however, adding new api is very easy. Lets tests these apis.

    * Navigate to home page.
    * Scroll up few times.
    * Change display to dark mode. 

![Animation](https://user-images.githubusercontent.com/83523058/139616831-613e795b-4853-4f71-8ec8-292abed97ea2.gif)


## 4. [WindowGrid](https://github.com/IRobotizeInternet/RuRay/tree/master/WindowGrid)

This is a windows desktop application which is helpful when user need to click on certain location of the screen, they can request to show/hide the grid. The grid appears with indexes, where the user can command to click on a given index. Please note everything is controlled through apis. This is demonstrated below:


* Call grid API to identify the location.
* Right click on the given index, identified through grid earlier.
* Removing the grid.

![Animation1](https://user-images.githubusercontent.com/83523058/139618333-02485928-6345-4a44-a4fd-17dbe4c10dcb.gif)

## 5. [RASAAPI](https://github.com/IRobotizeInternet/RuRay/tree/master/RASAAPI)

Now that you know how we mapped entire Facebook UI, and how we can call apis to execute certain actions. Since we have apis to do just anything on Facebook, we just need to teach machine learning program Rasa to learn what api to call when a user request something. I would encourage you to go to www.rasa.com and learn how Rasa works. It is not just string to string matching, instead it understand the meaning of the text and call appropriate api.
Here are some examples how we provide training data to Rasa.

![image](https://user-images.githubusercontent.com/83523058/139623164-1e8864a0-9888-4e9b-8413-c181304e80fb.png)

## 6. [RobotizeTTSAndSTT](https://github.com/IRobotizeInternet/RuRay/tree/master/RuRayTTS) ( Incomplete )
Finally the last part which complete the cycle, that is listening to the users requests from microphone and converting into text. This projects uses google 
apis to convert sound to text. There is not much added in this project yet.



