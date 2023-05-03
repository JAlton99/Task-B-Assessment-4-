using System.Text;

namespace Task_B
{
    public partial class Form1 : Form
    {
        private Graph socialNetwork;
        public Form1()
        {
            InitializeComponent();
            socialNetwork = new Graph();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name1 = textPerson1.Text;
            string name2 = textBox3.Text;
            socialNetwork.AddEdge(name1, name2);
            textPerson1.Clear();
            textBox3.Clear();
        }

        private void textPersonName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            string name = textPersonName.Text;
            socialNetwork.AddNode(name);
            textPersonName.Clear();
        }

        private void textPerson1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonShowFriends_Click(object sender, EventArgs e)
        {
            string personName = textPersonName.Text;

            if (string.IsNullOrWhiteSpace(personName))
            {
                MessageBox.Show("Please enter a person's name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GraphNode personNode = socialNetwork.GetNodeByName(personName);

            if (personNode == null)
            {
                MessageBox.Show($"Person '{personName}' not found in the social network.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LinkedList<GraphNode> friendsList = personNode.GetAdjList();
            StringBuilder friendsStringBuilder = new StringBuilder();

            foreach (GraphNode friend in friendsList)
            {
                friendsStringBuilder.AppendLine(friend.Name);
            }

            MessageBox.Show(friendsStringBuilder.ToString(), $"Friends of {personName}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textFriendsof_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {

        }
    }
}