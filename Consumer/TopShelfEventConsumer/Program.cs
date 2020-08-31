﻿using System;
using Topshelf;

namespace TopShelfEventConsumer
{
    class Program
    {
        public static int Main()
        {
            return (int) HostFactory.Run(cfg =>
            {
                cfg.Service(x => new EventConsumerService());
            });
        }
    }
}
