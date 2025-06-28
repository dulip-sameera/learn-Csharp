
namespace WeekPayCalc
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNoOfWorkHours = new Label();
            txtNoOfWorkHours = new TextBox();
            lblTitle = new Label();
            lblPayRate = new Label();
            txtPayRate = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // lblNoOfWorkHours
            // 
            lblNoOfWorkHours.AutoSize = true;
            lblNoOfWorkHours.BackColor = SystemColors.Highlight;
            lblNoOfWorkHours.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoOfWorkHours.Location = new Point(12, 116);
            lblNoOfWorkHours.Name = "lblNoOfWorkHours";
            lblNoOfWorkHours.Size = new Size(229, 23);
            lblNoOfWorkHours.TabIndex = 0;
            lblNoOfWorkHours.Text = "No of Work Hours (Per Week)";
            // 
            // txtNoOfWorkHours
            // 
            txtNoOfWorkHours.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNoOfWorkHours.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNoOfWorkHours.Location = new Point(14, 151);
            txtNoOfWorkHours.Margin = new Padding(5);
            txtNoOfWorkHours.Name = "txtNoOfWorkHours";
            txtNoOfWorkHours.PlaceholderText = "No of work hours per week";
            txtNoOfWorkHours.ScrollBars = ScrollBars.Vertical;
            txtNoOfWorkHours.Size = new Size(423, 32);
            txtNoOfWorkHours.TabIndex = 1;
            txtNoOfWorkHours.TextChanged += txtNoOfWorkHours_TextChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(123, 41);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(206, 29);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Week Pay Calculator";
            // 
            // lblPayRate
            // 
            lblPayRate.AutoSize = true;
            lblPayRate.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPayRate.Location = new Point(14, 188);
            lblPayRate.Name = "lblPayRate";
            lblPayRate.Size = new Size(130, 23);
            lblPayRate.TabIndex = 3;
            lblPayRate.Text = "Hourly Pay Rate";
            // 
            // txtPayRate
            // 
            txtPayRate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPayRate.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPayRate.Location = new Point(14, 229);
            txtPayRate.Name = "txtPayRate";
            txtPayRate.PlaceholderText = "Hourly Pay Rate";
            txtPayRate.Size = new Size(425, 32);
            txtPayRate.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCalculate.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = SystemColors.Highlight;
            btnCalculate.Location = new Point(14, 306);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(425, 50);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(451, 365);
            Controls.Add(btnCalculate);
            Controls.Add(txtPayRate);
            Controls.Add(lblPayRate);
            Controls.Add(lblTitle);
            Controls.Add(txtNoOfWorkHours);
            Controls.Add(lblNoOfWorkHours);
            ForeColor = SystemColors.Info;
            Name = "Main";
            Text = "Week Pay Calculator";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label lblNoOfWorkHours;
        private TextBox txtNoOfWorkHours;
        private Label lblTitle;
        private Label lblPayRate;
        private TextBox txtPayRate;
        private Button btnCalculate;
    }
}
