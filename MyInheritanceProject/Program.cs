using System;

namespace MyInheritanceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Battalion soldier0 = new Battalion();
            Console.WriteLine("===================================================================================");
            Console.WriteLine("The Batallion mission is to manage and support subordinate units");
            soldier0.SignalSoldiers("");
            soldier0.InfantrySoldiers("");
            soldier0.SupplySoldiers("");
            //soldier0.Mission("Manage and support subordinate units");
            Console.WriteLine("===================================================================================\n");

            SignalCompany soldier1 = new SignalCompany();
            soldier1.SignalSoldiers("");
            soldier1.Shoot();
            soldier1.Move();
            soldier1.Communicate();
            soldier1.Mission();
            Console.WriteLine("===================================================================================\n");

            InfantryCompany soldier2 = new InfantryCompany();
            soldier1.InfantrySoldiers("");
            soldier2.RECON();
            soldier2.Relay();
            soldier2.Attack();
            soldier2.Mission();
            Console.WriteLine("===================================================================================\n");

            SupplyCompany soldier3 = new SupplyCompany();
            soldier1.SupplySoldiers("");
            soldier3.Maintain();
            soldier3.Analyze();
            soldier3.Supply();
            soldier3.Mission();
            Console.WriteLine("===================================================================================\n");
        }
    }
    class Battalion
    {
        public void SignalSoldiers(string Communicate)
        {
            Console.WriteLine("GO SIGNAL");
        }
        public void InfantrySoldiers(string Fight)
        {
            Console.WriteLine("GO INFANTRY");

        }
        public void SupplySoldiers(string Supply)
        {
            Console.WriteLine("GO SUPPLY");
        }
        public virtual void Mission()
        {
            Console.WriteLine("The Batallion mission is to manage and support subordinate units");
        }
    }
    
    class SignalCompany : Battalion
    {
        public void Shoot()
        {
            Console.WriteLine("Train with Field Exercises");
        }
        public void Move()
        {
            Console.WriteLine("Relocate and Reconnect");
        }

        public void Communicate()
        {
            Console.WriteLine("Set up communications on the battlefield");
        }

        public override void Mission()
        {
            Console.WriteLine("You can talk about us, but you can't talk without us");
        }
    }

    class InfantryCompany : Battalion
    {
        public void RECON()
        {
            Console.WriteLine("Locate enemy forces");
        }
        public void Relay()
        {
            Console.WriteLine("Communicate SA to higher Headquarters");
        }

        public void Attack()
        {
            Console.WriteLine("Advance on battlefield, engage in combat");
        }
        public override void Mission()
        {
            Console.WriteLine("Defend the country and our way of life, One war at a time");
        }
    }
    class SupplyCompany : Battalion
    {
        public void Maintain()
        {
            Console.WriteLine("Keep track of inventory");
        }
        public void Analyze()
        {
            Console.WriteLine("Analyze need of organization");
        }
        public void Supply()
        {
            Console.WriteLine("Deliver shortages to organization");
        }
        public override void Mission()
        {
            Console.WriteLine("Support the needs of the Army");
        }
    }
}

