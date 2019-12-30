using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Abstract_class_vs_Interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Abstract_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StudentAbstract Stud = new Student_Details1();
                Stud.ID = "333";
                Stud.FirstName = "Dhruv";
                Stud.LastName = "Sheth";
                MessageBox.Show(Stud.Add());
                //call the CalculateAttendance method
                MessageBox.Show(Stud.CalculateAttendance());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Interface_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                IStudent iStud = new Student_Details2();

                iStud.ID = "333";
                iStud.FirstName = "Dhruv";
                iStud.LastName = "Sheth";

                MessageBox.Show(iStud.Add());
                MessageBox.Show(iStud.CalculateAttendance());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


    public abstract class StudentAbstract
    {
        public StudentAbstract()
        {

        }


        //we can have fields and properties 

        #region Abstract Properties and methods
        //properties
        public abstract String ID
        {
            get;
            set;
        }

        public abstract String FirstName
        {
            get;
            set;
        }

        public abstract String LastName
        {
            get;
            set;
        }

        //abstract method that is different 
        public abstract String CalculateAttendance();
        #endregion


        #region Non Abstract properties and methods

        #region non-abstract properties

        protected String id;
        protected String lname;
        protected String fname;

        #endregion

        #region non-abstract methods

        public String Update()
        {
            return "Student " + id + " " +
                      lname + " " + fname +
                      " updated";
        }

        public String Add()
        {
            return "Student " + id + " " +
                      lname + " " + fname +
                      " added";
        }

        public String Delete()
        {
            return "Student " + id + " " +
                      lname + " " + fname +
                      " deleted";
        }

        public String Search()
        {
            return "Student " + id + " " +
                      lname + " " + fname +
                      " found";
        }

        #endregion

        #endregion



    }

    public interface IStudent
    {
        //cannot have fields. uncommenting 
        //will raise error, 
        //if we will try to declare same as abstract class!
        //        protected String id;
        //        protected String lname;
        //        protected String fname;

        //just signature of the properties 
        //and methods.
        //setting a rule or contract to be 
        //followed by implementations.

        String ID { get; set; }
        String FirstName { get; set; }
        String LastName { get; set; }


        // cannot have implementation
        // cannot have modifiers public 
        // etc all are assumed public
        // cannot have virtual

        String Update();
        String Add();
        String Delete();
        String Search();
        String CalculateAttendance();
    }

    //Inheriting from the Abstract class

    public class Student_Details1 : StudentAbstract
    {
        //uses all the properties of the 

        //Abstract class therefore no 
        //properties or fields here!

        public Student_Details1()
        {
        }

        public override String ID { get; set; }
        public override String FirstName { get; set; }
        public override String LastName { get; set; }

        //common methods that are 
        //implemented in the abstract class
        public new String Add()
        {
            return base.Add();
        }

        //common methods that are implemented 
        //in the abstract class
        public new String Delete()
        {
            return base.Delete();
        }

        //common methods that are implemented 
        //in the abstract class
        public new String Search()
        {
            return base.Search();
        }

        //common methods that are implemented 
        //in the abstract class
        public new String Update()
        {
            return base.Update();
        }

        //abstract method that is different 
        //therefore I override it here.
        public override String CalculateAttendance()
        {
            return "Full time Student " +
                  base.fname + "'s attandance is calculated " +
                  "using the Abstract class...";
        }
    }


    public class Student_Details2 : IStudent
    {
        //All the properties and 

        //fields are defined here!
        protected String id;
        protected String lname;
        protected String fname;

        public Student_Details2()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public String ID { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        //all the manipulations including Add,Delete, 

        //Search, Update, Calculate are done
        //within the object as there are not 
        //implementation in the Interface entity.

        public String Add()
        {
            return "Fulltime Student " + fname + " added.";
        }

        public String Delete()
        {
            return "Fulltime Student " + fname + " deleted.";
        }

        public String Search()
        {
            return "Fulltime Student " + fname + " searched.";
        }

        public String Update()
        {
            return "Fulltime Student " + fname + " updated.";
        }

        //if you change to Calculateattendance(). 


        //Just small 'a' it will raise 
        //error as in interface
        //it is CalculateAttendance() with capital 'A'.

        public String CalculateAttendance()
        {
            return "Full time Student " +
                  fname + "'s attandance calculated using " +
                  "Interface.";
        }
    }
}
