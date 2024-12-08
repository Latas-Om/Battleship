using System;
using System.Data.Common;
using Vsite.Oom.Battleship.Model;

namespace BattleshipGUI
{
    public partial class Form1 : Form
    {
        GameRules rules = new GameRules();
        private FleetBuilder fleetGenerator;
        private Fleet playerFleet;
        private Fleet computerFleet;

        private Gunnery computerGunnery;


        public Form1()
        {
            // rules = new GameRules();
            computerGunnery = new Gunnery(rules);
            fleetGenerator = new FleetBuilder(rules);
            playerFleet = fleetGenerator.CreateFleet();
            computerFleet = fleetGenerator.CreateFleet();
            InitializeComponent();
            remainingShips1.UpdateRemainingShips(computerFleet);
        }

        private void newFleetButton_Click(object sender, EventArgs e)
        {
            playerFleet = fleetGenerator.CreateFleet();
            foreach (Button button in myGrid.buttons)
            {
                button.BackColor = default;
            }
            myGrid_Load(this, EventArgs.Empty);
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            newFleetButton.Enabled = false;
        }

        private void myGrid_Load(object sender, EventArgs e)
        {
            FillPlayerGrid();
            myGrid.Refresh();
        }

        private void opponentGrid_Load(object sender, EventArgs e)
        {
            opponentGrid.AttachOpponentButtonClickEvent(RecordGridButtonClick);
        }

        private void FillPlayerGrid()
        {
            foreach (Ship ship in playerFleet.Ships)
            {
                foreach (Square square in ship.Squares)
                {
                      myGrid.buttons[square.Row, square.Column].BackColor = Color.Green;
                }
            }
        }


        private void RecordGridButtonClick(object sender, EventArgs e)
        {
            newFleetButton.Enabled = false;

            Button button = (Button)sender;
            GridButton gridButton = (GridButton)button;

            int row = gridButton.Row;
            int column = gridButton.Column;

            Square target = new Square(row, column);

            HitResult result = computerFleet.Fire(target);
            target.Mark(result);
            UpdateGridButton(target, result, opponentGrid, computerFleet);
            button.Enabled = false;

            remainingShips1.UpdateRemainingShips(computerFleet);

            if (!computerFleet.Ships.Any(s => s.Squares.Any(ss => ss.SquareState == SquareState.Initial)))
            {
                DialogResult newGame = MessageBox.Show("You have won! Do you want to play another game?", "Congratulations!", MessageBoxButtons.YesNo);

                if (newGame == DialogResult.Yes)
                {
                    ReloadForm();
                }
                else
                {
                    Close();
                }
            }

            ComputerMove();
        }


        private GridButton GetGridButton(Square target, Grid grid)
        {
            foreach (GridButton button in grid.Controls)
            {
                if (button.Row == target.Row && button.Column == target.Column)
                {
                    return button;
                }
            }
            return null;
        }


        private void UpdateGridButton(Square target, HitResult result, Grid grid, Fleet fleet)
        {
            GridButton button = GetGridButton(target, grid);

            switch (result)
            {
                case HitResult.Hit:
                    button.BackColor = Color.Red;
                    break;
                case HitResult.Sunk:
                    var ship = fleet.Ships.FirstOrDefault(s => s.Squares.Contains(target));
                    if (ship != null)
                    {
                        foreach (var square in ship.Squares)
                        {
                            GridButton shipButton = GetGridButton(square, grid);
                            shipButton.BackColor = Color.DarkRed;
                        }
                    }
                    break;
                case HitResult.Missed:
                    button.BackColor = Color.Gray;
                    break;
                default:
                    button.BackColor = SystemColors.Control;
                    break;
            }

        }

        private void ComputerMove()
        {
            Square target = computerGunnery.NextTarget();

            HitResult result = playerFleet.Fire(target);

            computerGunnery.ProcessHitResult(result);

            UpdateGridButton(target, result, myGrid, playerFleet);

            if (!playerFleet.Ships.Any(s => s.Squares.Any(ss => ss.SquareState == SquareState.Initial)))
            {
                DialogResult newGame = MessageBox.Show("Computer has won! Do you want to play another game?", "Game Over", MessageBoxButtons.YesNo);

                if (newGame == DialogResult.Yes)
                {
                    ReloadForm();
                }
                else
                {
                    this.Close();
                }
            }

        }

        private void ReloadForm()
        {
            computerGunnery = new Gunnery(rules);
            fleetGenerator = new FleetBuilder(rules);
            playerFleet = fleetGenerator.CreateFleet();
            computerFleet = fleetGenerator.CreateFleet();
            newFleetButton.Enabled = true;

            foreach (GridButton button in myGrid.buttons)
            {
                button.BackColor = SystemColors.Control;
            }

            foreach (GridButton button in opponentGrid.buttons)
            {
                button.BackColor = SystemColors.Control;
                button.Enabled = true;
            }

            FillPlayerGrid();
            remainingShips1.UpdateRemainingShips(computerFleet);
            myGrid.Refresh();
            opponentGrid.Refresh();
        }

        private void remainingShips1_Load(object sender, EventArgs e)
        {

        }
    }

}