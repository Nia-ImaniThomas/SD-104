using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson13_1_DesignPatterns
{
    class Laptop : DesignPatterns
    {/*What to look for: (fiters needed)
        Brand
        Model
        Laptop Options
        Memory Options
        Hard Drive (HD) Options*/
        public string brand;
        public string model;
        public LaptopOptions laptopOptions;
        public MemoryOptions memoryOptions;
        public HardDriveOptions hdOptions;


        public Laptop()
        {
            //the constructor.
        }
    }

    class LaptopOptions
    {
        public string color { get; private set; }
        public int screenSizeInches { get; private set; }

        public LaptopOptions(string color, int size)
        {
            this.color = color;
            this.screenSizeInches = size;
        }
    }

    class MemoryOptions
    {
        public int memoryGB { get; private set; }

        public MemoryOptions(int memoryGB)
        {
            this.memoryGB = memoryGB;
        }
    }

    class HardDriveOptions
    {
        public int diskSpace { get; private set; }

        public HardDriveOptions(int diskSpace)
        {
            this.diskSpace = diskSpace;
        }
    }

    class TheBuilder
    {
        Laptop myLaptop = new Laptop();

        public TheBuilder(string brand, string model)
        {
            myLaptop.brand = brand;
            myLaptop.model = model;
        }

        public void AddFirstOption(string color, int size)
        {
            myLaptop.laptopOptions = new LaptopOptions(color, size);
        }

        public void AddSecondOption(int memory)
        {
            myLaptop.memoryOptions = new MemoryOptions(memory);
        }

        public void AddThirdOption(int diskSpace)
        {
            myLaptop.hdOptions = new HardDriveOptions(diskSpace);
        }

        public Laptop GetLaptop()
        {
            return myLaptop;
        }
    }
}
