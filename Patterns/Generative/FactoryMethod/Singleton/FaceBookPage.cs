using System;

namespace Singleton
{
    public class FaceBookPage
    {
        private static readonly FaceBookPage Instance = new FaceBookPage();

        public string Name { get; set; }

        private FaceBookPage()
        {
            
        }

        public static FaceBookPage GetInstance()
        {
            return Instance;
        }
        //private static FaceBookPage instance;

        //public string Name { get; set; }
        //private static readonly object SyncRoot = new Object();

        //protected FaceBookPage(string name)
        //{
        //    this.Name = name;
        //}

        //public static FaceBookPage GetInstance(string name)
        //{
        //    if (instance == null)
        //    {
        //        lock (SyncRoot)
        //        {
        //            if (instance == null)
        //                instance = new FaceBookPage(name);
        //        }
        //    }
        //    return instance;
        //}
    }
}
