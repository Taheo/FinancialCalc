namespace FinancialCalc
{
    partial class Main
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
            this.category = new System.Windows.Forms.ComboBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.calcbutton = new System.Windows.Forms.Button();
            this.food = new System.Windows.Forms.TextBox();
            this.party = new System.Windows.Forms.TextBox();
            this.transport = new System.Windows.Forms.TextBox();
            this.others = new System.Windows.Forms.TextBox();
            this.books = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.TextBox();
            this.foodlabel = new System.Windows.Forms.Label();
            this.partylabel = new System.Windows.Forms.Label();
            this.transportlabel = new System.Windows.Forms.Label();
            this.bookslabel = new System.Windows.Forms.Label();
            this.otherslabel = new System.Windows.Forms.Label();
            this.sumlabel = new System.Windows.Forms.Label();
            this.sumlabeltext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Food",
            "Party",
            "Transport",
            "Books",
            "Others"});
            this.category.Location = new System.Drawing.Point(56, 354);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(152, 21);
            this.category.TabIndex = 0;
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addbutton.Location = new System.Drawing.Point(214, 328);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(122, 47);
            this.addbutton.TabIndex = 1;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // calcbutton
            // 
            this.calcbutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calcbutton.Location = new System.Drawing.Point(342, 328);
            this.calcbutton.Name = "calcbutton";
            this.calcbutton.Size = new System.Drawing.Size(79, 47);
            this.calcbutton.TabIndex = 2;
            this.calcbutton.Text = "Calc";
            this.calcbutton.UseVisualStyleBackColor = true;
            this.calcbutton.Click += new System.EventHandler(this.calcbutton_Click);
            // 
            // food
            // 
            this.food.Location = new System.Drawing.Point(57, 100);
            this.food.Multiline = true;
            this.food.Name = "food";
            this.food.ReadOnly = true;
            this.food.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.food.Size = new System.Drawing.Size(183, 166);
            this.food.TabIndex = 3;
            // 
            // party
            // 
            this.party.Location = new System.Drawing.Point(246, 100);
            this.party.Multiline = true;
            this.party.Name = "party";
            this.party.ReadOnly = true;
            this.party.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.party.Size = new System.Drawing.Size(183, 166);
            this.party.TabIndex = 4;
            // 
            // transport
            // 
            this.transport.Location = new System.Drawing.Point(435, 100);
            this.transport.Multiline = true;
            this.transport.Name = "transport";
            this.transport.ReadOnly = true;
            this.transport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.transport.Size = new System.Drawing.Size(183, 166);
            this.transport.TabIndex = 5;
            // 
            // others
            // 
            this.others.Location = new System.Drawing.Point(813, 100);
            this.others.Multiline = true;
            this.others.Name = "others";
            this.others.ReadOnly = true;
            this.others.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.others.Size = new System.Drawing.Size(183, 166);
            this.others.TabIndex = 6;
            // 
            // books
            // 
            this.books.Location = new System.Drawing.Point(624, 100);
            this.books.Multiline = true;
            this.books.Name = "books";
            this.books.ReadOnly = true;
            this.books.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.books.Size = new System.Drawing.Size(183, 166);
            this.books.TabIndex = 7;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(56, 328);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(152, 20);
            this.input.TabIndex = 8;
            // 
            // foodlabel
            // 
            this.foodlabel.AutoSize = true;
            this.foodlabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodlabel.Location = new System.Drawing.Point(53, 78);
            this.foodlabel.Name = "foodlabel";
            this.foodlabel.Size = new System.Drawing.Size(42, 19);
            this.foodlabel.TabIndex = 9;
            this.foodlabel.Text = "Food";
            // 
            // partylabel
            // 
            this.partylabel.AutoSize = true;
            this.partylabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partylabel.Location = new System.Drawing.Point(242, 78);
            this.partylabel.Name = "partylabel";
            this.partylabel.Size = new System.Drawing.Size(41, 19);
            this.partylabel.TabIndex = 10;
            this.partylabel.Text = "Party";
            // 
            // transportlabel
            // 
            this.transportlabel.AutoSize = true;
            this.transportlabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportlabel.Location = new System.Drawing.Point(431, 78);
            this.transportlabel.Name = "transportlabel";
            this.transportlabel.Size = new System.Drawing.Size(67, 19);
            this.transportlabel.TabIndex = 11;
            this.transportlabel.Text = "Transport";
            // 
            // bookslabel
            // 
            this.bookslabel.AutoSize = true;
            this.bookslabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookslabel.Location = new System.Drawing.Point(620, 78);
            this.bookslabel.Name = "bookslabel";
            this.bookslabel.Size = new System.Drawing.Size(49, 19);
            this.bookslabel.TabIndex = 12;
            this.bookslabel.Text = "Books";
            // 
            // otherslabel
            // 
            this.otherslabel.AutoSize = true;
            this.otherslabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherslabel.Location = new System.Drawing.Point(809, 78);
            this.otherslabel.Name = "otherslabel";
            this.otherslabel.Size = new System.Drawing.Size(50, 19);
            this.otherslabel.TabIndex = 13;
            this.otherslabel.Text = "Others";
            // 
            // sumlabel
            // 
            this.sumlabel.AutoSize = true;
            this.sumlabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sumlabel.Location = new System.Drawing.Point(920, 344);
            this.sumlabel.Name = "sumlabel";
            this.sumlabel.Size = new System.Drawing.Size(0, 31);
            this.sumlabel.TabIndex = 14;
            // 
            // sumlabeltext
            // 
            this.sumlabeltext.AutoSize = true;
            this.sumlabeltext.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sumlabeltext.Location = new System.Drawing.Point(849, 343);
            this.sumlabeltext.Name = "sumlabeltext";
            this.sumlabeltext.Size = new System.Drawing.Size(65, 31);
            this.sumlabeltext.TabIndex = 15;
            this.sumlabeltext.Text = "Sum:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 531);
            this.Controls.Add(this.sumlabeltext);
            this.Controls.Add(this.sumlabel);
            this.Controls.Add(this.otherslabel);
            this.Controls.Add(this.bookslabel);
            this.Controls.Add(this.transportlabel);
            this.Controls.Add(this.partylabel);
            this.Controls.Add(this.foodlabel);
            this.Controls.Add(this.input);
            this.Controls.Add(this.books);
            this.Controls.Add(this.others);
            this.Controls.Add(this.transport);
            this.Controls.Add(this.party);
            this.Controls.Add(this.food);
            this.Controls.Add(this.calcbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.category);
            this.Name = "Main";
            this.Text = "FinancialCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button calcbutton;
        private System.Windows.Forms.TextBox food;
        private System.Windows.Forms.TextBox party;
        private System.Windows.Forms.TextBox transport;
        private System.Windows.Forms.TextBox others;
        private System.Windows.Forms.TextBox books;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label foodlabel;
        private System.Windows.Forms.Label partylabel;
        private System.Windows.Forms.Label transportlabel;
        private System.Windows.Forms.Label bookslabel;
        private System.Windows.Forms.Label otherslabel;
        private System.Windows.Forms.Label sumlabel;
        private System.Windows.Forms.Label sumlabeltext;
    }
}

