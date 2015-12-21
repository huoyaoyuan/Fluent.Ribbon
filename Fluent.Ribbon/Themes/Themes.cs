using System;
using System.Collections.Generic;

namespace Fluent.Themes
{
    public class Office2010SilverTheme : Theme
    {
        public override IEnumerable<Uri> GetThemeUris()
        {
            yield return new Uri("pack://application:,,,/Fluent;component/Themes/Generic.xaml");
            yield return new Uri("pack://application:,,,/Fluent;component/Themes/Office2010/Silver.xaml");
        }
    }
    public class Office2010BlueTheme : Theme
    {
        public override IEnumerable<Uri> GetThemeUris()
        {
            yield return new Uri("pack://application:,,,/Fluent;component/Themes/Generic.xaml");
            yield return new Uri("pack://application:,,,/Fluent;component/Themes/Office2010/Blue.xaml");
        }
    }
    public class Office2010BlackTheme : Theme
    {
        public override IEnumerable<Uri> GetThemeUris()
        {
            yield return new Uri("pack://application:,,,/Fluent;component/Themes/Generic.xaml");
            yield return new Uri("pack://application:,,,/Fluent;component/Themes/Office2010/Black.xaml");
        }
    }
    public class Office2013Theme : Theme
    {
        public override IEnumerable<Uri> GetThemeUris()
        {
            yield return new Uri("pack://application:,,,/Fluent;component/Themes/Office2013/Generic.xaml");
        }
    }
    public class Windows8Theme : Theme
    {
        public override IEnumerable<Uri> GetThemeUris()
        {
            yield return new Uri("pack://application:,,,/Fluent;component/Themes/Windows8/Generic.xaml");
            yield return new Uri("pack://application:,,,/Fluent;component/Themes/Windows8/Silver.xaml");
        }
    }
}
