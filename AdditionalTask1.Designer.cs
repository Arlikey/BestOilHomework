namespace BestOilHomework
{
    partial class AdditionalTask1
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
            projectsListBox = new ListBox();
            projectDateTimePicker = new DateTimePicker();
            addProjectButton = new Button();
            aboutButton = new Button();
            removeButton = new Button();
            SuspendLayout();
            // 
            // projectsListBox
            // 
            projectsListBox.FormattingEnabled = true;
            projectsListBox.ItemHeight = 15;
            projectsListBox.Location = new Point(241, 14);
            projectsListBox.Name = "projectsListBox";
            projectsListBox.Size = new Size(362, 424);
            projectsListBox.TabIndex = 0;
            // 
            // projectDateTimePicker
            // 
            projectDateTimePicker.Location = new Point(12, 171);
            projectDateTimePicker.Name = "projectDateTimePicker";
            projectDateTimePicker.Size = new Size(200, 23);
            projectDateTimePicker.TabIndex = 1;
            // 
            // addProjectButton
            // 
            addProjectButton.Location = new Point(51, 228);
            addProjectButton.Name = "addProjectButton";
            addProjectButton.Size = new Size(120, 35);
            addProjectButton.TabIndex = 2;
            addProjectButton.Text = "Добавить проект";
            addProjectButton.UseVisualStyleBackColor = true;
            addProjectButton.Click += AddProjectButton_Click;
            // 
            // aboutButton
            // 
            aboutButton.Location = new Point(642, 14);
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(120, 35);
            aboutButton.TabIndex = 2;
            aboutButton.Text = "Подробнее";
            aboutButton.UseVisualStyleBackColor = true;
            aboutButton.Click += aboutButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(642, 82);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(120, 35);
            removeButton.TabIndex = 2;
            removeButton.Text = "Удалить проект";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += DeleteProjectButton_Click;
            // 
            // AdditionalTask1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(removeButton);
            Controls.Add(aboutButton);
            Controls.Add(addProjectButton);
            Controls.Add(projectDateTimePicker);
            Controls.Add(projectsListBox);
            Name = "AdditionalTask1";
            Text = "AdditionalTask1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox projectsListBox;
        private DateTimePicker projectDateTimePicker;
        private Button addProjectButton;
        private Button aboutButton;
        private Button removeButton;
    }
}