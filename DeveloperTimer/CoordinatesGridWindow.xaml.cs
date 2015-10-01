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
using System.Windows.Shapes;

namespace DeveloperTimer
{
    using System.Windows.Controls.Primitives;
    using System.Windows.Input;

    public partial class CoordinatesGridWindow : Window
    {
        private UniformGrid uniformGrid;

        public CoordinatesGridWindow()
        {

            InitializeComponent();
            uniformGrid = new UniformGrid();
            Content = uniformGrid;
            FillGrid();
        }

        private void FillGrid()
        {
            for (var c = 'A'; c <= 'Y'; c++)
            {
                for (char n = 'A'; n <= 'Y'; n++)
                {
                    var cell = NewCell();
                    var label = NewLabel(CellName(c, n));
                    cell.Child = label;
                    uniformGrid.Children.Add(cell);
                }
            }
        }

        private static TextBlock NewLabel(string name)
        {
            return new TextBlock()
            {
                Text = name,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                Foreground = new SolidColorBrush(Colors.Green),
                Background = new SolidColorBrush(Colors.White)
            };
        }

        private string CellName(char c, char n)
        {
            return c + "-" + ((n) - 64);
        }

        private Border NewCell()
        {
            return new Border()
            {
                BorderBrush = Brushes.Black,
                BorderThickness = new Thickness(0.1),
            };
        }

        private void CoordinatesGridWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            Hide();
        }
    }
}
