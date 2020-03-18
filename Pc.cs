using System;

namespace Computer
{
    public static class Pc
    {
        private static Gpu gpu;
        private static Hdd hdd;
        private static Cpu cpu;

        private static void Main(string[] args)
        {
            gpu = new Gpu();
            hdd = new Hdd();
            cpu = new Cpu(gpu, hdd);

            cpu.RunProgram();
        }
    }
}
