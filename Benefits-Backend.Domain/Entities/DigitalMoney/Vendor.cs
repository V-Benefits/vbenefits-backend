using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.Entities.DigitalMoney
{
   public class Vendor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        public List<Cashier> Cashiers{ get; set; }
    }
    public class Cashier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
    }
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
     //   public string Code { get; set; }  to be confirmed
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
    }
    public class Menu
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public List<MenuItem> MenuItems { get; set; }
    }

    public class Order
    {      
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public Boolean AllowanceFlag { get; set; }
        public string OrderCode { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public int CashierId { get; set; }
        public Cashier Cashier { get; set; }
        public List<MenuItem> MenuItems { get; set; }
        public int EmployeeStaffId { get; set; }

        //DTO  shouldn't contain employee id //////////////////////////////// in service
        public int EmployeeId { get; set; }
        public Employeee Employee { get; set; }
    }
    public class EmployeeAllowance
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Boolean AllowanceFlag { get; set; }
        public int EmployeeStaffId { get; set; }
    }
    public class EmployeeeConsumption
    {
        public int Id { get; set; }
        //consumed search for another name                     //////////////////////////name
        public decimal TotalConsumedAmountOfMoneyForThisMonth { get; set; }
        public DateTime CurrentDate { get; set; }
        public int EmployeeeId { get; set; }
        public Employeee Employeee { get; set; }

    }

    public class Employeee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Band { get; set; }
        public decimal MaxLimit { get; set; }
        public int StaffId { get; set; }
    }
    public class EmployeeeConsumptionHistory
    {
        public int Id { get; set; }
        //consumed search for another name ///////////////////////////////////////////name
        public decimal TotalConsumedAmountOfMoneyForThisMonth { get; set; }
        public DateTime CurrentDate { get; set; }
        public string Name { get; set; }
        public string Band { get; set; }
        public decimal MaxLimit { get; set; }
        public int EmployeeStaffId { get; set; }
    }

    public class OrderHistory
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public Boolean AllowanceFlag { get; set; }
        public string OrderCode { get; set; }
        public string VendorName { get; set; }
        public string CashierName { get; set; }
       // public List<MenuItem> MenuItems { get; set; } ///////////////osamaaaaa
        public int EmployeeStaffId { get; set; }
        public string Name { get; set; }
        public string Band { get; set; }
        public decimal MaxLimit { get; set; }
    }
}
