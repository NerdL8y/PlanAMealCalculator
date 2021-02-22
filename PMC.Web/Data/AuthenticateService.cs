using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMC.Web.Data
{
    public class AuthenticateService
    {
        public event Action OnChange;
        private int _number;
        public int UserID
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
