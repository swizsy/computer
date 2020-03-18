﻿using System;

namespace Computer
{
    public class Cpu
    {
        private Gpu gpu;
        private Hdd hdd;

        private bool quit;

        public Cpu(Gpu gpu, Hdd hdd)
        {
            this.gpu = gpu;
            this.hdd = hdd;
        }

        public void RunProgram()
        {
            while (!quit)
            {
                gpu.DisplayOptions();
                string input = Console.ReadLine();

                int option = 0;
                try
                {
                    option = Int32.Parse(input);
                }
                catch(Exception)
                {
                    gpu.Display(Constants.INVALID_INPUT);
                    continue;
                }

                EvaluateOption(option);
            }
        }

        private void EvaluateOption(int option)
        {
            switch (option)
            {
                case 1:
                    hdd.Save();
                    gpu.Display(Constants.HDD_SAVE);
                    break;
                case 2:
                    gpu.DisplayRecords(hdd.Read());
                    break;
                case 3:
                    hdd.Format();
                    gpu.Display(Constants.HDD_FORMAT);
                    break;
                case 4:
                    quit = true;
                    break;
                default:
                    gpu.Display(Constants.NO_SUCH_OPTION);
                    break;
            }
        }
    }
}