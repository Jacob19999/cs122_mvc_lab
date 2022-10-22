// Written By Jacob Tang

using System.Data;
using System.Diagnostics.Metrics;
using System.Net;
using System.Numerics;
using System.Security.Cryptography;

namespace mvc_app1.Models
{
    public class EmployeeModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Title { get; set; }
        public string? TitleOfCourtesy { get; set; }
        public string? Address { get; set; }
        public string? Birthdate { get; set; }
        public string? HireDate { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Extension { get; set; }
        public string? Notes { get; set; }
        public string? Photo { get; set; }
        public string? ReportsTo { get; set; }


    }


    public class Employee
    {
        public DataTable updateEmployee(string path)
        {
            var employees = new File.FileGateway();
            return employees.GetDataTabletFromCSVFile(path);
        }

        public List<EmployeeModel>UpdateDT(DataTable dt)
        {

            int i = dt.Rows.Count;    
            System.Diagnostics.Debug.WriteLine("Size of table: " + i);
            List<EmployeeModel> list1 = new List<EmployeeModel>();

            for (int j=0; j<i; j++)
            {

                var k = new EmployeeModel();

                k.LastName = Convert.ToString(dt.Rows[j][1].ToString());
                k.FirstName = Convert.ToString(dt.Rows[j][2].ToString());
                k.Title = Convert.ToString(dt.Rows[j][3].ToString());
                k.TitleOfCourtesy = Convert.ToString(dt.Rows[j][4].ToString());
                k.Birthdate = Convert.ToString(dt.Rows[j][5].ToString());
                k.HireDate = Convert.ToString(dt.Rows[j][6].ToString());
                k.Address = Convert.ToString(dt.Rows[j][7].ToString());
                k.City = Convert.ToString(dt.Rows[j][8].ToString());
                k.Region = Convert.ToString(dt.Rows[j][9].ToString());
                k.PostalCode = Convert.ToString(dt.Rows[j][10].ToString());
                k.Country = Convert.ToString(dt.Rows[j][11].ToString());
                k.Phone = Convert.ToString(dt.Rows[j][12].ToString());
                k.Extension = Convert.ToString(dt.Rows[j][13].ToString());
                k.Photo = Convert.ToString(dt.Rows[j][14].ToString());
                k.Notes = Convert.ToString(dt.Rows[j][15].ToString());
                k.ReportsTo = Convert.ToString(dt.Rows[j][16].ToString());

                list1.Add(k);

            }
      
            return list1;
        }
    }
}
