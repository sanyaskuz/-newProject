


namespace newProject {


  class Program {

    static  void Main() {
      //Типи данних
      // int num_1 = 10;
      // byte num_2 = 15;
      // short num_3 = 321;
      // float num_4 = 3.24242f;
      // string str = "Hello";
      // bool bol = false;
      // char s = 's';
      ////////////
      //зипис данних через консоль
      // int num_1 = 0, num_2 = 0;

      // num_1 = Convert.ToInt32(Console.ReadLine());
      // num_2 = Convert.ToInt32(Console.ReadLine());
     
      // Console.WriteLine(num_1 + " " + num_2);
      ///////////
      // 
      // Console.Write("Введіть число з крапкою: ");
      // float user_input = float.Parse(Console.ReadLine());
      
      // Вычисление
      // float result;
      // result = user_input - 10f + 3.4f;
      // result = user_input + 10f;
      // result = user_input * 10f;
      // result = user_input / 10f;
      // result = user_input % 10f;

      // int a = 5, b = 6;
      // int res = a + b;
      
      //  int a = 5, b = 6;
      // int res = a - b;

      //  int a = 5, b = 6;
      // int res = a * b;

      //  float a = 5f, b = 6f;
      // float res = a / b;

      //  int a = 5, b = 6;
      // int res = a % b;


      //Mat funtction
      //  Console.WriteLine(Math.Abs(-20));
      // Console.WriteLine(Math.Ceiling(4.11f));
      // Console.WriteLine(Math.Floor(4.99f));
      // Console.WriteLine(Math.Round(4.51f));
        //Максымальное ы мынымально 
      // Console.WriteLine(Math.Min(0, 5));
      // Console.WriteLine(Math.Max(0, 3));
      //степень
      // Console.WriteLine(Math.Pow(5, 3));

      //Радиус круга
      // System.Console.WriteLine("Введите радиус круга:");
      // double radius = Convert.ToDouble(Console.ReadLine());
      // double area = Math.PI * Math.Pow(radius, 2);
      // System.Console.WriteLine("площадь круга с рфдусом {0} равно {1}", radius, area);

      // 
// Условний оператор и if
      // float f = 6.3f;
      // int a = 5;
      // bool isMAsCar = true;
      // string word = "hello";

      // if(word != "hello") {

      // }

      // if(a == 6) {
      //   System.Console.WriteLine("Number is 5");
      // }else if((a == 3 || isMAsCar) && a > 3) {
      //   System.Console.WriteLine("Number is 3");
      //   System.Console.WriteLine("User has car");
      // }else {
      //   System.Console.WriteLine("Number is not faunt");
      // }

      // if(a <= 6.2) {
      //   System.Console.WriteLine("Number is 5");
      // }else {
      //   System.Console.WriteLine("Number is not 5");
      // }


      // if Пример
    //   System.Console.WriteLine("Enter name : ");
    //   string role = Console.ReadLine();
      
    //   if(role == "Admin") {
    //     System.Console.Write("Enter user name : ");
    //     string user_name = Console.ReadLine();
    //     Console.Write("Enter {0} age: ",user_name);
    //     short age = Convert.ToInt16(Console.ReadLine());

    //     if(age <= 0 || age > 90 ) {
    //       Console.Write("Enter {0} age : ", user_name);
    //        age = Convert.ToInt16(Console.ReadLine());

    //     }
    //     if(age <= 0 || age > 90 ) {
    //       Console.WriteLine("Error");
    //       age = 0;
    //       } else {
    //         System.Console.WriteLine("User`s age is " + age);
    //       }
      
    //   }else {
    //     System.Console.WriteLine("You are not admin");
    //   }
// Switch
    // short user_input = Convert.ToInt16(Console.ReadLine());

    // switch(user_input) {
    //   case 5: 
    //   System.Console.WriteLine("Number is Fave");
    //   break;
    //   case 15: 
    //   System.Console.WriteLine("Number is fifteen");
    //   break;
    //   case 25: 
    //   System.Console.WriteLine("Number is twenty-five");
    //   break;
    //   case 10: 
    //   System.Console.WriteLine("Number is ten");
    //   break;
    //   default: 
    //   System.Console.WriteLine("Number is not fount");
    //   break;
    // }


    // }
    // for while do while


    // for(float i = 200;i > 10; i/= 2){
    //     Console.WriteLine("Element: {0} " , i);
    // }

    // byte i = 10;
    // while(i > 0){
    //   Console.WriteLine("Element: {0} " , i);
    //   i--;
    // }

    // bool isHasCar = true;
    // while(isHasCar) {
    //   string end = Console.ReadLine();
    //   if(end == "end") {
    //     isHasCar = false;
    //   }
    // }

    // byte i = 100;

    // do{
    //   System.Console.WriteLine("Element : " + i);
    // }while(i < 10);


    for(short i = 0; i < 10; i++){
      // if(i > 5) 
      //  break;
      if(i % 2 != 0) {
        continue;
      }

      Console.WriteLine("EL: " + i);
    }

    }
  }
} 
