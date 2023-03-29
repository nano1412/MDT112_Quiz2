using System;

class Program{
  static void Main(string[] args){
    int N = int.Parse(Console.ReadLine());
    int K = int.Parse(Console.ReadLine());
    int judge1 = K;
    int judge2 = K;

    for(int order = 1; order <= N;order++){
      int gender = int.Parse(Console.ReadLine());
      int judge1Score = int.Parse(Console.ReadLine());
      int judge2Score = int.Parse(Console.ReadLine());
      if(SingerProfile(gender,judge1Score,judge2Score)){
        PrintWinner(order, judge1Score, judge2Score, ref judge1, ref judge2, 1, 2);
      } else {
        PrintWinner(order, judge2Score, judge1Score, ref judge2, ref judge1, 2, 1);
      }
    }
  }
  static void PrintWinner(int order, int primary_score, int secondary_score, ref int primary_space, ref int secondary_space, int primary_number, int secondary_number){
    if(primary_space > 0){
      Console.WriteLine("{0} {1}",order,primary_number);
      primary_space--;
    } else if (secondary_space > 0 && secondary_score >= primary_score){
      Console.WriteLine("{0} {1}",order,secondary_number);
      secondary_space--;
    }
  }
  static bool SingerProfile(int gender, int k1Score, int k2Score){

    if((k1Score >=9 && k2Score < 9) || (k1Score >=9 && k2Score >= 9 && gender == 1)){
      return true;
    }
    return false;
  }
}