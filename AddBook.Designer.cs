namespace LibraryManagmentSystem
{
    partial class AddBook
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
            this.labelBookId = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelCopies = new System.Windows.Forms.Label();
            this.labelBookname = new System.Windows.Forms.Label();
            this.tbBookId = new System.Windows.Forms.TextBox();
            this.tbBookname = new System.Windows.Forms.TextBox();
            this.tbCopies = new System.Windows.Forms.TextBox();
            this.tbstatus = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.btnupdate1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBookId
            // 
            this.labelBookId.AutoSize = true;
            this.labelBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookId.Location = new System.Drawing.Point(133, 91);
            this.labelBookId.Name = "labelBookId";
            this.labelBookId.Size = new System.Drawing.Size(57, 17);
            this.labelBookId.TabIndex = 1;
            this.labelBookId.Text = "Bookid";
            this.labelBookId.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.Location = new System.Drawing.Point(133, 313);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(56, 17);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Author";
            this.labelAuthor.Click += new System.EventHandler(this.labelAuthor_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(133, 266);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(45, 17);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Price";
            this.labelPrice.Click += new System.EventHandler(this.labelPrice_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(133, 225);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(54, 17);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Status";
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            // 
            // labelCopies
            // 
            this.labelCopies.AutoSize = true;
            this.labelCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopies.Location = new System.Drawing.Point(133, 183);
            this.labelCopies.Name = "labelCopies";
            this.labelCopies.Size = new System.Drawing.Size(57, 17);
            this.labelCopies.TabIndex = 5;
            this.labelCopies.Text = "Copies";
            this.labelCopies.Click += new System.EventHandler(this.labelCopies_Click);
            // 
            // labelBookname
            // 
            this.labelBookname.AutoSize = true;
            this.labelBookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookname.Location = new System.Drawing.Point(133, 134);
            this.labelBookname.Name = "labelBookname";
            this.labelBookname.Size = new System.Drawing.Size(83, 17);
            this.labelBookname.TabIndex = 6;
            this.labelBookname.Text = "Bookname";
            this.labelBookname.Click += new System.EventHandler(this.labelBookname_Click);
            // 
            // tbBookId
            // 
            this.tbBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBookId.Location = new System.Drawing.Point(317, 91);
            this.tbBookId.Name = "tbBookId";
            this.tbBookId.Size = new System.Drawing.Size(100, 23);
            this.tbBookId.TabIndex = 7;
            this.tbBookId.TextChanged += new System.EventHandler(this.tbBookId_TextChanged);
            // 
            // tbBookname
            // 
            this.tbBookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBookname.Location = new System.Drawing.Point(317, 134);
            this.tbBookname.Name = "tbBookname";
            this.tbBookname.Size = new System.Drawing.Size(100, 23);
            this.tbBookname.TabIndex = 8;
            this.tbBookname.TextChanged += new System.EventHandler(this.tbBookname_TextChanged);
            // 
            // tbCopies
            // 
            this.tbCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCopies.Location = new System.Drawing.Point(317, 177);
            this.tbCopies.Name = "tbCopies";
            this.tbCopies.Size = new System.Drawing.Size(100, 23);
            this.tbCopies.TabIndex = 9;
            this.tbCopies.TextChanged += new System.EventHandler(this.tbCopies_TextChanged);
            // 
            // tbstatus
            // 
            this.tbstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbstatus.Location = new System.Drawing.Point(317, 225);
            this.tbstatus.Name = "tbstatus";
            this.tbstatus.Size = new System.Drawing.Size(100, 23);
            this.tbstatus.TabIndex = 10;
            this.tbstatus.TextChanged += new System.EventHandler(this.tbstatus_TextChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(317, 266);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 23);
            this.tbPrice.TabIndex = 11;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // tbAuthor
            // 
            this.tbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAuthor.Location = new System.Drawing.Point(317, 313);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(100, 23);
            this.tbAuthor.TabIndex = 12;
            this.tbAuthor.TextChanged += new System.EventHandler(this.tbAuthor_TextChanged);
            // 
            // btnCancel1
            // 
            this.btnCancel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel1.Location = new System.Drawing.Point(342, 378);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(75, 32);
            this.btnCancel1.TabIndex = 13;
            this.btnCancel1.Text = "Cancel";
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // btnupdate1
            // 
            this.btnupdate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate1.Location = new System.Drawing.Point(141, 378);
            this.btnupdate1.Name = "btnupdate1";
            this.btnupdate1.Size = new System.Drawing.Size(75, 32);
            this.btnupdate1.TabIndex = 14;
            this.btnupdate1.Text = "Add";
            this.btnupdate1.UseVisualStyleBackColor = true;
            this.btnupdate1.Click += new System.EventHandler(this.btnupdate1_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.btnupdate1);
            this.Controls.Add(this.btnCancel1);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbstatus);
            this.Controls.Add(this.tbCopies);
            this.Controls.Add(this.tbBookname);
            this.Controls.Add(this.tbBookId);
            this.Controls.Add(this.labelBookname);
            this.Controls.Add(this.labelCopies);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelBookId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBookId;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelCopies;
        private System.Windows.Forms.Label labelBookname;
        private System.Windows.Forms.TextBox tbBookId;
        private System.Windows.Forms.TextBox tbBookname;
        private System.Windows.Forms.TextBox tbCopies;
        private System.Windows.Forms.TextBox tbstatus;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnupdate1;
    }
}