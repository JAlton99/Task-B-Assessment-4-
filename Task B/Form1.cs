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

        private void buttonAddEdge_Click(object sender, EventArgs e)
        {
            string name1 = textConnectPerson1.Text;
            string name2 = textConnectPerson2.Text;
            socialNetwork.AddEdge(name1, name2);
            textConnectPerson1.Clear();
            textConnectPerson2.Clear();

            MessageBox.Show($"{name1} is now connected to {name2}");
        }


        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            string name = textPersonName.Text;
            socialNetwork.AddNode(name);
            textPersonName.Clear();
        }


        private void buttonShowFriends_Click(object sender, EventArgs e)
        {
            string personName = textBox3.Text;

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

            LinkedList<string> friendsList = personNode.GetAdjList();

            textAllFriends.Items.Clear();

            foreach (string friend in friendsList)
            {
                textAllFriends.Items.Add(friend);
            }

        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            textAllFriends.Items.Clear();
            List<string> names = socialNetwork.GetAllNodes();

            foreach (string name in names)
            {
                textAllFriends.Items.Add(name);
            }

        }

        private void buttonRemovePerson_Click(object sender, EventArgs e)
        {
            string name = textRemovePerson.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a person's name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = socialNetwork.RemoveNode(name);

            if (success)
            {
                textRemovePerson.Clear();
                MessageBox.Show($"{name} has been removed from the social network.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Person '{name}' not found in the social network.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAllConnections_Click(object sender, EventArgs e)
        {
            string name = textAllConnections.Text;

            GraphNode personNode = socialNetwork.GetNodeByName(name);

            if (personNode == null)
            {
                MessageBox.Show($"Person '{name}' not found in the social network.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> allConnections = GetAllConnections(personNode);

            textAllFriends.Items.Clear();

            foreach (string connection in allConnections)
            {
                textAllFriends.Items.Add(connection);
            }

            textAllConnections.Clear();
        }

        private List<string> GetAllConnections(GraphNode node)
        {
            var visited = new HashSet<string>();
            var queue = new Queue<GraphNode>();

            visited.Add(node.Name);
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();

                foreach (var neighbor in currentNode.GetAdjList())
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(socialNetwork.GetNodeByName(neighbor));
                    }
                }
            }

            // Create a list from the set of visited nodes
            var allConnections = visited.ToList();

            // Remove the original person from the list, as you do not want this to show in the connections list
            allConnections.Remove(node.Name);

            return allConnections;
        }





    }
}