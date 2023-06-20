package at.eugene.aprprojekt.commands;

import at.eugene.aprprojekt.DeathandRespawn.DeathandRespawn;
import org.bukkit.ChatColor;
import org.bukkit.command.Command;
import org.bukkit.command.CommandExecutor;
import org.bukkit.command.CommandSender;

public class DeathCommand implements CommandExecutor {
    @Override
    public boolean onCommand(CommandSender sender, Command command, String label, String[] args) {

        if(args.length == 0){
            SendUsage(sender);
            return true;
        }
        switch (args[0].toLowerCase()){
            case "count": {
                sender.sendMessage(ChatColor.GRAY + "Tode: "+ DeathandRespawn.deaths);
                break;
            }
            default:
                SendUsage(sender);
                break;
        }
        return false;
    }

    private void SendUsage(CommandSender sender){
        sender.sendMessage(ChatColor.GRAY + "Verwendung: "+ ChatColor.BLUE + "/deaths deaths");
    }
}

