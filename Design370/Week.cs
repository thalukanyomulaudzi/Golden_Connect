using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design370
{
    class Week
    {
        public string Day1Slot { get; set; } = "";
        public string Day2Slot { get; set; } = "";
        public string Day3Slot { get; set; } = "";
        public string Day4Slot { get; set; } = "";
        public string Day5Slot { get; set; } = "";
        public string Day6Slot { get; set; } = "";
        public string Day7Slot { get; set; } = "";

        public Week(List<string> list)
        {
            if (list.Count != 7)
            {
                throw new Exception("The list does not match the required amount of days. Current amount: " + list.Count);
            }
            else
            {
                Day1Slot = list[0];
                Day2Slot = list[1];
                Day3Slot = list[2];
                Day4Slot = list[3];
                Day5Slot = list[4];
                Day6Slot = list[5];
                Day7Slot = list[6];
            }
        }

    }
}
