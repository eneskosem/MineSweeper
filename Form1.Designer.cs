namespace MayinTarlasiWinForms
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
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCols = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.labelFlagCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(12, 12);
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRows.TabIndex = 0;
            // 
            // numericUpDownCols
            // 
            this.numericUpDownCols.Location = new System.Drawing.Point(147, 12);
            this.numericUpDownCols.Name = "numericUpDownCols";
            this.numericUpDownCols.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCols.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(76, 51);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(115, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Oyuna Başla";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(24, 126);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 100);
            this.panel.TabIndex = 3;
            // 
            // labelFlagCount
            // 
            this.labelFlagCount.AutoSize = true;
            this.labelFlagCount.Location = new System.Drawing.Point(86, 90);
            this.labelFlagCount.Name = "labelFlagCount";
            this.labelFlagCount.Size = new System.Drawing.Size(63, 16);
            this.labelFlagCount.TabIndex = 4;
            this.labelFlagCount.Text = "Bayrak: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFlagCount);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.numericUpDownCols);
            this.Controls.Add(this.numericUpDownRows);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.NumericUpDown numericUpDownCols;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelFlagCount;
    }
}

