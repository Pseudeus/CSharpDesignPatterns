
namespace MVCWinFormDemo
{
    partial class StudentForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTextBoxContext = new System.Windows.Forms.Label();
            this.lblEnrolledStudents = new System.Windows.Forms.Label();
            this.addStudentTextBox = new System.Windows.Forms.TextBox();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.removeStudentButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.showStudentsListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(19, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(314, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "A Sample MVC WinForm Application Demo";
            // 
            // lblTextBoxContext
            // 
            this.lblTextBoxContext.AutoSize = true;
            this.lblTextBoxContext.Location = new System.Drawing.Point(21, 91);
            this.lblTextBoxContext.Name = "lblTextBoxContext";
            this.lblTextBoxContext.Size = new System.Drawing.Size(75, 13);
            this.lblTextBoxContext.TabIndex = 1;
            this.lblTextBoxContext.Text = "Add a student";
            // 
            // lblEnrolledStudents
            // 
            this.lblEnrolledStudents.AutoSize = true;
            this.lblEnrolledStudents.Location = new System.Drawing.Point(332, 91);
            this.lblEnrolledStudents.Name = "lblEnrolledStudents";
            this.lblEnrolledStudents.Size = new System.Drawing.Size(91, 13);
            this.lblEnrolledStudents.TabIndex = 2;
            this.lblEnrolledStudents.Text = "Enrolled Students";
            // 
            // addStudentTextBox
            // 
            this.addStudentTextBox.Location = new System.Drawing.Point(21, 116);
            this.addStudentTextBox.Name = "addStudentTextBox";
            this.addStudentTextBox.Size = new System.Drawing.Size(156, 21);
            this.addStudentTextBox.TabIndex = 3;
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(89, 156);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(88, 30);
            this.addStudentButton.TabIndex = 4;
            this.addStudentButton.Text = "Add";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // removeStudentButton
            // 
            this.removeStudentButton.Location = new System.Drawing.Point(89, 204);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(88, 30);
            this.removeStudentButton.TabIndex = 5;
            this.removeStudentButton.Text = "Remove";
            this.removeStudentButton.UseVisualStyleBackColor = true;
            this.removeStudentButton.Click += new System.EventHandler(this.removeStudentButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(89, 252);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(88, 30);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // showStudentsListView
            // 
            this.showStudentsListView.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showStudentsListView.HideSelection = false;
            this.showStudentsListView.Location = new System.Drawing.Point(332, 135);
            this.showStudentsListView.Name = "showStudentsListView";
            this.showStudentsListView.Size = new System.Drawing.Size(91, 246);
            this.showStudentsListView.TabIndex = 6;
            this.showStudentsListView.UseCompatibleStateImageBehavior = false;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showStudentsListView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.removeStudentButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.addStudentTextBox);
            this.Controls.Add(this.lblEnrolledStudents);
            this.Controls.Add(this.lblTextBoxContext);
            this.Controls.Add(this.lblTitle);
            this.Name = "StudentForm";
            this.Text = "Student Form";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTextBoxContext;
        private System.Windows.Forms.Label lblEnrolledStudents;
        private System.Windows.Forms.TextBox addStudentTextBox;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button removeStudentButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView showStudentsListView;
    }
}

