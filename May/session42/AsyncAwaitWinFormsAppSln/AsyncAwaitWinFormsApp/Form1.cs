using AsyncAwaitWinFormsApp.Services;

namespace AsyncAwaitWinFormsApp
{
    public partial class Form1 : Form
    {
        PrintingService _service = new PrintingService();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello pressed");
        }

        private void btnPrintSync_Click(object sender, EventArgs e)
        {
            _service.Print();
            MessageBox.Show("End of click");
        }

        private void butTask1_Click(object sender, EventArgs e)
        {
            //Task.Run(()=>_service.Print());
            Task.Run(_service.Print);
            MessageBox.Show("end of task 1 click");
        }

        private async void btnPrintAsync1_Click(object sender, EventArgs e)
        {
            await _service.PrintAsync1();
            MessageBox.Show("end of Async 1 click");

        }

        private async void btnPrintAsync2_Click(object sender, EventArgs e)
        {
            var result = await _service.PrintAsync2();
            MessageBox.Show(result.ToString());
        }
    }
}