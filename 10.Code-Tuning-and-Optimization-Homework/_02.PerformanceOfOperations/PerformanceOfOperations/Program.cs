using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PerformanceOfOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan averageAddTimeOperation = GetAddOperation();

            TimeSpan averageSubstract = GetSubtract();
            TimeSpan averageMultiply = GetMultiply();
            TimeSpan averageDivide = GetDivide();
            TimeSpan averageIncrement = GetIncrement();
            TimeSpan averageSqrt = GetSquareRoot();
            TimeSpan averageLogarithm = GetLogarithm();
            TimeSpan averageSin = GetSin();

            // Console.WriteLine(averageAddTimeOperation);
            // Console.WriteLine(averageSubstract);
            // Console.WriteLine(averageMultiply);
            // Console.WriteLine(averageDivide);
            // Console.WriteLine(averageIncrement);
            // Console.WriteLine(averageSqrt);
            // Console.WriteLine(averageLogarithm);
            // Console.WriteLine(averageSin);
        }

        private static TimeSpan GetAddOperation()
        {
            Stopwatch timer = new Stopwatch();

            List<TimeSpan> times = new List<TimeSpan>();

            for (int i = 0; i < 500; i++)
            {
                timer.Restart();
                timer.Start();

                var a = 0;
                int count = 5000;

                for (int j = 0; j < count; j++)
                {
                    a = a + 500;
                }

                timer.Stop();
                times.Add(timer.Elapsed);
            }

            double averageTicks = times.Average(timespan => timespan.Ticks);
            TimeSpan average = new TimeSpan(Convert.ToInt64(averageTicks));

            return average;
        }

        private static TimeSpan GetSubtract()
        {
            Stopwatch timer = new Stopwatch();
            List<TimeSpan> times = new List<TimeSpan>();
            for (int i = 0; i < 500; i++) 
            {
                timer.Restart();
                timer.Start();

                var a = 0;
                int count = 5000;
                for (int j = 0; j < count; j++)
                {
                    a = a - 500;
                }
                timer.Stop();
                times.Add(timer.Elapsed);
            }

            double averageTicks = times.Average(timespan => timespan.Ticks);
            TimeSpan average = new TimeSpan(Convert.ToInt64(averageTicks));

            return average;
        }

        private static TimeSpan GetMultiply()
        {
            Stopwatch timer = new Stopwatch();
            List<TimeSpan> times = new List<TimeSpan>();
            for (int i = 0; i < 500; i++)
            {
                timer.Restart();
                timer.Start();

                var a = 0;
                int count = 5000;
                for (int j = 0; j < count; j++)
                {
                    a = a * 500;
                }
                timer.Stop();
                times.Add(timer.Elapsed);
            }

            double averageTicks = times.Average(timespan => timespan.Ticks);
            TimeSpan average = new TimeSpan(Convert.ToInt64(averageTicks));

            return average;
        }

        private static TimeSpan GetDivide()
        {
            Stopwatch timer = new Stopwatch();
            List<TimeSpan> times = new List<TimeSpan>();
            for (int i = 0; i < 500; i++)
            {
                timer.Restart();
                timer.Start();

                var a = 0;
                int count = 5000;
                for (int j = 0; j < count; j++)
                {
                    a = a / 500;
                }
                timer.Stop();
                times.Add(timer.Elapsed);
            }

            double averageTicks = times.Average(timespan => timespan.Ticks);
            TimeSpan average = new TimeSpan(Convert.ToInt64(averageTicks));

            return average;
        }

        private static TimeSpan GetIncrement()
        {
            Stopwatch timer = new Stopwatch();
            List<TimeSpan> times = new List<TimeSpan>();
            for (int i = 0; i < 500; i++)
            {
                timer.Restart();
                timer.Start();

                var a = 0;
                int count = 5000;
                for (int j = 0; j < count; j++)
                {
                    a++;
                }
                timer.Stop();
                times.Add(timer.Elapsed);
            }

            double averageTicks = times.Average(timespan => timespan.Ticks);
            TimeSpan average = new TimeSpan(Convert.ToInt64(averageTicks));

            return average;
        }

        private static TimeSpan GetSquareRoot()
        {
            Stopwatch timer = new Stopwatch();
            List<TimeSpan> times = new List<TimeSpan>();
            for (int i = 0; i < 500; i++)
            {
                timer.Restart();
                timer.Start();

                var a = 0;
                int count = 5000;
                for (int j = 0; j < count; j++)
                {
                    Math.Sqrt(a);
                }
                timer.Stop();
                times.Add(timer.Elapsed);
            }

            double averageTicks = times.Average(timespan => timespan.Ticks);
            TimeSpan average = new TimeSpan(Convert.ToInt64(averageTicks));

            return average;
        }

        private static TimeSpan GetLogarithm()
        {
            Stopwatch timer = new Stopwatch();
            List<TimeSpan> times = new List<TimeSpan>();
            for (int i = 0; i < 500; i++)
            {
                timer.Restart();
                timer.Start();

                var a = 0;
                int count = 5000;
                for (int j = 0; j < count; j++)
                {
                    Math.Log(a);
                }
                timer.Stop();
                times.Add(timer.Elapsed);
            }

            double averageTicks = times.Average(timespan => timespan.Ticks);
            TimeSpan average = new TimeSpan(Convert.ToInt64(averageTicks));

            return average;
        }

        private static TimeSpan GetSin()
        {
            Stopwatch timer = new Stopwatch();
            List<TimeSpan> times = new List<TimeSpan>();
            for (int i = 0; i < 500; i++)
            {
                timer.Restart();
                timer.Start();

                var a = 0;
                int count = 5000;
                for (int j = 0; j < count; j++)
                {
                    Math.Sin(a);
                }
                timer.Stop();
                times.Add(timer.Elapsed);
            }

            double averageTicks = times.Average(timespan => timespan.Ticks);
            TimeSpan average = new TimeSpan(Convert.ToInt64(averageTicks));

            return average;
        }
    }
}
