using System;
using System.Diagnostics;

namespace StringExtensionsNamespace
{
    public static class MessageWriter
    {
        public static void Execute()
        {
#if (ShouldUseConsole)
            Console.WriteLine("MESSAGE_TO_WRITE");
#else
            Debug.WriteLine("MESSAGE_TO_WRITE");
#endif
        }
    }
}