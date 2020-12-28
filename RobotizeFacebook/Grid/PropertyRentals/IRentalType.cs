using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Grid
{
    public interface IRentalType<TRentalType> where TRentalType : struct, IConvertible
    {
        IApplyFilter RentalType(TRentalType numberOfBedrooms);
    }
}
