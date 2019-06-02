using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Maps.iOS;
using Xamarin.Forms;
using maps.iOS;
using maps;
using MapKit;
using CoreLocation;
//--------------------- https://gist.github.com/jgold6/0ac42b5db4a66e36c25a
[assembly: ExportRenderer(typeof(MyMap), typeof(MyMapRenderer))]
namespace maps.iOS
{
    public class MyMapRenderer : MapRenderer
    {
        MKMapView mapView;
        MyMap myMap;
        MKPolyline lineOverlay;
        MKPolylineRenderer lineRenderer;
        protected override void OnElementChanged(Xamarin.Forms.Platform.iOS.ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {

                mapView = Control as MKMapView;

                myMap = e.NewElement as MyMap;

                mapView.OverlayRenderer = (m, o) => {
                    if (lineRenderer == null)
                    {
                        lineRenderer = new MKPolylineRenderer(o as MKPolyline);
                        lineRenderer.StrokeColor = UIColor.Red;
                        lineRenderer.FillColor = UIColor.Red;
                    }
                    return lineRenderer;
                };

                var point1 = new CLLocationCoordinate2D(37, -122);
                var point2 = new CLLocationCoordinate2D(37, -122.001);
                var point3 = new CLLocationCoordinate2D(37.001, -122.002);

                lineOverlay = MKPolyline.FromCoordinates(new CLLocationCoordinate2D[] { point1, point2, point3 });
                mapView.AddOverlay(lineOverlay);
            }
        }
    }
}