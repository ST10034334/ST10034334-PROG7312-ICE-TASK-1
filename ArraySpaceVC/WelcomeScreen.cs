namespace ArraySpaceVC
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
            loadImage();
        }


        //loadImage() method checks if the image exists and loads into PictureBox if successful.
        public void loadImage()
        {
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "welcome_spaceship_background.jpg");

            if (File.Exists(imagePath))
            {
                welcomePictureBox.Image = Image.FromFile(imagePath);
                welcomePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //btnStart_Click() event handler navigates to the MenuScreen form and hides current form.
        private void btnStart_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            this.Hide();
        }
    }
}
