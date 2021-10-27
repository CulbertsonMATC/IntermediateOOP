using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culbertson_ElectionProgram
{
    class Election
    {
        private string[] candidates = new string[NUMCANDIDATES];
        private const int NUMCANDIDATES = 5;
        private int[] votes = new int[NUMCANDIDATES];

        public int NumberOfCandidates
        {
            get { return NUMCANDIDATES; }
        }

        public string FindWinner()
        {
            int i = votes.Max();
            int maxIndex = Array.IndexOf(votes, i);
            return candidates[maxIndex];

        }

        public string GetCandidateName(int index)
        {
             return candidates[index];
        }

        public int GetCandidateVotes(int index)
        {
            return votes[index];
        }

        public void SetCandidateName(string values, int index)
        {
            candidates[index] = values;
        }

        public void SetVotes(int votes, int index)
        {
            this.votes[index] = votes;
        }

        public int TotalVotes()
        {
            int total = 0;
            for (int i = 0; i <= 4; i++)
            {
                total += votes[i];
            }

            return total; 
        }
    }
}
    
