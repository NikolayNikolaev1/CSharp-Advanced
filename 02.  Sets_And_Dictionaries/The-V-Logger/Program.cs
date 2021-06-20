using System;
using System.Collections.Generic;
using System.Linq;

namespace The_V_Logger
{
    class Program
    {
        private const string STATISTICS_COMMAND = "statistics";
        private const string SAVE_VLOGGER_COMMAND = "joined";
        private const string FOLLOW_VLOGGER_COMMAND = "followed";
        static void Main(string[] args)
        {
            // TODO: work in progres.....
            HashSet<Vlogger> vloggerSet = new HashSet<Vlogger>();
            bool hasNextCommand = true;

            while (hasNextCommand)
            {
                string[] command = Console.ReadLine().Split();
                string commandName = command[0];

                if (!commandName.ToLower().Equals(STATISTICS_COMMAND))
                {
                    commandName = command[1];
                }

                switch (commandName.ToLower())
                {
                    case SAVE_VLOGGER_COMMAND:
                        string vloggerName = command[0];
                        Vlogger vlogger = new Vlogger(vloggerName);
                        vloggerSet.Add(vlogger);
                        break;
                    case FOLLOW_VLOGGER_COMMAND:
                        string followerName = command[0];
                        string existingVloggerName = command[2];

                        bool doesFollowerExists = vloggerSet.Any(v => v.Name.Equals(followerName));
                        bool doesVloggerExists = vloggerSet.Any(v => v.Name.Equals(existingVloggerName));

                        if (doesFollowerExists && doesVloggerExists)
                        {
                            Vlogger follower = vloggerSet
                                .Where(v => v.Name.Equals(followerName))
                                .FirstOrDefault();

                            Vlogger following = vloggerSet
                                .Where(v => v.Name.Equals(existingVloggerName))
                                .FirstOrDefault();

                            following.addFollower(follower);
                            follower.addFollowing(following);
                        }

                        break;
                    case STATISTICS_COMMAND:
                        var vloggersByFollowers = vloggerSet.OrderByDescending(v => v.Followers.Count);

                        Console.WriteLine($"The V-Logger has a total of {vloggerSet.Count} vloggers in its logs.");
                        int counter = 1;
                        foreach (var v in vloggersByFollowers)
                        {
                            Console.WriteLine($"{counter}. {v.Name} : {v.Followers.Count} followers, {v.Following.Count} following");
                            if (v == vloggersByFollowers.First())
                            {
                                foreach (var vloggerFollower in v.Followers)
                                {
                                    Console.WriteLine($"* {vloggerFollower.Name}");
                                }
                            }
                            counter++;
                        }

                        hasNextCommand = false;
                        break;
                }

            }
        }
    }
}
