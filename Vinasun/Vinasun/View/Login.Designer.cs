namespace Vinasun.View
{
    partial class Login
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
            this.winRTLiveTileManager1 = new DevExpress.XtraBars.WinRTLiveTiles.WinRTLiveTileManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.winRTLiveTileManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // winRTLiveTileManager1
            // 
            this.winRTLiveTileManager1.ApplicationName = "";
            this.winRTLiveTileManager1.ContainerControl = this;
            this.winRTLiveTileManager1.Id = "1178ba8a-3d04-42f0-ae74-e73c8577f356";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 383);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.winRTLiveTileManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.WinRTLiveTiles.WinRTLiveTileManager winRTLiveTileManager1;

    }
}