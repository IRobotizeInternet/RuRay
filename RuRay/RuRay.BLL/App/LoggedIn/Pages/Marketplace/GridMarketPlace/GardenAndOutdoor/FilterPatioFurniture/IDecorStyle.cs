using System;

namespace RuRayFacebook.App.LoggedIn
{
    public interface IDecorStyle<TDecorStyle> where TDecorStyle : struct, IConvertible
    {
        IApplyFilter DecorStyle(TDecorStyle model);
    }
}