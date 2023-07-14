using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Science_Student
{
    class CompSciStudent : Student
    {
        // Constants
        private double MATH_HOURS = 20;
        private double CS_HOURS = 40;
        private double GEN_HOURS = 60;

        // Fields
        private string _academicTrack;

        // TODO
        // Constructor
       public CompSciStudent(string academicTrack)
        {
            _academicTrack = academicTrack;
        }

        // TODO
        // AcademicTrack property
        public string AcademicTrack()
        {
            get { return _academicTrack;}
            set { _academicTrack = value;}
        }
     

        // TODO
        // Override the RequiredHours property
        // returns the total number of hours required for the degree.
        public override double RequiredHours
        {
            get { return MATH_HOURS + CS_HOURS + GEN_HOURS; }
    }
}
