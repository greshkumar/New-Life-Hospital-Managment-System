using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hospital_Managerment_System
{
    class cPatient : cHuman
    {
        public String FullName;
        public String Gender;
        public String Occupation;
        public String RegistrationDate;
    }
}
