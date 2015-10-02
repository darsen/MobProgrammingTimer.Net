namespace DeveloperTimer
{
    using System.Windows.Controls.Primitives;
    using System.Windows.Input;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

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
            for (var letter = 'A'; letter <= 'Y'; letter++)
            {
                for (var number = 'A'; number <= 'Y'; number++)
                {
                    var cell = NewCell();
                    var label = NewLabel(CellName(letter, number));
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

        private string CellName(char letter, char number)
        {
            return letter + "-" + ((number) - 64);
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
