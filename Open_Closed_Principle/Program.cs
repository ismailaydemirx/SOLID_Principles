#region Ideal Code

using Open_Closed_Principle_IdealCode;

// Create an instance of MoneySender
MoneySender moneySender = new MoneySender();
// Create an instance of Bawag bank
Bawag bawag = new Bawag();

// Send money via Bawag
moneySender.SendMoney(bawag, 100, "123456");

// Send money via Santander with no changes to MoneySender
moneySender.SendMoney(new Santander(), 200, "654321");

// Send money via Bank of America with no changes to MoneySender
moneySender.SendMoney(new BankOfAmerica(), 300, "112233");

#endregion