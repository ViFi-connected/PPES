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
        public static BindingList<Team> LoadTeams()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string[] lines = File.ReadAllLines("data/Liga_2021_Tymy.csv", Encoding.GetEncoding(1250));
            
            BindingList<Team> teams = new();
            foreach  (string team in lines)
            {
                teams.Add(new Team(team));
            }
            
            return teams;
        }

        public static BindingList<Match> LoadMatches()
        {
            var path = @"data/Liga_2021_Zapasy.csv";
            using (TextFieldParser csvParser = new TextFieldParser(path, Encoding.GetEncoding(1250)))
            {
                csvParser.SetDelimiters(new string[] { ";" });
                csvParser.HasFieldsEnclosedInQuotes = false;

                BindingList<Match> matches = new();
                while (!csvParser.EndOfData)
                {
                    string[] fields = csvParser.ReadFields();

                    matches.Add(new Match(int.Parse(fields[0]), fields[1], fields[2] ));
                }

                return matches;
            }
        }
    }
} 