using PluginAPI.Core.Attributes;
using PluginAPI.Core;
using PluginAPI.Enums;
using PluginAPI.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InfinityAmmo
{
    public class InfinityAmmo
    {
        public const string Name = "InfinityAmmo";
        public const string Version = "v1.0.1";
        public const string Author = "Rysik5318";
        public static InfinityAmmo Instance { get; private set; }
        [PluginConfig("config.yml")]
        public Config Config;
        [PluginPriority(LoadPriority.Highest)]
        [PluginEntryPoint(Name, Version, "InfinityAmmo!", Author)]
        void LoadPlugin()
        {
            if (!Config.IsEnabled)
                return;
            Instance = this;
            EventManager.RegisterEvents<EventHandlers>(this);
            Log.Raw($"<color=blue>Loading {Name} {Version} by {Author}</color>");
            var handler = PluginHandler.Get(this);
            handler.SaveConfig(this, nameof(Config));
        }
    }
}
