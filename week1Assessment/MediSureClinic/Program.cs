using System;

namespace MediSureClinic
{
    public class PatientBill
    {
        public string BillId { get; set; }
        public string PatientName { get; set; }
        public bool HasInsurance { get; set; }
        public decimal ConsultationFee { get; set; }
        public decimal LabCharges { get; set; }
        public decimal MedicineCharges { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal FinalPayable { get; set; }
        
        public static PatientBill LastBill;
        public static bool HasLastBill = false;
    }

    public class BillingService
    {
        public static void CreateNewBill()
        {
            Console.Write("Enter Bill Id: ");
            string billId = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(billId))
            {
                Console.WriteLine("Bill Id cannot be empty.");
                return;
            }

            Console.Write("Enter Patient Name: ");
            string patientName = Console.ReadLine();

            Console.Write("Is the patient insured? (Y/N): ");
            string insuranceInput = Console.ReadLine();
            bool hasInsurance = insuranceInput?.ToUpper() == "Y";

            Console.Write("Enter Consultation Fee: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal consultationFee) || consultationFee <= 0)
            {
                Console.WriteLine("Consultation Fee must be greater than 0.");
                return;
            }

            Console.Write("Enter Lab Charges: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal labCharges) || labCharges < 0)
            {
                Console.WriteLine("Lab Charges must be greater than or equal to 0.");
                return;
            }

            Console.Write("Enter Medicine Charges: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal medicineCharges) || medicineCharges < 0)
            {
                Console.WriteLine("Medicine Charges must be greater than or equal to 0.");
                return;
            }

            decimal grossAmount = consultationFee + labCharges + medicineCharges;
            decimal discountAmount = hasInsurance ? grossAmount * 0.10m : 0;
            decimal finalPayable = grossAmount - discountAmount;

            PatientBill.LastBill = new PatientBill
            {
                BillId = billId,
                PatientName = patientName,
                HasInsurance = hasInsurance,
                ConsultationFee = consultationFee,
                LabCharges = labCharges,
                MedicineCharges = medicineCharges,
                GrossAmount = grossAmount,
                DiscountAmount = discountAmount,
                FinalPayable = finalPayable
            };

            PatientBill.HasLastBill = true;

            Console.WriteLine("Bill created successfully.");
            Console.WriteLine($"Gross Amount: {grossAmount:F2}");
            Console.WriteLine($"Discount Amount: {discountAmount:F2}");
            Console.WriteLine($"Final Payable: {finalPayable:F2}");
            Console.WriteLine("------------------------------------------------------------");
        }

        public static void ViewLastBill()
        {
            if (!PatientBill.HasLastBill)
            {
                Console.WriteLine("No bill available. Please create a new bill first.");
                return;
            }

            var bill = PatientBill.LastBill;
            Console.WriteLine("-----------Last Bill -----------");
            Console.WriteLine($"BillId: {bill.BillId}");
            Console.WriteLine($"Patient: {bill.PatientName}");
            Console.WriteLine($"Insured: {(bill.HasInsurance ? "Yes" : "No")}");
            Console.WriteLine($"Consultation Fee:{bill.ConsultationFee:F2}");
            Console.WriteLine($"Lab Charges: {bill.LabCharges:F2}");
            Console.WriteLine($"Medicine Charges: {bill.MedicineCharges:F2}");
            Console.WriteLine($"Gross Amount: {bill.GrossAmount:F2}");
            Console.WriteLine($"Discount Amount: {bill.DiscountAmount:F2}");
            Console.WriteLine($"Final Payable:{bill.FinalPayable:F2}");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
        }

        public static void ClearLastBill()
        {
            PatientBill.LastBill = null;
            PatientBill.HasLastBill = false;
            Console.WriteLine("Last bill  cleared.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("================== MediSure Clinic Billing ==================");
                Console.WriteLine("1. Create New Bill (Enter Patient Details)");
                Console.WriteLine("2. View Last Bill");
                Console.WriteLine("3. Clear Last Bill");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        BillingService.CreateNewBill();
                        break;
                    case "2":
                        BillingService.ViewLastBill();
                        break;
                    case "3":
                        BillingService.ClearLastBill();
                        break;
                    case "4":
                        Console.WriteLine("Thank you.Application closd normally.");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid menu option.");
                        break;
                }
            }
        }
    }
}
