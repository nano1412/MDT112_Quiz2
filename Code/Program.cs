using System;

class Program{
  static void Main(string[] args){
    int N = int.Parse(Console.ReadLine());
    int K = int.Parse(Console.ReadLine());
    int k1 = K;
    int k2 = K;

    for(int order = 1; order <= N; order++){
      int gender = int.Parse(Console.ReadLine());
      int k1Score = int.Parse(Console.ReadLine());
      int k2Score = int.Parse(Console.ReadLine());
      if(SingerGotPickByWho(gender,k1Score,k2Score)){
        if(k1 > 0 && k1Score >= k2Score && k1Score >=9){
          Console.WriteLine("{0} 1",order);
          k1--;
        } else if (k2 > 0 && k2Score >= k1Score && k2Score >=9){
          Console.WriteLine("{0} 2",order);
          k2--;
        }
      } else {
        if(k2 > 0 && k2Score >= k1Score && k2Score >=9){
          Console.WriteLine("{0} 2",order);
          k2--;
        } else if (k1 > 0 && k1Score >= k2Score && k1Score >=9){
          Console.WriteLine("{0} 1",order);
          k1--;
        }
      }
    }
  }

  static bool IsThereTheSpaceForSinger(int space, int domScore, int minerScore){
    return space > 0 && domScore >= minerScore && domScore >=9;
  }
  static bool SingerGotPickByWho(int gender, int k1Score, int k2Score){
    if((k1Score >=9 && k2Score < 9) || (k1Score >=9 && k2Score >= 9 && gender == 1)){
      return true;
    }
    return false;
  }
}