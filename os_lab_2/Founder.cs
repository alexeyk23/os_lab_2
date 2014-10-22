using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
namespace os_lab_2
{
    class Founder
    {
        private HashSet<string> setOfFNames = new HashSet<string>();//имена файлов
        private DirectoryInfo dInfo;
        public HashSet<string> fileNames 
        {
            get { return setOfFNames; }
            set { setOfFNames = value; }
        }
        public Founder(string dName)
        {
            dInfo = new DirectoryInfo(dName);
        }
        public int getCountFiles()
        {
            getAllFiles(dInfo);
            return setOfFNames.Count;
        }

        private void getAllFiles(DirectoryInfo dinf)
        {
            //текущая 
            DirectoryInfo[] folders = dinf.GetDirectories();
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
            {
                founders[i].Join();
            }
        }

        //получает все файлы в директории
        private void getFiles(object directory)
        {
            DirectoryInfo d = (DirectoryInfo)directory;
            foreach (FileInfo item in d.GetFiles())
            {
                //блокируем множество, чтобы в него добавить имя файл
                lock (setOfFNames)
                {
                    if (item.CreationTime == item.LastWriteTime)
                    {
                        setOfFNames.Add(item.Name);
                    }
                }
            }
        }
    }
}
