using System;
using System.Collections;

namespace Knives.Chat3
{
    public class DefaultLocal
    {
        public static ArrayList Load()
        {
            ArrayList list = new ArrayList();

            list.Add("Friend");
            list.Add("Views");
            list.Add("Ignore");
            list.Add("Remove Ignore");
            list.Add("Grant Global");
            list.Add("Revoke Global");
            list.Add("Ban");
            list.Add("Remove Ban");
            list.Add("Global Ignore");
            list.Add("Global Unignore");
            list.Add("Listen");
            list.Add("Remove Listen");
            list.Add("Set your away message");
            list.Add("Send Message");
            list.Add("Become User");
            list.Add("Client");
            list.Add("Goto");
            list.Add("Message Sound");
            list.Add("Friend and Messaging Options");
            list.Add("Online");
            list.Add("Away");
            list.Add("Busy");
            list.Add("Hidden");
            list.Add("You must unhide to see the player list");
            list.Add("Only friends can send messages");
            list.Add("Require friend requests");
            list.Add("Global Messages");
            list.Add("Sound on message receive");
            list.Add("Default Message Sound");
            list.Add("Friends speech shortcut");
            list.Add("Friend online alert");
            list.Add("Please select a channel to view");
            list.Add("Friends");
            list.Add("You are banned from chat");
            list.Add("You must join the channel first");
            list.Add("You are not in a chatting region");
            list.Add("You are not in a guild");
            list.Add("You are not in a faction");
            list.Add("Channels");
            list.Add("General Channel Options");
            list.Add("Options");
            list.Add("Channels speech shortcut");
            list.Add("Commands");
            list.Add("Global");
            list.Add("Global Chat");
            list.Add("Global World");
            list.Add("View All");
            list.Add("System Color");
            list.Add("Staff Color");
            list.Add("Color");
            list.Add("Channel");
            list.Add("Ignores");
            list.Add("GIgnores");
            list.Add("GListens");
            list.Add("Bans");
            list.Add("Display");
            list.Add("Mail");
            list.Add("Mail and Messaging Options");
            list.Add("Auto delete week old messages");
            list.Add("Mail speech shortcut");
            list.Add("from");
            list.Add("You must target a book");
            list.Add("Message to");
            list.Add("Recording.  Press send when finished.");
            list.Add("Recording stopped");
            list.Add("Now recording.  Everything you enter on the command line will appear in the message.");
            list.Add("You must have a message to send");
            list.Add("Message sent to");
            list.Add("You are now ignoring");
            list.Add("You delete the message");
            list.Add("Speech command set to");
            list.Add("Speech command cleared");
            list.Add("is no longer on your friend list");
            list.Add("is now on your friend list");
            list.Add("You are no longer ignoring");
            list.Add("now has global listening access");
            list.Add("no longer has global access");
            list.Add("You ban");
            list.Add("You lift the ban from");
            list.Add("You are no longer global ignoring");
            list.Add("You are now global ignoring");
            list.Add("You are no longer globally listening to");
            list.Add("You are now globally listening to");
            list.Add("is no longer online");
            list.Add("Friend Request");
            list.Add("Do you want to add this player as a friend?");
            list.Add("You have sent a friend request to");
            list.Add("has accepted your friend request");
            list.Add("has denied your friend request");
            list.Add("You deny");
            list.Add("You are now banned from chat");
            list.Add("Your chat ban has been lifted");
            list.Add("You've been granted global access");
            list.Add("Your global access has been revoked");
            list.Add("Broadcast to all");
            list.Add("Broadcast");
            list.Add("You can send another request in");
            list.Add("You must wait a few moments between messages");
            list.Add("Enable IRC");
            list.Add("Filter and Spam Options");
            list.Add("IRC Options");
            list.Add("Misc Options");
            list.Add("The server is already attempting to connect");
            list.Add("The server is already connected");
            list.Add("IRC connection failed");
            list.Add("Attempting to connect...");
            list.Add("Connection could not be established");
            list.Add("Connecting to IRC server...");
            list.Add("Server is now connected to IRC channel");
            list.Add("IRC names list updating");
            list.Add("IRC connection down");
            list.Add("Filter violation detected:");
            list.Add("Too many search results, be more specific");
            list.Add("No matching names found");
            list.Add("Select a name");
            list.Add("Auto Connect");
            list.Add("Auto Reconnect");
            list.Add("Nickname");
            list.Add("Server");
            list.Add("Room");
            list.Add("Port");
            list.Add("White");
            list.Add("Black");
            list.Add("Blue");
            list.Add("Green");
            list.Add("Light Red");
            list.Add("Brown");
            list.Add("Purple");
            list.Add("Orange");
            list.Add("Yellow");
            list.Add("Light Green");
            list.Add("Cyan");
            list.Add("Light Cyan");
            list.Add("Light Blue");
            list.Add("Pink");
            list.Add("Grey");
            list.Add("Light Grey");
            list.Add("Select a Color");
            list.Add("Staff Color");
            list.Add("Connect");
            list.Add("Cancel Connect");
            list.Add("Close Connection");
            list.Add("Apply filter to world speech");
            list.Add("Apply filter to private messages");
            list.Add("Chat Spam");
            list.Add("Pm Spam");
            list.Add("Request Spam");
            list.Add("Filter Ban");
            list.Add("Add/Remove Filter");
            list.Add("You remove the filter:");
            list.Add("You add the filter:");
            list.Add("Filters:");
            list.Add("Show staff in channel lists");
            list.Add("Max Mailbox Size");
            list.Add("Filter Penalty");
            list.Add("None");
            list.Add("Ban");
            list.Add("Jail");
            list.Add("IRC connection is down");
            list.Add("IRC Raw");
            list.Add("Select Ban Time");
            list.Add("30 minutes");
            list.Add("1 hour");
            list.Add("12 hours");
            list.Add("1 day");
            list.Add("1 week");
            list.Add("1 month");
            list.Add("1 year");
            list.Add("Local file reloaded");
            list.Add("Reload localized text file");
            list.Add("days");
            list.Add("hours");
            list.Add("minutes");
            list.Add("is now online");
            list.Add("Error loading global options.  Details on the RunUO Console.  Please report this to Knives at kmwill23@hotmail.com");
            list.Add("Error saving global options.  Details on the RunUO Console.  Please report this to Knives at kmwill23@hotmail.com");
            list.Add("Error filtering text.  Please report this to Knives at kmwill23@hotmail.com");
            list.Add("Channel Options");
            list.Add("New Channel");
            list.Add("Please select a channel");
            list.Add("Name");
            list.Add("Style");
            list.Add("Global");
            list.Add("Regional");
            list.Add("Send Chat to IRC");
            list.Add("Add/Remove Command");
            list.Add("Error loading channel information.  Details on the RunUO Console.  Please report this to Knives at kmwill23@hotmail.com");
            list.Add("Error saving channel information.  Details on the RunUO Console.  Please report this to Knives at kmwill23@hotmail.com");
            list.Add("Auto join new players");
            list.Add("You have left the channel");
            list.Add("You have joined the channel");
            list.Add("You must be staff to chat here");
            list.Add("Global Guild");
            list.Add("Global Faction");
            list.Add("The message needs a subject before you can begin recording");
            list.Add("Quick Bar");
            list.Add("Message Read Receipts");
            list.Add("has read");
            list.Add("Error loading gump information.  Details on the RunUO Console.  Please report to Knives at kmwill23@hotmail.com");
            list.Add("Error saving gump information.  Details on the RunUO Console.  Please report to Knives at kmwill23@hotmail.com");
            list.Add("Errors reported by either this chat system or other staff members!  Administrators have the power to clear this list.  All staff members can report an error using the [chaterrors <text> command.");
            list.Add("Chat Error Log");
            list.Add("Clear");
            list.Add("Friends");
            list.Add("Global Ignores");
            list.Add("Global Listens");
            list.Add("History");
            list.Add("General");
            list.Add("Filter");
            list.Add("Spam");
            list.Add("Irc");
            list.Add("Delete Channel");
            list.Add("Enable Channel");
            list.Add("This channel is disabled");
            list.Add("Filter Options");
            list.Add("Spam Options");
            list.Add("Colors");
            list.Add("Mail Options");
            list.Add("Your mailbox is full, please delete some messages so others may send to you.");
            list.Add("Press the button above to select a channel.  When adding commands, do not include the command prefix.");
            list.Add("Delay");
            list.Add("General Options");
            list.Add("Debug");
            list.Add("Show Staff");
            list.Add("Viewing");
            list.Add("You cannot send messages while under another user's identity.");
            list.Add("Global Options");
            list.Add("Error loading player options.  Details on the RunUO Console.  Please report this to Knives at kmwill23@hotmail.com");
            list.Add("Error saving player options.  Details on the RunUO Console.  Please report this to Knives at kmwill23@hotmail.com");
            list.Add("Error loading friends.  Details on the RunUO Console.  Please report this to Knives at kmwill23@hotmail.com");
            list.Add("Error saving friends.  Details on the RunUO Console.  Please report this to Knives at kmwill23@hotmail.com");
            list.Add("Error loading ignores.  Details on the RunUO Console.  Please report this to Knives at kmwill23@hotmail.com");
            list.Add("Error saving ignores.  Details on the RunUO Console.  Please report this to Knives at kmwill23@hotmail.com");
            list.Add("Error loading global listens.  Details on the RunUO Console.  Please report this to Knives at kmwill23@hotmail.com");
            list.Add("Error saving global listens.  Details on the RunUO Console.  Please report this to Knives at kmwill23@hotmail.com");
            list.Add("Error loading private messages.  Details on the RunUO Console.  Please report this to Knives at kmwill23@hotmail.com");
            list.Add("Error saving private messages.  Details on the RunUO Console.  Please report this to Knives at kmwill23@hotmail.com");
            list.Add("Logging");
            list.Add("Log Chat");
            list.Add("Log Pms");
            list.Add("Chat save completed in");
            list.Add("Chat information saving...");
            list.Add("The background you set will now be forced on all players.");
            list.Add("Players can now set their own backgrounds.");
            list.Add("Clear");
            list.Add("Submit");
            list.Add("Signature updated");
            list.Add("Your signature:");
            list.Add("Reply");
            list.Add("Delete");
            list.Add("Accept");
            list.Add("Deny");
            list.Add("Send");
            list.Add("Chat Karma:");
            list.Add("Filter Warnings");
            list.Add("You can't chat while squelched.");
            list.Add("Broadcast to Staff");
            list.Add("Staff");
            list.Add("You have {0} of max {1} in your mailbox.");
            list.Add("Auto-delete old when mailbox full");
            return list;
        }
    }
}