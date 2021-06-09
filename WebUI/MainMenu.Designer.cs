
namespace WebUI
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.gbxSearchByBook = new System.Windows.Forms.GroupBox();
            this.lblMaxPrice = new System.Windows.Forms.Label();
            this.lblMinPrice = new System.Windows.Forms.Label();
            this.tbxMaxPrice = new System.Windows.Forms.TextBox();
            this.tbxMinPrice = new System.Windows.Forms.TextBox();
            this.lblSearchByPrice = new System.Windows.Forms.Label();
            this.tbxSearchByLanguage = new System.Windows.Forms.TextBox();
            this.lblSearchByLanguage = new System.Windows.Forms.Label();
            this.lblSearchByAuthor = new System.Windows.Forms.Label();
            this.tbxSearchByBookTitle = new System.Windows.Forms.TextBox();
            this.lblSearchByBookTitle = new System.Windows.Forms.Label();
            this.lblSearchByCategory = new System.Windows.Forms.Label();
            this.cbxSearchByCategory = new System.Windows.Forms.ComboBox();
            this.dgwBooksMainMenu = new System.Windows.Forms.DataGridView();
            this.lblHomepageTitle = new System.Windows.Forms.Label();
            this.btnEditBooks = new System.Windows.Forms.Button();
            this.btnEditCategories = new System.Windows.Forms.Button();
            this.btnEditAuthors = new System.Windows.Forms.Button();
            this.cbxSearchByAuthor = new System.Windows.Forms.ComboBox();
            this.gbxSearchByBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooksMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSearchByBook
            // 
            this.gbxSearchByBook.BackColor = System.Drawing.Color.Transparent;
            this.gbxSearchByBook.Controls.Add(this.cbxSearchByAuthor);
            this.gbxSearchByBook.Controls.Add(this.lblMaxPrice);
            this.gbxSearchByBook.Controls.Add(this.lblMinPrice);
            this.gbxSearchByBook.Controls.Add(this.tbxMaxPrice);
            this.gbxSearchByBook.Controls.Add(this.tbxMinPrice);
            this.gbxSearchByBook.Controls.Add(this.lblSearchByPrice);
            this.gbxSearchByBook.Controls.Add(this.tbxSearchByLanguage);
            this.gbxSearchByBook.Controls.Add(this.lblSearchByLanguage);
            this.gbxSearchByBook.Controls.Add(this.lblSearchByAuthor);
            this.gbxSearchByBook.Controls.Add(this.tbxSearchByBookTitle);
            this.gbxSearchByBook.Controls.Add(this.lblSearchByBookTitle);
            this.gbxSearchByBook.Controls.Add(this.lblSearchByCategory);
            this.gbxSearchByBook.Controls.Add(this.cbxSearchByCategory);
            this.gbxSearchByBook.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.gbxSearchByBook.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gbxSearchByBook.Location = new System.Drawing.Point(43, 84);
            this.gbxSearchByBook.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSearchByBook.Name = "gbxSearchByBook";
            this.gbxSearchByBook.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSearchByBook.Size = new System.Drawing.Size(910, 221);
            this.gbxSearchByBook.TabIndex = 0;
            this.gbxSearchByBook.TabStop = false;
            this.gbxSearchByBook.Text = "Search";
            // 
            // lblMaxPrice
            // 
            this.lblMaxPrice.AutoSize = true;
            this.lblMaxPrice.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblMaxPrice.ForeColor = System.Drawing.Color.Teal;
            this.lblMaxPrice.Location = new System.Drawing.Point(759, 103);
            this.lblMaxPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxPrice.Name = "lblMaxPrice";
            this.lblMaxPrice.Size = new System.Drawing.Size(39, 20);
            this.lblMaxPrice.TabIndex = 9;
            this.lblMaxPrice.Text = "max";
            // 
            // lblMinPrice
            // 
            this.lblMinPrice.AutoSize = true;
            this.lblMinPrice.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblMinPrice.ForeColor = System.Drawing.Color.Teal;
            this.lblMinPrice.Location = new System.Drawing.Point(631, 103);
            this.lblMinPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinPrice.Name = "lblMinPrice";
            this.lblMinPrice.Size = new System.Drawing.Size(36, 20);
            this.lblMinPrice.TabIndex = 8;
            this.lblMinPrice.Text = "min\r\n";
            // 
            // tbxMaxPrice
            // 
            this.tbxMaxPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaxPrice.Location = new System.Drawing.Point(801, 97);
            this.tbxMaxPrice.Name = "tbxMaxPrice";
            this.tbxMaxPrice.Size = new System.Drawing.Size(56, 29);
            this.tbxMaxPrice.TabIndex = 7;
            this.tbxMaxPrice.TextChanged += new System.EventHandler(this.tbxMaxPrice_TextChanged);
            // 
            // tbxMinPrice
            // 
            this.tbxMinPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMinPrice.Location = new System.Drawing.Point(674, 96);
            this.tbxMinPrice.Name = "tbxMinPrice";
            this.tbxMinPrice.Size = new System.Drawing.Size(56, 29);
            this.tbxMinPrice.TabIndex = 6;
            this.tbxMinPrice.TextChanged += new System.EventHandler(this.tbxMinPrice_TextChanged);
            // 
            // lblSearchByPrice
            // 
            this.lblSearchByPrice.AutoSize = true;
            this.lblSearchByPrice.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblSearchByPrice.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSearchByPrice.Location = new System.Drawing.Point(469, 103);
            this.lblSearchByPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchByPrice.Name = "lblSearchByPrice";
            this.lblSearchByPrice.Size = new System.Drawing.Size(128, 21);
            this.lblSearchByPrice.TabIndex = 5;
            this.lblSearchByPrice.Text = "Search by Price\r\n";
            // 
            // tbxSearchByLanguage
            // 
            this.tbxSearchByLanguage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearchByLanguage.Location = new System.Drawing.Point(635, 40);
            this.tbxSearchByLanguage.Name = "tbxSearchByLanguage";
            this.tbxSearchByLanguage.Size = new System.Drawing.Size(226, 29);
            this.tbxSearchByLanguage.TabIndex = 4;
            this.tbxSearchByLanguage.TextChanged += new System.EventHandler(this.tbxSearchByLanguage_TextChanged);
            // 
            // lblSearchByLanguage
            // 
            this.lblSearchByLanguage.AutoSize = true;
            this.lblSearchByLanguage.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblSearchByLanguage.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSearchByLanguage.Location = new System.Drawing.Point(469, 43);
            this.lblSearchByLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchByLanguage.Name = "lblSearchByLanguage";
            this.lblSearchByLanguage.Size = new System.Drawing.Size(161, 21);
            this.lblSearchByLanguage.TabIndex = 3;
            this.lblSearchByLanguage.Text = "Search by Language";
            // 
            // lblSearchByAuthor
            // 
            this.lblSearchByAuthor.AutoSize = true;
            this.lblSearchByAuthor.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblSearchByAuthor.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSearchByAuthor.Location = new System.Drawing.Point(40, 159);
            this.lblSearchByAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchByAuthor.Name = "lblSearchByAuthor";
            this.lblSearchByAuthor.Size = new System.Drawing.Size(141, 21);
            this.lblSearchByAuthor.TabIndex = 0;
            this.lblSearchByAuthor.Text = "Search by Author";
            // 
            // tbxSearchByBookTitle
            // 
            this.tbxSearchByBookTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearchByBookTitle.Location = new System.Drawing.Point(204, 39);
            this.tbxSearchByBookTitle.Name = "tbxSearchByBookTitle";
            this.tbxSearchByBookTitle.Size = new System.Drawing.Size(226, 29);
            this.tbxSearchByBookTitle.TabIndex = 1;
            this.tbxSearchByBookTitle.TextChanged += new System.EventHandler(this.tbxSearchByBookTitle_TextChanged);
            // 
            // lblSearchByBookTitle
            // 
            this.lblSearchByBookTitle.AutoSize = true;
            this.lblSearchByBookTitle.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblSearchByBookTitle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSearchByBookTitle.Location = new System.Drawing.Point(29, 43);
            this.lblSearchByBookTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchByBookTitle.Name = "lblSearchByBookTitle";
            this.lblSearchByBookTitle.Size = new System.Drawing.Size(168, 21);
            this.lblSearchByBookTitle.TabIndex = 0;
            this.lblSearchByBookTitle.Text = "Search by Book Title";
            // 
            // lblSearchByCategory
            // 
            this.lblSearchByCategory.AutoSize = true;
            this.lblSearchByCategory.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblSearchByCategory.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSearchByCategory.Location = new System.Drawing.Point(40, 103);
            this.lblSearchByCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchByCategory.Name = "lblSearchByCategory";
            this.lblSearchByCategory.Size = new System.Drawing.Size(158, 21);
            this.lblSearchByCategory.TabIndex = 0;
            this.lblSearchByCategory.Text = "Search by Category";
            // 
            // cbxSearchByCategory
            // 
            this.cbxSearchByCategory.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSearchByCategory.FormattingEnabled = true;
            this.cbxSearchByCategory.Location = new System.Drawing.Point(204, 97);
            this.cbxSearchByCategory.Name = "cbxSearchByCategory";
            this.cbxSearchByCategory.Size = new System.Drawing.Size(226, 29);
            this.cbxSearchByCategory.TabIndex = 1;
            this.cbxSearchByCategory.SelectedIndexChanged += new System.EventHandler(this.cbxSearchByCategory_SelectedIndexChanged);
            // 
            // dgwBooksMainMenu
            // 
            this.dgwBooksMainMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBooksMainMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwBooksMainMenu.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgwBooksMainMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBooksMainMenu.GridColor = System.Drawing.SystemColors.Control;
            this.dgwBooksMainMenu.Location = new System.Drawing.Point(43, 325);
            this.dgwBooksMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.dgwBooksMainMenu.Name = "dgwBooksMainMenu";
            this.dgwBooksMainMenu.Size = new System.Drawing.Size(910, 200);
            this.dgwBooksMainMenu.TabIndex = 0;
            // 
            // lblHomepageTitle
            // 
            this.lblHomepageTitle.AutoSize = true;
            this.lblHomepageTitle.Font = new System.Drawing.Font("AlwaysRadio", 32F, System.Drawing.FontStyle.Bold);
            this.lblHomepageTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblHomepageTitle.Location = new System.Drawing.Point(362, 11);
            this.lblHomepageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHomepageTitle.Name = "lblHomepageTitle";
            this.lblHomepageTitle.Size = new System.Drawing.Size(294, 50);
            this.lblHomepageTitle.TabIndex = 3;
            this.lblHomepageTitle.Text = "Book Library";
            // 
            // btnEditBooks
            // 
            this.btnEditBooks.BackColor = System.Drawing.Color.Teal;
            this.btnEditBooks.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnEditBooks.ForeColor = System.Drawing.SystemColors.Info;
            this.btnEditBooks.Location = new System.Drawing.Point(105, 547);
            this.btnEditBooks.Name = "btnEditBooks";
            this.btnEditBooks.Size = new System.Drawing.Size(234, 53);
            this.btnEditBooks.TabIndex = 4;
            this.btnEditBooks.Text = "Edit Books";
            this.btnEditBooks.UseVisualStyleBackColor = false;
            this.btnEditBooks.Click += new System.EventHandler(this.btnEditBooks_Click);
            // 
            // btnEditCategories
            // 
            this.btnEditCategories.BackColor = System.Drawing.Color.Teal;
            this.btnEditCategories.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnEditCategories.ForeColor = System.Drawing.SystemColors.Info;
            this.btnEditCategories.Location = new System.Drawing.Point(387, 547);
            this.btnEditCategories.Name = "btnEditCategories";
            this.btnEditCategories.Size = new System.Drawing.Size(234, 53);
            this.btnEditCategories.TabIndex = 5;
            this.btnEditCategories.Text = "Edit Categories";
            this.btnEditCategories.UseVisualStyleBackColor = false;
            this.btnEditCategories.Click += new System.EventHandler(this.btnEditCategories_Click);
            // 
            // btnEditAuthors
            // 
            this.btnEditAuthors.BackColor = System.Drawing.Color.Teal;
            this.btnEditAuthors.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnEditAuthors.ForeColor = System.Drawing.SystemColors.Info;
            this.btnEditAuthors.Location = new System.Drawing.Point(666, 547);
            this.btnEditAuthors.Name = "btnEditAuthors";
            this.btnEditAuthors.Size = new System.Drawing.Size(234, 53);
            this.btnEditAuthors.TabIndex = 6;
            this.btnEditAuthors.Text = "Edit Authors";
            this.btnEditAuthors.UseVisualStyleBackColor = false;
            this.btnEditAuthors.Click += new System.EventHandler(this.btnEditAuthors_Click);
            // 
            // cbxSearchByAuthor
            // 
            this.cbxSearchByAuthor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSearchByAuthor.FormattingEnabled = true;
            this.cbxSearchByAuthor.Location = new System.Drawing.Point(204, 156);
            this.cbxSearchByAuthor.Name = "cbxSearchByAuthor";
            this.cbxSearchByAuthor.Size = new System.Drawing.Size(226, 29);
            this.cbxSearchByAuthor.TabIndex = 10;
            this.cbxSearchByAuthor.SelectedIndexChanged += new System.EventHandler(this.cbxSearchByAuthor_SelectedIndexChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(993, 628);
            this.Controls.Add(this.btnEditAuthors);
            this.Controls.Add(this.btnEditCategories);
            this.Controls.Add(this.btnEditBooks);
            this.Controls.Add(this.lblHomepageTitle);
            this.Controls.Add(this.dgwBooksMainMenu);
            this.Controls.Add(this.gbxSearchByBook);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "ELibrary";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.gbxSearchByBook.ResumeLayout(false);
            this.gbxSearchByBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooksMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSearchByBook;
        private System.Windows.Forms.Label lblSearchByBookTitle;
        private System.Windows.Forms.DataGridView dgwBooksMainMenu;
        private System.Windows.Forms.TextBox tbxSearchByBookTitle;
        private System.Windows.Forms.Label lblHomepageTitle;
        private System.Windows.Forms.ComboBox cbxSearchByCategory;
        private System.Windows.Forms.Label lblSearchByCategory;
        private System.Windows.Forms.Label lblSearchByAuthor;
        private System.Windows.Forms.Button btnEditBooks;
        private System.Windows.Forms.Button btnEditCategories;
        private System.Windows.Forms.Button btnEditAuthors;
        private System.Windows.Forms.TextBox tbxSearchByLanguage;
        private System.Windows.Forms.Label lblSearchByLanguage;
        private System.Windows.Forms.TextBox tbxMaxPrice;
        private System.Windows.Forms.TextBox tbxMinPrice;
        private System.Windows.Forms.Label lblSearchByPrice;
        private System.Windows.Forms.Label lblMaxPrice;
        private System.Windows.Forms.Label lblMinPrice;
        private System.Windows.Forms.ComboBox cbxSearchByAuthor;
    }
}

