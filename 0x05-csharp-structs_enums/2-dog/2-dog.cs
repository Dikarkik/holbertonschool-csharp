public enum Rating
{
    Good,
    Great,
    Excellent
}

public struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string name_, float age_, string owner_, Rating rating_)
    {
        name = name_;
        age = age_;
        owner = owner_;
        rating = rating_;
    }
}
