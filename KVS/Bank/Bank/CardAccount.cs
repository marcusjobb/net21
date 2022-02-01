// -----------------------------------------------------------------------------------------------
//  CheckingAccount.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace Bank;

public class CardAccount : BankAccount
{
    public CardAccount (decimal amount)
    {
        Name = "Kortkonto";
        balance = amount;
    }
}
