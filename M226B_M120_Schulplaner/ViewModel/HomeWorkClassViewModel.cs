using M226B_M120_Schulplaner.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M226B_M120_Schulplaner.ViewModel
{
    class HomeWorkClassViewModel
    {
        public List<HomeWorkClass> _HomeWorkList = new List<HomeWorkClass>();
        public void addToList(HomeWorkClass HomeWorkClass)
        {
            _HomeWorkList.Add(HomeWorkClass);
        }

        public List<HomeWorkClass> getHomeWorkClassList()
        {
            return _HomeWorkList;
        }
        public void setHomeWorkClassList(List<HomeWorkClass> value)
        {
            _HomeWorkList = value;
        }
    }
}
