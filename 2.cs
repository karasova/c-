using System;

  class MainClass {

    public static void Main (string[] args) {
      string input;
      string[] input_arr;

      input = System.Console.ReadLine();
      
      int m = Int32.Parse(input);
      long n = m * m;

      int[,] pole = new int[n, n];
      int[,] pole_two = new int[n, n];
      int[,] base_pole = new int[n, n];

      string flag = "True";

      if (n == 0) {
        flag = "False";
      }

      for (int i = 0; i < n; i++) {
        input = System.Console.ReadLine();
        input_arr = input.Split(' ');
        for (int j = 0; j < n; j++) {
          int k = Int32.Parse(input_arr[j]);
          if (k > n) {
            flag = "False";
            break;
          }
          int c_i = (i / m);
          int c_j = (j / m);
          base_pole[c_j + m * c_i, Int64.Parse(input_arr[j]) - 1] += 1;
          // base_pole[i, j] = k;
          pole[i, Int64.Parse(input_arr[j]) - 1] += 1;
          pole_two[j, Int64.Parse(input_arr[j]) - 1] += 1;
        }

        if (flag == "False") {
          break;
        }
      }

      if (flag != "False") {
        for (int i = 0; i < n; i++) {
          for (int j = 0;j < n; j++) {
            if (pole[i, j] != 1 || pole_two[i, j] != 1 || base_pole[i, j] != 1) {
              flag = "False";
              break;
            }
          }
        }
      }

      System.Console.WriteLine(flag);
    }
  }
