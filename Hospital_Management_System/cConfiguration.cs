using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Hospital_Managerment_System
{
    public class cConfiguration
    {
        public enum pCrud { Create, Read, Update, Delete, xyz };
        public static String pCreate = "Create...";
        public static String pRead = "Read";
        public static String pUpdate = "Update";
        public static String pDelete = "Delete";
    }
}
