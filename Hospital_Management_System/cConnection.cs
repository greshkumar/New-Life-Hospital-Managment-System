using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hospital_Managerment_System
{
    class cConnection
    {
        static String vConnectionPath = Application.StartupPath;
        static String vDbName = "\\HospitalDB.accdb";
        static String connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + vDbName;

        static OleDbConnection adocon;
        static OleDbCommand insertcmd;



        public static void fPatientDataSave(cPatient tempPatient)
        {
            adocon = new OleDbConnection(connectionString);

            String commandText = "insert into tPatient values ('" + tempPatient.FullName + "', '" + tempPatient.FatherName + "', '" + tempPatient.Gender + "', '" + tempPatient.RegistrationDate + "','" + tempPatient.Occupation + "', '" + tempPatient.CNIC + "', '" + tempPatient.Contact + "', '" + tempPatient.Disease + "', '" + tempPatient.Address + "','" + tempPatient.Prescription + "')";
            insertcmd = new OleDbCommand(commandText, adocon);

            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();

            insertcmd.Connection.Close();

        }

        public static OleDbDataReader fDataRetrieveOnlyColumn(String s = "Select FullName from tPatient")
        {
            adocon = new OleDbConnection();
            adocon.ConnectionString = connectionString;
            adocon.Open();

            insertcmd = new OleDbCommand();
            insertcmd.CommandText = s;
            insertcmd.Connection = adocon;

            OleDbDataReader oDataReader = insertcmd.ExecuteReader();
            return oDataReader;
        }


        public static OleDbDataReader fDoctorRetrieveOnlyColumn(String s = "Select FullName from tDoctor")
        {
            adocon = new OleDbConnection();
            adocon.ConnectionString = connectionString;
            adocon.Open();

            insertcmd = new OleDbCommand();
            insertcmd.CommandText = s;
            insertcmd.Connection = adocon;

            OleDbDataReader oDataReader = insertcmd.ExecuteReader();
            return oDataReader;
        }

        public static OleDbDataReader fPharmacyRetrieveOnlyColumn(String s = "Select Name from tPharmacy")
        {
            adocon = new OleDbConnection();
            adocon.ConnectionString = connectionString;
            adocon.Open();

            insertcmd = new OleDbCommand();
            insertcmd.CommandText = s;
            insertcmd.Connection = adocon;

            OleDbDataReader oDataReader = insertcmd.ExecuteReader();
            return oDataReader;
        }

        public static void fDataRetrieveWholeRecord(cPatient oPatient, String opfullname)
        {
            adocon = new OleDbConnection();
            adocon.ConnectionString = connectionString;
            adocon.Open();

            insertcmd = new OleDbCommand();
            String vCommandText = "Select * from tPatient where fullname = '" + opfullname + "'";
            insertcmd.CommandText = vCommandText;
            insertcmd.Connection = adocon;

            OleDbDataAdapter oAdapter = new OleDbDataAdapter();
            oAdapter.SelectCommand = insertcmd;

            DataSet oDataSet = new DataSet();

            oAdapter.Fill(oDataSet, "tPatient");

            oPatient.FullName = oDataSet.Tables["tPatient"].Rows[0]["FullName"].ToString();
            oPatient.FatherName = oDataSet.Tables["tPatient"].Rows[0]["FatherName"].ToString();
            oPatient.Gender = oDataSet.Tables["tPatient"].Rows[0]["Gender"].ToString();
            oPatient.RegistrationDate = oDataSet.Tables["tPatient"].Rows[0]["RegistrationDate"].ToString();
            oPatient.Occupation = oDataSet.Tables["tPatient"].Rows[0]["Occupation"].ToString();
            oPatient.CNIC = oDataSet.Tables["tPatient"].Rows[0]["CNIC"].ToString();
            oPatient.Contact = oDataSet.Tables["tPatient"].Rows[0]["Contact"].ToString();
            oPatient.Disease = oDataSet.Tables["tPatient"].Rows[0]["Disease"].ToString();
            oPatient.Address = oDataSet.Tables["tPatient"].Rows[0]["Address"].ToString();
            oPatient.Prescription = oDataSet.Tables["tPatient"].Rows[0]["Prescription"].ToString();


        }


        public static void fDataRetrieveWholeRecord1(cDoctor oDoctor, String opfullname)
        {
            adocon = new OleDbConnection();
            adocon.ConnectionString = connectionString;
            adocon.Open();

            insertcmd = new OleDbCommand();
            String vCommandText = "Select * from tDoctor where FullName = '" + opfullname + "'";
            insertcmd.CommandText = vCommandText;
            insertcmd.Connection = adocon;

            OleDbDataAdapter oAdapter = new OleDbDataAdapter();
            oAdapter.SelectCommand = insertcmd;

            DataSet oDataSet = new DataSet();

            oAdapter.Fill(oDataSet, "tDoctor");

            oDoctor.Name = oDataSet.Tables["tDoctor"].Rows[0]["FullName"].ToString();
            oDoctor.FatherName = oDataSet.Tables["tDoctor"].Rows[0]["FatherName"].ToString();
            oDoctor.CNIC = oDataSet.Tables["tDoctor"].Rows[0]["CNIC"].ToString();
            oDoctor.Contact = oDataSet.Tables["tDoctor"].Rows[0]["Contact"].ToString();
            oDoctor.Disease = oDataSet.Tables["tDoctor"].Rows[0]["Disease"].ToString();
            oDoctor.Address = oDataSet.Tables["tDoctor"].Rows[0]["Address"].ToString();
            oDoctor.Prescription = oDataSet.Tables["tDoctor"].Rows[0]["Prescription"].ToString();
            oDoctor.Payroll = oDataSet.Tables["tDoctor"].Rows[0]["Payroll"].ToString();
            oDoctor.Type = oDataSet.Tables["tDoctor"].Rows[0]["Type"].ToString();
            oDoctor.Timing = oDataSet.Tables["tDoctor"].Rows[0]["Timing"].ToString();


        }


        public static void fDataRetrieveWholeRecord2(cPharmacy oPharmacy, String opname)
        {
            adocon = new OleDbConnection();
            adocon.ConnectionString = connectionString;
            adocon.Open();

            insertcmd = new OleDbCommand();
            String vCommandText = "Select * from tPharmacy where Name = '" + opname + "'";
            insertcmd.CommandText = vCommandText;
            insertcmd.Connection = adocon;

            OleDbDataAdapter oAdapter = new OleDbDataAdapter();
            oAdapter.SelectCommand = insertcmd;

            DataSet oDataSet = new DataSet();

            oAdapter.Fill(oDataSet, "tPharmacy");

            oPharmacy.Type = oDataSet.Tables["tPharmacy"].Rows[0]["Type"].ToString(); 
            oPharmacy.Name = oDataSet.Tables["tPharmacy"].Rows[0]["Name"].ToString();
            oPharmacy.Quantity = oDataSet.Tables["tPharmacy"].Rows[0]["Quantity"].ToString();
            oPharmacy.Stock = oDataSet.Tables["tPharmacy"].Rows[0]["Stock"].ToString();
            oPharmacy.CurrentDate = oDataSet.Tables["tPharmacy"].Rows[0]["Current Date"].ToString();
            oPharmacy.ExpiryDate = oDataSet.Tables["tPharmacy"].Rows[0]["Expiry Date"].ToString();
            oPharmacy.Price = oDataSet.Tables["tPharmacy"].Rows[0]["Retail Price"].ToString();
        }


        public static void fPatient_Update(cPatient opatient, string oPatientfullname)
        {
            adocon = new OleDbConnection(connectionString);

            string commandText = "Update tPatient SET ";
            commandText += "FullName = '" + opatient.FullName + "',";
            commandText += "FatherName = '" + opatient.FatherName + "',";
            commandText += "Gender = '" + opatient.Gender + "', ";
            commandText += "RegistrationDate = '" + opatient.RegistrationDate + "',";
            commandText += "Occupation = '" + opatient.Occupation + "',";
            commandText += "CNIC= '" + opatient.CNIC + "',";
            commandText += "Contact = '" + opatient.Contact + "',";
            commandText += "Disease = '" + opatient.Disease + "',";
            commandText += "Address = '" + opatient.Address + "',";
            commandText += "Prescription = '" + opatient.Prescription + "'";
            commandText += "WHERE FullName = '" + oPatientfullname + "'";

            OleDbCommand insertcmd = new OleDbCommand(commandText, adocon);

            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();

            insertcmd.Connection.Close();

        }

        public static void fPatient_Del( cPatient oPatient, String opfullname)
        {
            adocon = new OleDbConnection();
            adocon.ConnectionString = connectionString;
            adocon.Open();

            insertcmd = new OleDbCommand();
            String vCommandText = "Delete From tPatient where fullname = '" + opfullname + "'";
            insertcmd.CommandText = vCommandText;
            insertcmd.Connection = adocon;

            OleDbDataAdapter oAdapter = new OleDbDataAdapter();
            oAdapter.SelectCommand = insertcmd;

            DataSet oDataSet = new DataSet();

            oAdapter.Fill(oDataSet, "tPatient");

        }

        public static void fDoctor_Del(cDoctor oDoctor, String opfullname)
        {
            adocon = new OleDbConnection();
            adocon.ConnectionString = connectionString;
            adocon.Open();

            insertcmd = new OleDbCommand();
            String vCommandText = "Delete From tDoctor where FullName = '" + opfullname + "'";
            insertcmd.CommandText = vCommandText;
            insertcmd.Connection = adocon;

            OleDbDataAdapter oAdapter = new OleDbDataAdapter();
            oAdapter.SelectCommand = insertcmd;

            DataSet oDataSet = new DataSet();

            oAdapter.Fill(oDataSet, "tDoctor");

        }


        public static void fDoctorDataSave(cDoctor oDoctor)
        {
            adocon = new OleDbConnection(connectionString);

            String commandText = "insert into tDoctor values ('" + oDoctor.Name + "', '" + oDoctor.FatherName + "', '" + oDoctor.CNIC + "', '" + oDoctor.Contact + "', '" + oDoctor.Disease + "', '" + oDoctor.Address + "','" + oDoctor.Prescription + "', '" + oDoctor.Timing + "', '" + oDoctor.Type + "','" + oDoctor.Payroll + "')";
            insertcmd = new OleDbCommand(commandText, adocon);

            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();

            insertcmd.Connection.Close();
        }

        public static void fPharmacyDataSave(cPharmacy tempPharmacy)
        {
            adocon = new OleDbConnection(connectionString);

            String commandText = "insert into tPharmacy values ('" + tempPharmacy.Type + "', '" + tempPharmacy.Name + "', '" + tempPharmacy.Quantity + "', '" + tempPharmacy.Stock + "', '" + tempPharmacy.CurrentDate + "', '" +tempPharmacy.ExpiryDate + "', '" + tempPharmacy.Price + "')";
            insertcmd = new OleDbCommand(commandText, adocon);

            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();
            insertcmd.Connection.Close();
        
        }

        public static void fPharmacy_Del(cPharmacy oPharmacy, String opfullname)
        {
            adocon = new OleDbConnection();
            adocon.ConnectionString = connectionString;
            adocon.Open();

            insertcmd = new OleDbCommand();
            String vCommandText = "Delete From tPharmacy where Name = '" + opfullname + "'";
            insertcmd.CommandText = vCommandText;
            insertcmd.Connection = adocon;

            OleDbDataAdapter oAdapter = new OleDbDataAdapter();
            oAdapter.SelectCommand = insertcmd;

            DataSet oDataSet = new DataSet();

            oAdapter.Fill(oDataSet, "tPharmacy");

        }
    }
}
