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
            lstNearestAtms.Location = new Point(224, 60);
            lstNearestAtms.Name = "lstNearestAtms";
            lstNearestAtms.Size = new Size(350, 300);
            lstNearestAtms.Text = "Найближчі банкомати";
            lstNearestAtms.TabIndex = 0;
            // 
            // NearestAtmsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstNearestAtms);
            Name = "NearestAtmsForm";
            Text = "NearestAtmsForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstNearestAtms;

    }
}