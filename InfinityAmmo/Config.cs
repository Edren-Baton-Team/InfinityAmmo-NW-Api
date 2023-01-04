namespace InfinityAmmo
{
    using System.ComponentModel;

    public class Config
    {
        [Description("Plugin Enabled?")]
        public bool IsEnabled { get; set; } = true;
    }
}
