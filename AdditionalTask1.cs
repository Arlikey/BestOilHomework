using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOilHomework
{
    public partial class AdditionalTask1 : Form
    {
        public AdditionalTask1()
        {
            InitializeComponent();
            projectsListBox.DisplayMember = "Name";
        }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Введите название проекта: ", "Название проекта");
            string desription = Interaction.InputBox("Укажите описание проекта: ", "Описание проекта");
            Project project = new Project() { Name = name, Description = desription, ProjectDate = projectDateTimePicker.Value };
            projectsListBox.Items.Add(project);

        }

        public class Project
        {
            public DateTime ProjectDate { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public override string ToString()
            {
                return $"Название - {Name}, Описание - {Description}, Дата - {ProjectDate}";
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            if (projectsListBox.SelectedItem == null)
            {
                return;
            }
            Project item = projectsListBox.SelectedItem as Project;
            MessageBox.Show($"Название: {item.Name}\nОписание: {item.Description}\nСрок выполнения: {item.ProjectDate.ToShortDateString()}", "Про проект", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteProjectButton_Click(object sender, EventArgs e)
        {
            projectsListBox.Items.Remove(projectsListBox.SelectedItem);
        }
    }
}
