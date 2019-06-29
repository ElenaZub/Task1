using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Driver : Worker
    {
        private int drivingExperience;

        private Category category;

        public int DrivingExperience
        {
            get
            {
                return drivingExperience;
            }
            set
            {
                if (value > 0)
                {
                    drivingExperience = value;
                }
            }
        }

        public Category MyCategory { get; set; }

        public Driver(string name, int age, decimal salary, int drivingExperience, Category category)
            : base(name, age, salary)
        {
            this.DrivingExperience = drivingExperience;
            this.MyCategory = category;
        }
    }
}
