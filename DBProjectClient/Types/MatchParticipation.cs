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
        public int Item1Id { get; set; }
        public int Item2Id { get; set; }
        public int Item3Id { get; set; }
        public int Item4Id { get; set; }
        public int Item5Id { get; set; }
        public int Item6Id { get; set; }

        public override string ToString() {
            var str = $"[{Time}] - {AccountUsername} - {ChampionName} - {Grade} - {Kills}/{Deaths}/{Assists} - CS:{CS} - DS:{DS} - Dragons:{Dragons} - Rifts:{Rifts}";
            if (Item1Id != 0) str += $" - Item:{Item1Id}";
            if (Item2Id != 0) str += $" - Item:{Item2Id}";
            if (Item3Id != 0) str += $" - Item:{Item3Id}";
            if (Item4Id != 0) str += $" - Item:{Item4Id}";
            if (Item5Id != 0) str += $" - Item:{Item5Id}";
            if (Item6Id != 0) str += $" - Item:{Item6Id}";
            return str;
        }
    }
}
