namespace Kernel {
    class Kernel_class {
        public void Kernel_main() {
            Console.WriteLine("\nKernel loaded.");
            Console.WriteLine("APM loaded\n\nAlmost OS Portable. Version 1.00");

            while (true) {
                string path;
                Console.Write("@ash: ");
                var input = Console.ReadLine();
                string[] words = input.Split(' ');
                switch (words[0])
                {
                    case "shutdown":
                        Environment.Exit(0);
                        break;
                    case "help":
                        Console.WriteLine("info - prints info about current cpu");
                        Console.WriteLine("shutdown - shuts down current computer");
                        Console.WriteLine("help - shows this help menu");
                        Console.WriteLine("date - shows date");
                        Console.WriteLine("clear - clears console");
                        Console.WriteLine("mkdir - creates directory");;
                        Console.WriteLine("mkfile - creates file");
                        Console.WriteLine("swdir - shows current directory");
                        Console.WriteLine("remove - deletes file or folder");
                        break;
                    case "info":
                        Console.WriteLine("Main OS: " + Environment.OSVersion + "\nUsername: " + Environment.UserName + "\nDomain: " + Environment.UserDomainName + "\n\nASH Version: 0.1\nAOS Version: 1.01");
                        break;
                    case "date":
                        Console.WriteLine("Your timezone: " + DateTime.Now + "\nUTC: " + DateTime.UtcNow);
                        break;
                    case "clear":
                        Console.Clear();
                        Console.WriteLine("APM loaded\n\nAlmost OS Portable. Version 1.00");
                        break;
                    case "mkdir":
                        Console.WriteLine("Enter your path: ");
                        string path_mkd = Console.ReadLine();
                        Directory.CreateDirectory(path_mkd);
                        Console.WriteLine(path_mkd + "successfully created!");
                        break;
                    case "mkfile":
                        Console.WriteLine("Enter your path: ");
                        string path_mkf = Console.ReadLine();
                        File.Create(path_mkf);
                        Console.WriteLine(path_mkf + "successfully created!");
                        break;  
                    case "swdir":
                        Console.WriteLine(Environment.CurrentDirectory);
                        break;
                    case "remove":
                        Console.WriteLine("Enter path to the file: ");
                        string path_rm = Console.ReadLine();
                        Console.WriteLine("You sure? y/N");
                        string agree = Console.ReadLine();
                            if (agree == "y") {
                                File.Delete(path_rm);
                                Console.WriteLine(path_rm + "successfully deleted!");
                            }
                            if (agree == "N") {
                                Console.WriteLine("Canceling...");
                            }
                        break;
                    default:
                        Console.WriteLine($"\"{words[0]}\" is not a command");
                        break;
                    }
                }
        }
    }
}