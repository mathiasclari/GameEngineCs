using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoxiEditor.GameProject
{
    class NewProject : ViewModelBase
    {
        private string _name = "New Project";
        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;

                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        private string _path = "C:\\";

        public string Path
        {
            get => _path;
            set
            {
                if (_path != value)
                {
                    _path = value;

                    OnPropertyChanged(nameof(Path));
                }
            }
        }
    }
}
