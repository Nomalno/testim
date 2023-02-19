using System.Data;
using testim;

var prsn = new Person(1, "OhaYooo");
prsn.PersonJ();
var reps = new PersonRepositoriy();


reps.GetAll();
Thread.Sleep(1500);
reps.GetById();
Thread.Sleep(1500);
reps.Insert("New_Task");
Thread.Sleep(1500);
reps.GetAll();
Thread.Sleep(1500);
reps.Delete(3);
Thread.Sleep(1500);
reps.GetAll();
Thread.Sleep(1500);
reps.Update(3, "ahaha");
Thread.Sleep(1500);
reps.GetAll();
Thread.Sleep(1500);
reps.Find(4);
Console.ReadKey();





//GetAll - возвращает все элементы коллекции
//GetById - возвращает элемент по заданному id
//Insert - Добавляет элемент в коллекцию
//Delete - Удаляет элемент из коллекции
//Update - Обновляет элемент коллекции 
//Find - возвращает список элементов по заданному условию (Для условия можно использовать любое поле обьекта)









//Console.WriteLine(c);