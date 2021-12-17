using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DCV_4
{
    public partial class FootballSimulator : Form
    {
        public BindingList<Team> Teams { get; set; }

        public BindingList<Match> Matches { get; set; }

        private static IEnumerable<Match> currentMatches;
        private static readonly Random random = new();

        private static int round = 0;
        private static int time = 0;
        private static bool runFlag = false;
        private static bool startFlag = false;

        public FootballSimulator()
        {
            InitializeComponent();

            splitContainer1.SplitterDistance = splitContainer1.Size.Width / 2;

            textBoxRound.Text = round.ToString();
            textBoxTime.Text = time.ToString();
        }

        #region Buttons
        private void btnLoad_Click(object sender, EventArgs e)
        {
            Teams = Loading.LoadTeams(this);
            Matches = Loading.LoadMatches(this);

            dataGridViewTeams.DataSource = Teams;
            dataGridViewMatches.DataSource = Matches;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Matches == null)
            {
                MessageBox.Show("Please load the data first", "Data not loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                return;
            }

            if (!startFlag)
            {
                round = 1;
                startFlag = true;
                currentMatches = Matches.Where(x => x.Round == round);
            }

            if (runFlag)
            {
                btnStart.Text = "START";
                runFlag = false;
                timer.Enabled = false;
            }
            else
            {
                btnStart.Text = "STOP";
                runFlag = true;
                timer.Enabled = true;
            }
        }

        private void checkBoxTURBO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTURBO.Checked)
            {
                timer.Interval = 100;
            }
            else
            {
                timer.Interval = 1000;
            }
        }

        #endregion

        private void timer_Tick(object sender, EventArgs e)
        {
            if (time == 90)
            {
                if (round == 30)
                {
                    timer.Enabled = false;
                    return;
                }
                time = 0;
                round++;
                currentMatches = Matches.Where(x => x.Round == round);
            }
            else
            {
                time++;
            }

            foreach (var match in currentMatches)
            {
                if (RandomSuccess())
                {
                    match.GuestTeamGoals++;
                    Teams.SingleOrDefault(x => x.Name == match.GuestTeam).GoalsScored++;
                    Teams.SingleOrDefault(x => x.Name == match.HomeTeam).GoalsConceded++;
                    textBoxLog.AppendText(match.GuestTeam + " goal against " + match.HomeTeam);
                    textBoxLog.AppendText(Environment.NewLine);
                }

                if (RandomSuccess())
                {
                    match.HomeTeamGoals++;
                    Teams.SingleOrDefault(x => x.Name == match.HomeTeam).GoalsScored++;
                    Teams.SingleOrDefault(x => x.Name == match.GuestTeam).GoalsConceded++;
                    textBoxLog.AppendText(match.HomeTeam + " goal against " + match.GuestTeam);
                    textBoxLog.AppendText(Environment.NewLine);
                }
            }

            textBoxTime.Text = time.ToString();
            textBoxRound.Text = round.ToString();

            dataGridViewMatches.Update();
            dataGridViewTeams.Update();
        }

        private static bool RandomSuccess()
        {
            return random.NextDouble() < 0.01;
        }
    }
}
