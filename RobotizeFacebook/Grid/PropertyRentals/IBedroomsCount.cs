using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Grid
{
    public interface IBedroomsCount<TBedroomCount> where TBedroomCount: struct, IConvertible
    {
        IApplyFilter Bedrooms(TBedroomCount numberOfBedrooms);
    }
}
