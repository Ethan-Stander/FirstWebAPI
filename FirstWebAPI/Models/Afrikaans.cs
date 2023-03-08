namespace FirstWebAPI.Models
{
    public class Afrikaans : WordInterface
    {
        private string[] Worde = new string[10];

        public Afrikaans()
        {
            Worde[0] = "Hallo";
            Worde[1] = "Dankie";
            Worde[2] = "Ja";
            Worde[3] = "Nee";
            Worde[4] = "Goed";
            Worde[5] = "Sleg";
            Worde[6] = "Huis";
            Worde[7] = "Skool";
            Worde[8] = "Dier";
            Worde[9] = "Voel";
        }


        public string[] GetAll()
        {    
            return Worde;
        }

        public string GetOne()
        {
            Random rd = new Random();
            int iNum = rd.Next(0, 10);
            return Worde[iNum];
        }

        public string[] GetSorted()
        {
            Array.Sort(Worde);
            return Worde;

        }
    }
}
