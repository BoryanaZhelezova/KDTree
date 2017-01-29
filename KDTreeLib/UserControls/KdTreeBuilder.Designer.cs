namespace KdTreeLib
{
    partial class KdTreeBuilder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // KdTreeBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.DoubleBuffered = true;
            this.Name = "KdTreeBuilder";
            this.Size = new System.Drawing.Size(300, 300);
            this.Click += new System.EventHandler(this.KdTreeBuilder_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.KdTreeBuilder_Paint);
            this.MouseLeave += new System.EventHandler(this.KdTreeBuilder_MouseLeave);
            this.Resize += new System.EventHandler(this.KdTreeBuilder_Resize);
            this.StyleChanged += new System.EventHandler(this.KdTreeBuilder_StyleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
