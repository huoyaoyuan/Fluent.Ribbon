using System;
using System.Collections.Generic;

namespace Fluent.Themes
{
    /// <summary>
    /// Represent base class for theme objects
    /// </summary>
    public abstract class Theme
    {
        /// <summary>
        /// Provides the Uris of ResourceDictionary files used by the theme.
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerable<Uri> GetThemeUris();
    }
}
