using KeyboardCheck.Controls;
using System;
using System.Windows;

namespace KeyboardCheck
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ThreadTimer threadTimer;
        int count_ = 0;
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += (o, e) =>
            {
                WinApiWindow winApiWindow = new WinApiWindow();
                winApiWindow.Set(this);
                winApiWindow.HideWin_Tab();
                winApiWindow.MakeTransparent();
                winApiWindow.SetMostTop(true);
            };

            threadTimer = new ThreadTimer(this);
            threadTimer.Tick += (o, e) =>
            {
                x_keys.Children.Clear();
               
                foreach (System.Windows.Input.Key item in Enum.GetValues(typeof(System.Windows.Input.Key)))
                {
                    if(item == 0)
                        continue;
                    if (System.Windows.Input.Keyboard.IsKeyDown(item))
                    {
                        x_keys.Children.Add(new UIKeyPress() { Key = item });
                        count_++;
                    }
                }
               
                
            };
            threadTimer.initialize();
        }
    }
}
