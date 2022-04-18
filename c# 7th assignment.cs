progam 1   --> a console application which will read text files from mentioned file system location. 



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace fileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dir = @"C:\umesh\FileIO";
            string subdir1 = @"C:\umesh\FileIO\Write";
            string subdir2 = @"C:\umesh\FileIO\Read";
            string srcFilepath = @"C:\umesh\FileIO\Write\myFile.txt";
            string desFilepath = @"C:\umesh\FileIO\Read\myFile.txt";
            Directory.CreateDirectory(dir);
            Directory.CreateDirectory(subdir1);
            Directory.CreateDirectory(subdir2);

            DirectoryInfo ds = new DirectoryInfo(subdir2);

            FileStream fs = File.Create(srcFilepath);
            string[] lines = { "sai umesh", "umeshsai@gmail.com", "Bangalore" };
            StreamWriter sw = new StreamWriter(fs);
            foreach (string s in lines)
            {
                sw.WriteLine(s);
            }
            sw.Close();

            string[] line = File.ReadAllLines(srcFilepath);
            foreach (string s in line)
            {
                Console.WriteLine(s);
            }
            File.Copy(srcFilepath, desFilepath, true);
            Console.ReadLine();
        }
    }
}



program 2 ----> Create a simple user interfacee to accept account related information of a customer


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileIO
{
    internal class Bank
    {
        public class Account
        {
            public string Name;
            public double AccountNumber;
            public double balance;

            public Account(string name,double accountnumber,double balance)
            {
                this.Name = name;
                this.AccountNumber = accountnumber;
                this.balance = balance;
            }
        }
        static void Main(string[] args)
        {

            string dir = @"C:\umesh1\BankAccountDetails";
            string srcFilepath = @"C:\umesh1\BankAccountDetails\Account.txt";
            Directory.CreateDirectory(dir);

            FileStream fs = File.Create(srcFilepath);
                fs.Close();
            Console.WriteLine("Enter AccountHolder Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Account Number :");
             double accountNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Account Balance :");
             double balance = Convert.ToDouble(Console.ReadLine());
            Account a1 = new Account(name, accountNumber, balance);

            StreamWriter sw = new StreamWriter(srcFilepath);     
                sw.WriteLine(a1.Name);
                sw.WriteLine(a1.AccountNumber);
                sw.WriteLine(a1.balance);




            sw.Close();
            StreamReader sr = new StreamReader(srcFilepath);
            string line;

            Console.WriteLine("\nAccounts Details :");
            while ((line= sr.ReadLine()) != null)
            {
                
                Console.WriteLine(line);
            }
         
            Console.ReadLine();
        }
    }
}


program 3 ----->  Make the Employee, MarketingExecutive and Manager class as Serializable





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace FileInputandOutput
{
    interface IPrintable
    {
        void PrintDetails();
    }
    [Serializable()]
    class Employee : IPrintable
    {
        protected int EmpNo;
        protected string EmpName;
        protected double Salary;
        protected double HRA;
        protected double TA;
        protected double DA;
        protected double PF;
        protected double TDS;
        protected double NetSalary;
        protected double GrossSalary;

        public void SetEmpNo(int EmpNo)
        {
            this.EmpNo = EmpNo;
        }
        public void SetEmpName(string EmpName)
        {
            this.EmpName = EmpName;
        }
        public double SetSalary(double Salary)
        {
            this.Salary = Salary;
            if (this.Salary < 500)
            {
                this.HRA = (this.Salary * 10) / 100;
                this.TA = (this.Salary * 5) / 100;
                this.DA = (this.Salary * 15) / 100;
            }
            else if (this.Salary > 5000 && this.Salary < 10000)
            {
                this.HRA = (this.Salary * 15) / 100;
                this.TA = (this.Salary * 10) / 100;
                this.DA = (this.Salary * 20) / 100;
            }
            else if (this.Salary >= 10000 && this.Salary < 15000)
            {
                this.HRA = (this.Salary * 20) / 100;
                this.TA = (this.Salary * 15) / 100;
                this.DA = (this.Salary * 25) / 100;
            }
            else if (this.Salary >= 15000 && this.Salary < 20000)
            {
                this.HRA = (this.Salary * 25) / 100;
                this.TA = (this.Salary * 20) / 100;
                this.DA = (this.Salary * 30) / 100;
            }
            else
            {
                this.HRA = (this.Salary * 30) / 100;
                this.TA = (this.Salary * 25) / 100;
                this.DA = (this.Salary * 35) / 100;
            }
            
            return this.GrossSalary = this.Salary + this.HRA + this.TA + this.DA;

        }
        public virtual double CalculateSalary()
        {
            this.PF = (this.GrossSalary * 10) / 100;
            this.TDS = (this.GrossSalary * 18) / 100;
            this.NetSalary = this.GrossSalary - (this.PF + this.TDS);
            return this.NetSalary;
        }
        public void PrintDetails()
        {

            Console.WriteLine("Employee No: " + EmpNo + ", Employee Name: " + EmpName + ", Salary: " + Salary);
            Console.WriteLine("HRA: " + this.HRA + ", TA: " + this.TA + ", DA: " + this.DA);
            Console.WriteLine("PF: " + this.PF + ", TDS: " + this.TDS + "\n");
        }        

    }

    [Serializable]
    class Manager : Employee
    {
        private double PetrolAllowance;
        private double FoodAllowance;
        private double OtherAllowances;

        public double Gsalary(double Salary)
        {
            base.SetSalary(Salary);
            this.PetrolAllowance = Salary * 8 / 100;
            this.FoodAllowance = Salary * 13 / 100;
            this.OtherAllowances = Salary * 3 / 100;
            return this.GrossSalary = base.GrossSalary + PetrolAllowance + FoodAllowance + OtherAllowances;
        }
        public override double CalculateSalary()
        {
            this.TDS = (this.GrossSalary * 18) / 100;
            NetSalary = GrossSalary - (PF + TDS);
            return NetSalary;
        }
 
}
    [Serializable]
        class MarketingExecutive : Employee
    {
        private double KilometerTravel;
        private double TourAllowances;
        private int TelephoneAllowances = 1000;

        public void SetKilometersTravel(double Kilo)
        {
            KilometerTravel = Kilo;
            TourAllowances = KilometerTravel * 5;
        }
        public double Gsalary(double Salary)
        {
            base.SetSalary(Salary);
            return GrossSalary += TourAllowances + TelephoneAllowances;
        }
        public override double CalculateSalary()
        {
            base.SetSalary(Salary);
            this.PF = this.GrossSalary * 10 / 100;
            this.TDS = this.GrossSalary * 18 / 100;
            NetSalary = GrossSalary - (PF + TDS);
            return NetSalary;
        }
      
    }
    class inheritanceandpolymorphism
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Employee ID: ");
            int EmpId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee NAME: ");
            string EmpName = Console.ReadLine();
            Console.Write("Enter Employee SALARY: ");
            double Salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter kilometre value :");
            int kilo1 = Convert.ToInt32(Console.ReadLine());


            Employee employee = new Employee();
            employee.SetEmpNo(EmpId);
            employee.SetEmpName(EmpName);
            employee.SetSalary(Salary);
            employee.CalculateSalary();
            employee.PrintDetails();

            Manager manager = new Manager();


            MarketingExecutive me = new MarketingExecutive();

           Stream stream = File.Open("EmployeeInfo.txt", FileMode.Create);

            Stream stream1 = File.Open("ManagerInfo.txt", FileMode.Create);

            Stream stream2 = File.Open("MarketingExecutiveInfo.txt", FileMode.Create);



            BinaryFormatter bformatter = new BinaryFormatter();
            bformatter.Serialize(stream, employee);
            bformatter.Serialize(stream1, manager);
            bformatter.Serialize(stream2, me);



            stream.Close();



           

            me.SetSalary(Salary);
            me.SetKilometersTravel(kilo1);
            Console.WriteLine("Employee Gross Salary is : {0}", employee.SetSalary(Salary));
            Console.WriteLine("Employee Net salary is : {0}\n", employee.CalculateSalary());
            Console.WriteLine("Manager Gross Salary is :{0}", manager.Gsalary(Salary));
            Console.WriteLine("Manager Net salary is :{0}\n", manager.CalculateSalary());
            Console.WriteLine("Marketing Executive Gross Salary is :{0}", me.Gsalary(Salary));
            Console.WriteLine("Marketing Executive Net salary is :{0}", me.CalculateSalary());
            Console.ReadKey();
        }
    }
}


program 4 :Create a user interfacee to accept information about Manager(For simplicity accept only employee id , name and basic salary)






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileInputandOutput
{
    [Serializable]
    public class employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }
    }
    class Serializer
    {
        public void BinarySerialize(object data, string filePath)
        {
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath)) File.Delete(filePath);
            fileStream = File.Create(filePath);
            bf.Serialize(fileStream, data);
            fileStream.Close();
        }
        public object BinaryDeserialize(string filePath)
        {
            object obj = null;
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath))
            {
                fileStream = File.OpenRead(filePath);
                obj = bf.Deserialize(fileStream);
                fileStream.Close();
            }
            return obj;
        }
    }
    internal class Serialize
    {
        static void Main(string[] args)
        {
            string dir = @"C:\umesh2\FileIO\Write";
            string srcFilepath = @"C:\umesh2\FileIO\Write\myFile.txt";
            Directory.CreateDirectory(dir);
            employee emp1 = new employee
            {
                EmpId = Convert.ToInt32(Console.ReadLine()),
                EmpName = Console.ReadLine(),
                EmpSalary = Convert.ToDouble(Console.ReadLine())
            };
            Serializer se = new Serializer();
            se.BinarySerialize(emp1, srcFilepath);
            Console.WriteLine("Serialize done");
            emp1 = se.BinaryDeserialize(srcFilepath) as employee;
            Console.WriteLine(emp1.EmpId);
            Console.WriteLine(emp1.EmpName);
            Console.WriteLine(emp1.EmpSalary);
            Console.WriteLine("Deserialize done");
            Console.ReadKey();
        }
    }
}
