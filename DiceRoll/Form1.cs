namespace DiceRoll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the die with 6 sides
            Die die = new Die(20);
            die.Roll();
            // Display what was rolled, it uses the method Roll(). And that method in the Die Class. 
            // already returns a byte, so we can just call it directly in the MessageBox.
            MessageBox.Show(die.Roll().ToString());

        }
    }
}
