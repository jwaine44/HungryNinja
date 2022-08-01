class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;

    public Ninja()
    {
        calorieIntake = 0;
        FoodHistory = new List<Food>();
    }

    bool IsFull
    {
        get
        {
            return calorieIntake > 1200;
        }
    }

    public void Eat(Food item)
    {
        if(!IsFull)
        {
            calorieIntake += item.Calories;
            FoodHistory.Add(item);
            Console.WriteLine($"{item.Name} was just eaten!");
            if(item.isSweet){
                Console.WriteLine($"It was a sweet food!");
            }
            if(item.IsSpicy){
                Console.WriteLine($"It was a spicy food!");
            }
        }
        else {
            Console.WriteLine($"Warning: The ninja is full already!");
        }
    }
}