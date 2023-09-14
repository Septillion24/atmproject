class BankDatabase
{
    private static BankDatabase instance;
    Dictionary<string, Account> accountNamesAndAccounts = new() {};


    public BankDatabase()
    {

    }
    public static BankDatabase Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new BankDatabase();
            }
            return instance;
        }
    }

    public bool CreateAccount(string name, int pin)
    {
        if (accountNamesAndAccounts.Keys.Contains(name))
        {
            return false;
        }
        int id = accountNamesAndAccounts.Count + 1;
        Account account = new Account(id, pin, name);
        accountNamesAndAccounts[name] = account;
        return true;
    }
    public bool tryCheckLogin(string name, int pin, out Account? userAccount)
    {
        userAccount = null;
        if(!accountNamesAndAccounts.ContainsKey(name))
        {
            return false;
        }
        userAccount = accountNamesAndAccounts[name];
        return userAccount.checkPin(pin);
    }


}