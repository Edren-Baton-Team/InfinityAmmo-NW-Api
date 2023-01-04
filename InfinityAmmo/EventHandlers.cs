using InventorySystem.Items.Firearms;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;

namespace InfinityAmmo
{
    public class EventHandlers
    {
        [PluginEvent(ServerEventType.PlayerDropAmmo)]
        public bool OnPlayerDroppedAmmo(Player plr, ItemType ammoType, int amount)
        {
            return false;
        }
        [PluginEvent(ServerEventType.RoundStart)]
        public void OnRoundStart()
        {
            foreach (Player pl in Player.GetPlayers())
            {
                pl.SetAmmo(ItemType.Ammo44cal, 100);
                pl.SetAmmo(ItemType.Ammo12gauge, 100);
                pl.SetAmmo(ItemType.Ammo556x45, 100);
                pl.SetAmmo(ItemType.Ammo762x39, 100);
                pl.SetAmmo(ItemType.Ammo9x19, 100);
            }
        }
        [PluginEvent(ServerEventType.PlayerReloadWeapon)]
        public void OnReloadWeapon(Player player, Firearm gun)
        {
            player.SetAmmo(gun.AmmoType, 0);
            player.AddAmmo(gun.AmmoType, 100);
        }
    }
}
