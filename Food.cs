class Food
{
    public string Name;
    public int Calories;
    public bool IsSpicy;
    public bool isSweet;

    public Food(string foodName, int calories, bool spicy, bool sweet)
    {
        Name = foodName;
        Calories = calories;
        IsSpicy = spicy;
        isSweet = sweet;
    }
}