namespace Drawing
{
    partial class CfrmDrawings
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
            this.pnlDrawings = new System.Windows.Forms.Panel();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlDrawings
            // 
            this.pnlDrawings.BackColor = System.Drawing.Color.White;
            this.pnlDrawings.Location = new System.Drawing.Point(30, 12);
            this.pnlDrawings.Name = "pnlDrawings";
            this.pnlDrawings.Size = new System.Drawing.Size(474, 265);
            this.pnlDrawings.TabIndex = 0;
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDraw.ForeColor = System.Drawing.Color.White;
            this.btnDraw.Location = new System.Drawing.Point(39, 285);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(429, 285);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CfrmDrawings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 320);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.pnlDrawings);
            this.Name = "CfrmDrawings";
            this.Text = "Drawings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawings;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnClose;
    }
}

