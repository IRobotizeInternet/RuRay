﻿using RuRay.BLL.Resources;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public static class Constants
    {
        // Please note since we are relying on button text which could change 
        // So we have added all the possible comibinations. 
        public static string LikeOptions => $"//span[text()='{ResHomePage.Like}' or " +
                    $"text()='{ResHomePage.Love}' or " +
                    $"text()='{ResHomePage.Angry}' or " +
                    $"text()='{ResHomePage.Sad}' or " +
                    $"text()='{ResHomePage.Care}' or " +
                    $"text()='{ResHomePage.Haha}' or " +
                    $"text()='{ResHomePage.Wow}']";
    }
}
