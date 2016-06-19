using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class EmployeeData
    {
        public bool SaveEmployee(string fname, string lname, string tel)
        {
            bool result = false;
            try
            {
                using (var db = new LibraryDBEntities())
                {
                    var employee = new Employee() { FName = fname, LName = lname, Tel = tel };
                    db.Employees.Add(employee);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public List<Employee> Search()
        {

            using (var db = new LibraryDBEntities())
            {
                try
                {
                    return db.Employees.ToList();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
    }
}
