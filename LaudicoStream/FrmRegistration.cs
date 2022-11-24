using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaudicoStream
{
    public partial class FrmRegistration : Form
    {
        public static string SetFileName;
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            

            String studentNo = txtStudentNumber.Text;
            String LastName = txtLastName.Text;
            String FirstName = txtFirstName.Text;
            String MiddleName = txtMiddleName.Text;
            String ageNumber = txtAge.Text;
            String programs = cbProgram.SelectedItem.ToString();
            String gender = cbGender.SelectedItem.ToString();
            String bday = datePicker.Text;
            String contactNo = txtContactNo.Text;

            SetFileName = studentNo;


            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            studentNo +".txt")))
            {
                outputFile.WriteLine("Student Number : " + studentNo);
                outputFile.WriteLine("Full Name : " + LastName+ ", " +FirstName+ ", "+MiddleName+ ".");
                outputFile.WriteLine("Program : " + programs);
                outputFile.WriteLine("Gender: " + gender);
                outputFile.WriteLine("Age : " + ageNumber);
                outputFile.WriteLine("Birthday : " + bday);
                outputFile.WriteLine("Contact : " + contactNo);
            }

            this.Close();
        }
    }
}
