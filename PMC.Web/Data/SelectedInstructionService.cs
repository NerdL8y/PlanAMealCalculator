using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMC.Web.Data
{
    public class SelectedInstructionService
    {
        private int _number = 0;
        private int _count = 0;
        public int InstructionID
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
        public int InstructionCount
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

        public event Action OnChange;

        private void NotifyDataChanged() => OnChange?.Invoke();
    }
}
