namespace DBProjectClient.Types {
    public class Account {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Tag { get; set; } = "";
        public string Username => $"{Name}#{Tag}";
        public string Email { get; set; } = "";
        public bool IsBlocked { get; set; }

        public override string ToString() {
            return Username;
        }
    }
}
