Console.WriteLine("Задача 15 ");

Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine(" Выходной , Ура ");
  }
 
  else Console.WriteLine("Работай бедолага -это не выходной");
}

CheckingTheDayOfTheWeek(dayNumber);