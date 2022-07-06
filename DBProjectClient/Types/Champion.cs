namespace DBProjectClient.Types {
    public class Champion {
        public string Name { get; set; } = "";
        public int BlueEssencePrice { get; set; }
        public int GameCreditPrice { get; set; }

        public override string ToString() {
            return $"{Name} - {BlueEssencePrice}BE - {GameCreditPrice}GC";
        }
    }
}
