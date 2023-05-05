namespace Task_B
{
    partial class Form1
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
            buttonAddPerson = new Button();
            buttonAddEdge = new Button();
            buttonShowFriends = new Button();
            buttonShowAll = new Button();
            textPersonName = new TextBox();
            textConnectPerson1 = new TextBox();
            textBox3 = new TextBox();
            Person_Name = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textAllFriends = new ListBox();
            textConnectPerson2 = new TextBox();
            textRemovePerson = new TextBox();
            buttonRemovePerson = new Button();
            label1 = new Label();
            textAllConnections = new TextBox();
            buttonAllConnections = new Button();
            SuspendLayout();
            // 
            // buttonAddPerson
            // 
            buttonAddPerson.Location = new Point(38, 78);
            buttonAddPerson.Name = "buttonAddPerson";
            buttonAddPerson.Size = new Size(211, 23);
            buttonAddPerson.TabIndex = 0;
            buttonAddPerson.Text = "Add Person";
            buttonAddPerson.UseVisualStyleBackColor = true;
            buttonAddPerson.Click += buttonAddPerson_Click;
            // 
            // buttonAddEdge
            // 
            buttonAddEdge.Location = new Point(38, 196);
            buttonAddEdge.Name = "buttonAddEdge";
            buttonAddEdge.Size = new Size(211, 23);
            buttonAddEdge.TabIndex = 1;
            buttonAddEdge.Text = "Connect Persons";
            buttonAddEdge.UseVisualStyleBackColor = true;
            buttonAddEdge.Click += buttonAddEdge_Click;
            // 
            // buttonShowFriends
            // 
            buttonShowFriends.Location = new Point(459, 51);
            buttonShowFriends.Name = "buttonShowFriends";
            buttonShowFriends.Size = new Size(132, 24);
            buttonShowFriends.TabIndex = 2;
            buttonShowFriends.Text = "Direct Connections";
            buttonShowFriends.UseVisualStyleBackColor = true;
            buttonShowFriends.Click += buttonShowFriends_Click;
            // 
            // buttonShowAll
            // 
            buttonShowAll.Location = new Point(342, 362);
            buttonShowAll.Name = "buttonShowAll";
            buttonShowAll.Size = new Size(249, 23);
            buttonShowAll.TabIndex = 3;
            buttonShowAll.Text = "Show All Persons";
            buttonShowAll.UseVisualStyleBackColor = true;
            buttonShowAll.Click += buttonShowAll_Click;
            // 
            // textPersonName
            // 
            textPersonName.Location = new Point(38, 49);
            textPersonName.Name = "textPersonName";
            textPersonName.Size = new Size(211, 23);
            textPersonName.TabIndex = 4;
            // 
            // textConnectPerson1
            // 
            textConnectPerson1.Location = new Point(38, 167);
            textConnectPerson1.Name = "textConnectPerson1";
            textConnectPerson1.Size = new Size(211, 23);
            textConnectPerson1.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(342, 51);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(111, 23);
            textBox3.TabIndex = 6;
            // 
            // Person_Name
            // 
            Person_Name.AutoSize = true;
            Person_Name.Location = new Point(38, 31);
            Person_Name.Name = "Person_Name";
            Person_Name.Size = new Size(78, 15);
            Person_Name.TabIndex = 8;
            Person_Name.Text = "Person Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 149);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 9;
            label2.Text = "Connect Person 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 251);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 10;
            label3.Text = "Connect Person 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(342, 31);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 11;
            label4.Text = "Friends List";
            // 
            // textAllFriends
            // 
            textAllFriends.FormattingEnabled = true;
            textAllFriends.ItemHeight = 15;
            textAllFriends.Location = new Point(342, 109);
            textAllFriends.Margin = new Padding(2);
            textAllFriends.Name = "textAllFriends";
            textAllFriends.Size = new Size(249, 244);
            textAllFriends.TabIndex = 12;
            // 
            // textConnectPerson2
            // 
            textConnectPerson2.Location = new Point(38, 225);
            textConnectPerson2.Name = "textConnectPerson2";
            textConnectPerson2.Size = new Size(211, 23);
            textConnectPerson2.TabIndex = 13;
            // 
            // textRemovePerson
            // 
            textRemovePerson.Location = new Point(38, 330);
            textRemovePerson.Name = "textRemovePerson";
            textRemovePerson.Size = new Size(211, 23);
            textRemovePerson.TabIndex = 14;
            // 
            // buttonRemovePerson
            // 
            buttonRemovePerson.Location = new Point(38, 362);
            buttonRemovePerson.Name = "buttonRemovePerson";
            buttonRemovePerson.Size = new Size(211, 23);
            buttonRemovePerson.TabIndex = 15;
            buttonRemovePerson.Text = "Remove Person";
            buttonRemovePerson.UseVisualStyleBackColor = true;
            buttonRemovePerson.Click += buttonRemovePerson_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 312);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 16;
            label1.Text = "Person Name";
            // 
            // textAllConnections
            // 
            textAllConnections.Location = new Point(342, 81);
            textAllConnections.Name = "textAllConnections";
            textAllConnections.Size = new Size(111, 23);
            textAllConnections.TabIndex = 17;
            // 
            // buttonAllConnections
            // 
            buttonAllConnections.Location = new Point(459, 81);
            buttonAllConnections.Name = "buttonAllConnections";
            buttonAllConnections.Size = new Size(132, 24);
            buttonAllConnections.TabIndex = 18;
            buttonAllConnections.Text = "All Connections";
            buttonAllConnections.UseVisualStyleBackColor = true;
            buttonAllConnections.Click += buttonAllConnections_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 418);
            Controls.Add(buttonAllConnections);
            Controls.Add(textAllConnections);
            Controls.Add(label1);
            Controls.Add(buttonRemovePerson);
            Controls.Add(textRemovePerson);
            Controls.Add(textConnectPerson2);
            Controls.Add(textAllFriends);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Person_Name);
            Controls.Add(textBox3);
            Controls.Add(textConnectPerson1);
            Controls.Add(textPersonName);
            Controls.Add(buttonShowAll);
            Controls.Add(buttonShowFriends);
            Controls.Add(buttonAddEdge);
            Controls.Add(buttonAddPerson);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddPerson;
        private Button buttonAddEdge;
        private Button buttonShowFriends;
        private Button buttonShowAll;
        private TextBox textPersonName;
        private TextBox textConnectPerson1;
        private TextBox textBox3;
        private Label Person_Name;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox textAllFriends;
        private TextBox textConnectPerson2;
        private TextBox textRemovePerson;
        private Button buttonRemovePerson;
        private Label label1;
        private TextBox textAllConnections;
        private Button buttonAllConnections;
    }
}