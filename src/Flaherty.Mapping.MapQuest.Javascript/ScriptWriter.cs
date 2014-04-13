// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ScriptWriter.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The script writer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest.Javascript
{
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

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
            var lib = string.Format(
                "http://{0}/sdk/js/v7.0.s/mqa.toolkit.js?key={1}",
                this.map.License == License.Licensed ? "www.mapquestapi.com" : "open.mapquestapi.com",
                this.map.ApiKey);
            this.Libraries = new List<string> { lib };
        }

        /// <summary>
        /// Gets the referenced JavaScript libraries.
        /// </summary>
        public IEnumerable<string> Libraries { get; private set; }

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

            var options = "{}";
            if (this.map.Options != null)
            {
                this.map.Options.Element = this.map.Target;
                options = JsonConvert.SerializeObject(this.map.Options);
            }

            script.AppendLine(string.Format("\t\tvar mapOptions = {0};", options));
            script.AppendLine("\t\tvar map = new MQA.TileMap(mapOptions);");

            var pinIndex = 0;
            foreach (var pin in this.map.Pins)
            {
                script.AppendLine(
                    string.Format(
                        "\t\tvar pin_{0} = new {1}({2});",
                        pinIndex,
                        pin.JavascriptTypeName,
                        JsonConvert.SerializeObject(pin.Position)));
                if (!string.IsNullOrEmpty(pin.InfoText))
                {
                    script.AppendLine(string.Format("\t\tpin_{0}.setRolloverContent('{1}');", pinIndex, pin.InfoText));
                    script.AppendLine(string.Format("\t\tpin_{0}.setInfoContentHTML('{1}');", pinIndex, pin.InfoText));
                }

                var icon = this.GetIconUrl(pin, this.map.License);
                if (!string.IsNullOrEmpty(icon))
                {
                    script.AppendLine(
                        string.Format(
                            "\t\tvar icon_{0} = new MQA.Icon('{1}',{2},{3});",
                            pinIndex,
                            icon,
                            pin.Width,
                            pin.Height));
                    script.AppendLine(string.Format("\t\tpin_{0}.setIcon(icon_{0});", pinIndex));
                }

                script.AppendLine(string.Format("\t\tmap.addShape(pin_{0});", pinIndex));
                pinIndex++;
            }

            if (this.map.ShowMapTypeControl.HasValue && this.map.ShowMapTypeControl.Value)
            {
                script.AppendLine("\t\tMQA.withModule('viewoptions', function() {");
                script.AppendLine("\t\t\tmap.addControl(new MQA.ViewOptions());");
                script.AppendLine("\t\t});");
            }

            if (this.map.ShowZoomControl.HasValue && this.map.ShowZoomControl.Value
                && this.map.ShowPanControl.HasValue && this.map.ShowPanControl.Value)
            {
                script.AppendLine("\t\tMQA.withModule('largezoom', function() {");
                script.AppendLine("\t\t\tmap.addControl(new MQA.LargeZoom(), new MQA.MapCornerPlacement(MQA.MapCorner.TOP_LEFT, new MQA.Size(5,5)));");
                script.AppendLine("\t\t});");
            }

            if (this.map.ShowZoomControl.HasValue && this.map.ShowZoomControl.Value
                && (!this.map.ShowPanControl.HasValue || !this.map.ShowPanControl.Value))
            {
                script.AppendLine("\t\tMQA.withModule('smallzoom', function() {");
                script.AppendLine("\t\t\tmap.addControl(new MQA.SmallZoom(), new MQA.MapCornerPlacement(MQA.MapCorner.TOP_LEFT, new MQA.Size(5,5)));");
                script.AppendLine("\t\t});");
            }

            if (this.map.AutomaticBoundary)
            {
                script.AppendLine("\t\tmap.bestFit();");
            }

            script.AppendLine("\t}");
            script.AppendLine(string.Format("\tMQA.EventUtil.observe(window, 'load', LoadMap_{0});", this.map.Target));
            script.AppendLine("//]]>");
            script.AppendLine("</script>");
            return script.ToString();
        }

        private string GetIconUrl(Pin pin, License license)
        {
            if (!string.IsNullOrEmpty(pin.Icon))
            {
                return pin.Icon;
            }
            
            if (pin.Color.HasValue)
            {
                var pattern = new Regex("(\\d+)");
                var color = pattern.Replace(pin.Color.ToString().ToLower(), "_$1");
                int i;
                var index = !string.IsNullOrEmpty(pin.Text) && int.TryParse(pin.Text, out i)
                                ? "-" + pin.Text
                                : string.Empty;
                return string.Format(
                    "http://{0}/staticmap/geticon?uri=poi-{1}{2}.png",
                    license == License.Licensed ? "www.mapquestapi.com" : "open.mapquestapi.com",
                    color,
                    index);
            }

            return null;
        }
    }
}
