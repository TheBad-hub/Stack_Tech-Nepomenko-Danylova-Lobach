namespace WinForm
{
    partial class NearestAtmsForm
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
            lstNearestAtms = new ListBox();
            SuspendLayout();
            // 
            // lstNearestAtms
            // 
            lstNearestAtms.FormattingEnabled = true;
            lstNearestAtms.ItemHeight = 15;
            lstNearestAtms.Location = new Point(196, 45);
            lstNearestAtms.Margin = new Padding(3, 2, 3, 2);
            lstNearestAtms.Name = "lstNearestAtms";
            lstNearestAtms.Size = new Size(307, 214);
            lstNearestAtms.TabIndex = 0;
            // 
            // NearestAtmsForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(700, 338);
            Controls.Add(lstNearestAtms);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NearestAtmsForm";
            Text = "NearestAtmsForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstNearestAtms;

    }
}