namespace Mod2
{
    partial class DrawScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.randCheckBox = new System.Windows.Forms.CheckBox();
            this.randLabel = new System.Windows.Forms.Label();
            this.randColourButton = new System.Windows.Forms.Button();
            this.customLabel = new System.Windows.Forms.Label();
            this.customButton = new System.Windows.Forms.Button();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.colourLabel = new System.Windows.Forms.Label();
            this.animationLabel = new System.Windows.Forms.Label();
            this.animationRange = new System.Windows.Forms.NumericUpDown();
            this.directionLabel = new System.Windows.Forms.Label();
            this.multiplyLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.multiplyer = new System.Windows.Forms.NumericUpDown();
            this.numberOfPoints = new System.Windows.Forms.NumericUpDown();
            this.customColDialog = new System.Windows.Forms.ColorDialog();
            this.rotationBar = new System.Windows.Forms.TrackBar();
            this.rotationLabel = new System.Windows.Forms.Label();
            this.rotationValLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.animationRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationBar)).BeginInit();
            this.SuspendLayout();
            // 
            // randCheckBox
            // 
            this.randCheckBox.AutoSize = true;
            this.randCheckBox.Location = new System.Drawing.Point(652, 718);
            this.randCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.randCheckBox.Name = "randCheckBox";
            this.randCheckBox.Size = new System.Drawing.Size(163, 24);
            this.randCheckBox.TabIndex = 55;
            this.randCheckBox.Text = "Randomize colour";
            this.randCheckBox.UseVisualStyleBackColor = true;
            // 
            // randLabel
            // 
            this.randLabel.AutoSize = true;
            this.randLabel.Location = new System.Drawing.Point(973, 278);
            this.randLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.randLabel.Name = "randLabel";
            this.randLabel.Size = new System.Drawing.Size(80, 20);
            this.randLabel.TabIndex = 54;
            this.randLabel.Text = "RANDOM";
            // 
            // randColourButton
            // 
            this.randColourButton.BackColor = System.Drawing.Color.Gainsboro;
            this.randColourButton.Location = new System.Drawing.Point(936, 274);
            this.randColourButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.randColourButton.Name = "randColourButton";
            this.randColourButton.Size = new System.Drawing.Size(28, 29);
            this.randColourButton.TabIndex = 53;
            this.randColourButton.UseVisualStyleBackColor = false;
            this.randColourButton.Click += new System.EventHandler(this.randColourButton_Click);
            // 
            // customLabel
            // 
            this.customLabel.AutoSize = true;
            this.customLabel.Location = new System.Drawing.Point(973, 240);
            this.customLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customLabel.Name = "customLabel";
            this.customLabel.Size = new System.Drawing.Size(77, 20);
            this.customLabel.TabIndex = 52;
            this.customLabel.Text = "CUSTOM";
            // 
            // customButton
            // 
            this.customButton.BackColor = System.Drawing.Color.Gainsboro;
            this.customButton.Location = new System.Drawing.Point(936, 235);
            this.customButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(28, 29);
            this.customButton.TabIndex = 51;
            this.customButton.UseVisualStyleBackColor = false;
            this.customButton.Click += new System.EventHandler(this.customButton_Click);
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(973, 202);
            this.greenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(67, 20);
            this.greenLabel.TabIndex = 48;
            this.greenLabel.Text = "GREEN";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(973, 163);
            this.blueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(52, 20);
            this.blueLabel.TabIndex = 47;
            this.blueLabel.Text = "BLUE";
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(973, 120);
            this.redLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(44, 20);
            this.redLabel.TabIndex = 44;
            this.redLabel.Text = "RED";
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Gainsboro;
            this.greenButton.Location = new System.Drawing.Point(936, 197);
            this.greenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(28, 29);
            this.greenButton.TabIndex = 41;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Gainsboro;
            this.blueButton.Location = new System.Drawing.Point(936, 158);
            this.blueButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(28, 29);
            this.blueButton.TabIndex = 40;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(936, 120);
            this.redButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(28, 29);
            this.redButton.TabIndex = 37;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // colourLabel
            // 
            this.colourLabel.AutoSize = true;
            this.colourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colourLabel.Location = new System.Drawing.Point(930, 75);
            this.colourLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(175, 29);
            this.colourLabel.TabIndex = 36;
            this.colourLabel.Text = "Choose Colour";
            // 
            // animationLabel
            // 
            this.animationLabel.AutoSize = true;
            this.animationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animationLabel.Location = new System.Drawing.Point(22, 751);
            this.animationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.animationLabel.Name = "animationLabel";
            this.animationLabel.Size = new System.Drawing.Size(620, 29);
            this.animationLabel.TabIndex = 35;
            this.animationLabel.Text = "Animates from \'Number of Points\' to this number of points";
            // 
            // animationRange
            // 
            this.animationRange.Location = new System.Drawing.Point(28, 717);
            this.animationRange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.animationRange.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.animationRange.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.animationRange.Name = "animationRange";
            this.animationRange.Size = new System.Drawing.Size(615, 26);
            this.animationRange.TabIndex = 34;
            this.animationRange.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.animationRange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.animationRange_KeyDown);
            this.animationRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.animationRange_KeyPress);
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionLabel.Location = new System.Drawing.Point(426, 23);
            this.directionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(515, 29);
            this.directionLabel.TabIndex = 33;
            this.directionLabel.Text = "Press enter when in one of the boxes to redraw";
            // 
            // multiplyLabel
            // 
            this.multiplyLabel.AutoSize = true;
            this.multiplyLabel.Location = new System.Drawing.Point(267, 58);
            this.multiplyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.multiplyLabel.Name = "multiplyLabel";
            this.multiplyLabel.Size = new System.Drawing.Size(71, 20);
            this.multiplyLabel.TabIndex = 32;
            this.multiplyLabel.Text = "Multiplier";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(54, 58);
            this.pointsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(131, 20);
            this.pointsLabel.TabIndex = 31;
            this.pointsLabel.Text = "Number of Points";
            // 
            // multiplyer
            // 
            this.multiplyer.Location = new System.Drawing.Point(218, 23);
            this.multiplyer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.multiplyer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.multiplyer.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.multiplyer.Name = "multiplyer";
            this.multiplyer.Size = new System.Drawing.Size(180, 26);
            this.multiplyer.TabIndex = 30;
            this.multiplyer.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.multiplyer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.multiplyer_KeyDown);
            this.multiplyer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.multiplyer_KeyPress);
            // 
            // numberOfPoints
            // 
            this.numberOfPoints.Location = new System.Drawing.Point(28, 23);
            this.numberOfPoints.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberOfPoints.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberOfPoints.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberOfPoints.Name = "numberOfPoints";
            this.numberOfPoints.Size = new System.Drawing.Size(180, 26);
            this.numberOfPoints.TabIndex = 29;
            this.numberOfPoints.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberOfPoints.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberOfPoints_KeyDown);
            this.numberOfPoints.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOfPoints_KeyPress);
            // 
            // rotationBar
            // 
            this.rotationBar.Location = new System.Drawing.Point(936, 379);
            this.rotationBar.Maximum = 0;
            this.rotationBar.Name = "rotationBar";
            this.rotationBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.rotationBar.Size = new System.Drawing.Size(69, 310);
            this.rotationBar.TabIndex = 56;
            this.rotationBar.Scroll += new System.EventHandler(this.rotationBar_Scroll);
            // 
            // rotationLabel
            // 
            this.rotationLabel.AutoSize = true;
            this.rotationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotationLabel.Location = new System.Drawing.Point(931, 347);
            this.rotationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rotationLabel.Name = "rotationLabel";
            this.rotationLabel.Size = new System.Drawing.Size(192, 29);
            this.rotationLabel.TabIndex = 57;
            this.rotationLabel.Text = "Choose Rotation";
            // 
            // rotationValLabel
            // 
            this.rotationValLabel.AutoSize = true;
            this.rotationValLabel.Location = new System.Drawing.Point(931, 692);
            this.rotationValLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rotationValLabel.Name = "rotationValLabel";
            this.rotationValLabel.Size = new System.Drawing.Size(71, 20);
            this.rotationValLabel.TabIndex = 58;
            this.rotationValLabel.Text = "VALUE :";
            // 
            // DrawScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rotationValLabel);
            this.Controls.Add(this.rotationLabel);
            this.Controls.Add(this.rotationBar);
            this.Controls.Add(this.randCheckBox);
            this.Controls.Add(this.randLabel);
            this.Controls.Add(this.randColourButton);
            this.Controls.Add(this.customLabel);
            this.Controls.Add(this.customButton);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.colourLabel);
            this.Controls.Add(this.animationLabel);
            this.Controls.Add(this.animationRange);
            this.Controls.Add(this.directionLabel);
            this.Controls.Add(this.multiplyLabel);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.multiplyer);
            this.Controls.Add(this.numberOfPoints);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DrawScreen";
            this.Size = new System.Drawing.Size(1155, 811);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.animationRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox randCheckBox;
        private System.Windows.Forms.Label randLabel;
        private System.Windows.Forms.Button randColourButton;
        private System.Windows.Forms.Label customLabel;
        private System.Windows.Forms.Button customButton;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Label colourLabel;
        private System.Windows.Forms.Label animationLabel;
        private System.Windows.Forms.NumericUpDown animationRange;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.Label multiplyLabel;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.NumericUpDown multiplyer;
        private System.Windows.Forms.NumericUpDown numberOfPoints;
        private System.Windows.Forms.ColorDialog customColDialog;
        private System.Windows.Forms.TrackBar rotationBar;
        private System.Windows.Forms.Label rotationLabel;
        private System.Windows.Forms.Label rotationValLabel;
    }
}
