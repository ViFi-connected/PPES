using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace DCV_4
{
    public class Loading
    {
        public static BindingList<Team> LoadTeams(FootballSimulator form)
        {
            var path = @"data/Liga_2021_Tymy.csv";
            string[] lines;

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            try
            {
                lines = File.ReadAllLines(path, Encoding.GetEncoding(1250));
            }
            catch (Exception)
            {
                form.openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
                form.openFileDialog1.Title = "Select Teams data";
                form.openFileDialog1.FileName = "Liga_2021_Tymy.csv";
                if (form.openFileDialog1.ShowDialog() == DialogResult.Cancel)
                {
                    return null;
                }
                
                lines = File.ReadAllLines(form.openFileDialog1.FileName, Encoding.GetEncoding(1250));
            }

            BindingList<Team> teams = new();

            foreach  (string team in lines)
            {
                teams.Add(new Team(team));
            }

            return teams;
        }

        public static BindingList<Match> LoadMatches(FootballSimulator form)
        {
            var path = @"data/Liga_2021_Zapasy.csv";
            TextFieldParser csvParser;
            BindingList<Match> matches = new();

            try
            {
                 csvParser = new TextFieldParser(path, Encoding.GetEncoding(1250));
            }
            catch
            {
                form.openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
                form.openFileDialog1.Title = "Select Matches data";
                form.openFileDialog1.FileName = "Liga_2021_Zapasy.csv";
                if (form.openFileDialog1.ShowDialog() == DialogResult.Cancel)
                {
                    return null;
                }
                csvParser = new TextFieldParser(form.openFileDialog1.FileName, Encoding.GetEncoding(1250));
            }

            using (csvParser)
            {
                csvParser.SetDelimiters(new string[] { ";" });
                csvParser.HasFieldsEnclosedInQuotes = false;

                while (!csvParser.EndOfData)
                {
                    string[] fields = csvParser.ReadFields();

                    matches.Add(new Match(int.Parse(fields[0]), fields[1], fields[2]));
                }

                return matches;
            }

        }
    }
} 