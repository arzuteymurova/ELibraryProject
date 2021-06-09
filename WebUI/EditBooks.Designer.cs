
namespace WebUI
{
    partial class EditBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBooks));
            this.dgwBooks = new System.Windows.Forms.DataGridView();
            this.gbxBookAdd = new System.Windows.Forms.GroupBox();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.nudCountAdd = new System.Windows.Forms.NumericUpDown();
            this.lblCountAdd = new System.Windows.Forms.Label();
            this.tbxPriceAdd = new System.Windows.Forms.TextBox();
            this.lblPriceAdd = new System.Windows.Forms.Label();
            this.tbxLanguageAdd = new System.Windows.Forms.TextBox();
            this.lblLanguageAdd = new System.Windows.Forms.Label();
            this.lblAuthorAdd = new System.Windows.Forms.Label();
            this.tbxBookTitleAdd = new System.Windows.Forms.TextBox();
            this.lblBookTitleAdd = new System.Windows.Forms.Label();
            this.lblCategoryAdd = new System.Windows.Forms.Label();
            this.cbxCategoryAdd = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbxBookUpdate = new System.Windows.Forms.GroupBox();
            this.btnBookUpdate = new System.Windows.Forms.Button();
            this.nudCountUpdate = new System.Windows.Forms.NumericUpDown();
            this.lblCountUpdate = new System.Windows.Forms.Label();
            this.tbxPriceUpdate = new System.Windows.Forms.TextBox();
            this.lblPriceUpdate = new System.Windows.Forms.Label();
            this.tbxLanguageUpdate = new System.Windows.Forms.TextBox();
            this.lblLanguageUpdate = new System.Windows.Forms.Label();
            this.lblAuthorUpdate = new System.Windows.Forms.Label();
            this.tbxBookTitleUpdate = new System.Windows.Forms.TextBox();
            this.lblBookTitleUpdate = new System.Windows.Forms.Label();
            this.lblCategoryUpdate = new System.Windows.Forms.Label();
            this.cbxCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.cbxAuthorUpdate = new System.Windows.Forms.ComboBox();
            this.cbxAuthorAdd = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).BeginInit();
            this.gbxBookAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountAdd)).BeginInit();
            this.gbxBookUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBooks
            // 
            this.dgwBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwBooks.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgwBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBooks.GridColor = System.Drawing.SystemColors.Control;
            this.dgwBooks.Location = new System.Drawing.Point(44, 371);
            this.dgwBooks.Margin = new System.Windows.Forms.Padding(4);
            this.dgwBooks.Name = "dgwBooks";
            this.dgwBooks.Size = new System.Drawing.Size(910, 171);
            this.dgwBooks.TabIndex = 1;
            this.dgwBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBooks_CellClick);
            // 
            // gbxBookAdd
            // 
            this.gbxBookAdd.BackColor = System.Drawing.Color.Transparent;
            this.gbxBookAdd.Controls.Add(this.cbxAuthorAdd);
            this.gbxBookAdd.Controls.Add(this.btnBookAdd);
            this.gbxBookAdd.Controls.Add(this.nudCountAdd);
            this.gbxBookAdd.Controls.Add(this.lblCountAdd);
            this.gbxBookAdd.Controls.Add(this.tbxPriceAdd);
            this.gbxBookAdd.Controls.Add(this.lblPriceAdd);
            this.gbxBookAdd.Controls.Add(this.tbxLanguageAdd);
            this.gbxBookAdd.Controls.Add(this.lblLanguageAdd);
            this.gbxBookAdd.Controls.Add(this.lblAuthorAdd);
            this.gbxBookAdd.Controls.Add(this.tbxBookTitleAdd);
            this.gbxBookAdd.Controls.Add(this.lblBookTitleAdd);
            this.gbxBookAdd.Controls.Add(this.lblCategoryAdd);
            this.gbxBookAdd.Controls.Add(this.cbxCategoryAdd);
            this.gbxBookAdd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.gbxBookAdd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gbxBookAdd.Location = new System.Drawing.Point(44, 13);
            this.gbxBookAdd.Margin = new System.Windows.Forms.Padding(4);
            this.gbxBookAdd.Name = "gbxBookAdd";
            this.gbxBookAdd.Padding = new System.Windows.Forms.Padding(4);
            this.gbxBookAdd.Size = new System.Drawing.Size(910, 171);
            this.gbxBookAdd.TabIndex = 2;
            this.gbxBookAdd.TabStop = false;
            this.gbxBookAdd.Text = "Add Book";
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.BackColor = System.Drawing.Color.Teal;
            this.btnBookAdd.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnBookAdd.ForeColor = System.Drawing.SystemColors.Info;
            this.btnBookAdd.Location = new System.Drawing.Point(771, 71);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(121, 53);
            this.btnBookAdd.TabIndex = 7;
            this.btnBookAdd.Text = "Add";
            this.btnBookAdd.UseVisualStyleBackColor = false;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // nudCountAdd
            // 
            this.nudCountAdd.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.nudCountAdd.Location = new System.Drawing.Point(502, 77);
            this.nudCountAdd.Name = "nudCountAdd";
            this.nudCountAdd.Size = new System.Drawing.Size(72, 29);
            this.nudCountAdd.TabIndex = 12;
            // 
            // lblCountAdd
            // 
            this.lblCountAdd.AutoSize = true;
            this.lblCountAdd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblCountAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCountAdd.Location = new System.Drawing.Point(439, 80);
            this.lblCountAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountAdd.Name = "lblCountAdd";
            this.lblCountAdd.Size = new System.Drawing.Size(56, 21);
            this.lblCountAdd.TabIndex = 11;
            this.lblCountAdd.Text = "Count";
            // 
            // tbxPriceAdd
            // 
            this.tbxPriceAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPriceAdd.Location = new System.Drawing.Point(502, 120);
            this.tbxPriceAdd.Name = "tbxPriceAdd";
            this.tbxPriceAdd.Size = new System.Drawing.Size(226, 29);
            this.tbxPriceAdd.TabIndex = 10;
            // 
            // lblPriceAdd
            // 
            this.lblPriceAdd.AutoSize = true;
            this.lblPriceAdd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblPriceAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblPriceAdd.Location = new System.Drawing.Point(447, 123);
            this.lblPriceAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceAdd.Name = "lblPriceAdd";
            this.lblPriceAdd.Size = new System.Drawing.Size(48, 21);
            this.lblPriceAdd.TabIndex = 5;
            this.lblPriceAdd.Text = "Price\r\n";
            // 
            // tbxLanguageAdd
            // 
            this.tbxLanguageAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLanguageAdd.Location = new System.Drawing.Point(502, 39);
            this.tbxLanguageAdd.Name = "tbxLanguageAdd";
            this.tbxLanguageAdd.Size = new System.Drawing.Size(226, 29);
            this.tbxLanguageAdd.TabIndex = 4;
            // 
            // lblLanguageAdd
            // 
            this.lblLanguageAdd.AutoSize = true;
            this.lblLanguageAdd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblLanguageAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblLanguageAdd.Location = new System.Drawing.Point(414, 42);
            this.lblLanguageAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLanguageAdd.Name = "lblLanguageAdd";
            this.lblLanguageAdd.Size = new System.Drawing.Size(81, 21);
            this.lblLanguageAdd.TabIndex = 3;
            this.lblLanguageAdd.Text = "Language";
            // 
            // lblAuthorAdd
            // 
            this.lblAuthorAdd.AutoSize = true;
            this.lblAuthorAdd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblAuthorAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAuthorAdd.Location = new System.Drawing.Point(51, 83);
            this.lblAuthorAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthorAdd.Name = "lblAuthorAdd";
            this.lblAuthorAdd.Size = new System.Drawing.Size(62, 21);
            this.lblAuthorAdd.TabIndex = 0;
            this.lblAuthorAdd.Text = "Author";
            // 
            // tbxBookTitleAdd
            // 
            this.tbxBookTitleAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBookTitleAdd.Location = new System.Drawing.Point(135, 39);
            this.tbxBookTitleAdd.Name = "tbxBookTitleAdd";
            this.tbxBookTitleAdd.Size = new System.Drawing.Size(226, 29);
            this.tbxBookTitleAdd.TabIndex = 1;
            // 
            // lblBookTitleAdd
            // 
            this.lblBookTitleAdd.AutoSize = true;
            this.lblBookTitleAdd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblBookTitleAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblBookTitleAdd.Location = new System.Drawing.Point(40, 42);
            this.lblBookTitleAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookTitleAdd.Name = "lblBookTitleAdd";
            this.lblBookTitleAdd.Size = new System.Drawing.Size(88, 21);
            this.lblBookTitleAdd.TabIndex = 0;
            this.lblBookTitleAdd.Text = "Book Title";
            // 
            // lblCategoryAdd
            // 
            this.lblCategoryAdd.AutoSize = true;
            this.lblCategoryAdd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblCategoryAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCategoryAdd.Location = new System.Drawing.Point(8, 123);
            this.lblCategoryAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryAdd.Name = "lblCategoryAdd";
            this.lblCategoryAdd.Size = new System.Drawing.Size(126, 21);
            this.lblCategoryAdd.TabIndex = 0;
            this.lblCategoryAdd.Text = "Category Name";
            // 
            // cbxCategoryAdd
            // 
            this.cbxCategoryAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoryAdd.FormattingEnabled = true;
            this.cbxCategoryAdd.Location = new System.Drawing.Point(135, 120);
            this.cbxCategoryAdd.Name = "cbxCategoryAdd";
            this.cbxCategoryAdd.Size = new System.Drawing.Size(226, 29);
            this.cbxCategoryAdd.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.Info;
            this.btnBack.Location = new System.Drawing.Point(44, 551);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(171, 53);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbxBookUpdate
            // 
            this.gbxBookUpdate.BackColor = System.Drawing.Color.Transparent;
            this.gbxBookUpdate.Controls.Add(this.btnBookUpdate);
            this.gbxBookUpdate.Controls.Add(this.cbxAuthorUpdate);
            this.gbxBookUpdate.Controls.Add(this.nudCountUpdate);
            this.gbxBookUpdate.Controls.Add(this.lblCountUpdate);
            this.gbxBookUpdate.Controls.Add(this.tbxPriceUpdate);
            this.gbxBookUpdate.Controls.Add(this.lblPriceUpdate);
            this.gbxBookUpdate.Controls.Add(this.tbxLanguageUpdate);
            this.gbxBookUpdate.Controls.Add(this.lblLanguageUpdate);
            this.gbxBookUpdate.Controls.Add(this.lblAuthorUpdate);
            this.gbxBookUpdate.Controls.Add(this.tbxBookTitleUpdate);
            this.gbxBookUpdate.Controls.Add(this.lblBookTitleUpdate);
            this.gbxBookUpdate.Controls.Add(this.lblCategoryUpdate);
            this.gbxBookUpdate.Controls.Add(this.cbxCategoryUpdate);
            this.gbxBookUpdate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.gbxBookUpdate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gbxBookUpdate.Location = new System.Drawing.Point(44, 190);
            this.gbxBookUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.gbxBookUpdate.Name = "gbxBookUpdate";
            this.gbxBookUpdate.Padding = new System.Windows.Forms.Padding(4);
            this.gbxBookUpdate.Size = new System.Drawing.Size(910, 169);
            this.gbxBookUpdate.TabIndex = 13;
            this.gbxBookUpdate.TabStop = false;
            this.gbxBookUpdate.Text = "Update Book";
            // 
            // btnBookUpdate
            // 
            this.btnBookUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnBookUpdate.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnBookUpdate.ForeColor = System.Drawing.SystemColors.Info;
            this.btnBookUpdate.Location = new System.Drawing.Point(771, 71);
            this.btnBookUpdate.Name = "btnBookUpdate";
            this.btnBookUpdate.Size = new System.Drawing.Size(121, 53);
            this.btnBookUpdate.TabIndex = 7;
            this.btnBookUpdate.Text = "Update";
            this.btnBookUpdate.UseVisualStyleBackColor = false;
            this.btnBookUpdate.Click += new System.EventHandler(this.btnBookUpdate_Click);
            // 
            // nudCountUpdate
            // 
            this.nudCountUpdate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.nudCountUpdate.Location = new System.Drawing.Point(502, 77);
            this.nudCountUpdate.Name = "nudCountUpdate";
            this.nudCountUpdate.Size = new System.Drawing.Size(72, 29);
            this.nudCountUpdate.TabIndex = 12;
            // 
            // lblCountUpdate
            // 
            this.lblCountUpdate.AutoSize = true;
            this.lblCountUpdate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblCountUpdate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCountUpdate.Location = new System.Drawing.Point(439, 80);
            this.lblCountUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountUpdate.Name = "lblCountUpdate";
            this.lblCountUpdate.Size = new System.Drawing.Size(56, 21);
            this.lblCountUpdate.TabIndex = 11;
            this.lblCountUpdate.Text = "Count";
            // 
            // tbxPriceUpdate
            // 
            this.tbxPriceUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPriceUpdate.Location = new System.Drawing.Point(502, 120);
            this.tbxPriceUpdate.Name = "tbxPriceUpdate";
            this.tbxPriceUpdate.Size = new System.Drawing.Size(226, 29);
            this.tbxPriceUpdate.TabIndex = 10;
            // 
            // lblPriceUpdate
            // 
            this.lblPriceUpdate.AutoSize = true;
            this.lblPriceUpdate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblPriceUpdate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblPriceUpdate.Location = new System.Drawing.Point(447, 123);
            this.lblPriceUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceUpdate.Name = "lblPriceUpdate";
            this.lblPriceUpdate.Size = new System.Drawing.Size(48, 21);
            this.lblPriceUpdate.TabIndex = 5;
            this.lblPriceUpdate.Text = "Price\r\n";
            // 
            // tbxLanguageUpdate
            // 
            this.tbxLanguageUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLanguageUpdate.Location = new System.Drawing.Point(502, 39);
            this.tbxLanguageUpdate.Name = "tbxLanguageUpdate";
            this.tbxLanguageUpdate.Size = new System.Drawing.Size(226, 29);
            this.tbxLanguageUpdate.TabIndex = 4;
            // 
            // lblLanguageUpdate
            // 
            this.lblLanguageUpdate.AutoSize = true;
            this.lblLanguageUpdate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblLanguageUpdate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblLanguageUpdate.Location = new System.Drawing.Point(414, 42);
            this.lblLanguageUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLanguageUpdate.Name = "lblLanguageUpdate";
            this.lblLanguageUpdate.Size = new System.Drawing.Size(81, 21);
            this.lblLanguageUpdate.TabIndex = 3;
            this.lblLanguageUpdate.Text = "Language";
            // 
            // lblAuthorUpdate
            // 
            this.lblAuthorUpdate.AutoSize = true;
            this.lblAuthorUpdate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblAuthorUpdate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAuthorUpdate.Location = new System.Drawing.Point(51, 81);
            this.lblAuthorUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthorUpdate.Name = "lblAuthorUpdate";
            this.lblAuthorUpdate.Size = new System.Drawing.Size(62, 21);
            this.lblAuthorUpdate.TabIndex = 0;
            this.lblAuthorUpdate.Text = "Author";
            // 
            // tbxBookTitleUpdate
            // 
            this.tbxBookTitleUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBookTitleUpdate.Location = new System.Drawing.Point(135, 39);
            this.tbxBookTitleUpdate.Name = "tbxBookTitleUpdate";
            this.tbxBookTitleUpdate.Size = new System.Drawing.Size(226, 29);
            this.tbxBookTitleUpdate.TabIndex = 1;
            // 
            // lblBookTitleUpdate
            // 
            this.lblBookTitleUpdate.AutoSize = true;
            this.lblBookTitleUpdate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblBookTitleUpdate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblBookTitleUpdate.Location = new System.Drawing.Point(40, 42);
            this.lblBookTitleUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookTitleUpdate.Name = "lblBookTitleUpdate";
            this.lblBookTitleUpdate.Size = new System.Drawing.Size(88, 21);
            this.lblBookTitleUpdate.TabIndex = 0;
            this.lblBookTitleUpdate.Text = "Book Title";
            // 
            // lblCategoryUpdate
            // 
            this.lblCategoryUpdate.AutoSize = true;
            this.lblCategoryUpdate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblCategoryUpdate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCategoryUpdate.Location = new System.Drawing.Point(8, 123);
            this.lblCategoryUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryUpdate.Name = "lblCategoryUpdate";
            this.lblCategoryUpdate.Size = new System.Drawing.Size(126, 21);
            this.lblCategoryUpdate.TabIndex = 0;
            this.lblCategoryUpdate.Text = "Category Name";
            // 
            // cbxCategoryUpdate
            // 
            this.cbxCategoryUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoryUpdate.FormattingEnabled = true;
            this.cbxCategoryUpdate.Location = new System.Drawing.Point(135, 120);
            this.cbxCategoryUpdate.Name = "cbxCategoryUpdate";
            this.cbxCategoryUpdate.Size = new System.Drawing.Size(226, 29);
            this.cbxCategoryUpdate.TabIndex = 1;
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.BackColor = System.Drawing.Color.Teal;
            this.btnBookDelete.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnBookDelete.ForeColor = System.Drawing.SystemColors.Info;
            this.btnBookDelete.Location = new System.Drawing.Point(783, 551);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(171, 53);
            this.btnBookDelete.TabIndex = 14;
            this.btnBookDelete.Text = "Delete Book";
            this.btnBookDelete.UseVisualStyleBackColor = false;
            this.btnBookDelete.Click += new System.EventHandler(this.btnBookDelete_Click);
            // 
            // cbxAuthorUpdate
            // 
            this.cbxAuthorUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAuthorUpdate.FormattingEnabled = true;
            this.cbxAuthorUpdate.Location = new System.Drawing.Point(135, 78);
            this.cbxAuthorUpdate.Name = "cbxAuthorUpdate";
            this.cbxAuthorUpdate.Size = new System.Drawing.Size(226, 29);
            this.cbxAuthorUpdate.TabIndex = 13;
            // 
            // cbxAuthorAdd
            // 
            this.cbxAuthorAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAuthorAdd.FormattingEnabled = true;
            this.cbxAuthorAdd.Location = new System.Drawing.Point(135, 77);
            this.cbxAuthorAdd.Name = "cbxAuthorAdd";
            this.cbxAuthorAdd.Size = new System.Drawing.Size(226, 29);
            this.cbxAuthorAdd.TabIndex = 14;
            // 
            // EditBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(993, 650);
            this.Controls.Add(this.btnBookDelete);
            this.Controls.Add(this.gbxBookUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbxBookAdd);
            this.Controls.Add(this.dgwBooks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditBooks";
            this.Text = "Edit Books";
            this.Load += new System.EventHandler(this.EditBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).EndInit();
            this.gbxBookAdd.ResumeLayout(false);
            this.gbxBookAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountAdd)).EndInit();
            this.gbxBookUpdate.ResumeLayout(false);
            this.gbxBookUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBooks;
        private System.Windows.Forms.GroupBox gbxBookAdd;
        private System.Windows.Forms.Label lblPriceAdd;
        private System.Windows.Forms.TextBox tbxLanguageAdd;
        private System.Windows.Forms.Label lblLanguageAdd;
        private System.Windows.Forms.Label lblAuthorAdd;
        private System.Windows.Forms.TextBox tbxBookTitleAdd;
        private System.Windows.Forms.Label lblBookTitleAdd;
        private System.Windows.Forms.Label lblCategoryAdd;
        private System.Windows.Forms.ComboBox cbxCategoryAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbxPriceAdd;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.NumericUpDown nudCountAdd;
        private System.Windows.Forms.Label lblCountAdd;
        private System.Windows.Forms.GroupBox gbxBookUpdate;
        private System.Windows.Forms.Button btnBookUpdate;
        private System.Windows.Forms.NumericUpDown nudCountUpdate;
        private System.Windows.Forms.Label lblCountUpdate;
        private System.Windows.Forms.TextBox tbxPriceUpdate;
        private System.Windows.Forms.Label lblPriceUpdate;
        private System.Windows.Forms.TextBox tbxLanguageUpdate;
        private System.Windows.Forms.Label lblLanguageUpdate;
        private System.Windows.Forms.Label lblAuthorUpdate;
        private System.Windows.Forms.TextBox tbxBookTitleUpdate;
        private System.Windows.Forms.Label lblBookTitleUpdate;
        private System.Windows.Forms.Label lblCategoryUpdate;
        private System.Windows.Forms.ComboBox cbxCategoryUpdate;
        private System.Windows.Forms.Button btnBookDelete;
        private System.Windows.Forms.ComboBox cbxAuthorAdd;
        private System.Windows.Forms.ComboBox cbxAuthorUpdate;
    }
}