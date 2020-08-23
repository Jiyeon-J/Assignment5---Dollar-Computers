namespace Assignment5___Dollar_Computers
{
    partial class StartForm
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
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.OpenSavedOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.FlatAppearance.BorderSize = 0;
            this.NewOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NewOrderButton.Location = new System.Drawing.Point(116, 295);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(179, 40);
            this.NewOrderButton.TabIndex = 0;
            this.NewOrderButton.Text = "Start a New Order";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // OpenSavedOrderButton
            // 
            this.OpenSavedOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpenSavedOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OpenSavedOrderButton.Location = new System.Drawing.Point(116, 338);
            this.OpenSavedOrderButton.Name = "OpenSavedOrderButton";
            this.OpenSavedOrderButton.Size = new System.Drawing.Size(179, 40);
            this.OpenSavedOrderButton.TabIndex = 1;
            this.OpenSavedOrderButton.Text = "Open a Saved Order";
            this.OpenSavedOrderButton.UseVisualStyleBackColor = true;
            this.OpenSavedOrderButton.Click += new System.EventHandler(this.OpenSavedOrderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExitButton.Location = new System.Drawing.Point(115, 384);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(179, 40);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment5___Dollar_Computers.Properties.Resources.image2;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 433);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OpenSavedOrderButton);
            this.Controls.Add(this.NewOrderButton);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computer!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button OpenSavedOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}