
namespace SpiceWars
{
    partial class SpiceWarsWindow
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
            this.stockBox = new System.Windows.Forms.ListBox();
            this.destinationBox = new System.Windows.Forms.ListBox();
            this.SailBtn = new System.Windows.Forms.Button();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BuyBtn = new System.Windows.Forms.Button();
            this.SellBtn = new System.Windows.Forms.Button();
            this.currentLabel = new System.Windows.Forms.Label();
            this.goodiesBox = new System.Windows.Forms.ListBox();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // stockBox
            // 
            this.stockBox.FormattingEnabled = true;
            this.stockBox.ItemHeight = 15;
            this.stockBox.Location = new System.Drawing.Point(366, 63);
            this.stockBox.MultiColumn = true;
            this.stockBox.Name = "stockBox";
            this.stockBox.Size = new System.Drawing.Size(144, 154);
            this.stockBox.TabIndex = 1;
            // 
            // destinationBox
            // 
            this.destinationBox.FormattingEnabled = true;
            this.destinationBox.ItemHeight = 15;
            this.destinationBox.Location = new System.Drawing.Point(12, 271);
            this.destinationBox.MultiColumn = true;
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(144, 154);
            this.destinationBox.TabIndex = 2;
            // 
            // SailBtn
            // 
            this.SailBtn.Location = new System.Drawing.Point(212, 284);
            this.SailBtn.Name = "SailBtn";
            this.SailBtn.Size = new System.Drawing.Size(100, 23);
            this.SailBtn.TabIndex = 3;
            this.SailBtn.Text = "Segeln";
            this.SailBtn.UseVisualStyleBackColor = true;
            this.SailBtn.Click += new System.EventHandler(this.SailBtn_Click);
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(212, 63);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(100, 23);
            this.valueBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Marktplatz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Laderaum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Menge";
            // 
            // BuyBtn
            // 
            this.BuyBtn.Location = new System.Drawing.Point(212, 120);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(100, 23);
            this.BuyBtn.TabIndex = 8;
            this.BuyBtn.Text = "Kaufen >>>";
            this.BuyBtn.UseVisualStyleBackColor = true;
            this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // SellBtn
            // 
            this.SellBtn.Location = new System.Drawing.Point(212, 163);
            this.SellBtn.Name = "SellBtn";
            this.SellBtn.Size = new System.Drawing.Size(100, 23);
            this.SellBtn.TabIndex = 9;
            this.SellBtn.Text = "<<< Verkaufen";
            this.SellBtn.UseVisualStyleBackColor = true;
            this.SellBtn.Click += new System.EventHandler(this.SellBtn_Click);
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Location = new System.Drawing.Point(212, 314);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(38, 15);
            this.currentLabel.TabIndex = 10;
            this.currentLabel.Text = "label4";
            // 
            // goodiesBox
            // 
            this.goodiesBox.FormattingEnabled = true;
            this.goodiesBox.ItemHeight = 15;
            this.goodiesBox.Location = new System.Drawing.Point(12, 63);
            this.goodiesBox.Name = "goodiesBox";
            this.goodiesBox.Size = new System.Drawing.Size(144, 154);
            this.goodiesBox.TabIndex = 11;
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(366, 224);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(44, 15);
            this.moneyLabel.TabIndex = 12;
            this.moneyLabel.Text = "money";
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(0, 428);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(800, 22);
            this.statusBox.TabIndex = 13;
            // 
            // SpiceWarsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.goodiesBox);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.SellBtn);
            this.Controls.Add(this.BuyBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.SailBtn);
            this.Controls.Add(this.destinationBox);
            this.Controls.Add(this.stockBox);
            this.Name = "SpiceWarsWindow";
            this.Text = "Spice Wars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox stockBox;
        private System.Windows.Forms.ListBox destinationBox;
        private System.Windows.Forms.Button SailBtn;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BuyBtn;
        private System.Windows.Forms.Button SellBtn;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.ListBox goodiesBox;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.StatusStrip statusBox;
    }
}

