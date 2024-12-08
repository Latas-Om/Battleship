namespace BattleshipGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            myGrid = new Grid();
            opponentGrid = new Grid();
            newFleetButton = new Button();
            startGameButton = new Button();
            horizontalLabel1 = new HorizontalLabel();
            horizontalLabel2 = new HorizontalLabel();
            verticalLabel1 = new VerticalLabel();
            verticalLabel2 = new VerticalLabel();
            remainingShips1 = new RemainingShips();
            label1 = new Label();
            SuspendLayout();
            // 
            // myGrid
            // 
            myGrid.Location = new Point(59, 68);
            myGrid.Margin = new Padding(3, 5, 3, 5);
            myGrid.Name = "myGrid";
            myGrid.Size = new Size(541, 560);
            myGrid.TabIndex = 0;
            myGrid.Load += myGrid_Load;
            // 
            // opponentGrid
            // 
            opponentGrid.Location = new Point(744, 68);
            opponentGrid.Margin = new Padding(3, 5, 3, 5);
            opponentGrid.Name = "opponentGrid";
            opponentGrid.Size = new Size(541, 560);
            opponentGrid.TabIndex = 1;
            opponentGrid.Load += opponentGrid_Load;
            // 
            // newFleetButton
            // 
            newFleetButton.FlatAppearance.BorderColor = Color.White;
            newFleetButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            newFleetButton.Location = new Point(59, 648);
            newFleetButton.Margin = new Padding(3, 4, 3, 4);
            newFleetButton.Name = "newFleetButton";
            newFleetButton.Size = new Size(541, 61);
            newFleetButton.TabIndex = 2;
            newFleetButton.Text = "New Fleet";
            newFleetButton.UseVisualStyleBackColor = true;
            newFleetButton.Click += newFleetButton_Click;
            // 
            // startGameButton
            // 
            startGameButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            startGameButton.Location = new Point(59, 733);
            startGameButton.Margin = new Padding(3, 4, 3, 4);
            startGameButton.Name = "startGameButton";
            startGameButton.RightToLeft = RightToLeft.No;
            startGameButton.Size = new Size(541, 57);
            startGameButton.TabIndex = 3;
            startGameButton.Text = "Start Game";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += startGameButton_Click;
            // 
            // horizontalLabel1
            // 
            horizontalLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            horizontalLabel1.Location = new Point(744, 17);
            horizontalLabel1.Margin = new Padding(6, 5, 6, 5);
            horizontalLabel1.Name = "horizontalLabel1";
            horizontalLabel1.Size = new Size(541, 40);
            horizontalLabel1.TabIndex = 4;
            // 
            // horizontalLabel2
            // 
            horizontalLabel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            horizontalLabel2.Location = new Point(59, 17);
            horizontalLabel2.Margin = new Padding(6, 5, 6, 5);
            horizontalLabel2.Name = "horizontalLabel2";
            horizontalLabel2.Size = new Size(541, 40);
            horizontalLabel2.TabIndex = 5;
            // 
            // verticalLabel1
            // 
            verticalLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            verticalLabel1.Location = new Point(683, 68);
            verticalLabel1.Margin = new Padding(6, 7, 6, 7);
            verticalLabel1.Name = "verticalLabel1";
            verticalLabel1.Size = new Size(51, 560);
            verticalLabel1.TabIndex = 6;
            // 
            // verticalLabel2
            // 
            verticalLabel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            verticalLabel2.Location = new Point(3, 68);
            verticalLabel2.Margin = new Padding(6, 7, 6, 7);
            verticalLabel2.Name = "verticalLabel2";
            verticalLabel2.Size = new Size(51, 560);
            verticalLabel2.TabIndex = 7;
            // 
            // remainingShips1
            // 
            remainingShips1.Location = new Point(1015, 636);
            remainingShips1.Margin = new Padding(3, 5, 3, 5);
            remainingShips1.Name = "remainingShips1";
            remainingShips1.Size = new Size(270, 167);
            remainingShips1.TabIndex = 8;
            remainingShips1.Load += remainingShips1_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(867, 663);
            label1.Name = "label1";
            label1.Size = new Size(158, 32);
            label1.TabIndex = 9;
            label1.Text = "Enemy Fleet:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 839);
            Controls.Add(label1);
            Controls.Add(remainingShips1);
            Controls.Add(verticalLabel2);
            Controls.Add(verticalLabel1);
            Controls.Add(horizontalLabel2);
            Controls.Add(horizontalLabel1);
            Controls.Add(startGameButton);
            Controls.Add(newFleetButton);
            Controls.Add(opponentGrid);
            Controls.Add(myGrid);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Grid myGrid;
        private Grid opponentGrid;
        private Button newFleetButton;
        private Button startGameButton;
        private HorizontalLabel horizontalLabel1;
        private HorizontalLabel horizontalLabel2;
        private VerticalLabel verticalLabel1;
        private VerticalLabel verticalLabel2;
        private RemainingShips remainingShips1;
        private Label label1;
    }
}