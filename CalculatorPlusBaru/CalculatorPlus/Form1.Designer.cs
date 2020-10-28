namespace CalculatorPlus
{
    partial class Form1
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
            this.buttonPhysics = new System.Windows.Forms.Button();
            this.buttonCurrency = new System.Windows.Forms.Button();
            this.buttonGeneral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPhysics
            // 
            this.buttonPhysics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPhysics.Location = new System.Drawing.Point(188, 12);
            this.buttonPhysics.Name = "buttonPhysics";
            this.buttonPhysics.Size = new System.Drawing.Size(170, 65);
            this.buttonPhysics.TabIndex = 2;
            this.buttonPhysics.Text = "Physics Calculator";
            this.buttonPhysics.UseVisualStyleBackColor = true;
            this.buttonPhysics.Click += new System.EventHandler(this.buttonPhysics_Click);
            // 
            // buttonCurrency
            // 
            this.buttonCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCurrency.Location = new System.Drawing.Point(364, 12);
            this.buttonCurrency.Name = "buttonCurrency";
            this.buttonCurrency.Size = new System.Drawing.Size(170, 65);
            this.buttonCurrency.TabIndex = 3;
            this.buttonCurrency.Text = "Currency Calculator";
            this.buttonCurrency.UseVisualStyleBackColor = true;
            this.buttonCurrency.Click += new System.EventHandler(this.buttonCurrency_Click);
            // 
            // buttonGeneral
            // 
            this.buttonGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGeneral.Location = new System.Drawing.Point(12, 12);
            this.buttonGeneral.Name = "buttonGeneral";
            this.buttonGeneral.Size = new System.Drawing.Size(170, 65);
            this.buttonGeneral.TabIndex = 4;
            this.buttonGeneral.Text = "General Calculator";
            this.buttonGeneral.UseVisualStyleBackColor = true;
            this.buttonGeneral.Click += new System.EventHandler(this.buttonGeneral_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 85);
            this.Controls.Add(this.buttonGeneral);
            this.Controls.Add(this.buttonCurrency);
            this.Controls.Add(this.buttonPhysics);
            this.Name = "Form1";
            this.Text = "Calculator Plus";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonPhysics;
        private System.Windows.Forms.Button buttonCurrency;
        private System.Windows.Forms.Button buttonGeneral;
    }
}

