using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Student_Housing
{
    public partial class HomePage : Form
    {
        Color backColorOfButton = Color.FromArgb(41, 128, 185);
        Color activePanelColor = Color.FromArgb(49, 153, 222);
        User? _student;       
        Event? selectedEvent;
        StudentHouseManagement _management;

        public HomePage(User student)
        {
            InitializeComponent();
            _management = new StudentHouseManagement(student);
            _student = student;
            Debug.WriteLine(student.Id);
            btnHome.BackColor = activePanelColor;          
            tbNameOfEvent.PlaceholderText = "Name of event";
            tbDescription.PlaceholderText = "Decription of my event";
            UpdateListViews();
            LoadUpcomingTasks();
        }

        public void UpdateListViews()
        {
            UpdateListView<Event>(listViewStudentsEvents, '|', _management.GetEventsOfStudent().ToArray());
            UpdateListView<Event>(listViewAllEvents, '|', _management.GetEvents().ToArray());           
        }


        private void UpdateListView<T>(ListView list, char splitingCharInString, T[] arrayOfitems)
        {
            list.Items.Clear();
            for (int i = 0; i < arrayOfitems.Length; i++)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.SubItems.AddRange(arrayOfitems[i].ToString().Split(splitingCharInString));
                listViewItem.Tag = arrayOfitems[i];
                list.Items.Add(listViewItem);
            }
        }

        private void LoadUpcomingTasks()
        {
            listBoxUpcomingTasks.Items.Clear();
            foreach (var task in _management.GetCleanCycle().Tasks)
            {
                listBoxUpcomingTasks.Items.Add(task);
            }
            foreach (var task in _management.GetTrashCycle().Tasks)
            {
                listBoxUpcomingTasks.Items.Add(task);
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = backColorOfButton;
            btnHouseApplience.BackColor = backColorOfButton;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelHome.BringToFront();
            btnHouseApplience.BackColor = backColorOfButton;
            btnHome.BackColor = activePanelColor;
        }

        private void btnHouseApplience_Click(object sender, EventArgs e)
        {
            panelHouseApplience.BringToFront();
            btnHome.BackColor = backColorOfButton;
            btnHouseApplience.BackColor = activePanelColor;
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
           if(VeriftactionOfInputDataForEventCreation() == true)
            {
                _management.CreateNewEvent(tbNameOfEvent.Text, _student, dtpStartdate.Value.Date, dtpEnddate.Value.Date, tbDescription.Text, _management.Property);
                UpdateListViews();
            }
        }

        private bool VeriftactionOfInputDataForEventCreation()
        {
            if (string.IsNullOrEmpty(tbNameOfEvent.Text))
            {
                lblVerificationOfNameOfEvent.Visible = true;
                return false;
            }
            if (string.IsNullOrEmpty(tbDescription.Text))
            {
                lblVerifitationOfDecriptionForCreateAnEvent.Visible = true;
                return false;
            }
            else
            {
                return true;
            }
        }


        private void listViewStudentsEvents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                List<Event> events = _management.GetEvents();
                events.Remove(selectedEvent);
                UpdateListViews();
                TextFileUtilities.WriteToJson(events, "Events");
            }
        }

        private void listViewStudentsEvents_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedEvent = (Event)e.Item.Tag;
         
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            EntryPage entryPage = new EntryPage();
            entryPage.Show();
            Close();
        }
    }
}
