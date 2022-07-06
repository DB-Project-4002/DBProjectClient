namespace DBProjectClient.Types {
    public class Sticker {
        public string Name { get; set; } = "";
        public int GameCreditPrice { get; set; }
        public bool Owned { get; set; }

        public override string ToString() {
            if (Owned) {
                return Name;
            }
            return $"{Name} - {GameCreditPrice}GC";
        }
    }
}
