namespace Inheritance_Demo
{
    // Car derives from Vehicle
    public class Car : Vehicle // Example of Inheritance Relationship between classes
    {
        protected double transmission = 0;

        // Car HAS-Aa Engine
        // Example of Composition Relationship between classes
        private Engine engine;

        public Car()
        {

        }

        public Car(int maxTransmission)
            : base(maxTransmission)
        {
            Console.WriteLine("Car(int maxTransmission) executed second!");
        }



        // Shadowing Variables
        void OpenDoor(float transmission)
        {
            base.transmission = 1;
            this.transmission = 2;

            if (transmission == 0)
            {
                // TODO: Open
            }
        }

        public override string ToString()
        {
            return "I am a car...";
        }

        // Car changed behaviour of Move() method to Console.WriteLine("All 4 tires work...");
        // But every class that derives from Car cannot change Move() method behaviour, since it is sealed
        public override sealed void Move()
        {
            Console.WriteLine("All 4 tires work...");
        }
    }
}