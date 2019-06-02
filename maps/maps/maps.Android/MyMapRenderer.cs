using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using maps;
using maps.Droid;
using Xamarin.Android;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Maps.Android;
[assembly: ExportRenderer(typeof(MyMap), typeof(MyMapRenderer))]
namespace maps.Droid
{
    public class MyMapRenderer : MapRenderer
    {
        MapView mapView;
        GoogleMap map;
        MyMap myMap;
        protected override void OnElementChanged(Xamarin.Forms.Platform.Android.ElementChangedEventArgs<Map> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {

                mapView = Control as MapView;
                map = mapView.Map;
                myMap = e.NewElement as MyMap;
                PolylineOptions line = new PolylineOptions();
                line.InvokeColor(global::Android.Graphics.Color.Red);
                // Add the points of the polyline
                LatLng latLng = new LatLng(37, -122);
                line.Add(latLng);
                //latLng = new LatLng(37, -122.001);
                //line.Add(latLng);
                latLng = new LatLng(37.001, -122.002);
                line.Add(latLng);
                // Add the polyline to the map
                map.AddPolyline(line);
            }
        }
    }
}