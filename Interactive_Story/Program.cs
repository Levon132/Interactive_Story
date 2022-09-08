
Console.WriteLine("Hi, please type Micheal or Jack");

string name = Console.ReadLine();

Console.WriteLine($"Hello {name}");



if (name == "Micheal")
{
    Console.WriteLine("Micheal please choose one of the following, Winter or Summer");
    string weather = Console.ReadLine();
    if (weather == "Winter")
    {
        Console.WriteLine("Its winter please choose one of the following, Jacket or Gloves");
        string clothes = Console.ReadLine();
        if (clothes == "Gloves")
        {
            Console.WriteLine("YOU FROOZE TO DEATH!");
        }
        else if (clothes == "Jacket")
        {
            Console.WriteLine("Your getting hungry now, please choose one of the following 10 Canned Beans or 1 Chicken");
            string food = Console.ReadLine();
            if (food == "1 Chicken")
            {
                Console.WriteLine("You Starved!");
            }
            else if (food == "10 Canned Beans")
            {
                Console.WriteLine("Good Job! You survived the Winter.");
            }
        }

    }
    else if (weather == "Summer")
    {
        Console.WriteLine("Its getting hot please choose one of the following, Fan or AC");
        string cooler = Console.ReadLine();
        if (cooler == "Fan")
        {
            Console.WriteLine("You died of a heatstroke...");
        }
        else if (cooler == "AC")
        {
            Console.WriteLine("The AC worked, now please choose, Cold Water or Warm Soda");
            string drink = Console.ReadLine();
            if (drink == "Warm Soda")
            {
                Console.WriteLine("You died of thrist...");
            }
            else if (drink == "Cold Water")
            {
                Console.WriteLine("Good job you survived the heatstroke!");
            }
        }
    }

}
else if (name == "Jack")
{
    Console.WriteLine("Jack someone is chasing you, choose Knife or Gun");
    string weapon = Console.ReadLine();
    if (weapon == "Gun")
    {
        Console.WriteLine("Sorry you have no ammo...");
    }
    else if (weapon == "Knife")
    {
        Console.WriteLine("The Knife is useable now choose, Kill or Save");
        string murder = Console.ReadLine();
        if (murder == "Kill")
        {
            Console.WriteLine("The police caught you, you're in for murder!");
        }
        else if (murder == "Save")
        {
            Console.WriteLine("Smart choice saving the weapon for another time, now please choose something to escape in, Car or Bike");
            string vehicle = Console.ReadLine();
            if (vehicle == "Bike")
            {
                Console.WriteLine("You fell over and died!");
            }
            else if (vehicle == "Car")
            {
                Console.WriteLine("Good job you fled from the the danger!");
            }
        }
    }
}

Console.WriteLine("Ending in 5 secs...");
Thread.Sleep(5000);

