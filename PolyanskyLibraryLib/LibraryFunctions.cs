using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PolyanskyLibraryLib
{
    public class LibraryFunctions
    {
        private string libraryName = "Городская библиотека г.Чита"; //имя библиотеки
        private string chiefLibrarian = "Иванова Мария Петровна"; //главный библиотекарь
        private List<string> staffList = new List<string>
        {
            "Петров П.С.",
            "Сидорова А.В.",
            "Козлов И.Д.",
            "Иванова М.П."
        }; // сотрудники библиотеки

        public string GetChiefLibrarian()
        {
            return chiefLibrarian; // возвращает ФИО главного библиотекаря
        }

        public string GetLibraryName()
        {
            return libraryName; // возвращает название библиотек 
        }

        public bool SetChiefLibrarian(string fullname)
        {
            if (staffList.Contains(fullname))
            {
                chiefLibrarian = fullname;
                return true;
            }
            else
            {
                return false; // меняет главного библиотекаря, если он есть в списке
            }
        }

        public string GenerateBookCode(string category, int number)
        {
            return category + "_" + number; // формирует и возвращает строку вида CAT_number
        }

        public List<string> GetStaff()
        {
            return staffList; // возвращает список сотрудников библиотеки
        }

        public void AddStaff(string fullname)
        {
            staffList.Add(fullname); // добавляет нового сотрудника в список
        }
    }
}
