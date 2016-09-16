namespace FactoryMethodPattern
{
    public interface File
    {
        string getName();
        string getFileType();
        void createFile();
        void writeToFile(string text);
    }
}