package at.eugene.aprprojekt.commands;

import at.eugene.aprprojekt.DeathandRespawn.DeathandRespawn;
import at.eugene.aprprojekt.Main;
import at.eugene.aprprojekt.timer.Timer;
import org.bukkit.ChatColor;
import org.bukkit.command.Command;
import org.bukkit.command.CommandExecutor;
import org.bukkit.command.CommandSender;

import org.bukkit.GameMode;
import org.bukkit.entity.Player;

public class TimmerCommand implements CommandExecutor {
    @Override
    public boolean onCommand(CommandSender sender, Command command, String label, String[] args) {

        if(args.length == 0){
            SendUsage(sender);
            return true;
        }
        switch (args[0].toLowerCase()){
            case "resume": {
                Timer timer = Main.getInstance().getTimer();
                if (timer.isRunning()) {
                    sender.sendMessage(ChatColor.RED + "Der Timer läuft bereits");
                    break;
                }
                Player p= (Player) sender;
                p.setGameMode(GameMode.SURVIVAL);
                timer.setRunning(true);
                sender.sendMessage(ChatColor.GRAY + "Der Timer wurde gestartet.");
                break;
            }
            case "pause": {
                Timer timer = Main.getInstance().getTimer();
                if (!timer.isRunning()) {
                    sender.sendMessage(ChatColor.RED + "Der Timer läuft bereits");
                    break;
                }
                timer.setRunning(false);
                sender.sendMessage(ChatColor.GRAY + "Der Timer wurde gestoppt.");
                break;
            }
            case "time": {
                if(args.length != 2){
                    sender.sendMessage(ChatColor.GRAY + "Verwendung: "+ ChatColor.BLUE + "/timer time <Zeit>");
                    return  true;
                }
                try {
                    Timer timer = Main.getInstance().getTimer();
                    timer.setRunning(false);
                    timer.setTime(Integer.parseInt(args[1]));
                    sender.sendMessage(ChatColor.GRAY +"Die Zeit wurde auf " + args[1]+" gesetzt");
                }catch (NumberFormatException e){
                    sender.sendMessage(ChatColor.RED + "Dein Parameter 2 muss eine Zahl sein.");
                }
            }
            break;
            case "reset":{
                Timer timer = Main.getInstance().getTimer();
                Player p= (Player) sender;
                p.setHealth(0.0);

                timer.setRunning(false);
                timer.setTime(0);
                timer.setMin(0);
                sender.sendMessage(ChatColor.GRAY + "Der Timer wurde zurückgesetzt.");
                break;
            }
            default:
                SendUsage(sender);
                break;
        }
        return false;
    }

    private void SendUsage(CommandSender sender){
        sender.sendMessage(ChatColor.GRAY + "Verwendung: "+ ChatColor.BLUE + "/timer resume, timer pause, timer time <Zeit>, /timer reset");
    }
}
