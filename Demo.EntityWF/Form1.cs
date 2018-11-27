using Demo.EntityConsole;
using Demo.UnitOfWork;
using Entities.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.EntityWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource =
                Unit.GroupsRepository.AllItems.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group item = (sender as ComboBox).SelectedItem as Group;
            var groupTimeTables = Unit.GroupTimetablesRepository.AllItems.Where(x => x.Group.Id == item.Id).ToList();
            //var timeTables = Unit.TimetablesRepository.AllItems.Where(x => x.Id == groupTimeTable.Group.Id).ToList();
            listBox1.DataSource = groupTimeTables.Select(x => x.Timetable.ToString()).ToList();
            
        }
    }
}
