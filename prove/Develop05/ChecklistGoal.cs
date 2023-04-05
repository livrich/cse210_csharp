// using System;

// public class ChecklistGoal : Goal
// {
//     // Attributes
//     private int _bonusPoints;
//     private int _repsCompleted;
//     private int _totalRepetitions;

//     // Constructor
//     public ChecklistGoal(string type, string name, string description, int points, 
//     int bonusPoints, int totalReps, int repsCompleted = 0): base(type, name, description, points)
//     {
//         _bonusPoints = bonusPoints;
//         _repsCompleted = repsCompleted;
//         _totalRepetitions = totalReps;
//     }

//     // Methods
//     public override bool RecordGoal()
//     {
//         return true;
//     } 

//     public int GetRepsCompleted()
//     {
//         return _repsCompleted;
//     }

//     public int GetTotalReps()
//     {
//         return _totalRepetitions;
//     }

//     public void CheckCompleted()
//     {
//         if (_repsCompleted == _totalRepetitions)
//         {
//             _isCompleted = true;
//         }
//         else
//         {
//             _isCompleted = false;
//         }
//     }
// }