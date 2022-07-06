using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProjectClient.Types {
    public class Loot {
        public string Name { get; set; } = "";
        public int MythicEssencePrice { get; set; }
        public int GameCreditPrice { get; set; }
        public string Type { get; set; } = "";
        public int Count { get; set; }

        public override string ToString() {
            if (Count > 0) {
                return $"{Name} - {Count}";
            }
            return $"{Name} - {MythicEssencePrice}ME - {GameCreditPrice}GC";
        }
    }
}
