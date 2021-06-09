
namespace WebUI
{
    partial class EditCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCategories));
            this.gbxCategoryAdd = new System.Windows.Forms.GroupBox();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.nudBookCountAdd = new System.Windows.Forms.NumericUpDown();
            this.lblBookCountAdd = new System.Windows.Forms.Label();
            this.tbxCategoryNameAdd = new System.Windows.Forms.TextBox();
            this.lblCategoryNameAdd = new System.Windows.Forms.Label();
            this.gbxBookUpdate = new System.Windows.Forms.GroupBox();
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            this.nudBookCountUpdate = new System.Windows.Forms.NumericUpDown();
            this.lblBookCountUpdate = new System.Windows.Forms.Label();
            this.tbxCategoryNameUpdate = new System.Windows.Forms.TextBox();
            this.lblCategoryNameUpdate = new System.Windows.Forms.Label();
            this.dgwCategories = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.gbxCategoryAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookCountAdd)).BeginInit();
            this.gbxBookUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookCountUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCategoryAdd
            // 
            this.gbxCategoryAdd.BackColor = System.Drawing.Color.Transparent;
            this.gbxCategoryAdd.Controls.Add(this.btnCategoryAdd);
            this.gbxCategoryAdd.Controls.Add(this.nudBookCountAdd);
            this.gbxCategoryAdd.Controls.Add(this.lblBookCountAdd);
            this.gbxCategoryAdd.Controls.Add(this.tbxCategoryNameAdd);
            this.gbxCategoryAdd.Controls.Add(this.lblCategoryNameAdd);
            this.gbxCategoryAdd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.gbxCategoryAdd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gbxCategoryAdd.Location = new System.Drawing.Point(44, 18);
            this.gbxCategoryAdd.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCategoryAdd.Name = "gbxCategoryAdd";
            this.gbxCategoryAdd.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCategoryAdd.Size = new System.Drawing.Size(444, 202);
            this.gbxCategoryAdd.TabIndex = 3;
            this.gbxCategoryAdd.TabStop = false;
            this.gbxCategoryAdd.Text = "Add Category";
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.BackColor = System.Drawing.Color.Teal;
            this.btnCategoryAdd.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnCategoryAdd.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCategoryAdd.Location = new System.Drawing.Point(272, 125);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(121, 53);
            this.btnCategoryAdd.TabIndex = 7;
            this.btnCategoryAdd.Text = "Add";
            this.btnCategoryAdd.UseVisualStyleBackColor = false;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // nudBookCountAdd
            // 
            this.nudBookCountAdd.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.nudBookCountAdd.Location = new System.Drawing.Point(167, 77);
            this.nudBookCountAdd.Name = "nudBookCountAdd";
            this.nudBookCountAdd.Size = new System.Drawing.Size(72, 29);
            this.nudBookCountAdd.TabIndex = 12;
            // 
            // lblBookCountAdd
            // 
            this.lblBookCountAdd.AutoSize = true;
            this.lblBookCountAdd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblBookCountAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblBookCountAdd.Location = new System.Drawing.Point(47, 80);
            this.lblBookCountAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookCountAdd.Name = "lblBookCountAdd";
            this.lblBookCountAdd.Size = new System.Drawing.Size(102, 21);
            this.lblBookCountAdd.TabIndex = 11;
            this.lblBookCountAdd.Text = "Book Count";
            // 
            // tbxCategoryNameAdd
            // 
            this.tbxCategoryNameAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCategoryNameAdd.Location = new System.Drawing.Point(167, 39);
            this.tbxCategoryNameAdd.Name = "tbxCategoryNameAdd";
            this.tbxCategoryNameAdd.Size = new System.Drawing.Size(226, 29);
            this.tbxCategoryNameAdd.TabIndex = 1;
            // 
            // lblCategoryNameAdd
            // 
            this.lblCategoryNameAdd.AutoSize = true;
            this.lblCategoryNameAdd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblCategoryNameAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCategoryNameAdd.Location = new System.Drawing.Point(23, 42);
            this.lblCategoryNameAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryNameAdd.Name = "lblCategoryNameAdd";
            this.lblCategoryNameAdd.Size = new System.Drawing.Size(126, 21);
            this.lblCategoryNameAdd.TabIndex = 0;
            this.lblCategoryNameAdd.Text = "Category Name";
            // 
            // gbxBookUpdate
            // 
            this.gbxBookUpdate.BackColor = System.Drawing.Color.Transparent;
            this.gbxBookUpdate.Controls.Add(this.btnCategoryUpdate);
            this.gbxBookUpdate.Controls.Add(this.nudBookCountUpdate);
            this.gbxBookUpdate.Controls.Add(this.lblBookCountUpdate);
            this.gbxBookUpdate.Controls.Add(this.tbxCategoryNameUpdate);
            this.gbxBookUpdate.Controls.Add(this.lblCategoryNameUpdate);
            this.gbxBookUpdate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.gbxBookUpdate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gbxBookUpdate.Location = new System.Drawing.Point(510, 18);
            this.gbxBookUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.gbxBookUpdate.Name = "gbxBookUpdate";
            this.gbxBookUpdate.Padding = new System.Windows.Forms.Padding(4);
            this.gbxBookUpdate.Size = new System.Drawing.Size(444, 202);
            this.gbxBookUpdate.TabIndex = 14;
            this.gbxBookUpdate.TabStop = false;
            this.gbxBookUpdate.Text = "Update Book";
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnCategoryUpdate.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnCategoryUpdate.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCategoryUpdate.Location = new System.Drawing.Point(272, 125);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(121, 53);
            this.btnCategoryUpdate.TabIndex = 7;
            this.btnCategoryUpdate.Text = "Update";
            this.btnCategoryUpdate.UseVisualStyleBackColor = false;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
            // 
            // nudBookCountUpdate
            // 
            this.nudBookCountUpdate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.nudBookCountUpdate.Location = new System.Drawing.Point(167, 77);
            this.nudBookCountUpdate.Name = "nudBookCountUpdate";
            this.nudBookCountUpdate.Size = new System.Drawing.Size(72, 29);
            this.nudBookCountUpdate.TabIndex = 12;
            // 
            // lblBookCountUpdate
            // 
            this.lblBookCountUpdate.AutoSize = true;
            this.lblBookCountUpdate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblBookCountUpdate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblBookCountUpdate.Location = new System.Drawing.Point(47, 80);
            this.lblBookCountUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookCountUpdate.Name = "lblBookCountUpdate";
            this.lblBookCountUpdate.Size = new System.Drawing.Size(102, 21);
            this.lblBookCountUpdate.TabIndex = 11;
            this.lblBookCountUpdate.Text = "Book Count";
            // 
            // tbxCategoryNameUpdate
            // 
            this.tbxCategoryNameUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCategoryNameUpdate.Location = new System.Drawing.Point(167, 35);
            this.tbxCategoryNameUpdate.Name = "tbxCategoryNameUpdate";
            this.tbxCategoryNameUpdate.Size = new System.Drawing.Size(226, 29);
            this.tbxCategoryNameUpdate.TabIndex = 1;
            // 
            // lblCategoryNameUpdate
            // 
            this.lblCategoryNameUpdate.AutoSize = true;
            this.lblCategoryNameUpdate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblCategoryNameUpdate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCategoryNameUpdate.Location = new System.Drawing.Point(23, 39);
            this.lblCategoryNameUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryNameUpdate.Name = "lblCategoryNameUpdate";
            this.lblCategoryNameUpdate.Size = new System.Drawing.Size(126, 21);
            this.lblCategoryNameUpdate.TabIndex = 0;
            this.lblCategoryNameUpdate.Text = "Category Name";
            // 
            // dgwCategories
            // 
            this.dgwCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCategories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwCategories.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgwCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCategories.GridColor = System.Drawing.SystemColors.Control;
            this.dgwCategories.Location = new System.Drawing.Point(44, 248);
            this.dgwCategories.Margin = new System.Windows.Forms.Padding(4);
            this.dgwCategories.Name = "dgwCategories";
            this.dgwCategories.Size = new System.Drawing.Size(910, 171);
            this.dgwCategories.TabIndex = 15;
            this.dgwCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCategories_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.Info;
            this.btnBack.Location = new System.Drawing.Point(44, 437);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(171, 53);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.BackColor = System.Drawing.Color.Teal;
            this.btnCategoryDelete.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnCategoryDelete.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCategoryDelete.Location = new System.Drawing.Point(767, 437);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(186, 53);
            this.btnCategoryDelete.TabIndex = 17;
            this.btnCategoryDelete.Text = "Delete Category";
            this.btnCategoryDelete.UseVisualStyleBackColor = false;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // EditCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(993, 525);
            this.Controls.Add(this.btnCategoryDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgwCategories);
            this.Controls.Add(this.gbxBookUpdate);
            this.Controls.Add(this.gbxCategoryAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditCategories";
            this.Text = "Edit Categories";
            this.Load += new System.EventHandler(this.EditCategories_Load);
            this.gbxCategoryAdd.ResumeLayout(false);
            this.gbxCategoryAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookCountAdd)).EndInit();
            this.gbxBookUpdate.ResumeLayout(false);
            this.gbxBookUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookCountUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCategoryAdd;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.NumericUpDown nudBookCountAdd;
        private System.Windows.Forms.Label lblBookCountAdd;
        private System.Windows.Forms.TextBox tbxCategoryNameAdd;
        private System.Windows.Forms.Label lblCategoryNameAdd;
        private System.Windows.Forms.GroupBox gbxBookUpdate;
        private System.Windows.Forms.Button btnCategoryUpdate;
        private System.Windows.Forms.NumericUpDown nudBookCountUpdate;
        private System.Windows.Forms.Label lblBookCountUpdate;
        private System.Windows.Forms.TextBox tbxCategoryNameUpdate;
        private System.Windows.Forms.Label lblCategoryNameUpdate;
        private System.Windows.Forms.DataGridView dgwCategories;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCategoryDelete;
    }
}