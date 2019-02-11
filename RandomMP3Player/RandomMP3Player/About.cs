#region

using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using RandomMP3Player.Properties;

#endregion

namespace RandomMP3Player
{
    internal static class About
    {
        public static List<string> Aboutjes()
        {
            List<string> abouts = new List<string>();
            string versienummer = Assembly.GetExecutingAssembly().GetName().Version.Major + "." +
                                  Assembly.GetExecutingAssembly().GetName().Version.Minor;
            if (Assembly.GetExecutingAssembly().GetName().Version.Build.ToString() != "0")
            {
                versienummer += "." + Assembly.GetExecutingAssembly().GetName().Version.Build;
            }

            switch (Settings.Default.Language)
            {
                case "Ned":
                    abouts.Add("Random MP3 Player and Copier versie " + versienummer); //lblversion
                    abouts.Add("Voor opmerkingen of vragen e-mail mij op:"); //lblquestion
                    abouts.Add("Geprogrammeerd door:TheKidMSX"); //lblProgrammer
                    abouts.Add(versienummer);
                    break;
                case "Eng":
                    abouts.Add("Random MP3 Player and Copier version " + versienummer);
                    abouts.Add("For comments or questions email me at:"); //lblquestion
                    abouts.Add("Coded by:TheKidMSX"); //lblProgrammer
                    abouts.Add(versienummer);
                    break;
            }

            string rauwetext = string.Empty;
            using (
                StreamReader sr =
                    new StreamReader(
                        Assembly.GetExecutingAssembly().GetManifestResourceStream("RandomMP3Player.Licence.txt"),
                        Encoding.UTF7))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    rauwetext += line + "\r\n";
                }
            }

            string[] versies = rauwetext.Split('#');

            switch (Settings.Default.Language)
            {
                case "Eng":
                    abouts.Add(versies[1]);
                    break;
                case "Ned":
                    abouts.Add(versies[2]);
                    break;
            }
            return abouts;
        }


        public static string VersionText()
        {
            string version = string.Empty;
            string rauwetext = string.Empty;
            using (
                StreamReader sr =
                    new StreamReader(
                        Assembly.GetExecutingAssembly().GetManifestResourceStream("RandomMP3Player.VersionInfo.txt"),
                        Encoding.UTF7))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    rauwetext += line + "\r\n";
                }
            }

            string[] versies = rauwetext.Split('#');

            switch (Settings.Default.Language)
            {
                case "Eng":
                    version = versies[0];
                    break;
                case "Ned":
                    version = versies[1];
                    break;
            }
            return version;
        }
    }
}