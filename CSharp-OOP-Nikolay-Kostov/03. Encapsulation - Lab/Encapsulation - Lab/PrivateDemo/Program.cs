namespace PrivateDemo
{
    /*
        Private access modifier is the least accessible member with this modifier.
        When class member is private that means only the class can modify
        change its behaviour. The outer world and the derived classes
        from a class which has private members cannot modify or change the member.
        Only the class where the member is defined can modify it.
        Private access modifier is the main modifier to achieve encapsulation
        and provides us with the functionality to hide implementation details
        from our class with the aim to protect our data and make sure the 
        data we are working with is correct.
    */
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class MotorVehicle
    {
        // Accessible only in MotorVehicle
        private string engine;

        // Accessible from MotorVehicle and classes that derive from MotorVehicle
        protected double horsePower;

        public MotorVehicle()
        {

        }

        //public string Engine
        //{
        //    get { return engine; }
        //    set
        //    {
        //        engine = value;
        //    }
        //}

        //public double HorsePower
        //{
        //    get { return this.horsePower; }
        //    set
        //    {
        //        this.horsePower = value;
        //    }
        //}
    }

    public class Car : MotorVehicle 
    {
        public void Accelerate()
        {
            if (horsePower < 100)
            {
                Console.WriteLine("Accelerated to 90 km/h");
            }
        }
    }
}