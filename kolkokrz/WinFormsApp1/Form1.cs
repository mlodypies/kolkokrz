namespace WinFormsApp1
{
    enum CurrentPlayer
    {
        Cross,
        Circle
    }
    public partial class Form1 : Form
    {
        CurrentPlayer currentPlayer;
        public Form1()
        {
            InitializeComponent();
            currentPlayer = CurrentPlayer.Cross;
            changeLabel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Mark(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if (currentPlayer == CurrentPlayer.Cross)
            {
                senderButton.Text = "X";
                currentPlayer = CurrentPlayer.Circle;
            }
            else
            {
                senderButton.Text = "O";
                currentPlayer = CurrentPlayer.Cross;
            }
            checkForWinner();
            changeLabel();
        }
        public void changeLabel()
        {
            if (currentPlayer == CurrentPlayer.Cross)
            {
                currentPlayerLabel.Text = "Krzy¿yk";
            }
            else
            {
                currentPlayerLabel.Text = "Kó³ko";
            }
        }
        public void checkForWinner()
        {
            if ((TL.Text == TC.Text) && (TC.Text == TR.Text) && TL.Text != "")
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = TL.Text;
                victoryScreen.Show();
            }
            else if ((CL.Text == CC.Text) && (CC.Text == CR.Text) && CL.Text != "")
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = CL.Text;
                victoryScreen.Show();
            }
            else if ((BL.Text == BC.Text) && (BC.Text == BR.Text) && BL.Text != "")
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = BL.Text;
                victoryScreen.Show();
            }

            if ((TL.Text == CL.Text) && (CL.Text == BL.Text) && TL.Text != "")
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = TL.Text;
                victoryScreen.Show();
            }
            else if ((TC.Text == CC.Text) && (CC.Text == BC.Text) && CC.Text != "")
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = TC.Text;
                victoryScreen.Show();
            }
            else if ((TR.Text == BR.Text) && (BR.Text == CR.Text) && TR.Text != "")
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = TR.Text;
                victoryScreen.Show();
            }

            if ((TL.Text == CC.Text) && (CC.Text == BR.Text) && TL.Text != "")
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = CC.Text;
                victoryScreen.Show();
            }
            else if ((TR.Text == CC.Text) && (CC.Text == BL.Text) && TR.Text != "")
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = TR.Text;
                victoryScreen.Show();
            }

        }
        public void clearBoard()
        {
            TableLayoutControlCollection buttons = tableLayoutPanel1.Controls;
            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i] is Button)
                    buttons[i].Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
