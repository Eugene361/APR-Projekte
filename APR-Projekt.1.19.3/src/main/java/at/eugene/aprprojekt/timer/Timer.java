package at.eugene.aprprojekt.timer;

import at.eugene.aprprojekt.Main;
import net.md_5.bungee.api.ChatMessageType;
import net.md_5.bungee.api.chat.TextComponent;
import org.bukkit.Bukkit;
import org.bukkit.ChatColor;
import org.bukkit.entity.Player;
import org.bukkit.scheduler.BukkitRunnable;

public class Timer {
    private  boolean running;
    private int time;
    private int min;
    public Timer(boolean running, int time) {
        this.running = running;
        this.time = time;

        run();
    }
    public boolean isRunning() {
        return running;
    }
    public void setRunning(boolean running) {
        this.running = running;
    }
    public int getTime() {
        return time;
    }
    public void setTime(int time) {this.time = time;}
    public int getMin() {
        return min;
    }
    public void setMin(int min) {this.min = min;}
    public void sendActionBar(){
        for (Player player: Bukkit.getOnlinePlayers()) {
            if(!isRunning()){
                player.spigot().sendMessage(ChatMessageType.ACTION_BAR, new TextComponent(ChatColor.RED + "Timer ist Pausiert"));
                continue;
            }
            if(time / 60 >= 1){
                min = min + 1 ;
                time = time -60;
            }
            player.spigot().sendMessage(ChatMessageType.ACTION_BAR, new TextComponent(ChatColor.GOLD.toString() + ChatColor.BOLD+ min +":"+time));
        }
    }
    private void run(){
        new BukkitRunnable() {
            @Override
            public void run(){
                sendActionBar();
                if(!isRunning()){
                    return;
                }
                setTime(getTime()+1);
            }
        }.runTaskTimer(Main.getInstance(), 20, 20);
    }

}
