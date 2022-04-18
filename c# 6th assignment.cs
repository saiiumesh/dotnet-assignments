

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Delegates
{
        
    class inheritanceandpolymorphism
    {

        public class Employee
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
            
        }

        
        public class Manager : Employee
        {
            
            public delegate double EmployeeDelegate();

            private double PetrolAllowance;
            private double FoodAllowance;
            private double OtherAllowances;

            public double SetSalary(double Salary)
            {
                base.SetSalary(Salary);
                this.PetrolAllowance = Salary * 8 / 100;
                this.FoodAllowance = Salary * 13 / 100;
                this.OtherAllowances = Salary * 3 / 100;
                return this.GrossSalary = base.GrossSalary + PetrolAllowance + FoodAllowance + OtherAllowances;
            }
            public override double CalculateSalary()
            {
                TDS = GrossSalary * 18 / 100;
                NetSalary = GrossSalary - TDS;
                return NetSalary;
                
            }
        }
        static void Main(string[] args)
        {
            
            Console.Write("Enter Employee ID: ");
            int EmpId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee NAME: ");
            string EmpName = Console.ReadLine();
            Console.Write("Enter Employee SALARY: ");
            double Salary = Convert.ToDouble(Console.ReadLine());
            

            

            Employee employee = new Employee();
            employee.SetEmpNo(EmpId);
            employee.SetEmpName(EmpName);
            employee.SetSalary(Salary);
            employee.CalculateSalary();

           

            Manager manager = new Manager();
            manager.SetSalary(Salary);           
                    
          
            Console.WriteLine("Manager Gross Salary is :{0}", manager.SetSalary(Salary));


            
            Manager.EmployeeDelegate del = new Manager.EmployeeDelegate(manager.CalculateSalary);
            Console.WriteLine("Manager Net Salary is : " + del());


            Console.ReadKey();
        }
    }

}



program 2 : Marketing Executive details using delegate(multicast)




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class MarketingExecuteDelegate
    { 
           public class Employee
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
                
            }

            
            public class Manager : Employee
            {
                
                public delegate double EmployeeDelegate();

                private double PetrolAllowance;
                private double FoodAllowance;
                private double OtherAllowances;

                public double SetSalary(double Salary)
                {
                    base.SetSalary(Salary);
                    this.PetrolAllowance = Salary * 8 / 100;
                    this.FoodAllowance = Salary * 13 / 100;
                    this.OtherAllowances = Salary * 3 / 100;
                    return this.GrossSalary = base.GrossSalary + PetrolAllowance + FoodAllowance + OtherAllowances;
                }
                public override double CalculateSalary()
                {
                    TDS = GrossSalary * 18 / 100;
                    NetSalary = GrossSalary - TDS;
                    return NetSalary;

                }
            }
        
        class MarketingExecutive : Employee
        {
            
            public delegate double EmployeeDelegate1();

            private double KilometerTravel;
            private double TourAllowances;
            private int TelephoneAllowances = 1000;

            
            public void SetKilometersTravel(double Kilo)
            {
                KilometerTravel = Kilo;
                TourAllowances = KilometerTravel * 5;
            }
            public double SetSalary(double Salary)
            {
                base.SetSalary(Salary);
                return GrossSalary += TourAllowances + TelephoneAllowances;
            }
            
            public override double CalculateSalary()
            {
                TDS = GrossSalary * 18 / 100;
                NetSalary = GrossSalary - TDS;
                return NetSalary;

            }
        }
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

                Manager manager = new Manager();
                manager.SetSalary(Salary);


            MarketingExecutive me = new MarketingExecutive();
            me.SetSalary(Salary);
            me.SetKilometersTravel(kilo1);

            Console.WriteLine("Manager Gross Salary is :{0}", manager.SetSalary(Salary));
            Console.WriteLine("MarketingExecutive Gross Salary is :{0}\n", me.SetSalary(Salary));

            Manager.EmployeeDelegate del = new Manager.EmployeeDelegate(manager.CalculateSalary);
            MarketingExecutive.EmployeeDelegate1 del1 = new MarketingExecutive.EmployeeDelegate1(me.CalculateSalary);

            Console.WriteLine("Manager Net Salary is : " + del());
            Console.WriteLine("MarketingExecutive Net Salary is : " + del1());
            Console.ReadKey();
            }
        }    
}


program 3 : Banking Account Transacton using delegate and Event



using System;


namespace Delegates
{
    class BankAtm
    {
        
        public delegate void delegatemethod(int x);

        public class Account
        {
            public int AccountNumber { get; set; }
            public int CustomerName { get; set; }


            public int Balance =1000;

            public event delegatemethod UnderBalance;
            public event delegatemethod ZeroBalance;


            public void Insufficient(int x)
            {
                UnderBalance(x);
                
            }
          public void DepositMoney(int y)
            {
                ZeroBalance(y);
                    
            }

            public void WithDraw(int x)
            {
                if (x < Balance && Balance!=0)
                {
                    Console.WriteLine("Transaction Succesfull");
                    Console.WriteLine("Remaining Balance is " + (Balance - x));
                }
                else if(x>Balance && Balance!=0)
                {
                    Console.WriteLine("Insufficient Amount");
                    Console.WriteLine("Your Current Balance is " + Balance + " only");
                }    
                else
                {
                    Console.WriteLine("Zero Balance :" + Balance);
                }
            }

            public void Deposit(int x)
            {
                Console.Write("Balance After Depositing: "+ (Balance+x));
            }
        }

        static void Main(string[] args)
        {
            Account obj = new Account();           
            Console.WriteLine("Action to be performed WithDraw Amount or Deposit : w or d");
            string wd = Console.ReadLine();
            if (wd == "w")
            {
                Console.WriteLine("Enter Balance to be WithDrawn");
                int wdbalance = Convert.ToInt32(Console.ReadLine());
                obj.UnderBalance += new delegatemethod(obj.WithDraw);
                obj.Insufficient(wdbalance);
            }
            else
            {
                Console.WriteLine("Enter Amount to be Deposit : ");
                int dpbalance = Convert.ToInt32(Console.ReadLine());
                obj.ZeroBalance += new delegatemethod(obj.Deposit);
                obj.DepositMoney(dpbalance);
            }
            Console.ReadKey();
        }
    }
}
