using System;

namespace RobotizeFacebook.App.LoggedIn.Components.Grid.Electronics.FilterTVs
{
    public interface IFeature<TFeature> where TFeature : struct, IConvertible
    {
        IApplyFilter Feature(TFeature feature);
    }
}
