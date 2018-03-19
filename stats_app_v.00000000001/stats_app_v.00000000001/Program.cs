using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace stats_app_
{
    
    class Program
    {
        const String key = "RGAPI-8a343779-5707-4bf4-9bc3-d4888d4c7187";
        static void Main(string[] args)
        {

        }
    }
}

/*
 * static void Main(string[] args)
        {
            Task.Run(async () =>
           {
               await asyncApi();
           }).Wait();
            Console.WriteLine("Press Enter to Exit...");
            Console.ReadLine();
        }

        public static async Task asyncApi()
        {
            
            try
            {
                var apiAccess = RiotApi.GetDevelopmentInstance(key);
                var staticApi = StaticRiotApi.GetInstance(key);

                var championList = await staticApi.GetChampionsAsync(RiotSharp.Misc.Region.na);
                var runeList = await staticApi.GetRunesAsync(RiotSharp.Misc.Region.na);
                var summoner = await apiAccess.Summoner.GetSummonerByNameAsync(RiotSharp.Misc.Region.na, "PapaSimmz");
                Console.WriteLine((summoner.GetType().ToString()));
                Console.WriteLine(summoner.AccountId.ToString() + ": " + summoner.Name + "\r\n");
                var summonerRecentGames = await apiAccess.Match.GetRecentMatchesAsync(RiotSharp.Misc.Region.na, summoner.AccountId);
                Console.WriteLine("Number of recent games: {0}", summonerRecentGames.Count());
                var matchData = await apiAccess.Match.GetMatchAsync(RiotSharp.Misc.Region.na, summonerRecentGames[0].GameId);
                Console.WriteLine(string.Format("Match ID: {0} | Game Type {1}\r\n", matchData.GameId, matchData.GameType));
                Console.Write(string.Format(" {0,10} | {1,20} | {2,10} | {3,50}\r\n", "Account ID", "Name", "Champion", "Runes"));
                foreach (var participant in matchData.ParticipantIdentities)
                {
                    // var playerChampion = await apiAccess.Champion.GetChampionAsync(RiotSharp.Misc.Region.na,
                    //   matchData.Participants[participant.ParticipantId].ChampionId);

                    string championName="";
                    if (championList.Keys.TryGetValue(matchData.Participants[participant.ParticipantId-1].ChampionId, out championName))
                    {
                        championName = championList.Keys[matchData.Participants[participant.ParticipantId-1].ChampionId].ToString();
                    }
                    
                    
                    //var championName = matchData.Participants[participant.ParticipantId-1].ChampionId.ToString();

                    //championList.Keys.TryGetValue(matchData.Participants[participant.ParticipantId].ChampionId
                    Console.Write(string.Format(" {0,10} | {1,20} | {2,10} | ", 
                        participant.Player.AccountId, participant.Player.SummonerName,
                        championName
                        ));
                    foreach (var runeI in matchData.Participants[participant.ParticipantId - 1].Stats.)
                    {
                        string runeName = runeI.RuneId.ToString();
                        RiotSharp.Endpoints.StaticDataEndpoint.Rune.RuneStatic rune;
                        if (runeList.Runes.TryGetValue(runeI.RuneId, out rune))
                        {
                            runeName = runeList.Runes[runeI.RuneId].Name.ToString();
                        }
                        Console.Write(string.Format("{0,10}, ", runeName));
                    }




                }
            }
            catch (RiotSharpException ex)
            {
                Console.WriteLine("Fuck");
                Console.WriteLine(ex.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Fuck Hammer");
                Console.WriteLine(ex.ToString());
            }
        }
*/