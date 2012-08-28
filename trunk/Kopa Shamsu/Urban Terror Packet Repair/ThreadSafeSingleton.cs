using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Urban_Terror_Packet_Repair
{
    public sealed class ThreadSafeSingleton
    {
        private static volatile ThreadSafeSingleton instance;
        private static object syncRoot = new Object();

        public bool IsTimeToExit { get; set; }

        private ThreadSafeSingleton()
        {
        }

        public static ThreadSafeSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ThreadSafeSingleton();
                    }
                }

                return instance;
            }
        }
    }
}
