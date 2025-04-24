namespace Theads_Labb2_2._0
{
    public class Race
    {
        public static List<Car> Cars = new();
        public static Car car;
        public static async Task StartRace()
        {
            Cars.Add(new Car("Blixten Mcqueen"));
            Cars.Add(new Car("Röda Faran"));
            Cars.Add(new Car("Bulan"));
            Cars.Add(new Car("Bettan"));
        }
         
        public static async Task<string> RunCar() 
        {
            // km/h / 3.6 = m/s
            var meterPerSeconds = car.Speed / 3.6;

            while(car.MinLength < car.MaxLength)
            {
                var length = car.MinLength += car.MaxLength;
                TroubleMethods.Methods(car);
                await Task.Delay(1000);

                car.MinLength = meterPerSeconds;


                //if(Math.Floor(currentDistans / 1000) > Math.Floor())

                await Task.Delay(1000);
            }

            car.Finish = true;
            await Task.WhenAll();
            //Console.WriteLine($"{car.Name} has finished the race");

            return $"{car.Name} has finished the race";



        }
    }
}
