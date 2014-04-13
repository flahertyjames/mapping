// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapOptions.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The map options.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps.Javascript
{
    using System.ComponentModel;
    using System.Drawing;

    using Flaherty.Mapping.BingMaps.Javascript.Converters;

    using Newtonsoft.Json;

    /// <summary>
    /// The map options.
    /// </summary>
    public class MapOptions
    {
        /// <summary>
        /// Gets or sets the color to use for the map control background. The default color is #F4F2EE.
        /// </summary>
        [JsonProperty("backgroundColor", NullValueHandling = NullValueHandling.Ignore)]
        [TypeConverter(typeof(ColorConverter))]
        public Color BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets a boolean indicating whether to load the new Bing Maps overlay styles. The default value is false. 
        /// This property setting only takes effect if the Microsoft.Maps.Overlays.Style module is loaded.
        /// </summary>
        [JsonProperty("customizeOverlays", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CustomizeOverlays { get; set; }

        /// <summary>
        /// Gets or sets a boolean indicating whether to disable the bird’s eye map type. The default value is false. 
        /// If this property is set to true, bird’s eye will be removed from the map navigation control and the 
        /// birdseyeMapTypeId is disabled. Additionally, the auto map type will only display road or aerial.
        /// </summary>
        [JsonProperty("disableBirdseye", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableBirdseye { get; set; }

        /// <summary>
        /// Gets or sets a boolean value indicating whether to disable the map’s response to keyboard input. 
        /// The default value is false.
        /// </summary>
        [JsonProperty("disableKeyboardInput", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableKeyboardInput { get; set; }

        /// <summary>
        /// Gets or sets a boolean value indicating whether to disable the map’s response to mouse input. 
        /// The default value is false.
        /// </summary>
        [JsonProperty("disableMouseInput", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableMouseInput { get; set; }

        /// <summary>
        /// Gets or sets a boolean value indicating whether to disable the user’s ability to pan the map. 
        /// The default value is false.
        /// </summary>
        [JsonProperty("disablePanning", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisablePanning { get; set; }

        /// <summary>
        /// Gets or sets a boolean value indicating whether to disable the map’s response to touch input. 
        /// The default value is false.
        /// </summary>
        [JsonProperty("disableTouchInput", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableTouchInput { get; set; }

        /// <summary>
        /// Gets or sets a boolean value indicating whether to disable the map’s response to any user input. 
        /// The default value is false.
        /// </summary>
        [JsonProperty("disableUserInput", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableUserInput { get; set; }

        /// <summary>
        /// Gets or sets a boolean value indicating whether to disable the user’s ability to zoom in or out. 
        /// The default value is false.
        /// </summary>
        [JsonProperty("disableZooming", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableZooming { get; set; }

        /// <summary>
        /// Gets or sets a boolean value indicating whether the BingTM logo on the map is clickable. 
        /// The default value is true.
        /// </summary>
        [JsonProperty("enableClickableLogo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableClickableLogo { get; set; }

        /// <summary>
        /// Gets or sets a boolean value indicating whether to enable the BingTM hovering search logo on 
        /// the map. The default value is true.
        /// </summary>
        [JsonProperty("enableSearchLogo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSearchLogo { get; set; }

        /// <summary>
        /// Gets or sets a boolean indicating whether the div containing the map control is fixed on the 
        /// page and the browser will not be resized. The default value is false. In this case the map 
        /// control redraws if necessary based on any div or window resize. If this property is set to true, 
        /// the map control does not check the size of the div containing it every time the map view changes, 
        /// thus increasing the performance of the control.
        /// </summary>
        [JsonProperty("fixedMapPosition", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FixedMapPosition { get; set; }

        /// <summary>
        /// Gets or sets the height of the map. The default value is null. If no height is specified, the 
        /// height of the div is used. If height is specified, then width must be specified as well.
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets a number between 0 and 1 specifying the intensity of the inertia animation effect. 
        /// The inertia effect increases as the intensity value gets larger. The default value is .85. 
        /// Setting this property to 0 indicates no inertia effect. The useInertia property must be set to 
        /// true for the inertiaIntensity value to have an effect.
        /// </summary>
        [JsonProperty("inertiaIntensity", NullValueHandling = NullValueHandling.Ignore)]
        public double? InertiaIntensity { get; set; }

        /// <summary>
        /// Gets or sets a boolean value indicating whether to display the "breadcrumb control". The 
        /// breadcrumb control shows the current center location’s geography hierarchy. For example, if the 
        /// location center is Seattle, the breadcrumb control displays "World . United States . WA". The 
        /// default value is false. The breadcrumb control displays best when the width of the map is at 
        /// least 300 pixels.
        /// </summary>
        [JsonProperty("showBreadcrumb", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowBreadcrumb { get; set; }

        /// <summary>
        /// Gets or sets a boolean value indicating whether or not to show the map copyright. The default 
        /// value is true.
        /// </summary>
        [JsonProperty("showCopyright", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowCopyright { get; set; }

        /// <summary>
        /// Gets or sets a boolean value indicating whether to show the map navigation control. The default 
        /// value is true.
        /// </summary>
        [JsonProperty("showDashboard", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowDashboard { get; set; }

        /// <summary>
        /// Gets or sets a boolean value indicating whether to show the map type selector in the map 
        /// navigation control. The default value is true.
        /// </summary>
        [JsonProperty("showMapTypeSelector", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowMapTypeSelector { get; set; }

        /// <summary>
        /// Gets or sets a boolean value indicating whether to show the scale bar. The default value is true.
        /// </summary>
        [JsonProperty("showScalebar", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowScalebar { get; set; }

        /// <summary>
        /// Gets or sets a theme object specifying the theme to use for the design of the map. To get the 
        /// latest Bing Maps design, load the Microsoft.Maps.Themes.BingTheme module and assign a BingTheme 
        /// object to this property.
        /// </summary>
        [JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore)]
        public object Theme { get; set; }

        /// <summary>
        /// Gets or sets a number between 0 and 4 specifying how many tiles to use as a buffer around the map 
        /// view. The default value is 0.
        /// </summary>
        [JsonProperty("tileBuffer", NullValueHandling = NullValueHandling.Ignore)]
        public int? TileBuffer { get; set; }

        /// <summary>
        /// Gets or sets a boolean value indicating whether to use the inertia animation effect during map 
        /// navigation. The default value is true.
        /// </summary>
        [JsonProperty("useInertia", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseInertia { get; set; }

        /// <summary>
        /// Gets or sets the width of the map. The default value is null. If no width is specified, the 
        /// width of the div is used. If width is specified, then height must be specified as well.
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets a boolean that specifies whether to animate map navigation. 
        /// Note that this option is associated with each setView call and defaults 
        /// to true if not specified.
        /// </summary>
        [JsonProperty("animate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Animate { get; set; }

        /// <summary>
        /// Gets or sets the bounding rectangle of the map view. If both are specified, 
        /// bounds takes precedence over center.
        /// </summary>
        [JsonProperty("bounds", NullValueHandling = NullValueHandling.Ignore)]
        [TypeConverter(typeof(BoundaryConverter))]
        public Boundary Bounds { get; set; }

        /// <summary>
        /// Gets or sets the location of the center of the map view. If both are specified, 
        /// bounds takes precedence over center.
        /// </summary>
        [JsonProperty("center", NullValueHandling = NullValueHandling.Ignore)]
        [TypeConverter(typeof(CoordinatesConverter))]
        public Coordinates Center { get; set; }

        /// <summary>
        /// Gets or sets the amount the center is shifted. This property is ignored if 
        /// center is not specified.
        /// </summary>
        [JsonProperty("centerOffset", NullValueHandling = NullValueHandling.Ignore)]
        [TypeConverter(typeof(Converters.PointConverter))]
        public Point CenterOffset { get; set; }

        /// <summary>
        /// Gets or sets the directional heading of the map. The heading is represented in 
        /// geometric degrees with 0 or 360 = North, 90 = East, 180 = South, and 270 = West.
        /// </summary>
        [JsonProperty("heading", NullValueHandling = NullValueHandling.Ignore)]
        public double? Heading { get; set; }

        /// <summary>
        /// Gets or sets a constant indicating how map labels are displayed.
        /// </summary>
        [JsonProperty("labelOverlay", NullValueHandling = NullValueHandling.Ignore)]
        public LabelOverlay? LabelOverlay { get; set; }

        /// <summary>
        /// Gets or sets the label overlay of the view.
        /// </summary>
        [JsonProperty("mapTypeId", NullValueHandling = NullValueHandling.Ignore)]
        public MapType? MapType { get; set; }

        /// <summary>
        /// Gets or sets the amount of padding to be added to each side of the bounds of the map view.
        /// </summary>
        [JsonProperty("padding", NullValueHandling = NullValueHandling.Ignore)]
        public double? Padding { get; set; }

        /// <summary>
        /// Gets or sets the zoom level of the map view.
        /// </summary>
        [JsonProperty("zoom", NullValueHandling = NullValueHandling.Ignore)]
        public int? Zoom { get; set; }

        /// <summary>
        /// Gets or sets the API key.
        /// </summary>
        [JsonProperty("credentials")]
        internal string ApiKey { get; set; }
    }
}
