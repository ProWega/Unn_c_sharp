using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_classes
{
    public class HRDirector
    {
        public List<Baker> bakerList = new List<Baker>();
        public List<Deliverer> delivererList = new List<Deliverer>();
        public List<Worker> workerList = new List<Worker>();
        public CookDirector cook;

        public void LazyHuntNewBaker(float expectedSalary)
        {
            List < Baker > bakers = FindBakerCandidates();
            foreach (Baker baker in bakers)
            {
                if (baker.salary <= expectedSalary)
                {
                    bakerList.Add(baker);
                    workerList.Add(baker);
                    Console.WriteLine($"Hunted new Baker {baker.Id}");
                }
            }

        }
        public void LazyHuntNewDeliverer(float expectedSalary)
        {
            List<Deliverer> deliverers = FindDelivererCandidates();
            foreach (Deliverer deliverer in deliverers)
            {
                if (deliverer.salary <= expectedSalary)
                {
                    delivererList.Add(deliverer);
                    workerList.Add(deliverer);
                    Console.WriteLine($"Hunted new Deliverer {deliverer.Id}");
                }
            }

        }

        List<Baker> FindBakerCandidates()
        {
            List<Baker> bakers = new List<Baker>();
            bakers.Add(new Baker(23500));
            bakers.Add(new Baker(78200));
            bakers.Add(new Baker(22700));
            bakers.Add(new Baker(34700));
            bakers.Add(new Baker(15000));
            return bakers;
        }
        List<Deliverer> FindDelivererCandidates()
        {
            List<Deliverer> deliverer = new List<Deliverer>();
            deliverer.Add(new Deliverer(13500));
            deliverer.Add(new Deliverer(38200));
            deliverer.Add(new Deliverer(5700));
            deliverer.Add(new Deliverer(4700));
            deliverer.Add(new Deliverer(15000));
            return deliverer;
        }
        public void AnalyzeWorkers()
        {
            foreach (Worker worker in workerList)
            {
                if (worker.loyalityRate < 0)
                {
                    Console.WriteLine($"Worker {worker.Id} может быть уволен, тк его рейтинг {worker.loyalityRate}");
                }
                
                
            }
            if (cook.orders.Count() > 0 || cook.ordersCookingList.Count() > 0)
            {
                Console.WriteLine("Имеет смысл нанять поваров, тк слишком много заказов, которые еще не приготовлены");
            }
            if (cook.ordersReady.Count() > 0 || cook.ordersDelivering.Count() > 0)
            {
                Console.WriteLine("Имеет смысл нанять доставщиков, тк слишком много заказов не доставлено");
            }
        }
        public void PrintJsonBakers()
        {
            string bakers = JsonConvert.SerializeObject(bakerList);
            Console.WriteLine(bakers);
        }
        public void HuntBakersFromJson()
        {
            List<Baker> bakers = JsonConvert.DeserializeObject<List<Baker>>("ba.json");
            foreach (Baker baker in bakers)
            {
                bakerList.Add(baker);
            }
        }
        public void SaveBakersToJson()
        {
            File.WriteAllText(@"C:\Users\Admin\source\repos\UpperLvl\Lab3_classes\Lab3_classes\Lab3_classes\ba.json", JsonConvert.SerializeObject(bakerList));
            Console.WriteLine("Write to json");
        }
    }
}
