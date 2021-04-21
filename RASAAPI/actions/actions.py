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

class ActionShowHideGrid(Action):

    def name(self) -> Text:
        return "action_show_hide_grid"

    def run(self, dispatcher: CollectingDispatcher,
            tracker: Tracker,
            domain: Dict[Text, Any]) -> List[Dict[Text, Any]]:

        url = 'https://localhost:5001/api/v1/WindowsScreen/1'
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

        url = 'https://localhost:5001/api/v1/Mouse/LeftClick/4'
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

        url = 'https://localhost:5001/api/v1/Mouse/RightClick/4'
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

        url = 'https://localhost:5001/api/v1/Mouse/GoToXY/3'
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