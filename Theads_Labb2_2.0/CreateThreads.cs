namespace Theads_Labb2_2._0
{
    public class CreateThreads
    {
        public List<Car> Cars = new();
        public List<Thread> Threads = new();

        //public void Cars()
        //{
        //public Car car1 = new Car("Blixten Mcqueen");
        //public Car car2 = new Car("Röda Faran");
        //public Car car3 = new Car("Bulan");
        //public Car car4 = new Car("Bettan");
        //}

        public static async Task Race()
        {
            Car car1 = new Car("Blixten Mcqueen");
            Car car2 = new Car("Röda Faran");
            Car car3 = new Car("Bulan");
            Car car4 = new Car("Bettan");

            //Thread t1 = new Thread(car1);



            //await Task.WhenAll(car1, car2, car3, car4);
        }
    }
}
