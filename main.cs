using System;
Console.WriteLine("Lütfen pozitif bir sayı girin");
int sayi = Convert.ToInt32(Console.ReadLine());
int i = 0;
Console.Clear();
//ekrana pozitif bir sayı girmesini ister ve girilen sayıyı int türüne çevirir i sayısını tanımlar ve konsolu temizler
b:
if (i == sayi)
{
    Console.WriteLine(i);
    Console.WriteLine("kodu bitirmek için bir tuşa basın");
    Console.ReadKey();
    goto a;
  //i sayısı girilen sayıya eşitse i sayısını ekrana yaz kodu bitirmek için klavyeden tuşa basılmasını bekle ve a konumuna git
    
}
else
    { 
    i++;
        Console.WriteLine(i);
        System.Threading.Thread.Sleep(90);
        Console.Clear();
    goto b;
    //i sayısı girilen sayıdan büyükse i sayısını arttırıp ekrana yazar sonrasında 90 salise bekleyip konsolu temizler ve b konumuna gider
    }
a:;
