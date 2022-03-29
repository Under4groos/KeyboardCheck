using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KeyboardCheck.Controls
{
    /// <summary>
    /// Логика взаимодействия для UIKeyPress.xaml
    /// </summary>
    public partial class UIKeyPress : UserControl
    {
        System.Windows.Input.Key Key_l;
        public System.Windows.Input.Key Key
        {
            get
            {
                return this.Key;
            }
            set
             {
                this.Key_l = value;
                key_name.Content = value;
            }
        }
        public UIKeyPress()
        {
            InitializeComponent();
        }
    }
}
