using System;
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

    public Dog(string dogName, float dogAge, string dogOwner, Rating dogRating)
    {
        name = dogName;
        age = dogAge;
        owner = dogOwner;
        rating = dogRating;
    }

    public override string ToString()
    {
        return "Dog Name: " + name + "\nAge: " + age + "\nOwner: " + owner + "\nRating: " + rating;
    }
}