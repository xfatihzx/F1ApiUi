
namespace F1ApiUi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Season = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RaceGrid = new System.Windows.Forms.DataGridView();
            this.ConstructorForTabOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverTabForOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeTabForOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointTabForOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionTabForOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Race = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Stop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PitStop = new System.Windows.Forms.DataGridView();
            this.DriverForPitStop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StopForPitStop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeForPitStop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RaceForPitSpot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SeasonForPitSpot = new System.Windows.Forms.TextBox();
            this.SearchForPitStop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RaceGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PitStop)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(77, 73);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 23);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Season";
            // 
            // Season
            // 
            this.Season.Location = new System.Drawing.Point(77, 21);
            this.Season.Name = "Season";
            this.Season.Size = new System.Drawing.Size(100, 20);
            this.Season.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RaceGrid);
            this.tabPage1.Controls.Add(this.Race);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Season);
            this.tabPage1.Controls.Add(this.Search);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Top Three";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RaceGrid
            // 
            this.RaceGrid.AllowUserToAddRows = false;
            this.RaceGrid.AllowUserToDeleteRows = false;
            this.RaceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RaceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConstructorForTabOne,
            this.DriverTabForOne,
            this.TimeTabForOne,
            this.PointTabForOne,
            this.PositionTabForOne});
            this.RaceGrid.Location = new System.Drawing.Point(242, 6);
            this.RaceGrid.Name = "RaceGrid";
            this.RaceGrid.ReadOnly = true;
            this.RaceGrid.Size = new System.Drawing.Size(547, 377);
            this.RaceGrid.TabIndex = 6;
            // 
            // ConstructorForTabOne
            // 
            this.ConstructorForTabOne.HeaderText = "Constructor";
            this.ConstructorForTabOne.Name = "ConstructorForTabOne";
            this.ConstructorForTabOne.ReadOnly = true;
            // 
            // DriverTabForOne
            // 
            this.DriverTabForOne.HeaderText = "Driver\'s name";
            this.DriverTabForOne.Name = "DriverTabForOne";
            this.DriverTabForOne.ReadOnly = true;
            // 
            // TimeTabForOne
            // 
            this.TimeTabForOne.HeaderText = "Time";
            this.TimeTabForOne.Name = "TimeTabForOne";
            this.TimeTabForOne.ReadOnly = true;
            // 
            // PointTabForOne
            // 
            this.PointTabForOne.HeaderText = "Point";
            this.PointTabForOne.Name = "PointTabForOne";
            this.PointTabForOne.ReadOnly = true;
            // 
            // PositionTabForOne
            // 
            this.PositionTabForOne.HeaderText = "Position";
            this.PositionTabForOne.Name = "PositionTabForOne";
            this.PositionTabForOne.ReadOnly = true;
            // 
            // Race
            // 
            this.Race.Location = new System.Drawing.Point(77, 47);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(100, 20);
            this.Race.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Race";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Stop);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.PitStop);
            this.tabPage2.Controls.Add(this.RaceForPitSpot);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.SeasonForPitSpot);
            this.tabPage2.Controls.Add(this.SearchForPitStop);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PitStop";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(82, 94);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(100, 20);
            this.Stop.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Stop";
            // 
            // PitStop
            // 
            this.PitStop.AllowUserToAddRows = false;
            this.PitStop.AllowUserToDeleteRows = false;
            this.PitStop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PitStop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DriverForPitStop,
            this.StopForPitStop,
            this.Laps,
            this.TimeForPitStop,
            this.Duration});
            this.PitStop.Location = new System.Drawing.Point(270, 6);
            this.PitStop.Name = "PitStop";
            this.PitStop.ReadOnly = true;
            this.PitStop.Size = new System.Drawing.Size(514, 410);
            this.PitStop.TabIndex = 11;
            // 
            // DriverForPitStop
            // 
            this.DriverForPitStop.HeaderText = "Driver";
            this.DriverForPitStop.Name = "DriverForPitStop";
            this.DriverForPitStop.ReadOnly = true;
            // 
            // StopForPitStop
            // 
            this.StopForPitStop.HeaderText = "Stop";
            this.StopForPitStop.Name = "StopForPitStop";
            this.StopForPitStop.ReadOnly = true;
            // 
            // Laps
            // 
            this.Laps.HeaderText = "Laps";
            this.Laps.Name = "Laps";
            this.Laps.ReadOnly = true;
            // 
            // TimeForPitStop
            // 
            this.TimeForPitStop.HeaderText = "Time";
            this.TimeForPitStop.Name = "TimeForPitStop";
            this.TimeForPitStop.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // RaceForPitSpot
            // 
            this.RaceForPitSpot.Location = new System.Drawing.Point(82, 64);
            this.RaceForPitSpot.Name = "RaceForPitSpot";
            this.RaceForPitSpot.Size = new System.Drawing.Size(100, 20);
            this.RaceForPitSpot.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Race";
            // 
            // SeasonForPitSpot
            // 
            this.SeasonForPitSpot.Location = new System.Drawing.Point(82, 38);
            this.SeasonForPitSpot.Name = "SeasonForPitSpot";
            this.SeasonForPitSpot.Size = new System.Drawing.Size(100, 20);
            this.SeasonForPitSpot.TabIndex = 8;
            // 
            // SearchForPitStop
            // 
            this.SearchForPitStop.Location = new System.Drawing.Point(82, 124);
            this.SearchForPitStop.Name = "SearchForPitStop";
            this.SearchForPitStop.Size = new System.Drawing.Size(100, 23);
            this.SearchForPitStop.TabIndex = 6;
            this.SearchForPitStop.Text = "Search";
            this.SearchForPitStop.UseVisualStyleBackColor = true;
            this.SearchForPitStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Season";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RaceGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PitStop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Season;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView RaceGrid;
        private System.Windows.Forms.TextBox Race;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConstructorForTabOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverTabForOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeTabForOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointTabForOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionTabForOne;
        private System.Windows.Forms.TextBox Stop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView PitStop;
        private System.Windows.Forms.TextBox RaceForPitSpot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SeasonForPitSpot;
        private System.Windows.Forms.Button SearchForPitStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverForPitStop;
        private System.Windows.Forms.DataGridViewTextBoxColumn StopForPitStop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laps;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeForPitStop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
    }
}

