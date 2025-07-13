namespace DependencyInjection.Services;

public class CustomClass
{
    public  int publicValue { get; set; } = 100;
    public void ChangeValue()
    {
        publicValue = 2000;
    }

}