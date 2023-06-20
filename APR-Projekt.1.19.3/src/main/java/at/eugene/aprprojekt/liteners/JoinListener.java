package at.eugene.aprprojekt.liteners;

import at.eugene.aprprojekt.Main;
import org.bukkit.ChatColor;
import org.bukkit.entity.Player;
import org.bukkit.event.EventHandler;
import  org.bukkit.event.Listener;
import org.bukkit.event.player.PlayerJoinEvent;
public class JoinListener implements Listener{
    @EventHandler
    public void onJoin(PlayerJoinEvent event){
        Player player = event.getPlayer();
        event.setJoinMessage(ChatColor.DARK_PURPLE.toString() + ChatColor.UNDERLINE + player.getName() + " hat den Server betreten");

        player.sendMessage(ChatColor.GOLD + "Wilkommen auf dem Server! \nViel Spaß und Vergnügen");
    }
}
