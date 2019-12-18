using System;
using Xaminals.Data;
using Xaminals.Models;

namespace Xaminals.DesignData
{
  public class BearViewModel: Animal
  {
    private Animal _currentBear;
       

    public BearViewModel()
    {
      _currentBear = BearData.Bears[0];

      Name = _currentBear.Name;
      Location = _currentBear.Location;
      Details = _currentBear.Details;
      ImageUrl = _currentBear.ImageUrl;
    }
  }
}
