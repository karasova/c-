class MainClass {
  public static void Main (string[] args) {
    string input;
    string[] input_arr;

    input = System.Console.ReadLine();
    input_arr = input.Split(' ');
    
    int width = Int32.Parse(input_arr[0]);
    int height = Int32.Parse(input_arr[1]);

    int[,] pole = new int[i, j];
    input = System.Console.ReadLine();
    int num = Int32.Parse(input);

    for (int i = 0; i < num; i++) {
      input = System.Console.ReadLine();
      input_arr = input.Split(' ');
      int x1 = Int32.Parse(input_arr[0]);
      int y1 = Int32.Parse(input_arr[1]);
      int x2 = Int32.Parse(input_arr[2]);
      int y2 = Int32.Parse(input_arr[3]);

      for (int j = x1; j < x2; j++) {
        for (int k = y1; k < y2; k++) {
          pole[j, k] += 1;
        }
      }
    }

    int sum = 0;

    for (int i = 0; i < width; i++) {
      for (int j = 0; j < height; j++) {
        if (pole[i, j] == 0) {
          sum += 1;
        }
      }
    }
    System.Console.WriteLine(sum);
  }
