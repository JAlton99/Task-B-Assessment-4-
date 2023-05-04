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
            Person_Name = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textAllFriends = new ListBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // buttonAddPerson
            // 
            buttonAddPerson.Location = new Point(99, 108);
            buttonAddPerson.Margin = new Padding(4, 5, 4, 5);
            buttonAddPerson.Name = "buttonAddPerson";
            buttonAddPerson.Size = new Size(170, 38);
            buttonAddPerson.TabIndex = 0;
            buttonAddPerson.Text = "Add Person";
            buttonAddPerson.UseVisualStyleBackColor = true;
            buttonAddPerson.Click += buttonAddPerson_Click;
            // 
            // buttonAddEdge
            // 
            buttonAddEdge.Location = new Point(110, 334);
            buttonAddEdge.Margin = new Padding(4, 5, 4, 5);
            buttonAddEdge.Name = "buttonAddEdge";
            buttonAddEdge.Size = new Size(170, 38);
            buttonAddEdge.TabIndex = 1;
            buttonAddEdge.Text = "Connect Persons";
            buttonAddEdge.UseVisualStyleBackColor = true;
            buttonAddEdge.Click += button2_Click;
            // 
            // buttonShowFriends
            // 
            buttonShowFriends.Location = new Point(99, 566);
            buttonShowFriends.Margin = new Padding(4, 5, 4, 5);
            buttonShowFriends.Name = "buttonShowFriends";
            buttonShowFriends.Size = new Size(170, 38);
            buttonShowFriends.TabIndex = 2;
            buttonShowFriends.Text = "Show Friends";
            buttonShowFriends.UseVisualStyleBackColor = true;
            buttonShowFriends.Click += buttonShowFriends_Click;
            // 
            // buttonShowAll
            // 
            buttonShowAll.Location = new Point(489, 60);
            buttonShowAll.Margin = new Padding(4, 5, 4, 5);
            buttonShowAll.Name = "buttonShowAll";
            buttonShowAll.Size = new Size(170, 38);
            buttonShowAll.TabIndex = 3;
            buttonShowAll.Text = "Show All Persons";
            buttonShowAll.UseVisualStyleBackColor = true;
            buttonShowAll.Click += buttonShowAll_Click;
            // 
            // textPersonName
            // 
            textPersonName.Location = new Point(54, 67);
            textPersonName.Margin = new Padding(4, 5, 4, 5);
            textPersonName.Name = "textPersonName";
            textPersonName.Size = new Size(263, 31);
            textPersonName.TabIndex = 4;
            // 
            // textPerson1
            // 
            textPerson1.Location = new Point(41, 267);
            textPerson1.Margin = new Padding(4, 5, 4, 5);
            textPerson1.Name = "textPerson1";
            textPerson1.Size = new Size(313, 31);
            textPerson1.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(54, 619);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(263, 31);
            textBox3.TabIndex = 6;
            // 
            // Person_Name
            // 
            Person_Name.AutoSize = true;
            Person_Name.Location = new Point(54, 30);
            Person_Name.Margin = new Padding(4, 0, 4, 0);
            Person_Name.Name = "Person_Name";
            Person_Name.Size = new Size(117, 25);
            Person_Name.TabIndex = 8;
            Person_Name.Text = "Person Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 220);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 9;
            label2.Text = "Connect Person 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 463);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 10;
            label3.Text = "Connect Person 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(489, 30);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(220, 25);
            label4.TabIndex = 11;
            label4.Text = "Person Name (Friends List)";
            // 
            // textAllFriends
            // 
            textAllFriends.FormattingEnabled = true;
            textAllFriends.ItemHeight = 25;
            textAllFriends.Location = new Point(489, 121);
            textAllFriends.Name = "textAllFriends";
            textAllFriends.Size = new Size(354, 529);
            textAllFriends.TabIndex = 12;
            textAllFriends.SelectedIndexChanged += textFriendsof_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 413);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 31);
            textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 750);
            Controls.Add(textBox1);
            Controls.Add(textAllFriends);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Person_Name);
            Controls.Add(textBox3);
            Controls.Add(textPerson1);
            Controls.Add(textPersonName);
            Controls.Add(buttonShowAll);
            Controls.Add(buttonShowFriends);
            Controls.Add(buttonAddEdge);
            Controls.Add(buttonAddPerson);
            Margin = new Padding(4, 5, 4, 5);
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
        private Label Person_Name;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox textAllFriends;
        private TextBox textBox1;
    }
}