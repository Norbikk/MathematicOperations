using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class WorkScript : MonoBehaviour
{
 [SerializeField] private Text text;
 [SerializeField] private InputField inputNumber;
 
 public void OnClickDivTwo()
 {
  int n = Convert.ToInt32(inputNumber.text);
  int[] divNum = new int[n];
  List<int> numbers = new List<int>();

  for (int i = 1; i < divNum.Length; i++)
  {
   divNum[i] = i;
   if (i%2 == 0)
   {
    numbers.Add(divNum[i]);
   }
  }
  text.text = string.Join(" ", numbers.ToArray());
 }
 /*
  * Что бы работало именно от 1-10
  * Убираем int n
  * пишем int[] divNum = new int[11]
  */

 public void OnClickMultiplication()
 {
  string multiply = string.Empty;
  int i = Convert.ToInt32(inputNumber.text);
 
   for (int j = 1; j <= 10; j++)
   {
    multiply += $"{i} x {j} = {i * j}\n";
   }
   text.text = multiply;
 }
 /*
  *Сделал так для красоты, но если нужно, можно сделать
  * for (int i = 1 i<=10; i++)
  * {
  * for (int j= 1; j<=10; j++)
  * {
  * multiply += $"{i} x {j} = {i*j}\n
  * }
  * multiply = "\n"
  * }
  * text.text = multiply;
  */

 public void OnClickFactorial()
 {
  int i = Convert.ToInt32(inputNumber.text);
  long j = 1;
  for (int a = 1; a <= i; a++)
  {
   j *= a;
  }
  text.text = $"Факториал равен {j}";
 }
}
