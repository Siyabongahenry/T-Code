namespace FormAnim
{
    partial class CfrmDrawAnim
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
            this.components = new System.ComponentModel.Container();
            this.pnlDrawing = new System.Windows.Forms.Panel();
            this.tmrDraw = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlDrawing
            // 
            this.pnlDrawing.BackColor = System.Drawing.Color.White;
            this.pnlDrawing.Location = new System.Drawing.Point(43, 28);
            this.pnlDrawing.Name = "pnlDrawing";
            this.pnlDrawing.Size = new System.Drawing.Size(482, 269);
            this.pnlDrawing.TabIndex = 0;
            // 
            // tmrDraw
            // 
            this.tmrDraw.Enabled = true;
            this.tmrDraw.Tick += new System.EventHandler(this.tmrDraw_Tick);
            // 
            // CfrmDrawAnim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 341);
            this.Controls.Add(this.pnlDrawing);
            this.Name = "CfrmDrawAnim";
            this.Text = "Animation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawing;
        private System.Windows.Forms.Timer tmrDraw;
    }
}

