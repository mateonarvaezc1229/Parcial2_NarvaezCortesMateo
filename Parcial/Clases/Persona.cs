using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            _year = ValidateYear(year);
            _month = ValidateMonth(month);
            _day = ValidateDay(day);

                
        }

        private int ValidateDay(int day, int month, int year)
        {
            if (month == 2 && day == 29 && IsleapYear(year))
            {
                return day;
            } 
            else
            {
                throw new YearException(String.Format("El año {0} no es bisiesto", year));
            }
        }

        private bool IsleapYear(int year)
        { 
            bool IsleapYear = year % 400 == 0 || year % 4 == 0 && year % 100 == 0;
            return IsleapYear;
        }
        




        private int ValidateYear(int year)
        {
            if (year >= 1900)

            {
                return year;
            }
            else 
            {
                throw new YearException(String.Format("El año {0} no es valido", year));
            }
        }




        private int ValidateMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;

            }
            else 
            {
                throw new MonthException(String.Format ("Ingrese un mes valido del 1 al 12; el mes {0} no es correcto",month));
            }
        }




        public override string ToString()
        { 
            var dateConcatenated = _day + "/"+ _month + "/"+ _year; 
            return dateConcatenated;
        }



        #endregion


    }
}
