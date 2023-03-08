namespace FirstWebAPI.Models
{
    public interface WordInterface
    {

        public string GetOne();

        public string[] GetAll();

        public string[] GetSorted();

    }
}
