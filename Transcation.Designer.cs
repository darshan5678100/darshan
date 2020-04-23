namespace LibraryManagmentSystem
{
    partial class Transcation
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
            this.gvTable = new System.Windows.Forms.DataGridView();
            this.tbHeadLine = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // gvTable
            // 
            this.gvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTable.Location = new System.Drawing.Point(137, 114);
            this.gvTable.Name = "gvTable";
            this.gvTable.ReadOnly = true;
            this.gvTable.Size = new System.Drawing.Size(529, 259);
            this.gvTable.TabIndex = 3;
            // 
            // tbHeadLine
            // 
            this.tbHeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeadLine.ForeColor = System.Drawing.Color.Maroon;
            this.tbHeadLine.Location = new System.Drawing.Point(162, 30);
            this.tbHeadLine.Name = "tbHeadLine";
            this.tbHeadLine.Size = new System.Drawing.Size(450, 38);
            this.tbHeadLine.TabIndex = 10;
            // 
            // Transcation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbHeadLine);
            this.Controls.Add(this.gvTable);
            this.Name = "Transcation";
            this.Text = "Transcation";
            this.Load += new System.EventHandler(this.Transcation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvTable;
        private System.Windows.Forms.TextBox tbHeadLine;
    }
}