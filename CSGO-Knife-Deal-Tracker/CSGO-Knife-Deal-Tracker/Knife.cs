using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace CSGO_Knife_Deal_Tracker
{
    class Knife
    {
        #region Member Variables

        private string baseURL;
        private string knifeURL;
        private string fullURL;
        private string name;
        private double lowPrice;
        private double medPrice;
        private double desiredPrice;
        private int percentage;
        private readonly char[] unwantedChars = new char[12] { '%', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ' '};
        private double prevLow;

        #endregion

        #region Properties

        public string KnifeURL
        {
            get { return knifeURL; }
            set { knifeURL = value; }
        }

        public string FullURL
        {
            get { return fullURL; }
            set { fullURL = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double LowPrice
        {
            get { return lowPrice; }
            set { lowPrice = value; }
        }

        public double MedPrice
        {
            get { return medPrice; }
            set { medPrice = value; }
        }

        public double DesiredPrice
        {
            get { return desiredPrice; }
            set { desiredPrice = value; }
        }

        public int Percentage
        {
            get { return percentage; }
            set { percentage = value; }
        }

        public double PrevLow
        {
            get { return prevLow; }
        }

        #endregion

        #region Constructors

        public Knife(string BaseURL, string KnifeURL, int Percentage)
        {
            this.baseURL = BaseURL;                         // Copy the given BaseURL (should never change)
            this.KnifeURL = KnifeURL;                       // Copy the given URL (from file) as the knife's URL

            percentage = Percentage;

            ProcessURL();                                   // Process it to get name
            GetData();                                      // Then fetch the price data through the constructed final URL
        }

        #endregion

        #region Utility Functions

        private void ProcessURL()
        {
            string name = KnifeURL;

            // Take out the rest of the unwanted chars
            List<string> namePieces = new List<string>();

            namePieces = name.Split('%').ToList();
            string newName = "";

            foreach(string piece in namePieces)
            {
                if (piece[0] < (int)('0') || piece[0] > (int)('9'))
                    newName = newName + piece + " ";
                else
                {
                    string altPiece = piece.Substring(2);
                    newName = newName + piece + " ";
                }
            }

            newName = newName.Trim();                       // Take the space off the end just for good measure

            this.name = newName;

            FullURL = baseURL + KnifeURL;                   // Add KnifeURL to BaseURL to get the full URL
        }

        private void GetData()
        {
            string fileText = (new WebClient()).DownloadString(FullURL);
            char[] badChars = new char[4] { '{', '}', (char) 92, (char)34 };
            // Example text in expected format: {"success":true,"lowest_price":"104,--\u20ac","volume":"4","median_price":"100,29\u20ac"}

            prevLow = lowPrice;

            fileText = fileText.Replace(',', ' ');                              // Replace all commas with spaces
            fileText = fileText.Replace(':', ' ');                              // Replace all colons with spaces

            List<string> textPieces = fileText.Split(' ').ToList();             // Tokenize the file text by the newly created spaces

            for (int i = 0; i < textPieces.Count; i++)
            {
                string currentPiece = textPieces[i];

                if (currentPiece == "\"lowest_price\"")
                {
                    string piece = textPieces[i + 1];
                    piece = piece.Substring(1);
                    LowPrice = Convert.ToDouble(piece);
                    i++;
                }
                else if (currentPiece == "\"median_price\"")
                {
                    string piece = textPieces[i + 1];
                    piece = piece.Substring(1);
                    MedPrice = Convert.ToDouble(piece);
                    i++;
                }
            }

            DesiredPrice = MedPrice * (1 - (percentage * 0.01));
        }

        public void Update()
        {
            GetData();
        }

        #endregion
    }
}
