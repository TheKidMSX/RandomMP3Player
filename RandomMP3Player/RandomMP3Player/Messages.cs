#region

using System.Windows.Forms;
using RandomMP3Player.Properties;

#endregion

namespace RandomMP3Player
{
    public static class Messages
    {
        public static void Message(string mess)
        {
            string melding = string.Empty;
            string language = Settings.Default.Language;

            switch (mess)
            {
                case "directorybestaatniet":
                    if (language == "Ned") melding = "De directory bestaat niet! # Directory bestaat niet!";
                    if (language == "Eng") melding = "There is no such directory! # No such directory!";
                    break;
                case "geenkopieselectie":
                    if (language == "Ned")
                        melding =
                            "U heeft niets geselecteerd dus er valt niets af te kopieren! # Geen selectie gemaakt!";
                    if (language == "Eng")
                        melding =
                            "Since you've selected nothing, there isn't anything to be copied! # No selection made!";
                    break;
                case "geenselectie":
                    if (language == "Ned")
                        melding = "Er is geen selectie gemaakt om te bewaren! # Geen selectie gemaakt!";
                    if (language == "Eng") melding = "There is no selection made to save! # No selection made!";
                    break;
                case "nietsgeselecteerd":
                    if (language == "Ned")
                        melding = "U heeft niets geselecteerd dus er valt niets af te spelen! # Geen selectie gemaakt!";
                    if (language == "Eng")
                        melding = "You have selected nothing, so there isn't anything to play! # No selection made!";
                    break;
                case "standaarddir":
                    if (language == "Ned")
                        melding = "Geef de standaard directory met mp3 bestanden aan! # Selecteer standaard directory!";
                    if (language == "Eng")
                        melding = "Select the default directory for the mp3 files! # Specify default directory!";
                    break;
                case "vullijsteerst":
                    if (language == "Ned")
                        melding = "U moet eerst de lijst vullen, voordat u een selectie kunt laden! # Lege lijst!";
                    if (language == "Eng")
                        melding = "You must first fill the list, before you can load the selection! # Empty list!";
                    break;
                case "extensieonbruikbaar":
                    if (language == "Ned")
                        melding = "Het opgegeven audiotype is niet bruikbaar! # Audiotype niet bruikbaar!";
                    if (language == "Eng") melding = "The specified audiotype can't be used! # Audiotype not useable!";
                    break;
                case "geensongs":
                    if (language == "Ned")
                        melding =
                            "Er zijn geen muziekbestanden aangetroffen met de extensie(s) zoals opgegeven in de .ini file! # Geen muziekbestanden gevonden!";
                    if (language == "Eng")
                        melding =
                            "There are no musicfiles found with the extension(s) specified in the .ini file! # No musicfiles found!";
                    break;
            }
            string[] messtitle = melding.Split('#');
            MessageBox.Show(messtitle[0], messtitle[1]);
        }
    }
}