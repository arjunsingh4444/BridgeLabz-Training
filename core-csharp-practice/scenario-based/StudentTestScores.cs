/*. Scenario: Develop a program to manage student test scores. The program should:
 ● Store the scores of n students in an array.
 ● Calculate and display the average score.
 ● Find and display the highest and lowest scores.
 ● Identify and display the scores above the average.
 ● Handle invalid input like negative scores or non-numeric input.*/

using System;

public class StudentTestScores{
    //Method to calculate the average of an array of integers
      public static float CalculateAverage(int[] scores){
            int sum = 0;
            for(int i=0;i<scores.Length;i++){ //Loop through the array of integers
                  sum += scores[i];
            }
            return (float)sum / scores.Length; //Return the average as a float
      }
      //Method to find the highest score in an array of integers

      public static int highestScore(int[] scores){
            int highest = scores[0];
            for(int i=1;i<scores.Length;i++){ //Loop through the array of integers
                  if(scores[i] > highest){ //If the current score is greater than the current highest score
                        highest = scores[i]; //Set the current score as the new highest score
                  } 
                  if(scores[i] > highest){
                        highest = scores[i];
                  }
            }
            return highest;
      }
    //Method to find the lowest score in an array of integers

      public static int lowestScore(int[] scores){
            int lowest = scores[0];
            for(int i=1;i<scores.Length;i++){ //Loop through the array of integers
                  if(scores[i] < lowest){
                        lowest = scores[i];
                  }
            }
            return lowest;
      }
      //Method to display the scores above the average

      public static void ScoresAboveAverage(int[] scores, float average){
            Console.WriteLine("Scores above average:");
            for(int i=0;i<scores.Length;i++){ //Loop through the array of integers
                  if(scores[i] > average){
                        Console.WriteLine(scores[i]);
                  }
            }     
      }
//Main method to handle user input and call the other methods
      public static void Main(string[] args){
            Console.WriteLine("Enter the number of students:");
            int n=Convert.ToInt32(Console.ReadLine()); //Get the number of students from the user
            if(n<0){ //Check if the number of students is negative
                  Console.WriteLine("Invalid input. Number of students cannot be negative.");
                  return;
            }
            int[] scores = new int[n]; //Create an array of integers to store the scores
            for(int i=0;i<n;i++){ //Loop through the array of integers and get the scores from the user
                  Console.WriteLine($"Enter score for student {i+1}:");
                  int score;
                  if(!int.TryParse(Console.ReadLine(), out score) || score < 0){ //Check if the input is a valid integer and not negative
                        Console.WriteLine("Invalid input. Score cannot be negative.");
                        i--;
                        continue;
                  }
                  scores[i] = score;
            }

            float average = CalculateAverage(scores); //Calculate the average of the scores
            int highest = highestScore(scores); //Find the highest score in the array
            int lowest = lowestScore(scores); //        Find the lowest score in the array

            Console.WriteLine($"Average Score: {average}"); //Display the average score
            Console.WriteLine($"Highest Score: {highest}"); //Display the highest and lowest scores
            Console.WriteLine($"Lowest Score: {lowest}"); //Display the lowest and highest scores
            ScoresAboveAverage(scores, average); //Display the scores above the average
      }
}