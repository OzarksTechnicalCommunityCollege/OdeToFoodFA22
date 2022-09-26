using OdeToFood.Core;       // adds a reference to our .csproj file
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data
{
    /// <summary>
    /// abstraction
    /// </summary>
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
