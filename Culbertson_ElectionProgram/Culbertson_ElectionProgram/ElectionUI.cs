using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Culbertson_ElectionProgram
{
    class ElectionUI
    {
        private void DisplayResults(string name, int votes, double percent)
        {
            WriteLine("\t\t{0}\t\t{1}\t\t{2:P}\n", name, votes, percent);
        }

        public void MainMethod()
        {
            Election theElection = new Election(); 
            for (int i = 0; i <= 4; i++) 
            {
                theElection.SetCandidateName(PromptForString(i), i);
                theElection.SetVotes(PromptForInt(theElection.GetCandidateName(i)), i);      
            }
            int total = theElection.TotalVotes();
            for (int j = 0; j <= 4; j++)
            {
                double result = theElection.GetCandidateVotes(j)/total;
                DisplayResults(theElection.GetCandidateName(j), theElection.GetCandidateVotes(j), (double)theElection.GetCandidateVotes(j) / total);
            }
            WriteLine("The total number of votes is {0}, and", total);
            WriteLine("the winner of the election is {0}!!", theElection.FindWinner());
        }

        private int PromptForInt(string name)
        {
            Write("Please enter {0}'s votes: ", name);
            int votes = int.Parse(ReadLine());
            return votes;
        }

        private string PromptForString(int num)
        {
            Write("Please enter Candidate {0}'s name: ", num+1);
            string name = ReadLine();
            return name;
        }
    }
}
