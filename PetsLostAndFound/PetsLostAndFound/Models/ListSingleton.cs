using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetsLostAndFound.Models
{
    // Singleton to contain data for display
    public class ListSingleton
    {
        private List<Animal> _allAnimals;

        private static ListSingleton _instance = null;

        public static ListSingleton Instance 
        {
            get 
            {
                if (_instance == null)
                {
                    _instance = new ListSingleton();
                }
                return _instance;
            }
             }

       
    }
}
