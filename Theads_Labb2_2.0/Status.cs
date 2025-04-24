namespace Theads_Labb2_2._0
{
    public class Status
    {
        public Car car;
        public string CheckStatus()
        {
            return $"{car.Name} - {car.Speed} - {car.MinLength}";
        }
    }
}
