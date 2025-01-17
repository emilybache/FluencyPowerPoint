using System;

namespace PowerPointGeneration.Tests
{
    public class Details
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                DirectoryName = baseDirectory + "CodeSmells-" + Name;
            }
        }

        public string GoodName { get; set; }
        public string BadName { get; set; }
        public int BackgroundColor { get; set; }
        public float FontSize { get; set; }
        public string GoodNameText { get; set; }
        public string BadNameText { get; set; }
        public string FileEndingWithDot { get; set; }
        public Timings Timings { get; set; }
        public string baseDirectory { get; set; }
        public string FileNameFilter { get; set; }

        public string DirectoryName { get; set; }

        public Details()
        {
            BackgroundColor = 0xFFFFFF;
            FontSize = 120;
            FileEndingWithDot = ".png";
            Timings = new Timings {{2, 100}, {5, 4}, {20, 2.5F}, {Int32.MaxValue, 1.5F}};
            baseDirectory =  @"C:\code\FluencyPowerPoint\PowerPointGeneration\PowerPointGeneration.Tests\";
            FileNameFilter = "CodeSmells-{0}\\{1} {2:00}{3}";
            DirectoryName = baseDirectory + "CodeSmells-" + Name;
        }

        public String GetTextForGood()
        {
            return GoodNameText ?? GoodName;
        }

        public String GetTextForBad()
        {
            return BadNameText ?? BadName;
        }

    }
}