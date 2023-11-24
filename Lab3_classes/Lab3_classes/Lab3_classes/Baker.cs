using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_classes
{
    [Serializable]
    public class Baker : Worker
    {
        public CookDirector cookDirector;
        public static HRDirector hr;

        Order? currentOrder = null;
        public Baker(float salary_, CookDirector cookDirector)
        {
            Id = hr.workerList[hr.workerList.Count()-1].Id+1;
            salary = salary_;
            loyalityRate = 0;
            this.cookDirector = cookDirector;  
        }
        public Baker(float salary_)
        {
            if (hr.workerList.Count() > 0)
            {
                Id = hr.workerList[hr.workerList.Count() - 1].Id + 1;
            } 
            else { Id = 0; }
            
            salary = salary_;
            loyalityRate = 0;
        }
        public void SetCookDirector(CookDirector cook)
        {
            cookDirector = cook;
        }

        public void SetHrDirector(HRDirector hr)
        {
            Baker.hr = hr;
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
            Console.WriteLine($"Пекарь {Id} начал рабочий день");

        }
        public void TakeNextOrder()
        {
            if (currentOrder == null)
            {
                if (cookDirector.orders.Count != 0)
                { 
                    currentOrder = cookDirector.orders.Dequeue();
                    cookDirector.ordersCookingList.Add(currentOrder);
                    Console.WriteLine($"Заказ [{currentOrder.Id}] взял повар {Id}");
                }
                else
                {
                    Console.WriteLine($"Baker {Id} can't take order because orders dont exists");
                }
            }
            else
            {
                Console.WriteLine($"Baker {Id} can't take order {cookDirector.orders.Peek().Id} because he already cooking another order Id: {currentOrder.Id}");
            }
        }
        public void FinishCurrentOrder()
        {
            if (currentOrder == null)
            {
                return;
            }
            float newWeight = currentOrder.stockWeight + cookDirector.Stock.currentTotalLoad;
            if (SendCurentOrderToStock())
            {

                cookDirector.ordersCookingList.Remove(currentOrder);
                cookDirector.ordersReady.Add(currentOrder);
                Console.WriteLine($"Заказ [{currentOrder.Id}] приготовлен и отпрвлен на склад поваром [{Id}]");
                currentOrder = null;
                
            }
            else
            {
                Console.WriteLine($"Заказ [{currentOrder.Id}] приготовлен");
                Console.WriteLine($"Склад переполнен, повар {Id} ждет пока освободится место");
            }
        }
        public bool SendCurentOrderToStock()
        {
            if (currentOrder != null)
            {
                float newWeight = currentOrder.stockWeight + cookDirector.Stock.currentTotalLoad;
                if (newWeight <= cookDirector.Stock.totalCapacity)
                {
                    cookDirector.Stock.currentTotalLoad = newWeight;
                    cookDirector.Stock.items.Enqueue(currentOrder);
                    Console.WriteLine($"Склад заполнен на {newWeight}/{cookDirector.Stock.totalCapacity}");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public override void LoyaltyFine(float fine)
        {
            loyalityRate -= fine;
        }
    }
}
