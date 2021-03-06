﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapKit;
using Foundation;
using UIKit;

namespace maps.iOS
{
    public class CustomMKAnnotationView : MKAnnotationView
    {
        public string Id { get; set; }

        public string Url { get; set; }

        public CustomMKAnnotationView(IMKAnnotation annotation, string id)
            : base(annotation, id)
        {
        }
    }
}