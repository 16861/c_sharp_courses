using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;

namespace SingleResponsibility_Before {
    public class RiskManager {
        private List<string> BadPhones { get; set; }

        public RiskManager()
        {
            BadPhones = File.ReadAllText(@"badphones.txt")
                .Split(Environment.NewLine)
                .Select(x => x.Trim())
                .ToList();
        }

        public bool CheckForBadPhones(string phoneNumber) {
            return BadPhones.Contains(phoneNumber);
        }
    }
}