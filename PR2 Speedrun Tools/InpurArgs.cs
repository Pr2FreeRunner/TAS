using System;
using System.IO;

namespace PR2_Speedrun_Tools
{
    public static class InputArgs
    {
        public static string LevelFilepath { get; set; }

        public static bool SimpleView { get; set; }

        static InputArgs()
        {
            try
            {
                string[] commandLineArgs = Environment.GetCommandLineArgs();
                bool simpleView;
                if (bool.TryParse((commandLineArgs.Length >= 3) ? commandLineArgs[2] : string.Empty, out simpleView))
                {
                    InputArgs.SimpleView = simpleView;
                }
                string text = (commandLineArgs.Length >= 2) ? commandLineArgs[1] : string.Empty;
                if (File.Exists(text))
                {
                    InputArgs.LevelFilepath = text;
                }
            }
            catch
            {
            }
        }
    }
}
