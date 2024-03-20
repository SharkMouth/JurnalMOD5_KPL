public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++) {
            Console.WriteLine($"Data {i+1} berisi : {storedData[i]} yang disimpan pada waktu {inputDates[i]}");
        }
    }   
}

class main
{
    static void Main(string[] args)
    {
        SimpleDataBase<int> simpleDataBase = new SimpleDataBase<int>();
        int angka1 = 13;
        int angka2 = 02;
        int angka3 = 22;
        simpleDataBase.AddNewData(angka1);
        simpleDataBase.AddNewData(angka2);
        simpleDataBase.AddNewData(angka3);
        simpleDataBase.PrintAllData();
    }
}