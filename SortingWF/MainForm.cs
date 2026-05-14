namespace SortingWF
{
    public partial class MainForm : Form
    {

        int[] testArr = new int[] { 9, 1, 3, 5, 4, 2, 6, 7, 8, 10, 0 };
        

        public MainForm()
        {
            InitializeComponent();
            Sorting.BozoSort bs = new Sorting.BozoSort(displaySort);

            bs.sort(testArr);
        }

        public void displaySort(int[] arr)
        {
            displayPanel.Invalidate();
        }

        private void displayPanel_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Color.White);
            using (SolidBrush sb = new SolidBrush(Color.Black))
            {
                Pen p = new Pen(Color.Tomato);

                var width = displayPanel.Width / testArr.Length;

                for (int i = 0; i < testArr.Length; i++)
                {
                    var x = width * i;

                    var height = (testArr[i] + 1) * (displayPanel.Height / testArr.Length);
                    var y = displayPanel.Height - height;
                    g.FillRectangle(sb, x, y, width, height);
                    g.DrawRectangle(p, x, y, width, height);

                }
            }

        }
    }
}
