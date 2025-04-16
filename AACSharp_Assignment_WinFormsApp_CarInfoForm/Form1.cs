using AACSharp_Assignment_WinFormsApp_CarInfoForm.Classes;

namespace AACSharp_Assignment_WinFormsApp_CarInfoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_showInfos_Click(object sender, EventArgs e)
        {

            try
            {
                Car car = new Car();
                car.brand  = text_brand.Text;
                car.model = text_model.Text;
                car.color = text_color.Text;
                car.windowCount = Convert.ToInt32(text_windowCount.Text);
                car.doorCount = Convert.ToInt32(text_doorCount.Text);
                car.fuelBurnedPer100 = Convert.ToDouble(text_fuelBurnedPer100.Text);

                string message =
                    $"-Renk: {car.color}\n" +
                    $"-Kapý Sayýsý: {car.doorCount}\n" +
                    $"-Pencere Sayýsý: {car.windowCount}\n" +
                    $"-100 km'de Yaktýðý Yakýt: {car.fuelBurnedPer100} litre";

                string title = $"{car.brand} - {car.model}";

                MessageBox.Show(message, title);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
