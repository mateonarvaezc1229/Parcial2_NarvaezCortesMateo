using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Clases
{
    public class Persona
    {
        #region Fields

        private int _year;
        private int _month;
        private int _day;

        public Persona()
        {
        }

        #endregion

        #region Methods

        public Persona(int year, int month, int day)
        {
            _year = year;
            _month = month;
            _day = day; 

                
        }

        public override string ToString()
        { 
            var dateConcatenated = _day + "/"+ _month + "/"+ _year; 
            return dateConcatenated;
        }



        #endregion


    }
}
