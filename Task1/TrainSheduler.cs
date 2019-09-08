using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class TrainScheduler
    {
        private const int TrainMaxNumbers = 2;

        private Train[] trainList;

        public TrainScheduler()
        {
            this.trainList = new Train[TrainScheduler.TrainMaxNumbers];
        }

        public void Execute()
        {
            for (int i = 0; i < TrainScheduler.TrainMaxNumbers; i++)
                this.trainList[i] = this.GetNewTrain();

            SortTrain();

            int selectedTrainNumber = this.AskTrainNumber();

            this.DisplayTrainInfo(selectedTrainNumber);
        }

        private void SortTrain()
        {
            Train temp;

            for (int i = 0; i < this.trainList.Length - 1; i++)
            { 
                for (int j = 0; j < this.trainList.Length - i - 1; j++)
                {
                    if (this.trainList[j + 1].Number > this.trainList[j].Number)
                    {
                        temp = this.trainList[j + 1];
                        this.trainList[j + 1] = this.trainList[j];
                        this.trainList[j] = temp;
                    }
                }
            }
        }


        private int AskTrainNumber()
        {
            int trainNumber = 0;

            while (true)
            {
                Console.WriteLine("Enter the number of train:");
                if (int.TryParse(Console.ReadLine(), out trainNumber))
                    break;
            }

            return trainNumber;
        }

        private void DisplayTrainInfo(int trainNumber)
        {
            Train selectedTrain = new Train();

            for (int i = 0; i < TrainScheduler.TrainMaxNumbers; i++)
            {
                if (this.trainList[i].Number == trainNumber)
                    selectedTrain = this.trainList[i];
            }

            if (selectedTrain.Number == 0)
            {
                Console.WriteLine($"Train number {trainNumber} was not found on the list of trains");
                return;
            }

            Console.WriteLine($"Train {trainNumber} is departuring to {selectedTrain.Appointment} at {selectedTrain.Time}");
        }

        private Train GetNewTrain() 
        {
            int trainNumber = 0;

            while (true)
            {
                Console.WriteLine("Enter the train numbers: ");

                if (Int32.TryParse(Console.ReadLine(), out trainNumber))
                    break;
            }

            DateTime departureTime;

            while (true)
            {
                Console.WriteLine("Enter the departure time of a train: ");

                if (DateTime.TryParse(Console.ReadLine(), out departureTime))
                    break;
            }

            string appointment = string.Empty;

            while (true)
            {
                Console.WriteLine("Enter the appointment: ");

                appointment = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(appointment))
                    break;
            }

            return new Train(appointment, trainNumber, departureTime);
        }
    }
}
