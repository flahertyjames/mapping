// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ScriptWriter.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The script writer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps.Javascript
{
    using System.Linq;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// The script writer.
    /// </summary>
    public class ScriptWriter
    {
        private readonly IMap map;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptWriter"/> class.
        /// </summary>
        /// <param name="map">
        /// The map.
        /// </param>
        public ScriptWriter(IMap map)
        {
            this.map = map;
        }

        /// <summary>
        /// Writes the JavaScript for the map.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string WriteScript()
        {
            var script = new StringBuilder();
            script.AppendLine("<script type=\"text/javascript\">");
            script.AppendLine("//<![CDATA[");
            script.AppendLine(string.Format("\tfunction LoadMap_{0}() {{", this.map.Target));

            if (this.map.LoadBingTheme)
            {
                script.AppendLine(
                    string.Format(
                        "\t\tMicrosoft.Maps.loadModule('Microsoft.Maps.Themes.BingTheme', {{ callback: ThemeLoaded_{0} }});",
                        this.map.Target));
                script.AppendLine("\t}");
                script.AppendLine(string.Format("\tfunction ThemeLoaded_{0}() {{", this.map.Target));
            }

            var options = "{}";
            if (this.map.Options != null)
            {
                this.map.Options.ApiKey = this.map.ApiKey;
                options = JsonConvert.SerializeObject(this.map.Options);
            }

            script.AppendLine(string.Format("\t\tvar mapOptions = {0};", options));
            if (this.map.LoadBingTheme)
            {
                script.AppendLine("\t\tmapOptions.theme = new Microsoft.Maps.Themes.BingTheme();");
            }

            script.AppendLine(
                string.Format(
                    "\t\tvar map = new Microsoft.Maps.Map(document.getElementById('{0}'), mapOptions);",
                    this.map.Target));

            if (this.map.AutomaticBoundary && this.map.Pins.Any())
            {
                script.AppendLine("\t\tvar locations = [];");
            }

            foreach (var pushpin in this.map.Pins)
            {
                var pushpinOptions = JsonConvert.SerializeObject(pushpin.Options);
                script.AppendLine(string.Format("\t\tvar pinOptions = {0};", pushpinOptions));
                var infobox = pushpin.Options.Infobox;
                if (infobox != null && !infobox.IsEmpty())
                {
                    infobox.Location = infobox.Location ?? pushpin.Position;
                    var infoboxOptions = JsonConvert.SerializeObject(infobox.Options);
                    script.AppendLine(
                        string.Format(
                            "\t\tvar infobox = new {0}({1}, {2});",
                            infobox.JavascriptTypeName,
                            infobox.Location.ToJavascript(),
                            infoboxOptions));
                    script.AppendLine("\t\tmap.entities.push(infobox);");
                    script.AppendLine("\t\tpinOptions.infobox = infobox;");
                }

                script.AppendLine(
                    string.Format(
                        "\t\tvar pin = new {0}({1}, pinOptions);",
                        pushpin.JavascriptTypeName,
                        pushpin.Position.ToJavascript()));
                if (this.map.AutomaticBoundary)
                {
                    script.AppendLine("\t\tlocations.push(pin.getLocation());");
                }

                script.AppendLine("\t\tmap.entities.push(pin);");
            }

            if (this.map.AutomaticBoundary && this.map.Pins.Any())
            {
                script.AppendLine("\t\tmap.setView({bounds: Microsoft.Maps.LocationRect.fromLocations(locations)});");
            }

            script.AppendLine("\t}");
            script.AppendLine(
                string.Format(
                    "if (window.addEventListener) {{ window.addEventListener('load', LoadMap_{0}, false); }}",
                    this.map.Target));
            script.AppendLine(
                string.Format(
                    "else if (window.attachEvent) {{ window.attachEvent('load', LoadMap_{0}); }}",
                    this.map.Target));
            script.AppendLine("//]]>");
            script.AppendLine("</script>");
            return script.ToString();
        }
    }
}
