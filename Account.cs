class Account 
{
    int id;
    int pin;
    double balance = 0;
    string name;
 
    public Account(int id, int pin, string name)
    {
        this.id = id;
        this.pin = pin;
        this.name = name;
    }

    public bool checkPin(int pin)
    {
        if (pin == this.pin)
        {
            return true;
        }
        return false;
    }
    
}