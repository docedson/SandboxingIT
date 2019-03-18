using System;
using System.Collections.Generic;
using System.Text;

namespace SerialNumbers
{
    public class SerialNums
    {
        private static volatile SerialNums instance;
        private static object synchronizationRoot = new object();
        private int _count = 1245;

        /*public static SerialNums Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialNums();
                        }
                    }
                }
                return instance;
            }
        }*/
        private SerialNums() { }
        
        public int NextSerial
        {            
            get { return ++_count; }
        }

    }
}