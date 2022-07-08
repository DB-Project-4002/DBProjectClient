namespace DBProjectClient.Types {
    public class MatchParticipation {
        public int AccountId { get; set; }
        public string AccountUsername { get; set; }
        public DateTime Time { get; set; }
        public string Team { get; set; }
        public string ChampionName { get; set; }
        public string Grade { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public int CS { get; set; }
        public int DS { get; set; }
        public int Dragons { get; set; }
        public int Rifts { get; set; }
        public int Item1 { get; set; }
        public int Item2 { get; set; }
        public int Item3 { get; set; }
        public int Item4 { get; set; }
        public int Item5 { get; set; }
        public int Item6 { get; set; }

        public override string ToString() {
            var str = $"[{Time}] - {AccountUsername} - Champion: {ChampionName} - Grade: {Grade} - KDA: {Kills}/{Deaths}/{Assists} - CS: {CS} - DS: {DS} - Dragons: {Dragons} - Rifts: {Rifts}";
            if (Item1 != 0) str += $" - Item: {Item1}";
            if (Item2 != 0) str += $" - Item: {Item2}";
            if (Item3 != 0) str += $" - Item: {Item3}";
            if (Item4 != 0) str += $" - Item: {Item4}";
            if (Item5 != 0) str += $" - Item: {Item5}";
            if (Item6 != 0) str += $" - Item: {Item6}";
            return str;
        }
    }
}
