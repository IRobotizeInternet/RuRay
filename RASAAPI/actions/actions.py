# This files contains your custom actions which can be used to run
# custom Python code.
#
# See this guide on how to implement these action:
# https://rasa.com/docs/rasa/custom-actions


# This is a simple example for a custom action which utters "Hello World!"
from typing import Any, Text, Dict, List
from rasa_sdk import Action, Tracker
from rasa_sdk.executor import CollectingDispatcher
import requests
from actions import enumerations

class ActionShowHideGrid(Action):

    def name(self) -> Text:
        return "action_show_hide_grid"

    def run(self, dispatcher: CollectingDispatcher,
            tracker: Tracker,
            domain: Dict[Text, Any]) -> List[Dict[Text, Any]]:
        
        gridMode = tracker.latest_message['entities'][0]['value']
        res = 1 if gridMode == "show" else 2
        url = "https://localhost:5001/api/v1/WindowsScreen/"+str(res)
        myobj = {'somekey': 'somevalue'}

        x = requests.post(url, verify=False)

        dispatcher.utter_message(text="Hello World!00000")

        return []

class ActionLeftClick(Action):

    def name(self) -> Text:
        return "action_left_click"

    def run(self, dispatcher: CollectingDispatcher,
            tracker: Tracker,
            domain: Dict[Text, Any]) -> List[Dict[Text, Any]]:

        location = tracker.latest_message['entities'][0]['value']
        url = 'https://localhost:5001/api/v1/Mouse/LeftClick/'+location
        myobj = {'somekey': 'somevalue'}

        x = requests.post(url, verify=False)

        dispatcher.utter_message(text="Hello World!00000")

        return []

class ActionRightClick(Action):

    def name(self) -> Text:
        return "action_right_click"

    def run(self, dispatcher: CollectingDispatcher,
            tracker: Tracker,
            domain: Dict[Text, Any]) -> List[Dict[Text, Any]]:

        location = tracker.latest_message['entities'][0]['value']
        url = 'https://localhost:5001/api/v1/Mouse/RightClick/'+location
        myobj = {'somekey': 'somevalue'}

        x = requests.post(url, verify=False)

        dispatcher.utter_message(text="Hello World!00000")

        return []


class ActionGoToXY(Action):

    def name(self) -> Text:
        return "action_goto_xy"

    def run(self, dispatcher: CollectingDispatcher,
            tracker: Tracker,
            domain: Dict[Text, Any]) -> List[Dict[Text, Any]]:
        print(tracker.latest_message)
        location = tracker.latest_message['entities'][0]['value']
        url = 'https://localhost:5001/api/v1/Mouse/GoToXY/'+location
        myobj = {'somekey': 'somevalue'}

        x = requests.post(url, verify=False)

        dispatcher.utter_message(text="Hello World!00000")

        return []

class ActionSendkey(Action):

    def name(self) -> Text:
        return "action_send_key"

    def run(self, dispatcher: CollectingDispatcher,
            tracker: Tracker,
            domain: Dict[Text, Any]) -> List[Dict[Text, Any]]:
        print(tracker.latest_message)
        key = tracker.latest_message['entities'][0]['value']
        url = 'https://localhost:5001/api/v1/Keyboard/SendKey/'+ enumerations.KeyStrokes(key)
        myobj = {'somekey': 'somevalue'}

        x = requests.post(url, verify=False)

        dispatcher.utter_message(text="Hello World!00000")

        return []

class ActionSecond(Action):

    def name(self) -> Text:
        return "action_second"

    def run(self, dispatcher: CollectingDispatcher,
            tracker: Tracker,
            domain: Dict[Text, Any]) -> List[Dict[Text, Any]]:
        
        message = " Second action"

        dispatcher.utter_message(text=message)

        return []