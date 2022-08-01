class Buffet
{
    public List<Food> Menu;

    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Buffalo chicken", 1000, true, false),
            new Food("Sweet and sour chicken", 1500, false, true),
            new Food("Shrimp scampi", 900, false, false),
            new Food("Spaghetti", 500, false, false),
            new Food("Chicken caesar salad", 400, false, false),
            new Food("Pizza", 1500, false, false),
            new Food("Apple pie", 500, false, true)
        };
    }

    public Food Serve()
    {
        Random rand = new Random();
        Food randItem = Menu[rand.Next(Menu.Count())];
        return randItem;
    }
}