// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Map.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Control for rendering a MapQuest Map in an ASP.net web application.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest.WebControls
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    using Flaherty.Mapping.MapQuest.Javascript;

    using IMap = Flaherty.Mapping.MapQuest.Javascript.IMap;
    using License = Flaherty.Mapping.MapQuest.License;

    /// <summary>
    /// Control for rendering a Bing Map in an ASP.net web application.
    /// </summary>
    [ParseChildren(true)]
    public sealed class Map : Panel, IMap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Map"/> class.
        /// </summary>
        public Map()
        {
            this.AutomaticBoundary = false;
            this.Options = new MapOptions();
            this.Pins = new List<Javascript.Pin>();
            this.ShowZoomControl = true;
            this.Init += this.Map_Init;
        }

        /// <summary>
        /// Gets the target.
        /// </summary>
        public string Target
        {
            get
            {
                return this.ClientID;
            }
        }

        /// <summary>
        /// Gets or sets the API key.
        /// </summary>
        public string ApiKey
        {
            get
            {
                return (string)this.ViewState["ApiKey"];
            }

            set
            {
                this.ViewState["ApiKey"] = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to set the boundary by the pushpins.
        /// </summary>
        public bool AutomaticBoundary
        {
            get
            {
                return (bool)this.ViewState["AutomaticBoundary"];
            }

            set
            {
                this.ViewState["AutomaticBoundary"] = value;
            }
        }

        public Boundary Boundary { get; set; }

        /// <summary>
        /// Gets or sets the center.
        /// </summary>
        public Coordinates Center
        {
            get
            {
                return this.Options.Center;
            }

            set
            {
                this.Options.Center = value;
            }
        }

        /// <summary>
        /// Gets or sets the map type.
        /// </summary>
        public MapType? MapType
        {
            get
            {
                return this.Options.MapType;
            }

            set
            {
                this.Options.MapType = value;
            }
        }

        /// <summary>
        /// Gets or sets the padding.
        /// </summary>
        public double? Padding
        {
            get
            {
                return this.Options.Padding;
            }

            set
            {
                this.Options.Padding = value;
            }
        }

        /// <summary>
        /// Gets or sets the license.
        /// </summary>
        public License License { get; set; }

        /// <summary>
        /// Gets or sets the options.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public MapOptions Options
        {
            get
            {
                return (MapOptions)this.ViewState["Options"];
            }

            set
            {
                this.ViewState["Options"] = value;
            }
        }

        /// <summary>
        /// Gets the pushpins.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public List<Javascript.Pin> Pins
        {
            get
            {
                return (List<Javascript.Pin>)this.ViewState["Pins"];
            }

            private set
            {
                this.ViewState["Pins"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the show map type control.
        /// </summary>
        public bool? ShowMapTypeControl { get; set; }

        /// <summary>
        /// Gets or sets the show pan control.
        /// </summary>
        public bool? ShowPanControl { get; set; }

        /// <summary>
        /// Gets or sets the show zoom control.
        /// </summary>
        public bool? ShowZoomControl { get; set; }

        /// <summary>
        /// Gets or sets the zoom.
        /// </summary>
        public int? Zoom
        {
            get
            {
                return this.Options.Zoom;
            }

            set
            {
                this.Options.Zoom = value;
            }
        }

        private void RegisterJavascript()
        {
            var writer = new ScriptWriter(this);
            foreach (var lib in writer.Libraries)
            {
                this.Page.ClientScript.RegisterClientScriptInclude(this.GetType().Name, lib);
            }

            Page.ClientScript.RegisterClientScriptBlock(
                this.GetType(),
                string.Format("{0}.{1}", this.GetType().FullName, this.ClientID),
                writer.WriteScript());
        }

        // ReSharper disable once InconsistentNaming
        private void Map_Init(object sender, EventArgs e)
        {
            this.Page.Load += this.Page_Load;
            this.Page.PreRender += this.Page_PreRender;
        }

        // ReSharper disable once InconsistentNaming
        private void Page_Load(object sender, EventArgs e)
        {
        }

        // ReSharper disable once InconsistentNaming
        private void Page_PreRender(object sender, EventArgs e)
        {
            this.RegisterJavascript();
        }
    }
}
