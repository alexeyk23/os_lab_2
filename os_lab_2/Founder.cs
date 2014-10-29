using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Collections;
namespace os_lab_2
{
    class Founder
    {
        private HashSet<string> setOfFNames = new HashSet<string>();//имена файлов
        private string directoryName;
        public HashSet<string> fileNames 
        {
            get { return setOfFNames; }
            set { setOfFNames = value; }
        }
        public Founder(string dName)
        {
            directoryName = dName;
        }
        
       public int getCountFiles()
        {
            getAllFiles(directoryName);
            return setOfFNames.Count;
        }
        private void getAllFiles(string dinf)
        {           
            string[] folders = RsdnDirectory.GetAllDirectories(dinf).ToArray();
            //сыщики в папке
            Thread[] founders = new Thread[folders.Length];

            for (int i = 0; i < folders.Length; i++)
            {
                founders[i] = new Thread(getFiles);
                founders[i].Start(folders[i]);
            }
            Thread t1 = new Thread(getFiles);
            t1.Start(dinf);
            t1.Join();
            for (int i = 0; i < folders.Length; i++)            
                founders[i].Join();
            
        }

        //получает все файлы в директории по условию
        private void getFiles(object directory)
        {
            string d = (string)directory;
            foreach (string item in RsdnDirectory.GetFilse(d))
            {
                //блокируем множество, чтобы в него добавить имя файл
                lock (setOfFNames)
                {                    
                    setOfFNames.Add(item);                    
                }
            }
        }
    }
}
