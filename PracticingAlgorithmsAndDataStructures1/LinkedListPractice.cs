using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticingAlgorithmsAndDataStructures1
{
    public partial class LinkedListPractice : Form
    {
        MyLinkedList myList = new MyLinkedList();
        public LinkedListPractice()
        {
            InitializeComponent();
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            AddFromFrontToListAndListView();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddFromFrontToListAndListView();
                textBox1.Clear();
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddinLastToListAndListView();
                textBox2.Clear();
            }
        }
        private void AddFromFrontToListAndListView() {
            int temp;
            if (textBox1.Text != "")
            {
                temp = Convert.ToInt32(textBox1.Text);
                myList.AddNodeFromFront(new MyLinkedList.Node(temp));

                ListViewItem[] array = new ListViewItem[listView1.Items.Count];
                listView1.Items.CopyTo(array, 0);
                listView1.Clear();
                listView1.Items.Insert(0, textBox1.Text);
                foreach (ListViewItem s in array)
                {
                    listView1.Items.Add(s);
                }
            }
        }
        private void AddinLastToListAndListView()
        {
            int temp;
            if (textBox1.Text != "")
            {
                temp = Convert.ToInt32(textBox1.Text);
                myList.AddNodeInLast(new MyLinkedList.Node(temp));
                listView1.Items.Add(new ListViewItem(Convert.ToString(temp)));
            }
        }       
        private void button2_Click(object sender, EventArgs e)
        {
            AddinLastToListAndListView();
        }
        private void validateTextInteger(object sender, EventArgs e)
        {
            Exception X = new Exception();

            TextBox T = (TextBox)sender;

            try
            {
                if (T.Text != "-")
                {
                    int x = int.Parse(T.Text);
                }
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }
            }
        }

    }
}
