namespace GissaTalForms
{
    partial class guessNumber
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guessButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.guessesLabel = new System.Windows.Forms.Label();
            this.guessCounterLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guessInput = new System.Windows.Forms.TextBox();
            this.guessMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guessButton
            // 
            this.guessButton.BackColor = System.Drawing.Color.Chartreuse;
            this.guessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessButton.Location = new System.Drawing.Point(49, 204);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(90, 44);
            this.guessButton.TabIndex = 0;
            this.guessButton.Text = "Gissa";
            this.guessButton.UseVisualStyleBackColor = false;
            this.guessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Red;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(49, 264);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(90, 46);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Nollställ";
            this.resetButton.UseVisualStyleBackColor = false;
            // 
            // guessesLabel
            // 
            this.guessesLabel.AutoSize = true;
            this.guessesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessesLabel.Location = new System.Drawing.Point(12, 23);
            this.guessesLabel.Name = "guessesLabel";
            this.guessesLabel.Size = new System.Drawing.Size(126, 20);
            this.guessesLabel.TabIndex = 2;
            this.guessesLabel.Text = "Antal gissningar:";
            // 
            // guessCounterLabel
            // 
            this.guessCounterLabel.AutoSize = true;
            this.guessCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessCounterLabel.Location = new System.Drawing.Point(161, 23);
            this.guessCounterLabel.Name = "guessCounterLabel";
            this.guessCounterLabel.Size = new System.Drawing.Size(18, 20);
            this.guessCounterLabel.TabIndex = 3;
            this.guessCounterLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Din gissning";
            // 
            // guessInput
            // 
            this.guessInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessInput.Location = new System.Drawing.Point(112, 86);
            this.guessInput.Name = "guessInput";
            this.guessInput.Size = new System.Drawing.Size(61, 26);
            this.guessInput.TabIndex = 5;
            this.guessInput.Text = "0";
            // 
            // guessMessage
            // 
            this.guessMessage.AutoSize = true;
            this.guessMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessMessage.Location = new System.Drawing.Point(16, 141);
            this.guessMessage.Name = "guessMessage";
            this.guessMessage.Size = new System.Drawing.Size(173, 20);
            this.guessMessage.TabIndex = 6;
            this.guessMessage.Text = "Du har inte gissat ännu";
            // 
            // guessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 328);
            this.Controls.Add(this.guessMessage);
            this.Controls.Add(this.guessInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guessCounterLabel);
            this.Controls.Add(this.guessesLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.guessButton);
            this.Name = "guessNumber";
            this.Text = "Gissa Tal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label guessesLabel;
        private System.Windows.Forms.Label guessCounterLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox guessInput;
        private System.Windows.Forms.Label guessMessage;
    }
}

