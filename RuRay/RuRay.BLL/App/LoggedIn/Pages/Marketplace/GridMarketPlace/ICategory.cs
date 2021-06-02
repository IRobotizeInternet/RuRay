using System;
using System.Collections.Generic;

namespace RuRayFacebook.App.LoggedIn
{
    public interface ICategory<TCategoryType> where TCategoryType : struct, IConvertible
    {
        void Category(TCategoryType category);
        IEnumerable<string> GetAllCategories();
    }
}
