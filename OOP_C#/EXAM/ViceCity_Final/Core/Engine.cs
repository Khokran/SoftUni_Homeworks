namespace ViceCity.Core
{
    using System;

    using Contracts;
    using IO.Contracts;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly IController controller;

        public Engine(
            IReader reader,
            IWriter writer,
            IController controller)
        {
            this.reader = reader;
            this.writer = writer;
            this.controller = controller;
        }

        public void Run()
        {
            while (true)
            {
                var input = this.reader.ReadLine().Split();

                var message = string.Empty;

                if (input[0] == "Exit")
                {
                    Environment.Exit(0);
                }

                try
                {
                    if (input[0] == "AddPlayer")
                    {
                        var username = input[1];

                        message = this.controller.AddPlayer(username);
                    }
                    else if (input[0] == "AddGun")
                    {
                        var gunType = input[1];
                        var gunName = input[2];

                        message = this.controller.AddGun(gunType, gunName);
                    }
                    else if (input[0] == "AddGunToPlayer")
                    {
                        var playerName = input[1];

                        message = this.controller.AddGunToPlayer(playerName);
                    }
                    else if (input[0] == "Fight")
                    {
                        message = this.controller.Fight();
                    }            
                }
                catch (ArgumentException ae)
                {
                    this.writer.WriteLine(ae.Message);
                }

                this.writer.WriteLine(message);
            }
        }
    }
}
