# FindMissUniversity
CodeLearn
The Miss University is taking place at Royal Academy. In the final round, in order to find out the top best contestants, the organizers decided to change the way of scoring. That is : Each judge does not give the score for each contestant but give a list of best contestants according to he/she (the list has at least 1 contestant and maximum 3 contestants) in order of priority. The first contestant in the list will get 3 scores, the 2nd gets 2 scores and the 3rd gets 1 score. The winner will be the one with the highest score. If there are more than one contestant that has the highest score, the contestant who is selected more at the 1st place will win, if it's still a draw, we will consider the number of times she is selected as 2nd place. Finally, if we still can't find out the winner, all the remain contestants (get the highest score, equal in times getting at the 1st and the 2nd place) will be the winner.

For Example:

With input is numberOfJudges : 4
selectedContestant : [[5,2,1], [12,5,2], [1,2],[2,1,5]]
The output should be findMissUniversity(numberOfJudges,selectedContestants)=[2]
From this we have:
contestant 1 :  6 scores - 1x 1st - 1x 2nd - 1x 3rd 
contestant 2 :  8 scores - 1x 1st - 2x 2nd - 1x 3rd 
contestant 5 :  6 scores - 1x 1st - 1x 2nd - 1x 3rd 
contestant 12:  3 scores - 1x 1st 
So the winner is 2 since she gets 8 scores - the highest scores among all the contestants.
With input is numberOfJudges : 2
selectedcontestants:  [[3,2,1], [2,3,1]] 
The output should be findMissUniversity(numberOfJudges,selectedContestants)=[2,3]
We have:
contestant 1:  2 scores - 2x 3rd 
contestant 2:  5 scores - 1x 1st - 1x 2nd 
contestant 3:  5 scores - 1x 1st - 1x 2nd 
Since 2 and 3 get the same score (5 scores) and all get 1x 1st place and 2x 2nd place. So the answer  findMissUniversity(numberOfJudges,selectedContestants)=[2,3]
Input/Output:

[execution time limit] 0.5s (C++), 3s (Java , C#), 4s(Python,JavaScript)

[input] integer numberOfJudges

Number of Judges
Guaranteed constraints:
 1 ≤ numberOfJudges ≤ 100 

[input] Matrix.integer selectedContestants

Selected Contestant of each Judge. In order : 1st , 2st, 3rd
Guaranteed constraints:
 1 ≤ selectedContestants[i].length ≤ 3 
 1 ≤ selectedContestants[i][j] ≤ 25000 

[output] array.integer

Top best candidates
