using System;

class Program{
  static void Main(string[] args){
    int N = int.Parse(Console.ReadLine());
    int K = int.Parse(Console.ReadLine());
    int k1 = K;
    int k2 = K;
    int order = 1;

    while(N>0){
      int gender = int.Parse(Console.ReadLine());
      int k1Score = int.Parse(Console.ReadLine());
      int k2Score = int.Parse(Console.ReadLine());
      if(SingerProfile(gender,k1Score,k2Score)){
        if(k1 > 0 && k1Score >= k2Score){
          Console.WriteLine("{0} {1}",order,1);
          k1--;
        } else if (k2 > 0 && k2Score >= k1Score){
          Console.WriteLine("{0} {1}",order,2);
          k2--;
        }
      } else {
        if(k2 > 0 && k2Score >= k1Score){
          Console.WriteLine("{0} {1}",order,2);
          k2--;
        } else if (k1 > 0 && k1Score >= k2Score){
          Console.WriteLine("{0} {1}",order,1);
          k1--;
        }
      }
      N--;
      order++;
    }
  }
  static bool SingerProfile(int gender, int k1Score, int k2Score){

    if((k1Score >=9 && k2Score < 9) || (k1Score >=9 && k2Score >= 9 && gender == 1)){
      return true;
    }
    return false;
  }
}