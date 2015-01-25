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
        MyLinkedList<int> myList = new MyLinkedList<int>();
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
        private void button2_Click(object sender, EventArgs e)
        {
            AddinLastToListAndListView();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            myList.RemoveFront();

            ListViewItem[] array = new ListViewItem[listView1.Items.Count];
            //listView1.Items.CopyTo(array, 0);
            //listView1.Clear();
            listView1.Items.RemoveAt(0);
            //foreach (ListViewItem s in array)
            //{
            //    listView1.Items.Add(s);
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myList.RemoveLast();
            listView1.Items.RemoveAt(listView1.Items.Count - 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(myList.RemoveAllOccurancesByValue(Convert.ToInt32(textBoxRemoveNodeWithValue.Text)));
        }
        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddFromFrontToListAndListView();
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
        private void AddFromFrontToListAndListView()
        {
            int temp;
            if (textBox1.Text != "")
            {
                temp = Convert.ToInt32(textBox1.Text);
                myList.AddNodeFromFront(new Node<int>(temp));
                ListViewItem[] array = new ListViewItem[listView1.Items.Count];
                listView1.Items.CopyTo(array, 0);
                listView1.Clear();
                listView1.Items.Insert(0, textBox1.Text);
                foreach (ListViewItem s in array)
                {
                    listView1.Items.Add(s);
                }
                textBox1.Clear();
            }
        }
        private void AddinLastToListAndListView()
        {
            int temp;
            if (textBox2.Text != "")
            {
                temp = Convert.ToInt32(textBox2.Text);
                myList.AddNodeInLast(new Node<int>(temp));
                listView1.Items.Add(new ListViewItem(Convert.ToString(temp)));
            }
            textBox2.Clear();
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
