﻿namespace RuRayFacebook.App.LoggedIn
{
    public interface IPrice
    {
        IApplyFilter Price(double? min = null, double? max = null);
    }
}
