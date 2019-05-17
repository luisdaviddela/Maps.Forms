using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace maps
{
    public class MapPageCS: ContentPage
    {
        public MapPageCS()
        {
            var pin = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(37.79752, -122.40183),
                Label = "Xamarin San Francisco Office",
                Address = "394 Pacific Ave, San Francisco CA",
                Id = "Xamarin",
                Url = "http://xamarin.com/about/"
            };
            
            var customMap = new AreaMap
            {
                MapType = MapType.Satellite,
                WidthRequest = 500,
                HeightRequest = 500
            };
            customMap.CustomPins = new List<CustomPin> { pin };
            customMap.Pins.Add(pin);
            //customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(37.79752, -122.40183), Distance.FromMiles(1.0)));
            customMap.ShapeCoordinates.Add(new Position(37.797513, -122.402058));
            customMap.ShapeCoordinates.Add(new Position(37.798433, -122.402256));
            customMap.ShapeCoordinates.Add(new Position(37.798582, -122.401071));
            customMap.ShapeCoordinates.Add(new Position(37.797658, -122.400888));

            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(37.79752, -122.40183), Distance.FromMiles(0.1)));

            Content = customMap;
        }
    }
}
