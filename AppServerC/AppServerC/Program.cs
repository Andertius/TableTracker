﻿using System;

namespace AppServerC
{
    class Program
    {
        static void Main(string[] args)
        {
            Listener listener = new();
            listener.Listen();
        }
    }
}
