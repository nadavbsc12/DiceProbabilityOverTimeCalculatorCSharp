using System;
using System.Collections.Generic;
using System.Linq;

namespace YourNamespace
{
    class Program
    {
        static Random rng = new Random();

        static List<(string, double)> items = new List<(string, double)>
        {
            ("Hanzo Kabuto", 0.0002),
            ("Hanzo Yori", 0.0002),
            ("Hanzo Haidate", 0.0002),
            ("Hanzo Kote", 0.0002),
            ("Hanzo Kogake", 0.0002),
            ("Hanzo Mempo", 0.0002),
            ("Hanzo Sashimono", 0.0002),
            ("Hattori Kabuto", 0.0002),
            ("Hattori Yori", 0.0002),
            ("Hattori Haidate", 0.0002),
            ("Hattori Kote", 0.0002),
            ("Hattori Kogake", 0.0002),
            ("Hattori Mempo", 0.0002),
            ("Hattori Sashimono", 0.0002),
            ("Golden Warrior", 0.0002),
            ("Musashi Headgear", 0.0002),
            ("Musashi Glare", 0.0002),
            ("Musashi Armor", 0.0002),
            ("Musashi Greaves", 0.0002),
            ("Musashi Gauntlets", 0.0002),
            ("Musashi Boots", 0.0002),
            ("Gozen Headgear", 0.0002),
            ("Gozen Glare", 0.0002),
            ("Gozen Armor", 0.0002),
            ("Gozen Greaves", 0.0002),
            ("Gozen Gauntlets", 0.0002),
            ("Gozen Boots", 0.0002),
            ("Ronin HeadBand", 0.0002),
            ("Ronin Armor", 0.0002),
            ("Ronin Greaves", 0.0002),
            ("Ronin Gauntlets", 0.0002),
            ("Red Ronin HeadBand", 0.0002),
            ("Red Ronin Armor", 0.0002),
            ("Red Ronin Greaves", 0.0002),
            ("Red Ronin Gauntlets", 0.0002),
            ("Hanzo Kabuto", 0.0002),
            ("Hanzo Yori", 0.0002),
            ("Hanzo Haidate", 0.0002),
            ("Hanzo Kote", 0.0002),
            ("Hanzo Kogake", 0.0002),
            ("Hattori Kabuto", 0.0002),
            ("Hattori Yori", 0.0002),
            ("Hattori Haidate", 0.0002),
            ("Hattori Kote", 0.0002),
            ("Hattori Kogake", 0.0002),
            ("Genshin G-Dadao (Select Capsule)", 0.0002),
            ("Genshin S-Dadao (Select Capsule)", 0.0002),
            ("Genshin B-Dadao (Select Capsule)", 0.0002),
            ("Oda G-Shotgun (Select Capsule)", 0.0002),
            ("Oda S-Shotgun (Select Capsule)", 0.0002),
            ("Oda B-Shotgun (Select Capsule)", 0.0002),
            ("Jubei B-Rifle (Select Capsule)", 0.0002),
            ("Jubei S-Rifle (Select Capsule)", 0.0002),
            ("Jubei G-Rifle (Select Capsule)", 0.0002),
            ("Musa G-Bazooka (Select Capsule)", 0.0002),
            ("Musa S-Bazooka (Select Capsule)", 0.0002),
            ("Musa B-Bazooka (Select Capsule)", 0.0002),
            ("Gracious Hair", 0.0155),
            ("Gracious Top", 0.0155),
            ("Noble Top", 0.0155),
            ("Gracious Gloves", 0.0155),
            ("Gracious Boots", 0.0155),
            ("Gold Bottle Cap", 0.0155),
            ("Stitches and Scars", 0.0155),
            ("Energy Can", 0.0155),
            ("Energy Hands", 0.0155),
            ("Plain Skinny Legs", 0.0155),
            ("Energy Boots", 0.0155),
            ("Samurai Hair", 0.0155),
            ("Hip Hop Tee", 0.0155),
            ("Blue Shorts", 0.0155),
            ("Powerful Hands", 0.0155),
            ("Orange Star Boots", 0.0155),
            ("Blue Jacket", 0.0155),
            ("White Line Socks", 0.0155),
            ("Dj Khan Jeans", 0.0155),
            ("Tecktonik Gloves", 0.0155),
            ("Tecktonik Shoes", 0.0155),
            ("DJ Khan Abs", 0.0155),
            ("DJ Khan Headset", 0.0155),
            ("Short Brown Hair", 0.0155),
            ("Blue Basic Top", 0.0155),
            ("Blue Basic Pants", 0.0155),
            ("Fitted Gloves", 0.0155),
            ("Blue Basic Shoes", 0.0145),
            ("Sacred Hair", 0.0145),
            ("Sacred Face", 0.0145),
            ("Sophitia Negligee", 0.0145),
            ("Sacred Bracelets", 0.0145),
            ("Sophitia Heels", 0.0145),
            ("Sophitia Legs", 0.0145),
            ("Pink Wing V-Cut", 0.0145),
            ("Belted Thigh Highs", 0.0145),
            ("Stunning Hands", 0.0145),
            ("Triple Buckle Boots", 0.0145),
            ("Steel Hammer (A)", 0.0145),
            ("Steel Hammer (B)", 0.0145),
            ("Steel Hammer (C)", 0.0145),
            ("Mad Wrench (A)", 0.0145),
            ("Mad Wrench (B)", 0.0145),
            ("Mad Wrench (C)", 0.0145),
            ("Sherlock (A)", 0.0145),
            ("Sherlock (B)", 0.0145),
            ("Sherlock (C)", 0.0145),
            ("KW-79 (A)", 0.0145),
            ("KW-79 (B)", 0.0145),
            ("KW-79 (C)", 0.0145),
            ("Venom (A)", 0.0145),
            ("Venom (B)", 0.0145),
            ("Venom (C)", 0.0145),
            ("Venom (D)", 0.0145),
            ("Firefly (A)", 0.0145),
            ("Firefly (B)", 0.0145),
            ("Firefly (C)", 0.0145),
            ("Pocket Rocket (A)", 0.0145),
            ("Pocket Rocket (B)", 0.0145),
            ("Pocket Rocket (C)", 0.0145),
            ("Pulse (A)", 0.0145),
            ("Pulse (B)", 0.0145),
            ("Pulse (C)", 0.0145),
            ("500 MP Coin", 0.0125),
            ("1,000 MP Coin", 0.01),
            ("1,500 MP Coin", 0.008),
            ("2,000 MP Coin", 0.007),
            ("2,500 MP Coin", 0.005),
            ("3,500 MP Coin", 0.0041),
            ("4,000 MP Coin", 0.0022),
            ("4,500 MP Coin", 0.0004),
            ("5,000 MP Coin", 0.0003)
        };

        static void Main(string[] args)
        {
            rng = new Random(rng.Next(1, 101));

            double totalProbability = items.Sum(item => item.Item2);
            if (!(0.99 <= totalProbability && totalProbability <= 1.01))
            {
                throw new Exception($"The probabilities do not sum up to 1! The sum is {totalProbability}");
            }

            Console.WriteLine("Amount of runs: ");
            int runs;
            while (!int.TryParse(Console.ReadLine(), out runs))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            var probabilities = CalculateProbability(runs);
            foreach (var (item, (observedProb, picks, totalPicks)) in probabilities)
            {
                Console.WriteLine($"Probability of {item}: {observedProb * 100:0.0000}% ({picks}/{totalPicks} picks)");
            }

            string target = "Golden Warrior";
            int runsNeeded = CalculateProbabilityUntilItem(target);
            Console.WriteLine($"It took {runsNeeded} runs to get {target}.");
        }

        static string GenerateItem()
        {
            var totalProbability = items.Sum(item => item.Item2);
            var draw = rng.NextDouble();
            double cumulative = 0.0;
            foreach (var (name, probability) in items)
            {
                cumulative += probability;
                if (draw < cumulative)
                {
                    return name;
                }
            }
            throw new Exception("Failed to generate an item!");
        }

        static Dictionary<string, (double, int, int)> CalculateProbability(int runs)
        {
            Dictionary<string, int> observedCounts = new Dictionary<string, int>();
            for (int i = 0; i < runs; i++)
            {
                var item = GenerateItem();
                if (observedCounts.ContainsKey(item))
                    observedCounts[item]++;
                else
                    observedCounts[item] = 1;
            }

            var probabilities = observedCounts.ToDictionary(
                pair => pair.Key,
                pair => (pair.Value / (double)runs, pair.Value, runs)
            );

            return probabilities;
        }

        static int CalculateProbabilityUntilItem(string targetItem)
        {
            int runCount = 0;
            while (true)
            {
                runCount++;
                if (GenerateItem() == targetItem)
                {
                    break;
                }
            }
            return runCount;
        }
    }
}
