// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Default.aspx.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The default page.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps.WebControls.SampleApp
{
    using System;
    using System.Configuration;

    /// <summary>
    /// The default page.
    /// </summary>
    public partial class Default : System.Web.UI.Page
    {
        /// <summary>
        /// Handler that fires on page load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The event args.
        /// </param>
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Map.ApiKey = ConfigurationManager.AppSettings["BingMapsApiKey"];
        }
    }
}