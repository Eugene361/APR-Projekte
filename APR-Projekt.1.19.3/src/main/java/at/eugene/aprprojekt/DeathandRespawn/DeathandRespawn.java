package at.eugene.aprprojekt.DeathandRespawn;

import at.eugene.aprprojekt.Main;
import at.eugene.aprprojekt.timer.Timer;
///import net.minecraft.server.rcon.RemoteControlCommandListener;
import org.bukkit.Bukkit;
import org.bukkit.ChatColor;
import org.bukkit.GameMode;
import org.bukkit.Location;
import org.bukkit.entity.Player;
import org.bukkit.event.EventHandler;
import org.bukkit.event.Listener;
import org.bukkit.event.entity.PlayerDeathEvent;
import org.bukkit.event.player.PlayerRespawnEvent;
import org.bukkit.event.entity.EntityDeathEvent;
import org.bukkit.entity.EnderDragon;
import org.bukkit.entity.LivingEntity;

public class DeathandRespawn implements Listener{
   public static int deaths = 0;
    Location l = Bukkit.getWorld("world").getSpawnLocation();
    @EventHandler
    public void onDeath(PlayerDeathEvent e){
        deaths++;
        Player p = e.getEntity();
        l = p.getLocation();
        e.setDeathMessage(ChatColor.RED+ p.getName()+ " ist zum "+ deaths+ ". mal gestorben und hat die Challenge verloren!");
    }
    @EventHandler
    public  void onRespawn(PlayerRespawnEvent e){
        Player p = e.getPlayer();
        ///e.setRespawnLocation(l);
        p.setGameMode(GameMode.SPECTATOR);

        Timer timer = Main.getInstance().getTimer();

        timer.setRunning(false);
        timer.setTime(0);
        timer.setMin(0);
        p.sendMessage(ChatColor.GRAY + "Der Timer wurde zurückgesetzt.");
    }
    @EventHandler
    public void EnderdragonDeath(EntityDeathEvent e){
        if(e.getEntity() instanceof EnderDragon) {
            LivingEntity d = e.getEntity();
            Player p = d.getKiller();
            p.sendMessage(ChatColor.GOLD + p.getName() + "hat das Spiel durchgespielt und somit die Challenge gewonnen!");
            Timer timer = Main.getInstance().getTimer();

            timer.setRunning(false);
            timer.setTime(0);
            timer.setMin(0);
        }

    }
}
