using System;

namespace homeworkNo5
{
    class Program
    {
        static string InputPath = "c:\\input.txt";
        static string ConvolutionPath = "c:\\convolution.txt";
        static string OutputPath = "Output.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Input your file input");
            InputPath = Console.ReadLine();

            Console.WriteLine("Input your file convolution");
            ConvolutionPath = Console.ReadLine();

            Console.WriteLine("Input your file output");
            OutputPath = Console.ReadLine();
            double[,] image = ReadImageDataFromFile(InputPath);
            double[,] image_resize = new double[image.GetLength(1) + 3, image.GetLength(0) + 3];
            double[,] temp_output = new double[image.GetLength(0) + 1, image.GetLength(0) + 1];

            for (int i = 1; i < image.GetLength(1) + 1; i++)
            {
                for (int j = 1; j < image.GetLength(0) + 1; j++)
                {
                    image_resize[i, j] = image[i - 1, j - 1];
                }
            }
            display(image_resize);
            image_resize[0, image_resize.GetLength(0) - 2] = image[image.GetLength(1) - 1, 0];
            image_resize[0, 0] = image[image.GetLength(1) - 1, image.GetLength(0) - 1];
            image_resize[image_resize.GetLength(1) - 2, image_resize.GetLength(0) - 2] = image[0, 0];
            image_resize[image_resize.GetLength(1) - 2, 0] = image[0, image.GetLength(1) - 1];
            for (int i = 1; i < image.GetLength(0) + 1; i++)
            {
                image_resize[0, i] = image[image.GetLength(0) - 1, i - 1];
                image_resize[image_resize.GetLength(1) - 2, i] = image[0, i - 1];
                image_resize[i, 0] = image[i - 1, image.GetLength(1) - 1];
                image_resize[i, image_resize.GetLength(0) - 2] = image[i - 1, 0];
            }
            display(image_resize);
            double[,] confile = ReadImageDataFromFile(ConvolutionPath);
            Console.WriteLine(":>" + confile[0, 0]);
            for (int i = 0; i < image.GetLength(1) + 1; i++)
            {
                for (int j = 0; j < image.GetLength(0); j++)
                {
                    double sum = 0;
                    for (int k = 0; k < confile.GetLength(0); k++)
                    {
                        for (int n = 0; n < confile.GetLength(1); n++)
                        {
                            sum += confile[k, n] * image_resize[i + k, j + n];
                        }
                    }
                    temp_output[i, j] = sum;
                }
            }
            display(temp_output);
            WriteImageDataToFile(OutputPath, temp_output);
        }
        static void display(double[,] list)
        {
            Console.WriteLine("=========");
            for (int i = 0; i < list.GetLength(1) - 1; i++)
            {
                for (int j = 0; j < list.GetLength(0) - 1; j++)
                {
                    Console.Write(list[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        static double[,] ReadImageDataFromFile(string imageDataFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
            int imageHeight = lines.Length;
            int imageWidth = lines[0].Split(',').Length;
            double[,] imageDataArray = new double[imageHeight, imageWidth];

            for (int i = 0; i < imageHeight; i++)
            {
                string[] items = lines[i].Split(',');
                for (int j = 0; j < imageWidth; j++)
                {
                    imageDataArray[i, j] = double.Parse(items[j]);
                }
            }
            return imageDataArray;
        }
        static void WriteImageDataToFile(string imageDataFilePath, double[,] imageDataArray)
        {
            string imageDataString = "";
            for (int i = 0; i < imageDataArray.GetLength(0); i++)
            {
                for (int j = 0; j < imageDataArray.GetLength(1) - 1; j++)
                {
                    imageDataString += imageDataArray[i, j] + ", ";
                }
                imageDataString += imageDataArray[i, imageDataArray.GetLength(1) - 1];
                imageDataString += "\n";
            }
            System.IO.File.WriteAllText(imageDataFilePath, imageDataString);
        }
    }
}
