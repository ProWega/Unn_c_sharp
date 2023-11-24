using Lab3_classes;
using System.Text.Json;
//Baker baker = new Baker(15000.0f);
//Console.WriteLine(baker.salary);
//string json = JsonSerializer.Serialize(baker);
//using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
//{
//    await JsonSerializer.SerializeAsync<Baker>(fs, baker);
//    Console.WriteLine("Data has been saved to file");
    
    
//}
HRDirector hr = new HRDirector();
Baker.hr = hr;
Deliverer.hr = hr;  
hr.LazyHuntNewBaker(20000);
PizzaStock stock = new PizzaStock(3);
CookDirector cook = new CookDirector();
hr.cook = cook;
cook.Stock = stock;
foreach (Baker baker in hr.bakerList)
{
    baker.SetCookDirector(cook);
    baker.SetHrDirector(hr);
    baker.StartDay();
}
Deliverer deliverer = new Deliverer(10000);
hr.delivererList.Add(deliverer);
hr.workerList.Add(deliverer);
foreach (Deliverer deliv in hr.delivererList)
{
    deliv.SetCookDirector(cook);
    deliv.SetHrDirector(hr);
    deliv.StartDay();
}

cook.RegisterNewOrder();
hr.bakerList[0].TakeNextOrder();
hr.bakerList[0].FinishCurrentOrder();
hr.delivererList[0].TakeNextOrder();
hr.delivererList[0].FinishOrder();

foreach (Worker worker in hr.workerList)
{
    worker.EndDay();
}
hr.AnalyzeWorkers();
