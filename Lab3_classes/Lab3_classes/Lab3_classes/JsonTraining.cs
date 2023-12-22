using Newtonsoft.Json;
using Lab3_classes;

BakerJson bakers = JsonConvert.DeserializeObject<BakerJson>("bakers.json");

public class BakerJson {
    string salary;
}