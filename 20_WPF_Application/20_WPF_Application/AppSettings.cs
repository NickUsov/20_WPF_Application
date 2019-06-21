using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace _20_WPF_Application
{
    public class AppSettings : ApplicationSettingsBase
    {
        [UserScopedSetting]
        [DefaultSettingValue("Red")]
        public Brush color
        {
            set { this["color"] = (Brush)value; }
            get { return (Brush)this["color"]; }
        }

        [UserScopedSetting]
        [DefaultSettingValue("525")]
        public double width
        {
            set { this["width"] = (double)value; }
            get { return (double)this["width"]; }
        }

        [UserScopedSetting]
        [DefaultSettingValue("300")]
        public double height
        {
            set { this["height"] = (double)value; }
            get { return (double)this["height"]; }
        }

        [UserScopedSetting]
        [DefaultSettingValue("50")]
        public double top
        {
            set { this["top"] = (double)value; }
            get { return (double)this["top"]; }
        }

        [UserScopedSetting]
        [DefaultSettingValue("50")]
        public double left
        {
            set { this["left"] = (double)value; }
            get { return (double)this["left"]; }
        }
    }
}
