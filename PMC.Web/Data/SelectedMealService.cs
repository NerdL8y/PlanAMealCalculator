using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* TODO When a service exists, and it is set as a singleton, instead of using a specific ID, like MealID, 
 * can I make it a number (int) and set it to 0 once it is no longer needed?
 */
namespace PMC.Web.Data
{
    public class SelectedMealService
    {
        public event Action OnChange;
        private int _number;
        private int _count;
        public int MealID
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
                NotifyDataChanged();
            }
        }
        public int MealCount
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
                NotifyDataChanged();
            }
        }
        private string _color;
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
                NotifyDataChanged();
            }
        }

        private void NotifyDataChanged() => OnChange?.Invoke();
    }
}