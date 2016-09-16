using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FactoryMethodPattern
{
    class TextFile : File
    {
        private string name;
        private string fileType = ".txt";
        public TextFile(string name)
        {
            this.name = name;
        }

        public void createFile()
        {
            System.IO.File.Create("C:\\Temp\\" + name + fileType).Close();
            
        }

        public void writeToFile(string text)
        {
            System.IO.File.WriteAllText("C:\\Temp\\" + name + fileType, text);
        }

        public string getFileType()
        {
            return fileType;
        }

        public string getName()
        {
            return name;
        }
    }
}
