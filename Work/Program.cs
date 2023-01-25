Console.Write("Введите кол-во элементов массива:  ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];

int counter = 0;
    
for (int i = 0; i < n; i++)
    {
        Console.Write("Введите элемент массива:  ");
        string element = Console.ReadLine();
        if(element.Length < 4)
        {
            counter++;
        }
        array[i] = element;
    }    

string[] newArray = new string[counter];

void PullArray()
{   
    int y = 0; 
    for(int i = 0; i <= newArray.Length; i++)
        {    
            if(array[i].Length < 4)
            {                
               newArray[y] = array[i];
               y++;                
            }
        }    
}

PullArray();
Console.WriteLine(String.Join(" ", newArray));

