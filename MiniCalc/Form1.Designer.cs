
namespace MiniCalc
{
    partial class MiniCalc
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
            this.num_0 = new System.Windows.Forms.Button();
            this.num_1 = new System.Windows.Forms.Button();
            this.num_2 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num_0
            // 
            this.num_0.BackColor = System.Drawing.Color.LemonChiffon;
            this.num_0.Location = new System.Drawing.Point(173, 19);
            this.num_0.Name = "num_0";
            this.num_0.Size = new System.Drawing.Size(36, 31);
            this.num_0.TabIndex = 0;
            this.num_0.Text = "0";
            this.num_0.UseVisualStyleBackColor = false;
            // 
            // num_1
            // 
            this.num_1.BackColor = System.Drawing.Color.LemonChiffon;
            this.num_1.Location = new System.Drawing.Point(222, 19);
            this.num_1.Name = "num_1";
            this.num_1.Size = new System.Drawing.Size(36, 31);
            this.num_1.TabIndex = 1;
            this.num_1.Text = "1";
            this.num_1.UseVisualStyleBackColor = false;
            // 
            // num_2
            // 
            this.num_2.BackColor = System.Drawing.Color.LemonChiffon;
            this.num_2.Location = new System.Drawing.Point(271, 19);
            this.num_2.Name = "num_2";
            this.num_2.Size = new System.Drawing.Size(36, 31);
            this.num_2.TabIndex = 2;
            this.num_2.Text = "2";
            this.num_2.UseVisualStyleBackColor = false;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.PowderBlue;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(174, 73);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(36, 31);
            this.add.TabIndex = 3;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.PowderBlue;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(216, 73);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(36, 31);
            this.divide.TabIndex = 6;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            // 
            // display
            // 
            this.display.Enabled = false;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(21, 21);
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(134, 26);
            this.display.TabIndex = 7;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.PowderBlue;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(258, 73);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(49, 31);
            this.clear.TabIndex = 8;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = false;
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.PowderBlue;
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(174, 110);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(36, 31);
            this.equals.TabIndex = 9;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            // 
            // MiniCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 166);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.display);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.add);
            this.Controls.Add(this.num_2);
            this.Controls.Add(this.num_1);
            this.Controls.Add(this.num_0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiniCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniCalc";
            this.Load += new System.EventHandler(this.MiniCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button num_0;
        private System.Windows.Forms.Button num_1;
        private System.Windows.Forms.Button num_2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button equals;
    }
}

