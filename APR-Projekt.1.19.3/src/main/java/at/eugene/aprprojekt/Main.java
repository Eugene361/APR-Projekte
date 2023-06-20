package at.eugene.aprprojekt;

import at.eugene.aprprojekt.DeathandRespawn.DeathandRespawn;
import at.eugene.aprprojekt.commands.DeathCommand;
import at.eugene.aprprojekt.commands.TimmerCommand;
import at.eugene.aprprojekt.liteners.JoinListener;
import at.eugene.aprprojekt.timer.Timer;
import org.bukkit.Bukkit;
import org.bukkit.event.Listener;
import org.bukkit.plugin.PluginManager;
import org.bukkit.plugin.java.JavaPlugin;
public final class Main extends JavaPlugin {
    private  static Main instance;
    private Timer timer;
    public static Main getInstance() {
        return instance;
    }
    @Override
    public void onLoad() {
        instance = this;
    }
    @Override
    public void onEnable() {
        PluginManager pm = Bukkit.getPluginManager();
        pm.registerEvents(new JoinListener(), this);

        getCommand("timer").setExecutor(new TimmerCommand());

        timer = new Timer(false, 0);
        getCommand("deaths").setExecutor(new DeathCommand());
        Bukkit.getServer().getPluginManager().registerEvents(new DeathandRespawn(), this);
    }
    public Timer getTimer() {
        return timer;
    }
    @Override
    public void onDisable() {
        // Plugin shutdown logic
    }
}
