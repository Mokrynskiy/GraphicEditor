using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace GraphicEditor.Sensors
{
    /// <summary>
    /// Логика взаимодействия для TemperatureSensor.xaml
    /// </summary>
    public partial class TemperatureSensor : ContentControl
    {
        public TemperatureSensor()
        {
            InitializeComponent();
        }

        protected override void OnMouseDoubleClick(MouseButtonEventArgs e)
        {
            if(this.Parent is Canvas)
            {
                var canv = (Canvas)this.Parent;
                Selector.SetIsSelected(this, true);
            }
           
        }
    }
}
