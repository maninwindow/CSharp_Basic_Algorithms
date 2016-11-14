using DotNetPractices.Arrays;
using DotNetPractices.IO;
using DotNetPractices.LINQ;
using DotNetPractices.Recursion;
using DotNetPractices.SearchingAndSorting;
using DotNetPractices.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractices
{
    public class Program
    {
        private delegate int del(int i);

        private static void Main(string[] args)
        {
            ////Reference Types practice

            //GradeBook book = new GradeBook();
            //book.AddGrade(91);
            //book.AddGrade(32.3f);
            //book.AddGrade(42);

            //GradeStatistics stats = book.ComputeStatistics();
            //Console.WriteLine(stats.HighestGrade);
            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.LowestGrade);
            ////GradeBook book1 = new GradeBook();
            //GradeBook book1 = book;
            //book1.AddGrade(43);

            //Array Covariance
            //object[] objArr = new object[3];
            //string[] daysOfWeek = {
            //                        "Monday",
            //                        "Tuesday",
            //                        "Wednesday",
            //                        "Thersday",
            //                        "Friday",
            //                        "Saturday",
            //                        "Sunday"
            //                    };
            //int indexOfW = Array.FindIndex(daysOfWeek, x => x[0] == 'W');
            //Console.WriteLine(indexOfW);

            //string[] allWithChars = Array.FindAll(
            //    daysOfWeek, x => x.Length == 9);
            //foreach (string item in allWithChars)
            //    Console.WriteLine(item);

            //object[] objArr2 = daysOfWeek;

            //foreach (object obj in objArr2)
            //    Console.WriteLine(obj);

            //What Arrays can do?
            //int[] squares = { 1, 4, 9, 16 };

            //int[] copy = new int[8];
            //squares.CopyTo(copy, 0);
            //foreach (int value in copy)
            //{
            //    Console.WriteLine(value);
            //}
            //Console.WriteLine(string.Format("squares == copy?{0}", squares == copy));

            //Lambda expression examplds
            //del myDelegate = y => y * y;
            //int j = myDelegate(5);
            //Console.WriteLine(j);
            //Console.ReadLine();

            //Binary search
            //Array.Sort(daysOfWeek);
            //int indexOfSun = Array.BinarySearch(daysOfWeek, "Sunday");
            //Console.WriteLine("Index is:" + indexOfSun);

            /*Array Practices*/
            //CopyArrayToArray.CopyArray();
            //CheckDuplicatedElements.DuplicatedElements();
            //UniqueValues.UniqueArrays();
            //MergeArraysOfSameSize.MergeArrays();
            //CountFrequencyOfElements.Frequency();
            //MaximumAndMinimumElement.FindMaxAndMinElement();
            //SeperateOddAndEvenIntegers.OddAndEvenIntegers();
            //SortElementsInAscendingOrder.SortAscendingOrder();
            //InsertNewValue.InsertValue();
            //DeleteAnArray.DeleteArray();
            //FindSecondLargestElement.FindSecondLargest();
            //FindSecondSmallestElement.FindSecondSmallest();
            //Read2DArray.ReadArray();
            //AddTwoMatrices.TwoMatrices();
            //SubtractionOfTwoMatrices.Subtraction();
            //MultiplicationOfTwoMatrices.Multiplication();
            //TransposeMatrix.Transpose();
            //FindDiagonalsOfMatrix.SumOfLeftDiagonals();
            //FindDiagonalsOfMatrix.SumOfRightDiagonals();
            //FindSumOfRowsAnColumnsOfMatrix.SumOfRowsAnColumnsOfAMatrix();
            //DisplayTriangular.LowerTriangular();
            //DisplayTriangular.UpperTriangular();
            //CalculateDeteminant.Determinant();
            //SpraseMatrix.DetermineSparseMatrix();
            //CheckTwoMatrixAreEqual.AreTwoMatrixEqual();
            //CheckIdentityMatrix.CheckIndentity();

            /*Search and sort*/
            //ShellSort.ShellSortPractice();
            //CheckCertainWordInText.ExtractList();
            //BogoSort.BogoSortPractice();
            //BubbleSort.BubbleSortPractice();

            /*String*/
            //CopyOneStringIntoAnother.CopyString ToAnother();
            //CompareTwoString.CompareString();
            //CountNumberOfCharacters.CountCharacters();
            //CountNumberOfWordsInString.CountNumberOfWord();
            //MaximumAccurringCharacter.MaximumAccurring();
            //string str = "Find out maximum!";
            //SortStringAscendingOrder.SortStringAscending();
            //SortStringBubbleSort.SortStringUsingBubbleSort();
            //ExtractSubstringFromString.ExtractSubString();

            //IO
            //PreSignReady.GetReady();
            //string apkFile = @"D:\AutomationTool\APKs\dev-6.23.0.6.apk";
            //PreSignReady.SignReady(apkFile);

            //LINQ
            //DisplayCertainNumberFromListOfNumbers.TestMethod();

            //Recursio
            //CheckPalindromeUsingRecursion.TestMethod();
            //FindingFibonacciNumbers.FeibonacciRecursion();
            //GeneratePermutations.TestMethod();
        }
    }
}