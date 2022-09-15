

using _02_Abstracts.Example2.Models;

var dog1 = new Animal();
dog1.Age = 14;
dog1.Weight = 25;


var dog2 = new Dog();
dog2.Age = 14;
dog2.Weight = 25;
dog2.Name = "Dexter";
dog2.Bark();