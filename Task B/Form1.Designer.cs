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
            textPerson1 = new TextBox();
            textBox3 = new TextBox();
            textFriendsof = new TextBox();
            Person_Name = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonAddPerson
            // 
            buttonAddPerson.Location = new Point(126, 103);
            buttonAddPerson.Name = "buttonAddPerson";
            buttonAddPerson.Size = new Size(119, 23);
            buttonAddPerson.TabIndex = 0;
            buttonAddPerson.Text = "Add Person";
            buttonAddPerson.UseVisualStyleBackColor = true;
            buttonAddPerson.Click += buttonAddPerson_Click;
            // 
            // buttonAddEdge
            // 
            buttonAddEdge.Location = new Point(327, 190);
            buttonAddEdge.Name = "buttonAddEdge";
            buttonAddEdge.Size = new Size(119, 23);
            buttonAddEdge.TabIndex = 1;
            buttonAddEdge.Text = "Connect Persons";
            buttonAddEdge.UseVisualStyleBackColor = true;
            buttonAddEdge.Click += button2_Click;
            // 
            // buttonShowFriends
            // 
            buttonShowFriends.Location = new Point(165, 268);
            buttonShowFriends.Name = "buttonShowFriends";
            buttonShowFriends.Size = new Size(119, 23);
            buttonShowFriends.TabIndex = 2;
            buttonShowFriends.Text = "Show Friends";
            buttonShowFriends.UseVisualStyleBackColor = true;
            buttonShowFriends.Click += buttonShowFriends_Click;
            // 
            // buttonShowAll
            // 
            buttonShowAll.Location = new Point(165, 368);
            buttonShowAll.Name = "buttonShowAll";
            buttonShowAll.Size = new Size(119, 23);
            buttonShowAll.TabIndex = 3;
            buttonShowAll.Text = "Show All Persons";
            buttonShowAll.UseVisualStyleBackColor = true;
            buttonShowAll.Click += buttonShowAll_Click;
            // 
            // textPersonName
            // 
            textPersonName.Location = new Point(126, 74);
            textPersonName.Name = "textPersonName";
            textPersonName.Size = new Size(185, 23);
            textPersonName.TabIndex = 4;
            textPersonName.TextChanged += textPersonName_TextChanged;
            // 
            // textPerson1
            // 
            textPerson1.Location = new Point(280, 161);
            textPerson1.Name = "textPerson1";
            textPerson1.Size = new Size(220, 23);
            textPerson1.TabIndex = 5;
            textPerson1.TextChanged += textPerson1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(344, 268);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 23);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textFriendsof
            // 
            textFriendsof.Location = new Point(344, 368);
            textFriendsof.Name = "textFriendsof";
            textFriendsof.Size = new Size(185, 23);
            textFriendsof.TabIndex = 7;
            textFriendsof.TextChanged += textFriendsof_TextChanged;
            // 
            // Person_Name
            // 
            Person_Name.AutoSize = true;
            Person_Name.Location = new Point(126, 56);
            Person_Name.Name = "Person_Name";
            Person_Name.Size = new Size(78, 15);
            Person_Name.TabIndex = 8;
            Person_Name.Text = "Person Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 143);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 9;
            label2.Text = "Connect Person 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(400, 143);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 10;
            label3.Text = "Connect Person 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 350);
            label4.Name = "label4";
            label4.Size = new Size(148, 15);
            label4.TabIndex = 11;
            label4.Text = "Person Name (Friends List)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Person_Name);
            Controls.Add(textFriendsof);
            Controls.Add(textBox3);
            Controls.Add(textPerson1);
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
        private TextBox textPerson1;
        private TextBox textBox3;
        private TextBox textFriendsof;
        private Label Person_Name;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}