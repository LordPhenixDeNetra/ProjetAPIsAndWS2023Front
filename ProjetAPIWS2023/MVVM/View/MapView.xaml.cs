using GMap.NET.MapProviders;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GMap.NET.WindowsPresentation;

namespace ProjetAPIWS2023.MVVM.View
{
    /// <summary>
    /// Logique d'interaction pour MapView.xaml
    /// </summary>
    public partial class MapView : UserControl
    {
        public MapView()
        {
            InitializeComponent();
        }

        private void mapView_Loaded(object sender, RoutedEventArgs e)
        {
            //GMapProviders.GoogleMap.ApiKey = @"";

            //GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; //V1
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            // choose your provider here
            //mapView.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            mapView.MapProvider = GMapProviders.GoogleMap;

            mapView.MinZoom = 2;
            mapView.MaxZoom = 17;

            // whole world zoom
            mapView.Zoom = 2;

            // lets the map use the mousewheel to zoom
            mapView.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;

            // lets the user drag the map
            mapView.CanDragMap = true;

            // lets the user drag the map with the left mouse button
            mapView.DragButton = MouseButton.Left;

            double latitude = 14.710983855901924;
            double longitude = -17.438008451363782;

            mapView.Position = new GMap.NET.PointLatLng(latitude, longitude);

            mapView.MinZoom = 5;
            mapView.MaxZoom = 100;

            mapView.Zoom = 10;

            /*

            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@"D:\OneDrive - Université Cheikh Anta DIOP de DAKAR\DotNetProject\ProjetAPIWS2023\ProjetAPIWS2023\Images\marker.png");
            bitmapImage.EndInit();

            PointLatLng point = new PointLatLng(latitude, longitude);
            GMapMarker marker = new GMapMarker(point);

            Image image = new Image();
            image.Source = bitmapImage;
            marker.Shape = image;
            mapView.Markers.Add(marker);

            */


        }
    }
}
