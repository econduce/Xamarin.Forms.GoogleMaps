using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace XFGoogleMapSample
{
    public partial class BasicMapPage : ContentPage
    {
        public BasicMapPage()
        {
            //InitializeComponent();

            var camera = CameraUpdateFactory.NewPositionZoom(new Position(35.71d, 139.815d), 10d);
            map = new Map
            {
                VerticalOptions = LayoutOptions.Fill,
                HorizontalOptions = LayoutOptions.Fill,
                IsIndoorEnabled = false,
                IsTrafficEnabled = false,
                //HasRotationEnabled = false,
                //HasScrollEnabled = false,
                //HasZoomEnabled = false,
                //IsShowingUser = false,
                MapType = MapType.Street,
                InitialCameraUpdate = camera,
            };

            map.UiSettings.CompassEnabled = false;
            map.UiSettings.IndoorLevelPickerEnabled = false;
            map.UiSettings.MyLocationButtonEnabled = false;
            map.UiSettings.RotateGesturesEnabled = false;
            map.MyLocationEnabled = false;
            map.UiSettings.ScrollGesturesEnabled = false;
            map.UiSettings.TiltGesturesEnabled = false;
            map.UiSettings.ZoomControlsEnabled = false;
            map.UiSettings.ZoomGesturesEnabled = false;

            Content = map;
        }
    }
}

