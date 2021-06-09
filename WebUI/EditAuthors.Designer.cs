
namespace WebUI
{
    partial class EditAuthors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAuthors));
            this.gbxAuthorAdd = new System.Windows.Forms.GroupBox();
            this.tbxNationalityAdd = new System.Windows.Forms.TextBox();
            this.lblNationalityAdd = new System.Windows.Forms.Label();
            this.btnAuthorAdd = new System.Windows.Forms.Button();
            this.nudBookCountAdd = new System.Windows.Forms.NumericUpDown();
            this.lblBookCountAdd = new System.Windows.Forms.Label();
            this.tbxAuthorNameAdd = new System.Windows.Forms.TextBox();
            this.lblAuthorNameAdd = new System.Windows.Forms.Label();
            this.dgwAuthors = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAuthorDelete = new System.Windows.Forms.Button();
            this.gbxAuthorUpdate = new System.Windows.Forms.GroupBox();
            this.tbxNationalityUpdate = new System.Windows.Forms.TextBox();
            this.lblNationalityUpdate = new System.Windows.Forms.Label();
            this.btnAuthorUpdate = new System.Windows.Forms.Button();
            this.nudBookCountUpdate = new System.Windows.Forms.NumericUpDown();
            this.lblBookCountUpdate = new System.Windows.Forms.Label();
            this.tbxAuthorNameUpdate = new System.Windows.Forms.TextBox();
            this.lblAuthorNameUpdate = new System.Windows.Forms.Label();
            this.gbxAuthorAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookCountAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAuthors)).BeginInit();
            this.gbxAuthorUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookCountUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAuthorAdd
            // 
            this.gbxAuthorAdd.BackColor = System.Drawing.Color.Transparent;
            this.gbxAuthorAdd.Controls.Add(this.tbxNationalityAdd);
            this.gbxAuthorAdd.Controls.Add(this.lblNationalityAdd);
            this.gbxAuthorAdd.Controls.Add(this.btnAuthorAdd);
            this.gbxAuthorAdd.Controls.Add(this.nudBookCountAdd);
            this.gbxAuthorAdd.Controls.Add(this.lblBookCountAdd);
            this.gbxAuthorAdd.Controls.Add(this.tbxAuthorNameAdd);
            this.gbxAuthorAdd.Controls.Add(this.lblAuthorNameAdd);
            this.gbxAuthorAdd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.gbxAuthorAdd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gbxAuthorAdd.Location = new System.Drawing.Point(41, 24);
            this.gbxAuthorAdd.Margin = new System.Windows.Forms.Padding(4);
            this.gbxAuthorAdd.Name = "gbxAuthorAdd";
            this.gbxAuthorAdd.Padding = new System.Windows.Forms.Padding(4);
            this.gbxAuthorAdd.Size = new System.Drawing.Size(444, 244);
            this.gbxAuthorAdd.TabIndex = 4;
            this.gbxAuthorAdd.TabStop = false;
            this.gbxAuthorAdd.Text = "Add Author";
            // 
            // tbxNationalityAdd
            // 
            this.tbxNationalityAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNationalityAdd.Location = new System.Drawing.Point(167, 85);
            this.tbxNationalityAdd.Name = "tbxNationalityAdd";
            this.tbxNationalityAdd.Size = new System.Drawing.Size(226, 29);
            this.tbxNationalityAdd.TabIndex = 14;
            // 
            // lblNationalityAdd
            // 
            this.lblNationalityAdd.AutoSize = true;
            this.lblNationalityAdd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblNationalityAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblNationalityAdd.Location = new System.Drawing.Point(59, 88);
            this.lblNationalityAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNationalityAdd.Name = "lblNationalityAdd";
            this.lblNationalityAdd.Size = new System.Drawing.Size(89, 21);
            this.lblNationalityAdd.TabIndex = 13;
            this.lblNationalityAdd.Text = "Nationality";
            // 
            // btnAuthorAdd
            // 
            this.btnAuthorAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAuthorAdd.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnAuthorAdd.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAuthorAdd.Location = new System.Drawing.Point(285, 169);
            this.btnAuthorAdd.Name = "btnAuthorAdd";
            this.btnAuthorAdd.Size = new System.Drawing.Size(121, 53);
            this.btnAuthorAdd.TabIndex = 7;
            this.btnAuthorAdd.Text = "Add";
            this.btnAuthorAdd.UseVisualStyleBackColor = false;
            this.btnAuthorAdd.Click += new System.EventHandler(this.btnAuthorAdd_Click);
            // 
            // nudBookCountAdd
            // 
            this.nudBookCountAdd.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.nudBookCountAdd.Location = new System.Drawing.Point(167, 126);
            this.nudBookCountAdd.Name = "nudBookCountAdd";
            this.nudBookCountAdd.Size = new System.Drawing.Size(72, 29);
            this.nudBookCountAdd.TabIndex = 12;
            // 
            // lblBookCountAdd
            // 
            this.lblBookCountAdd.AutoSize = true;
            this.lblBookCountAdd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblBookCountAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblBookCountAdd.Location = new System.Drawing.Point(46, 129);
            this.lblBookCountAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookCountAdd.Name = "lblBookCountAdd";
            this.lblBookCountAdd.Size = new System.Drawing.Size(102, 21);
            this.lblBookCountAdd.TabIndex = 11;
            this.lblBookCountAdd.Text = "Book Count";
            // 
            // tbxAuthorNameAdd
            // 
            this.tbxAuthorNameAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAuthorNameAdd.Location = new System.Drawing.Point(167, 39);
            this.tbxAuthorNameAdd.Name = "tbxAuthorNameAdd";
            this.tbxAuthorNameAdd.Size = new System.Drawing.Size(226, 29);
            this.tbxAuthorNameAdd.TabIndex = 1;
            // 
            // lblAuthorNameAdd
            // 
            this.lblAuthorNameAdd.AutoSize = true;
            this.lblAuthorNameAdd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblAuthorNameAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAuthorNameAdd.Location = new System.Drawing.Point(38, 42);
            this.lblAuthorNameAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthorNameAdd.Name = "lblAuthorNameAdd";
            this.lblAuthorNameAdd.Size = new System.Drawing.Size(110, 21);
            this.lblAuthorNameAdd.TabIndex = 0;
            this.lblAuthorNameAdd.Text = "Author Name";
            // 
            // dgwAuthors
            // 
            this.dgwAuthors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwAuthors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwAuthors.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgwAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAuthors.GridColor = System.Drawing.SystemColors.Control;
            this.dgwAuthors.Location = new System.Drawing.Point(41, 278);
            this.dgwAuthors.Margin = new System.Windows.Forms.Padding(4);
            this.dgwAuthors.Name = "dgwAuthors";
            this.dgwAuthors.Size = new System.Drawing.Size(910, 171);
            this.dgwAuthors.TabIndex = 16;
            this.dgwAuthors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAuthors_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.Info;
            this.btnBack.Location = new System.Drawing.Point(41, 460);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(171, 53);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAuthorDelete
            // 
            this.btnAuthorDelete.BackColor = System.Drawing.Color.Teal;
            this.btnAuthorDelete.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnAuthorDelete.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAuthorDelete.Location = new System.Drawing.Point(780, 460);
            this.btnAuthorDelete.Name = "btnAuthorDelete";
            this.btnAuthorDelete.Size = new System.Drawing.Size(171, 53);
            this.btnAuthorDelete.TabIndex = 18;
            this.btnAuthorDelete.Text = "Delete Author";
            this.btnAuthorDelete.UseVisualStyleBackColor = false;
            this.btnAuthorDelete.Click += new System.EventHandler(this.btnAuthorDelete_Click);
            // 
            // gbxAuthorUpdate
            // 
            this.gbxAuthorUpdate.BackColor = System.Drawing.Color.Transparent;
            this.gbxAuthorUpdate.Controls.Add(this.tbxNationalityUpdate);
            this.gbxAuthorUpdate.Controls.Add(this.lblNationalityUpdate);
            this.gbxAuthorUpdate.Controls.Add(this.btnAuthorUpdate);
            this.gbxAuthorUpdate.Controls.Add(this.nudBookCountUpdate);
            this.gbxAuthorUpdate.Controls.Add(this.lblBookCountUpdate);
            this.gbxAuthorUpdate.Controls.Add(this.tbxAuthorNameUpdate);
            this.gbxAuthorUpdate.Controls.Add(this.lblAuthorNameUpdate);
            this.gbxAuthorUpdate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.gbxAuthorUpdate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gbxAuthorUpdate.Location = new System.Drawing.Point(507, 24);
            this.gbxAuthorUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.gbxAuthorUpdate.Name = "gbxAuthorUpdate";
            this.gbxAuthorUpdate.Padding = new System.Windows.Forms.Padding(4);
            this.gbxAuthorUpdate.Size = new System.Drawing.Size(444, 244);
            this.gbxAuthorUpdate.TabIndex = 15;
            this.gbxAuthorUpdate.TabStop = false;
            this.gbxAuthorUpdate.Text = "Update Author";
            // 
            // tbxNationalityUpdate
            // 
            this.tbxNationalityUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNationalityUpdate.Location = new System.Drawing.Point(167, 85);
            this.tbxNationalityUpdate.Name = "tbxNationalityUpdate";
            this.tbxNationalityUpdate.Size = new System.Drawing.Size(226, 29);
            this.tbxNationalityUpdate.TabIndex = 14;
            // 
            // lblNationalityUpdate
            // 
            this.lblNationalityUpdate.AutoSize = true;
            this.lblNationalityUpdate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblNationalityUpdate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblNationalityUpdate.Location = new System.Drawing.Point(59, 88);
            this.lblNationalityUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNationalityUpdate.Name = "lblNationalityUpdate";
            this.lblNationalityUpdate.Size = new System.Drawing.Size(89, 21);
            this.lblNationalityUpdate.TabIndex = 13;
            this.lblNationalityUpdate.Text = "Nationality";
            // 
            // btnAuthorUpdate
            // 
            this.btnAuthorUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnAuthorUpdate.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnAuthorUpdate.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAuthorUpdate.Location = new System.Drawing.Point(285, 169);
            this.btnAuthorUpdate.Name = "btnAuthorUpdate";
            this.btnAuthorUpdate.Size = new System.Drawing.Size(121, 53);
            this.btnAuthorUpdate.TabIndex = 7;
            this.btnAuthorUpdate.Text = "Update";
            this.btnAuthorUpdate.UseVisualStyleBackColor = false;
            this.btnAuthorUpdate.Click += new System.EventHandler(this.btnAuthorUpdate_Click);
            // 
            // nudBookCountUpdate
            // 
            this.nudBookCountUpdate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.nudBookCountUpdate.Location = new System.Drawing.Point(167, 126);
            this.nudBookCountUpdate.Name = "nudBookCountUpdate";
            this.nudBookCountUpdate.Size = new System.Drawing.Size(72, 29);
            this.nudBookCountUpdate.TabIndex = 12;
            // 
            // lblBookCountUpdate
            // 
            this.lblBookCountUpdate.AutoSize = true;
            this.lblBookCountUpdate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblBookCountUpdate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblBookCountUpdate.Location = new System.Drawing.Point(46, 129);
            this.lblBookCountUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookCountUpdate.Name = "lblBookCountUpdate";
            this.lblBookCountUpdate.Size = new System.Drawing.Size(102, 21);
            this.lblBookCountUpdate.TabIndex = 11;
            this.lblBookCountUpdate.Text = "Book Count";
            // 
            // tbxAuthorNameUpdate
            // 
            this.tbxAuthorNameUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAuthorNameUpdate.Location = new System.Drawing.Point(167, 39);
            this.tbxAuthorNameUpdate.Name = "tbxAuthorNameUpdate";
            this.tbxAuthorNameUpdate.Size = new System.Drawing.Size(226, 29);
            this.tbxAuthorNameUpdate.TabIndex = 1;
            // 
            // lblAuthorNameUpdate
            // 
            this.lblAuthorNameUpdate.AutoSize = true;
            this.lblAuthorNameUpdate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblAuthorNameUpdate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAuthorNameUpdate.Location = new System.Drawing.Point(38, 42);
            this.lblAuthorNameUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthorNameUpdate.Name = "lblAuthorNameUpdate";
            this.lblAuthorNameUpdate.Size = new System.Drawing.Size(110, 21);
            this.lblAuthorNameUpdate.TabIndex = 0;
            this.lblAuthorNameUpdate.Text = "Author Name";
            // 
            // EditAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(993, 546);
            this.Controls.Add(this.gbxAuthorUpdate);
            this.Controls.Add(this.btnAuthorDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgwAuthors);
            this.Controls.Add(this.gbxAuthorAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditAuthors";
            this.Text = "Edit Authors";
            this.Load += new System.EventHandler(this.EditAuthors_Load);
            this.gbxAuthorAdd.ResumeLayout(false);
            this.gbxAuthorAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookCountAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAuthors)).EndInit();
            this.gbxAuthorUpdate.ResumeLayout(false);
            this.gbxAuthorUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookCountUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAuthorAdd;
        private System.Windows.Forms.Button btnAuthorAdd;
        private System.Windows.Forms.NumericUpDown nudBookCountAdd;
        private System.Windows.Forms.Label lblBookCountAdd;
        private System.Windows.Forms.TextBox tbxAuthorNameAdd;
        private System.Windows.Forms.Label lblAuthorNameAdd;
        private System.Windows.Forms.DataGridView dgwAuthors;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAuthorDelete;
        private System.Windows.Forms.TextBox tbxNationalityAdd;
        private System.Windows.Forms.Label lblNationalityAdd;
        private System.Windows.Forms.GroupBox gbxAuthorUpdate;
        private System.Windows.Forms.TextBox tbxNationalityUpdate;
        private System.Windows.Forms.Label lblNationalityUpdate;
        private System.Windows.Forms.Button btnAuthorUpdate;
        private System.Windows.Forms.NumericUpDown nudBookCountUpdate;
        private System.Windows.Forms.Label lblBookCountUpdate;
        private System.Windows.Forms.TextBox tbxAuthorNameUpdate;
        private System.Windows.Forms.Label lblAuthorNameUpdate;
    }
}