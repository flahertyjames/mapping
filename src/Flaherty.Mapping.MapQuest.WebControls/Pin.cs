// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pin.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The pin.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest.WebControls
{
    using System.ComponentModel;
    using System.Web.UI;

    /// <summary>
    /// The pin.
    /// </summary>
    [ParseChildren(true)]
    public class Pin : Javascript.Pin
    {
        /// <summary>
        /// Gets or sets the info text.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public override string InfoText
        {
            get
            {
                return base.InfoText;
            }

            set
            {
                base.InfoText = value.Trim().Replace("\r", " ").Replace("\n", " ");
            }
        }
    }
}
