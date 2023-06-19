namespace FallingObjects
{
    public partial class Form1 : Form
    {
        public Thread ChangesColors;
        //public List<Color> colors = Colors.GetColors();
        public Form1()
        {
            InitializeComponent();
            ChangesColors = new Thread(new ThreadStart(ChangeColor));
            ChangesColors.Start();
        }

        public void ChangeColor()
        {
            bool valid = true;
            while (valid)
            {
                Color random_color = Colors.GetRandomColor();
                Play.BackColor = random_color;
                Thread.Sleep(750);
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game game = new Game();
            game.ShowDialog();
        }
    }
}