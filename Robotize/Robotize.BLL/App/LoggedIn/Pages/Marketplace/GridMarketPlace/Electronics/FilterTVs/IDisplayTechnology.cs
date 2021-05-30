using System;

namespace RuRayFacebook.App.LoggedIn
{
    public interface IDisplayTechnology<TDisplayTechnology> where TDisplayTechnology : struct, IConvertible
    {
        IApplyFilter DisplayTechnology(TDisplayTechnology displayTechnology);
    }
}
