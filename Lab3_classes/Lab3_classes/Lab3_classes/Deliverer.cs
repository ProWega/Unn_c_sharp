using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_classes
{
    public class Deliverer : Worker
    {
        Order? currentOrder = null;
        public CookDirector cookDirector;
        public static HRDirector hr;
        public Deliverer(float salary_)
        {
            Id = Deliverer.hr.workerList[hr.workerList.Count() - 1].Id + 1;
            salary = salary_;
        }
        public void SetCookDirector(CookDirector cook)
        {
            cookDirector = cook;
        }
        public void SetHrDirector(HRDirector hr)
        {
            Deliverer.hr = hr;
        }
        public override float CalculateRate()
        {
            return loyalityRate;
        }

        public override void EndDay()
        {
            loyalityRate++;
        }

        public override void Fire()
        {
            Console.WriteLine($"Worker {Id} wants to get fired");
        }

        public override void PrintSalary()
        {
            Console.WriteLine(salary);
        }

        public override void StartDay()
        {
            isWorking = true;
        }
        public void TakeNextOrder()
        {
            if (currentOrder == null)
            {
                if (cookDirector.Stock.items.Count() != 0)
                {

                    currentOrder = cookDirector.Stock.items.Dequeue();
                    cookDirector.ordersReady.Remove(currentOrder);
                    cookDirector.Stock.currentTotalLoad -= currentOrder.stockWeight;
                    Console.WriteLine($"Склад заполнен на {cookDirector.Stock.currentTotalLoad}/{cookDirector.Stock.totalCapacity}");

                    cookDirector.ordersDelivering.Add(currentOrder);
                    Console.WriteLine($"Заказ [{currentOrder.Id}] взял доставщик {Id}");
                }
                else
                {
                    Console.WriteLine($"Deliverer {Id} can't take order because orders dont exists");
                }
            }
            else
            {
                Console.WriteLine($"Deliverer {Id} can't take order {cookDirector.ordersReady[0].Id} because he already delivering another order Id: {currentOrder.Id}");
            }
        }
        public void FinishOrder()
        {
            if (currentOrder == null)
            {
                return;
            }
            cookDirector.ordersDelivering.Remove(currentOrder);
            cookDirector.ordersDeliveredArchive.Add(currentOrder);
            Console.WriteLine($"Заказ [{currentOrder.Id}] поставлен потребителю доставщиком [{Id}]");
            currentOrder = null;
        }

        public override void LoyaltyFine(float fine)
        {
            loyalityRate -= fine;
        }
    }
}
