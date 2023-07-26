using Kernel;
using APM;

namespace Boot {
    class Bootloader {
        public static void Main(string[] args) {
            Console.WriteLine("Bootloader ready.");
            Bootloader boot = new Bootloader();
            boot.Boot();
        }

        private void Boot()
        {
            Kernel_class kernel = new Kernel_class();
            kernel.Kernel_main();

            Console.WriteLine("\nKernel loaded.");

            PackageManager apm = new PackageManager();
            apm.Package_Download();

            Console.WriteLine("APM loaded\n\nAlmost OS Portable. Version 1.00");
        }
    }
}
