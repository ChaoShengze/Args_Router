using System;
using System.Collections;

namespace Args_Router
{
    public class args_router
    {
        private static Hashtable hashtable = new Hashtable();
        public delegate void runnable(string[] args);
        public static void register(string name, runnable callback)
        {
            hashtable.Add(name, callback);
        }

        public static void run(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                throw new SystemException("args is null!");
            }

            var length = args.Length - 1;
            var arr = new string[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = args[i + 1];
            }

            var name = args[0];
            if (hashtable.ContainsKey(name) == false)
            {
                throw new SystemException(name + " has not be registered!");
            }
            var callback = (runnable)hashtable[name];
            callback(arr);
        }
    }
}
