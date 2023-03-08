namespace FirstWebAPI.Models
{
    public class English : WordInterface
    {

        private string[] Words = new string[10]; 

        public English()
        {
            Words[0] = "Ello";
            Words[1] = "Hello";
            Words[2] = "Complacent";
            Words[3] = "Discrepancy";
            Words[4] = "Ephemeral";
            Words[5] = "Frivolous";
            Words[6] = "Gregarious";
            Words[7] = "Insidious";
            Words[8] = "Mellifluous";
            Words[9] = "Querulous";

        }

        public string[] GetAll()
        {
            return Words;
        }

        public string GetOne()
        {
            Random rd = new Random();
            return Words[rd.Next(1, 10)];
        }

        public string[] GetSorted()
        {
            Array.Sort(Words);
            return Words;    
        }
    }
}
