using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpDal;


namespace EmpLib
{



    public class Employee : Person, IEmployeeContract
    {
        public event EventHandler Join;
        public event EventHandler Resign;
        public Employee():base() 
        {
            this.viewContract();
            this.Sign();
            this.EmpId = new Random(1000).Next();
            EmpUtils.EmpCount++;
        }
        public void TriggerJoinEvent()
        {
            this.Join.Invoke(this,null);
        }

        public void TriggerResignEvent()
        {
            this.Resign.Invoke(this, null);
        }

        // call current class other constructor
        public Employee(string pAadhar):this()
        {
            this.Aadhar= pAadhar;
        }
        public Employee(string pAadhar,string pMobile):base(pAadhar,pMobile)
        {
            this.viewContract();
          this.Sign();
            this.EmpId=new Random(1000).Next();
            EmpUtils.EmpCount++;
        }

        // variables inside class are called fields
        private bool _contractSigned = false;
        private bool _hasReadContract = false;

        public void Sign()
        {
            _contractSigned = true;
        }

        public void viewContract()
        {
            _hasReadContract = true;
        }
        private int _empid;
        public int EmpId { get { return _empid; } private set { _empid = value; } }
        public string Designation { get; set; }
        public double salary { get; set; }
        public DateTime DOJ { get; set; }

        public bool IsActive { get; set; }
        public string AttendTraining(string pTraining)
        {
            return $"{this.Name}attend a training{pTraining}";
        }
        public string FillTimesheet(List<string> ptasks) {
            var csvTask = "";
            foreach (var task in ptasks)
            {
                csvTask = $"{csvTask},{task}";
            }
            return $"{this.Name}has worked on{csvTask} on {DateTime.Now.ToShortDateString()}";
        }
        public override string Work()
        {
            return $"{this.EmpId};{this.Name}employees eorks function";
        }
        public string Work(string task)
        {
            return $"{this.Name}with{this.EmpId}assigned on {DateTime.Today}"; 
        }
        public void setTaxInfo(string pTaxInfo)
        {
            this.TaxDetails = pTaxInfo;
        }
        public string getTaxInfo()
        {
            return $"{this.Name}: your tax detaoils {this.TaxDetails}";
        }

        public List<EmpDal.Employee> GetEmployees()
        {
            EmpDbContext dbContext = new EmpDbContext();
            return dbContext.Employees.ToList();
        }

        public List<EmpDal.Employee> InsertEmployees()
        {
            EmpDbContext dbContext = new EmpDbContext();
            return dbContext.Employees.ToList();
        }

        public List<EmpDal.Employee> UpdateEmployees()
        {
            EmpDbContext dbContext = new EmpDbContext();
            return dbContext.Employees.ToList();
        }

        public List<EmpDal.Employee> DeleteEmployees()
        {
            EmpDbContext dbContext = new EmpDbContext();
            return dbContext.Employees.ToList();
        }
    }
}
