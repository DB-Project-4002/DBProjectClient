namespace DBProjectClient.Types {
    public class ChampionSkin {
        public string Name { get; set; } = "";
        public string ChampionName { get; set; } = "";
        public int OrangeEssencePrice { get; set; }
        public int GameCreditPrice { get; set; }

        public override string ToString() {
            return $"{Name} - {OrangeEssencePrice}OE - {GameCreditPrice}GC";
        }
    }
}
