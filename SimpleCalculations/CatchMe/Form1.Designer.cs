namespace CatchMe
{
    partial class CatchTheButton
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
            this.buttonCatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCatch
            // 
            this.buttonCatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCatch.Location = new System.Drawing.Point(83, 55);
            this.buttonCatch.Name = "buttonCatch";
            this.buttonCatch.Size = new System.Drawing.Size(95, 72);
            this.buttonCatch.TabIndex = 0;
            this.buttonCatch.Text = "Catch Me!";
            this.buttonCatch.UseVisualStyleBackColor = true;
            this.buttonCatch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonCatch_MouseClick);
            this.buttonCatch.MouseEnter += new System.EventHandler(this.buttonCatch_MouseEnter);
            // 
            // CatchTheButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 343);
            this.Controls.Add(this.buttonCatch);
            this.Name = "CatchTheButton";
            this.Text = "Catch the button!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCatch;
    }
}

