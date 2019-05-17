using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace maps
{
    public class AreaMap : Map
    {
        public List<Position> ShapeCoordinates { get; set; }
        public List<CustomPin> CustomPins { get; set; }
        public AreaMap()
        {
            ShapeCoordinates = new List<Position>();
        }
    }
    public class CustomPin : Pin
    {
        public string Url { get; set; }
    }
}
