using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace DevAssign
{


    public partial class MainPage : Form
    {
        public static string inputPath = @"D:\input.txt";
        public static string outputPath = @"D:\output.txt";


        public MainPage()
        {
            InitializeComponent();

            //The Combo Box Elements
            options.Items.Add("Read From And Write to file");
            options.Items.Add("Binary Search");
            options.Items.Add("sort the input using merg sort");
            options.Items.Add("sort the input using quick sort");
            options.Items.Add("sort the input using Heap sort");
            options.Items.Add("sort the input using Count sort");

            // Hide the text Box of the Binary Search 
            // show it when select binary search

            txtBSValue.Visible = false;
            lblEnterValue.Visible = false;

        }

        public int[] mySplit(string s)
        {

            // delimiters
            char[] del = new char[] { ' ', '\n', ',', '\t' };

            //string to array of strings 
            string[] arr = s.Split(del);

            // a new int array of the size of the string array
            int[] intarr = new int[arr.Length];

            int cnt = 0;// cnt counts the number of valid numbers
            for (int i = 0; i < arr.Length; i++)
                if (arr[i].Length > 0) //check if the string contains characters 
                    intarr[cnt++] = Int32.Parse(arr[i]);

            //create a new array of the valid numbers
            int[] ret = new int[cnt];

            for (int i = 0; i < cnt; i++)
                ret[i] = intarr[i];

            // finally , return the final array
            return ret;
        }


        public int[] SplitForCountSort(string s) // to ensure that there's no -ve numbers
        {

            // delimiters
            char[] del = new char[] { ' ', '\n', ',', '\t' };

            //string to array of strings 
            string[] arr = s.Split(del);

            // a new int array of the size of the string array
            int[] intarr = new int[arr.Length];

            int cnt = 0;// cnt counts the number of valid numbers
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > 0)//check if the string contains characters 
                {
                    int num = Int32.Parse(arr[i]);

                    // check if the number is a non negative number ...
                    if (num >= 0)
                        intarr[cnt++] = num;
                }
            }

            //create a new array of the valid numbers
            int[] ret = new int[cnt];

            for (int i = 0; i < cnt; i++)
                ret[i] = intarr[i];

            // finally , return the final array
            return ret;
        }

        int Binary_Search(int val, int[] arr, ref int moves)
        {
            int ret = -1;

            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                moves++;

                int mid = (left + right) / 2;
                if (arr[mid] == val)
                    return mid;

                if (arr[mid] > val)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return ret;
        }

        private void options_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Execute_Click(object sender, EventArgs e)
        {
            string choice = options.Text;

            // MessageBox.Show(choice);

            if (choice == "Read From And Write to file")
            {
                // set the timer
                var watch = System.Diagnostics.Stopwatch.StartNew();

                // read the input file
                string s = File.ReadAllText(inputPath);

                //Write to the output file
                File.WriteAllText(outputPath, s);

                // stop the timer
                watch.Stop();

                double elapsedMs = (watch.ElapsedMilliseconds) / 1000.0;

                string msg = "Execution Time = " + elapsedMs + " S";
                msg += Environment.NewLine;

                msg += "to copy the input file to the output file";
                MessageBox.Show(msg, "Time elapsed", MessageBoxButtons.OK);
            }

            else if (choice == "Binary Search")
            {
                // get the value from the text box
                int val = Int32.Parse(txtBSValue.Text);

                // set the timer
                var watch = System.Diagnostics.Stopwatch.StartNew();

                // read the input file
                string s = File.ReadAllText(inputPath);

                // convert the read string into intgers array
                // using mySplit function 
                int[] arr = mySplit(s);

                // sort the array Using the merg sort

                MergeSortAlgorithm.MergeSort(arr);

                // declare a counter and index for the binary search
                int cnt = 0, index;

                // call the binary search 
                index = Binary_Search(val, arr, ref cnt);

                // stop the timer 
                watch.Stop();

                double elapsedMs = (watch.ElapsedMilliseconds) / 1000.0;
                string msg = "Execution Time = " + elapsedMs + " S";
                msg += Environment.NewLine;

                if (index == -1)
                    msg += "Value Not Found";
                else
                {
                    msg += "to Binary Search on Value";
                    msg += Environment.NewLine;
                    msg += "Value Found in index \'" + index + "\' in the file";
                    msg += Environment.NewLine;
                    msg += "The Binary Search took " + cnt + " steps to get the value between "
                        + arr.Length + " Elments";
                }

                // show the message
                MessageBox.Show(msg, "Time elapsed", MessageBoxButtons.OK);
            }

            //
            else if (choice == "sort the input using merg sort")
            {
                // set the timer
                var watch = System.Diagnostics.Stopwatch.StartNew();

                // read the input file
                string s = File.ReadAllText(inputPath);

                // convert the read string into intgers array
                // using mySplit function 
                int[] arr = mySplit(s);

                // sort the array Using the merg sort
                MergeSortAlgorithm.MergeSort(arr);

                //join the numbers in one string
                s = string.Join(",", arr);

                //Write to the output file
                File.WriteAllText(outputPath, s);

                // stop the timer 
                watch.Stop();


                double elapsedMs = (watch.ElapsedMilliseconds) / 1000.0;
                string msg = "Execution Time = " + elapsedMs + " S" + Environment.NewLine;
                msg += "To : " + Environment.NewLine;
                msg += "=> Read the input file" + Environment.NewLine;
                msg += "=> Sort the Numbers Using the merge Sort" + Environment.NewLine;
                msg += "=> print the sorted array to the output file" + Environment.NewLine;
                msg += "______________________________________________" + Environment.NewLine;
                msg += "=> The File contains an Array of Size : " + arr.Length + Environment.NewLine;

                // show the message
                MessageBox.Show(msg, "Time elapsed", MessageBoxButtons.OK);
            }

            else if (choice == "sort the input using quick sort")
            {
                // set the timer
                var watch = System.Diagnostics.Stopwatch.StartNew();

                // read the input file
                string s = File.ReadAllText(inputPath);

                // convert the read string into intgers array
                // using mySplit function 
                int[] arr = mySplit(s);

                // sort the array Using the Quick sort
                QuickSortAlogrithm.QuickSort(arr);

                //join the numbers in one string
                s = string.Join(",", arr);

                //Write to the output file
                File.WriteAllText(outputPath, s);

                // stop the timer 
                watch.Stop();


                double elapsedMs = (watch.ElapsedMilliseconds) / 1000.0;
                string msg = "Execution Time = " + elapsedMs + " S" + Environment.NewLine;
                msg += "To : " + Environment.NewLine;
                msg += "=> Read the input file" + Environment.NewLine;
                msg += "=> Sort the Numbers Using the Quick Sort" + Environment.NewLine;
                msg += "=> print the sorted array to the output file" + Environment.NewLine;
                msg += "______________________________________________" + Environment.NewLine;
                msg += "=> The File contains an Array of Size : " + arr.Length + Environment.NewLine;

                // show the message
                MessageBox.Show(msg, "Time elapsed", MessageBoxButtons.OK);
            }

            else if (choice == "sort the input using Heap sort")
            {
                // set the timer
                var watch = System.Diagnostics.Stopwatch.StartNew();

                // read the input file
                string s = File.ReadAllText(inputPath);

                // convert the read string into intgers array
                // using mySplit function 
                int[] arr = mySplit(s);

                // sort the array Using the Heap sort
                HeapSortAlogrithm.HeapSort(arr);

                //join the numbers in one string
                s = string.Join(",", arr);

                //Write to the output file
                File.WriteAllText(outputPath, s);

                // stop the timer 
                watch.Stop();


                double elapsedMs = (watch.ElapsedMilliseconds) / 1000.0;
                string msg = "Execution Time = " + elapsedMs + " S" + Environment.NewLine;
                msg += "To : " + Environment.NewLine;
                msg += "=> Read the input file" + Environment.NewLine;
                msg += "=> Sort the Numbers Using the Heap Sort" + Environment.NewLine;
                msg += "=> print the sorted array to the output file" + Environment.NewLine;
                msg += "______________________________________________" + Environment.NewLine;
                msg += "=> The File contains an Array of Size : " + arr.Length + Environment.NewLine;

                // show the message
                MessageBox.Show(msg, "Time elapsed", MessageBoxButtons.OK);
            }

            else if (choice == "sort the input using Count sort")
            {
                // set the timer
                var watch = System.Diagnostics.Stopwatch.StartNew();

                // read the input file
                string s = File.ReadAllText(inputPath);

                // convert the read string into intgers array

                // using SplitForCountSort function 
                int[] arr = SplitForCountSort(s);

                // sort the array Using the Count Sort
                CountSort.Count_Sort(arr);

                //join the numbers in one string
                s = string.Join(",", arr);

                //Write to the output file
                File.WriteAllText(outputPath, s);

                // stop the timer 
                watch.Stop();


                double elapsedMs = (watch.ElapsedMilliseconds) / 1000.0;
                string msg = "Execution Time = " + elapsedMs + " S" + Environment.NewLine;
                msg += "To : " + Environment.NewLine;
                msg += "=> Read the input file" + Environment.NewLine;
                msg += "=> Sort the Numbers Using the Count Sort" + Environment.NewLine;
                msg += "=> print the sorted array to the output file" + Environment.NewLine;
                msg += "______________________________________________" + Environment.NewLine;
                msg += "=> The File contains an Array of Size : " + arr.Length + Environment.NewLine;

                // show the message
                MessageBox.Show(msg, "Time elapsed", MessageBoxButtons.OK);
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBSValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void options_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (options.Text == "Binary Search")
            {
                txtBSValue.Visible = true;
                lblEnterValue.Visible = true;
                txtBSValue.Enabled = true;
                txtBSValue.Focus();
                //int val=txtBSValu
            }
            else
            {
                txtBSValue.Text = "";
                txtBSValue.Enabled = false;
                txtBSValue.Visible = false;
                lblEnterValue.Visible = false;
            }
        }
    }


    //Merge Sort 
    //Cloned From GitHub
    static class MergeSortAlgorithm
    {
        public static void MergeSort(int[] input, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                MergeSort(input, low, middle);
                MergeSort(input, middle + 1, high);
                Merge(input, low, middle, high);
            }
        }

        public static void MergeSort(int[] input)
        {
            MergeSort(input, 0, input.Length - 1);
        }

        private static void Merge(int[] input, int low, int middle, int high)
        {

            int left = low;
            int right = middle + 1;
            int[] tmp = new int[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (input[left] < input[right])
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                }
                else
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                input[low + i] = tmp[i];
            }
        }
    }

    //Quick Sort 
    //Cloned From GitHub
    public static class QuickSortAlogrithm
    {
        public static void QuickSort(int[] a)
        {
            QuickSort(a, 0, a.Length - 1);
        }

        public static void QuickSort(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);

                QuickSort(arr, start, i - 1);
                QuickSort(arr, i + 1, end);
            }
        }

        public static int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }
    }

    //Heap Sort 
    //Cloned From programmingalgorithms.com
    public static class HeapSortAlogrithm
    {

        public static void HeapSort(int[] data)
        {
            int heapSize = data.Length;

            for (int p = (heapSize - 1) / 2; p >= 0; --p)
                MaxHeapify(data, heapSize, p);

            for (int i = data.Length - 1; i > 0; --i)
            {
                int temp = data[i];
                data[i] = data[0];
                data[0] = temp;

                --heapSize;
                MaxHeapify(data, heapSize, 0);
            }
        }

        private static void MaxHeapify(int[] data, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heapSize && data[left] > data[index])
                largest = left;
            else
                largest = index;

            if (right < heapSize && data[right] > data[largest])
                largest = right;

            if (largest != index)
            {
                int temp = data[index];
                data[index] = data[largest];
                data[largest] = temp;

                MaxHeapify(data, heapSize, largest);
            }
        }
    }

    // Count Sort ...
    public static class CountSort
    {
        public static void Count_Sort(int[] data)
        {
            int sz = data.Length;

            int mxElement = 0;
            for (int i = 0; i < sz; i++)
                mxElement = Math.Max(mxElement, data[i]);

            int[] cntArray = new int[mxElement + 1];


            //count
            for (int i = 0; i < sz; i++)
                cntArray[data[i]]++;

            // sum
            for (int i = 1; i < cntArray.Length; i++)
                cntArray[i] = cntArray[i] + cntArray[i - 1];

            //sort
            int[] SortedArray = new int[data.Length];

            for (int i = 1; i < data.Length; i++)
            {
                int indx = cntArray[data[i]] - 1;
                SortedArray[indx] = data[i];
                cntArray[data[i]]--;
            }

            // copy the sorted array to the original one 
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = SortedArray[i];
            }
        }
    }
}