using System;

namespace QuickMartTraders
{
    public class SaleTransaction
    {
        public string InvoiceNo {get; set;}
        public string CustomerName {get; set;}
        public string ItemName {get; set;}
        public int Quantity { get;set;}
        public decimal PurchaseAmount { get; set; }
        public decimal SellingAmount  { get; set;}
        public string ProfitOrLossStatus{ get;set; }
        public decimal ProfitOrLossAmount { get; set; }
        public decimal ProfitMarginPercent{ get; set; }
        public static SaleTransaction LastTransaction;
        public static bool HasLastTransaction= false;
    }

    public class TransactionService
    {
        public static void CreateNewTransaction()
        {
            Console.Write("Enter Invoice No:");
            string invoiceNo = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(invoiceNo))
            {
                Console.WriteLine("Invoice No cannot be empty.");
                return;
            }

            Console.Write("Enter Customer Name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter Item Name: ");
            string itemName = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity <= 0)
            {
                Console.WriteLine("Quantity must be greater than 0.");
                return;
            }

            Console.Write("Enter Purchase Amount (total): ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal purchaseAmount) || purchaseAmount <= 0)
            {
                Console.WriteLine("Purchase Amount must be greater than 0.");
                return;
            }

            Console.Write("Enter Selling Amount (total): ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal sellingAmount) || sellingAmount < 0)
            {
                Console.WriteLine("Selling Amount must be greater than or equal to 0.");
                return;
            }

            string profitOrLossStatus;
            decimal profitOrLossAmount;
            decimal profitMarginPercent;

            if (sellingAmount > purchaseAmount)
            {
                profitOrLossStatus ="Profit";
                profitOrLossAmount =sellingAmount - purchaseAmount;
            }
            else if (sellingAmount < purchaseAmount)
            {
                profitOrLossStatus = "Loss";
                profitOrLossAmount = purchaseAmount - sellingAmount;
            }
            else
            {
                profitOrLossStatus ="Break-Even";
                profitOrLossAmount =0;
            }

            profitMarginPercent = (profitOrLossAmount / purchaseAmount) * 100;

            SaleTransaction.LastTransaction = new SaleTransaction
            {
                InvoiceNo = invoiceNo,
                CustomerName = customerName,
                ItemName =itemName,
                Quantity = quantity,
                PurchaseAmount = purchaseAmount,
                SellingAmount = sellingAmount,
                ProfitOrLossStatus =profitOrLossStatus,
                ProfitOrLossAmount = profitOrLossAmount,
                ProfitMarginPercent = profitMarginPercent
            };

            SaleTransaction.HasLastTransaction = true;

            Console.WriteLine("Transaction saved successfully.");
            Console.WriteLine($"Status: {profitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {profitOrLossAmount:F2}");
            Console.WriteLine($"Profit Margin (%): {profitMarginPercent:F2}");
            Console.WriteLine("------------------------------------------------------");
        }

        public static void ViewLastTransaction()
        {
            if (!SaleTransaction.HasLastTransaction)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }

            var transaction = SaleTransaction.LastTransaction;
            Console.WriteLine("-------------- Last Transaction --------------");
            Console.WriteLine($"InvoiceNo: {transaction.InvoiceNo}");
            Console.WriteLine($"Customer: {transaction.CustomerName}");
            Console.WriteLine($"Item: {transaction.ItemName}");
            Console.WriteLine($"Quantity: {transaction.Quantity}");
            Console.WriteLine($"Purchase Amount: {transaction.PurchaseAmount:F2}");
            Console.WriteLine($"Selling Amount: {transaction.SellingAmount:F2}");
            Console.WriteLine($"Status: {transaction.ProfitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {transaction.ProfitOrLossAmount:F2}");
            Console.WriteLine($"Profit Margin: {transaction.ProfitMarginPercent:F2}");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
        }

        public static void CalculateProfitLoss()
        {
            if (!SaleTransaction.HasLastTransaction)
            {
                Console.WriteLine("No transaction available.please create a new transaction first.");
                return;
            }

            var transaction = SaleTransaction.LastTransaction;
            
            string profitOrLossStatus;
            decimal profitOrLossAmount;
            decimal profitMarginPercent;

            if (transaction.SellingAmount > transaction.PurchaseAmount)
            {
                profitOrLossStatus = "PROFIT";
                profitOrLossAmount = transaction.SellingAmount - transaction.PurchaseAmount;
            }
            else if (transaction.SellingAmount < transaction.PurchaseAmount)
            {
                profitOrLossStatus = "LOSS";
                profitOrLossAmount = transaction.PurchaseAmount - transaction.SellingAmount;
            }
            else
            {
                profitOrLossStatus = "BREAK-EVEN";
                profitOrLossAmount = 0;
            }

            profitMarginPercent = (profitOrLossAmount / transaction.PurchaseAmount) * 100;

            transaction.ProfitOrLossStatus = profitOrLossStatus;
            transaction.ProfitOrLossAmount = profitOrLossAmount;
            transaction.ProfitMarginPercent = profitMarginPercent;

            Console.WriteLine($"Status: {profitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {profitOrLossAmount:F2}");
            Console.WriteLine($"Profit Margin (%): {profitMarginPercent:F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("================== QuickMart Traders ==================");
                Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
                Console.WriteLine("2. View Last Transaction");
                Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        TransactionService.CreateNewTransaction();
                        break;
                    case "2":
                        TransactionService.ViewLastTransaction();
                        break;
                    case "3":
                        TransactionService.CalculateProfitLoss();
                        break;
                    case "4":
                        Console.WriteLine("Thank you. Application closed normally.");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid menu option.");
                        break;
                }
            }
        }
    }
}
