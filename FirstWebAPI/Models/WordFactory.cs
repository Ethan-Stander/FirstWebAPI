namespace FirstWebAPI.Models
{
    public class WordFactory
    {
        private static WordFactory instance; 

        private static WordInterface wordInterface;

        int iCount = 0;
        private WordFactory()
            {
            iCount++;
            }


        public static WordFactory getInstance()
        {
            if(instance == null)
                {

                instance = new WordFactory();
                }   

            return instance;
        }


        public WordInterface getWordInterface(string Input)
        {

            if(Input == "English")
                {
                wordInterface = new English();
                }
            else
                if(Input == "Afrikaans")
            {
                wordInterface = new Afrikaans();
            }
            else
            {
                wordInterface = new Xhosa();
            }
            return wordInterface;
        }





    }
}
