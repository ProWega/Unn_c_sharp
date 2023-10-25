string inputText =
@"3 4
0 0 0 1
1 0 0 1
1 1 1 1
2";

string[] info = inputText.Split('\n');
int rows = Convert.ToInt32(info[0].Split(' ')[0]);
int columns = Convert.ToInt32(info[0].Split(' ')[1]);
int[,] ticketsInfo = new int[rows, columns];
//Console.WriteLine(ticketsInfo.Length);
for (int i = 0; i < rows; i++)
{
    string[] row = info[i+1].Split(' ');
    for (int j = 0; j < columns; j++)
    {
        ticketsInfo[i, j] = Convert.ToInt32(row[j]);
    }
}
int people_value = Convert.ToInt32(info[info.Length - 1]);
int together_value = 0;
int max_together_value = 0;
bool stop = false;
for (int i = 0;i < rows; i++)
{
    
    for(int j = 0; j<columns; j++)
    {
        if (stop)
        {
            break;
        }
        if (ticketsInfo[i,j] == 0)
        {
            together_value++;
            if (together_value == people_value)
            {
                Console.WriteLine($"Мы нашли места для вас. Ряд {i+1}");
                stop = true;
            }
            if (together_value > max_together_value)
            {
                max_together_value = together_value;
            }
        }
        else
        {
            together_value = 0;
        }
    }
}
if (max_together_value < people_value)
{
    Console.WriteLine($"Извините, мы нашли только {max_together_value} мест вместе");
}