namespace FirstWebAPI.Models
{
    public class Xhosa : WordInterface
    {

        private string[] Umlo = new string[10];

        public Xhosa()
        {
            Umlo[0] = "nje";
            Umlo[1] = "ntu";
            Umlo[2] = "nto";
            Umlo[3] = "kwa";
            Umlo[4] = "nya";
            Umlo[5] = "nxa";
            Umlo[7] = "zonke";
            Umlo[8] = "xa";
            Umlo[9] = "yile"; 
        }


        public string[] GetAll()
        {
            return Umlo;
        }

        public string GetOne()
        {
            Random rd = new Random();
            return Umlo[rd.Next(1, 10)];
        }

        public string[] GetSorted()
        {
            Array.Sort(Umlo);
            return Umlo;
        }
    }
}
